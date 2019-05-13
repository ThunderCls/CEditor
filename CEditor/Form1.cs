using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using System.Web;

namespace CEditor
{
    public partial class frmMain : Form
    {
        private List<string> wlFile;
        private static string logtext = "";
        private static object locker = new Object(); // thread safe var
        private static object finish_flag = new Object(); // thread safe var
        private static object hashes_stack_access = new Object(); // thread safe var
        private static bool finished = false;
        private static bool stop_thread = false;
        private const string SERVER_ACCESS_ERROR = "CONNECTION_ERROR";
        private static EventWaitHandle waitHandle = new ManualResetEvent(initialState: true);
        private int decypher_column = 0;
        private Stack<string> stackHashes;
        private static object decrypt_threads_amount_access = new Object(); // thread safe var
        private int decrypt_treads = 0;
        private static object statistics_access = new Object(); // thread safe var
        private int decryption_found = 0;
        private int server_errors = 0;
        private int seconds = 0;
        private int minutes = 0;
        private int hours = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ReadWordlistFile(string filename)
        {
            lock (finish_flag)
            {
                finished = false;
            }

            string[] txtFile;

            try
            {
                txtFile = File.ReadAllLines(filename);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\nThe file could not be read", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // populate list
            if (wlFile != null && wlFile.Count > 0)
            {
                wlFile.Clear();
                wlFile = txtFile.ToList();
            }
            else
                wlFile = new List<string>(txtFile);

            lock (finish_flag)
            {
                finished = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtFileSeparator.Text.Length == 0)
            {
                MessageBox.Show("You must specify a delimiter before loading a wordlist", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtWordslist.Text = openFileDialog1.FileName;

                Thread readFileThread = new Thread(() => ReadWordlistFile(txtWordslist.Text));
                stripStatus.Text = "Reading file...";
                readFileThread.Start();
                timeStatus.Enabled = true;

                //readFileThread.Join(); // wait for thread to end

                checkChangeSeparator.Checked = checkDecrypt.Checked = 
                checkRemBlank.Checked = checkRemDuplicates.Checked = 
                checkRemoveLinesText.Checked = checkReorderColumns.Checked = false;

                btnStart.Enabled = true;
            }
            else
                btnStart.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            txtNewSeparator.Enabled = checkChangeSeparator.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            txtStripLine.Enabled = checkRemoveLinesText.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            combDecipherColumns.Enabled = checkDecrypt.Checked;
        }

        private void comboHashes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCredentialsColumnsOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDecipherColumns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtFileSeparator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCurrentSeparator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNewSeparator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void FileProcessThread()
        {
            lock (finish_flag)
            {
                finished = false;
            }

            // remove duplicates
            waitHandle.WaitOne(); // waits for the signal to be set
            if (checkRemDuplicates.Checked && !stop_thread)
            {
                stripStatus.Text = "Removing duplicates...";
                wlFile = wlFile.Distinct().ToList();
            }

            // remove blank credentials
            waitHandle.WaitOne(); // waits for the signal to be set
            if (checkRemBlank.Checked && !stop_thread)
            {
                stripStatus.Text = "Removing blank credentials...";

                for (int i = 0; i < wlFile.Count; i++)
                {
                    string line = wlFile[i];
                    if (line.Length == 0) // if line is blank then remove it
                    {
                        wlFile.RemoveAt(i);
                        --i; // move index down
                    }
                    else
                    {
                        string[] tokens = line.Split(txtFileSeparator.Text.ToCharArray());
                        if (tokens.Contains("") || tokens.Contains(" ")) // if any credential is blank then remove it
                        {
                            wlFile.RemoveAt(i);
                            --i; // move index down
                        }
                    }
                }
            }

            // change separators
            waitHandle.WaitOne(); // waits for the signal to be set
            if (checkChangeSeparator.Checked && !stop_thread)
            {
                stripStatus.Text = "Changing wordlist separators...";

                for (int i = 0; i < wlFile.Count; i++)
                {
                    string line = wlFile[i];
                    line = line.Replace(txtFileSeparator.Text, txtNewSeparator.Text);
                    wlFile[i] = line;
                }
            }

            // reorder credential columns
            waitHandle.WaitOne(); // waits for the signal to be set
            if (checkReorderColumns.Checked && !stop_thread)
            {
                stripStatus.Text = "Reordering columns...";

                for (int i = 0; i < wlFile.Count; i++)
                {
                    string line = wlFile[i];
                    string[] tokens = line.Split(txtFileSeparator.Text.ToCharArray());
                    string[] colOrder = txtCredentialsColumnsOrder.Text.Split(',');

                    line = ""; // empty line to change it
                    for (int j = 0; j < tokens.Length; j++)
                    {
                        if (colOrder.Length > j && colOrder[j].Length > 0)
                        {
                            int colIndex = Convert.ToInt32(colOrder[j]) - 1;

                            if (tokens.Length > colIndex)
                                line += tokens[colIndex];

                            if (colOrder.Length > j + 1) // only add separator if thats the last column
                                line += txtFileSeparator.Text;
                        }
                    }

                    wlFile[i] = line;
                }
            }

            // remove lines with given text
            waitHandle.WaitOne(); // waits for the signal to be set
            if (checkRemoveLinesText.Checked && !stop_thread)
            {
                stripStatus.Text = "Removing specified lines...";
                wlFile = wlFile.Where(line => line.IndexOf(txtStripLine.Text) == -1).ToList();
            }

            // remove white spaces from given token
            waitHandle.WaitOne(); // waits for the signal to be set
            if (checkRemoveSpaces.Checked && !stop_thread)
            {
                for (int i = 0; i < wlFile.Count; i++)
                {
                    string[] tokens = wlFile[i].Split(txtFileSeparator.Text.ToCharArray());
                    string tokenNumb = "";
                    Invoke(new Action(() => { tokenNumb = combTokenSpaces.Text; }));
                    string nospacesline = tokens[Convert.ToInt32(tokenNumb) - 1];
                    tokens[Convert.ToInt32(tokenNumb) - 1] = nospacesline.Trim();
                    wlFile[i] = string.Join(txtFileSeparator.Text, tokens);
                }
            }

            // trim full chars from given token
            waitHandle.WaitOne(); // waits for the signal to be set
            if (checkRemoveSpaces.Checked && !stop_thread)
            {
                for (int i = 0; i < wlFile.Count; i++)
                {
                    string[] tokens = wlFile[i].Split(txtFileSeparator.Text.ToCharArray());
                    string tokenNumb = "";
                    Invoke(new Action(() => { tokenNumb = combTokenSpaces.Text; }));
                    string nospacesline = tokens[Convert.ToInt32(tokenNumb) - 1];
                    tokens[Convert.ToInt32(tokenNumb) - 1] = nospacesline.Trim();
                    wlFile[i] = string.Join(txtFileSeparator.Text, tokens);
                }
            }

            // strip username from email token
            waitHandle.WaitOne(); // waits for the signal to be set
            if (checkExtractUser.Checked && !stop_thread)
            {
                for (int i = 0; i < wlFile.Count; i++)
                {
                    string[] tokens = wlFile[i].Split(txtFileSeparator.Text.ToCharArray());
                    string tokenNumb = "";
                    Invoke(new Action(() => { tokenNumb = combTokenSpaces.Text; }));
                    string email = tokens[Convert.ToInt32(tokenNumb) - 1];
                    int limit = email.IndexOf('@') - 1;

                    string user = "";
                    if (limit >= 0)
                        user = email.Substring(0, limit);
                    else
                        user = email;

                    tokens[Convert.ToInt32(tokenNumb) - 1] = user;
                    wlFile[i] = string.Join(txtFileSeparator.Text, tokens);
                }
            }

            // decrypt hashes
            waitHandle.WaitOne(); // waits for the signal to be set
            if (checkDecrypt.Checked && !stop_thread)
            {
                stripStatus.Text = "Decrypting hashes...";
                List<string> copy = new List<string>(wlFile);
                copy.Reverse();
                stackHashes = new Stack<string>(copy); // move the list to the stack of hashes

                for (int i = 0; i < numDecryptThreads.Value; i++)
                {
                    ThreadStart childref = new ThreadStart(DecryptHashesThread);
                    Thread fileBatchThread = new Thread(childref);
                    fileBatchThread.Start();

                    lock (decrypt_threads_amount_access)
                    {
                        decrypt_treads++;
                    }
                }
            }
            else
            {
                lock (finish_flag)
                {
                    finished = true;
                }
            }
        }

        private string DecryptBase64(string hash, ref int server_errors)
        {
            server_errors = 0;
            byte[] data = Convert.FromBase64String(hash);
            return Encoding.UTF8.GetString(data);
        }

        /*private string DecodeBrotliCompression(string buffer)
        {
            string decoded = "";

            var bufferArray = Encoding.Default.GetBytes(buffer);
            byte[] decodedArray = BrotliSharpLib.Brotli.DecompressBuffer(bufferArray, 0, bufferArray.Length);
            decoded = Encoding.Default.GetString(decodedArray);

            return decoded;
        }*/

        private string DecryptMD5(string hash, ref int server_errors)
        {
            /*
            MD5 Cracking URLs
            * ----------------
            * http://www.md5online.org/md5-api.html (VIP Code to work with API, otherwise captcha protection)
            * https://crackhash.com/api.php
            * http://hashtoolkit.com/reverse-hash?hash=
            * http://www.nitrxgen.net/md5db_info/#api
            * http://md5decryption.com/ (Using post: hash=dca57be223efc2741bc98adce0ec5141&submit=Decrypt+It%21)
            * http://md5.my-addr.com/md5_decrypt-md5_cracker_online/md5_decoder_tool.php (Using post: md5=dca57be223efc2741bc98adce0ec5141&x=11&y=12)
            */

            string decrypted = "";

            // Decrypt with crackhash.com using API
            string response = PostDecryptHash("https://crackhash.com/", "application/x-www-form-urlencoded", String.Format("hash={0}&crack=crack", hash), ref server_errors);
            decrypted = ParseStringByDelimiters(response, " ==> ", '<');

            if (decrypted.Length > 0 && decrypted.IndexOf("not found") == 0) // first website api returns 'not found'
                // Decrypt with www.nitrxgen.net using API
                decrypted = GetDecryptHash("http://www.nitrxgen.net/md5db/" + hash + ".txt", ref server_errors);

            if (decrypted.Length == 0 || decrypted == SERVER_ACCESS_ERROR)
            {
                decrypted = "";
                // Decrypt with hashtoolkit.com
                response = GetDecryptHash("http://hashtoolkit.com/reverse-hash?hash=" + hash, ref server_errors);
                // parsing from hashtoolkit.com
                decrypted = ParseStringByDelimiters(response, "<span title=\"decrypted md5 hash\">", '<');
            }

            if (decrypted.Length == 0 || decrypted == SERVER_ACCESS_ERROR)
            {
                decrypted = "";
                response = PostDecryptHash("http://md5decryption.com/", "application/x-www-form-urlencoded", "hash=" + hash + "&submit=Decrypt+It%21", ref server_errors);
                // parse response from md5decryption.com
                decrypted = ParseStringByDelimiters(response, "Decrypted Text: </font></b><font size=\"2\">", '<');

            }

            if (decrypted.Length == 0 || decrypted == SERVER_ACCESS_ERROR)
            {
                decrypted = "";
                response = PostDecryptHash("http://md5.my-addr.com/md5_decrypt-md5_cracker_online/md5_decoder_tool.php", "application/x-www-form-urlencoded", "md5=" + hash + "&x=11&y=12", ref server_errors);
                // parse response from md5.my-addr.com
                decrypted = ParseStringByDelimiters(response, "Hashed string</span>:", '<');

            }

            return decrypted;
        }

        private enum HASH_TYPE
        {
            MD5,
            BASE64
        };

        private string DecryptHash(string hash, ref int server_errors)
        {
            int hashIndex = -1;
            Invoke(new Action(() => { hashIndex = combHashType.SelectedIndex; }));

            switch ((HASH_TYPE)hashIndex)
            {
                case HASH_TYPE.MD5:
                    return DecryptMD5(hash, ref server_errors);
                case HASH_TYPE.BASE64:
                    return DecryptBase64(hash, ref server_errors);
                default:
                    break;
            }

            return "";
        }

        private string PostDecryptHash(string URL, string ContentType, string postData, ref int server_errors)
        {
            try
            {
                WebRequest webRequest = WebRequest.Create(URL);
                webRequest.Method = "POST";
                webRequest.ContentType = ContentType;
                Stream reqStream = webRequest.GetRequestStream();
                byte[] postArray = Encoding.ASCII.GetBytes(postData);
                reqStream.Write(postArray, 0, postArray.Length);
                reqStream.Close();
                StreamReader response = new StreamReader(webRequest.GetResponse().GetResponseStream());
                return response.ReadToEnd();
            }
            catch (Exception)
            {
                //lock (statistics_access)
                //{
                    server_errors++;
                //}
                return (checkKeepHashOnServerError.Checked) ? SERVER_ACCESS_ERROR : "";
                //throw;
            }
        }

        private string GetDecryptHash(string URL, ref int server_errors)
        {
            string response = "";

            using (WebClient client = new WebClient())
            {
                try
                {
                    response = client.DownloadString(URL);
                }
                catch (Exception)
                {
                    //lock (statistics_access)
                    //{
                        server_errors++;
                    //}
                    return (checkKeepHashOnServerError.Checked) ? SERVER_ACCESS_ERROR : "";
                }
            }
            return response;
        }

        private void DecryptSingleHashThread()
        {
            string hashStr = "";
            Invoke(new Action(() => { hashStr = txtSingleHashStr.Text; }));
            Invoke(new Action(() => { stripStatus.Text = "Decrypting single hash..."; }));

            string decrypted = DecryptHash(hashStr, ref server_errors);
            if (decrypted.Length == 0)
                decrypted = "NOT_FOUND";

            Invoke(new Action(() => { txtSingleHashDecrypted.Text = decrypted; }));
            Invoke(new Action(() => { stripStatus.Text = "Process Finished!"; }));
        }

        private void DecryptHashesThread()
        {
            // decrypt hash
            string last_hash = "";
            string last_decrypted = "";

            int stack_size = 0;
            do
            {
                string decrypted = "";
                string line = "";

                lock (hashes_stack_access)
                {
                    stack_size = stackHashes.Count;
                    if (stack_size == 0)
                        break;
                    else
                        line = stackHashes.Pop(); //wlFile[i]; 
                }                

                //lock (locker) // labels info
                //{
                //    lock (statistics_access)
                //    {
                        logtext = String.Format("{0}/{1},{2},{3},{4}", wlFile.Count - stack_size, wlFile.Count, decryption_found, wlFile.Count - decryption_found, server_errors);
                //    }
                //}

                if (stop_thread) // check if force terminate thread
                    break;
                waitHandle.WaitOne(); // waits for the signal to be set

                int wlFileIndex = wlFile.IndexOf(line); // get location of line in main list
                string[] tokens = line.Split(txtFileSeparator.Text.ToCharArray());
                //lock (locker)
                //{
                    logtext += "," + last_hash + "," + last_decrypted + "," + tokens[decypher_column];
                //}

                last_hash = tokens[decypher_column]; // save last hash used for statistics

                decrypted = DecryptHash(tokens[decypher_column], ref server_errors);
                if (decrypted.Length != 0)
                {
                    //lock (statistics_access)
                    //{
                        decryption_found++;
                    //}
                }
                else
                    decrypted = "NOT_FOUND";

                if (decrypted == "NOT_FOUND" && checkKeepNotFoundHash.Checked) // check if keep hashes not found
                    tokens[decypher_column] = tokens[decypher_column];
                else
                    tokens[decypher_column] = decrypted;

                wlFile[wlFileIndex] = string.Join(txtFileSeparator.Text, tokens);
                last_decrypted = decrypted; // save last result obtained for statistics
            } while (stack_size > 0);

            lock (decrypt_threads_amount_access)
            {
                --decrypt_treads;
                lock (finish_flag)
                {
                    finished = (decrypt_treads == 0);
                }
            }
        }

        private void SetPreviewText()
        {
            combTokenExtractUser.Items.Clear();
            combTokenSpaces.Items.Clear();
            combDecipherColumns.Items.Clear();
            lstComboPreview.Clear();

            string[] tokens = wlFile[0].Split(txtFileSeparator.Text.ToCharArray());
            for (int i = 0; i < tokens.Length; i++)
                lstComboPreview.Columns.Add(String.Format("Token ({0})", i + 1));

            Array.Clear(tokens, 0, tokens.Length);
            int index = 0;
            foreach (string line in wlFile)
            {
                tokens = line.Split(txtFileSeparator.Text.ToCharArray());
                ListViewItem item = new ListViewItem(tokens[0]);
                for (int i = 1; i < tokens.Length; i++)
                    item.SubItems.Add(tokens[i]);
                
                lstComboPreview.Items.Add(item);
                index++;
            }
            
            // adjust columns width to longest text
            foreach (var column in lstComboPreview.Columns)
            {
                ((ColumnHeader)column).Width = -1;
                combTokenExtractUser.Items.Add(Convert.ToInt32(((ColumnHeader)column).Index + 1));
                combTokenSpaces.Items.Add(Convert.ToInt32(((ColumnHeader)column).Index + 1));
                combDecipherColumns.Items.Add(Convert.ToInt32(((ColumnHeader)column).Index + 1));
            }

            combTokenExtractUser.SelectedIndex = 0;
            combTokenSpaces.SelectedIndex = 0;
            combDecipherColumns.SelectedIndex = 0;
            // update counting
            stripEntries.Text = wlFile.Count.ToString();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are closing the application.\nAre you sure yo want to continue?", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                Application.Exit();
        }

        private void resetFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtWordslist.Text.Length > 0)
            {
                stripStatus.Text = "Reseting file...";
                Thread readFileThread = new Thread(() => ReadWordlistFile(txtWordslist.Text));                
                readFileThread.Start();
                timeStatus.Enabled = true;
                //readFileThread.Join(); // wait for thread to finish
            }
            else
                MessageBox.Show("No file loaded to reset", "No File!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SaveWordlistFile(string path)
        {
            try
            {
                File.WriteAllLines(path, wlFile.ToArray());
                MessageBox.Show("File successfully saved", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\nThe file could not be saved", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to overwrite the current file.\nAre you sure yo want to continue?", "Save File", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                SaveWordlistFile(txtWordslist.Text);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                SaveWordlistFile(saveFileDialog1.FileName);
        }

        private string ParseStringByDelimiters(string response, string start, char endchar)
        {
            string decrypted = "";

            int index = response.IndexOf(start);
            if (index >= 0)
            {
                int i = 0;
                while (response[index + start.Length + i] != endchar)
                {
                    decrypted += response[index + start.Length + i];
                    i++;
                }
            }

            return decrypted;
        }

        private void timeStatus_Tick(object sender, EventArgs e)
        {
            lock (locker)
            {
                // parse thread statistics information
                string[] thread_data = logtext.Split(',');
                if (thread_data.Length == 7)
                {
                    lblDecryptCurrentProgress.Text = thread_data[0];
                    lblDecryptFound.Text = thread_data[1];
                    lblDecryptNotFound.Text = thread_data[2];
                    lblServerErrors.Text = thread_data[3];

                    txtLastHash.Text = thread_data[4];
                    txtLastResult.Text = thread_data[5];
                    txtCurrentHash.Text = thread_data[6];
                }
            }

            lock (decrypt_threads_amount_access)
            {
                lblWorkingThreads.Text = Convert.ToString(decrypt_treads);
            }

            lock (finish_flag)
            {
                if (finished)
                {
                    timeStatus.Enabled = false;
                    SetPreviewText();
                    if (checkChangeSeparator.Checked)
                        txtFileSeparator.Text = txtNewSeparator.Text; // update current separator

                    stripStatus.Text = "Process Finished!";

                    btnStart.Enabled = true;
                    btnCancel.Enabled = btnPause.Enabled = false;
                    timeStopwatch.Enabled = false;

                    // uncheck all checkboxes
                    foreach (TabPage page in tabControl1.TabPages)
                    {
                        foreach (var item in page.Controls)
                        {                            
                            if (item is GroupBox)
                            {
                                foreach (Control subitem in ((GroupBox)item).Controls)
                                {
                                    if (subitem is CheckBox)
                                        ((CheckBox)subitem).Checked = false;
                                }
                            }

                            if (item is CheckBox)
                                ((CheckBox)item).Checked = false;
                        }
                    }

                    MessageBox.Show("Process Completed!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void checkDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            combDecipherColumns.Enabled = checkDecrypt.Checked;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = lstComboPreview.SelectedItems;
            String text = "";            
            foreach (ListViewItem item in selectedItems)
            {
                string txtsubitems = "";
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                    txtsubitems += txtFileSeparator.Text + subitem.Text;

                txtsubitems = txtsubitems.TrimStart(':');
                text += txtsubitems + Environment.NewLine;
            }

            Clipboard.SetText(text);
        }

        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String text = "";
            foreach (ListViewItem item in lstComboPreview.Items)
            {
                string txtsubitems = "";
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                    txtsubitems += txtFileSeparator.Text + subitem.Text;

                txtsubitems = txtsubitems.TrimStart(':');
                text += txtsubitems + Environment.NewLine;
            }

            Clipboard.SetText(text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                txtFusionFile.Text = openFileDialog2.FileName;
                richFusionFile.Lines = File.ReadAllLines(txtFusionFile.Text);
                checkMergeTokens.Checked = checkMergeFiles.Checked = false;
                btnFusion.Enabled = true;
            }
            else
                btnFusion.Enabled = false;
        }

        private void btnFusion_Click(object sender, EventArgs e)
        {
            // merge tokens of both files
            if (checkMergeTokens.Checked && wlFile != null && wlFile.Count > 0)
            {
                int iterations = 0;
                if(wlFile.Count < richFusionFile.Lines.Length) 
                    iterations = wlFile.Count; 
                else
                    iterations = richFusionFile.Lines.Length;

                for (int i = 0; i < iterations; i++)
                    wlFile[i] = wlFile[i] + txtFileSeparator.Text + richFusionFile.Lines[i];
            }

            // just add at the end of the main file
            if (checkMergeFiles.Checked && wlFile != null && wlFile.Count > 0)
            {
                wlFile.AddRange(richFusionFile.Lines.ToList());
                SetPreviewText(/*wlFile.ToArray()*/);
                MessageBox.Show("File successfully merged", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (wlFile != null && wlFile.Count > 0)
            {
                if (finished) // no thread working
                {
                    if (txtFileSeparator.Text.Length == 0)
                    {
                        MessageBox.Show("Specify the separator character in order to parse the file", "No Separator!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if(checkReorderColumns.Checked)
                    {
                        string[] tokens = txtCredentialsColumnsOrder.Text.Split(',');
                        foreach (string token in tokens)
	                    {
                            if (Convert.ToInt32(token) > lstComboPreview.Columns.Count)
                            {
                                MessageBox.Show("Token numbers specified to reorder credentials are out of range", "Out of tokens!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
	                    }
                    }

                    stop_thread = false; // reset the stop thread flag
                    finished = false; // reset the stop timer flag
                    lblElapsedTime.Text = "00:00:00"; //reset stopwatch
                    seconds = 0;
                    minutes = 0;
                    hours = 0;
                    decryption_found = 0;
                    server_errors = 0;

                    if (checkDecrypt.Checked)
                        decypher_column = Convert.ToInt32(combDecipherColumns.Text) - 1;

                    ThreadStart childref = new ThreadStart(FileProcessThread);
                    Thread fileBatchThread = new Thread(childref);
                    fileBatchThread.Start();

                    timeStatus.Enabled = true;
                    timeStopwatch.Enabled = true;
                    btnStart.Enabled = false;
                    btnPause.Enabled = true;
                    btnCancel.Enabled = true;
                    
                }
                else
                {
                    waitHandle.Set(); // resume thread
                    timeStopwatch.Enabled = true;
                    stripStatus.Text = stripStatus.Text.Substring(0, stripStatus.Text.IndexOf("PAUSED!"));
                    btnPause.Enabled = btnCancel.Enabled = true;
                    btnStart.Enabled = false;
                }
            }
            else
                MessageBox.Show("No file loaded to process", "No File!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to stop the current process.\nAre you sure yo want to continue?", "Stop!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                btnPause.Enabled = btnCancel.Enabled = false;
                btnStart.Enabled = true;

                stop_thread = true;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            waitHandle.Reset();
            stripStatus.Text += "PAUSED!";
            btnPause.Enabled = btnCancel.Enabled = false;
            btnStart.Enabled = true;
            timeStopwatch.Enabled = false;
        }

        private void txtExtractUserToken_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void checkExtractUser_CheckedChanged(object sender, EventArgs e)
        {
            combTokenExtractUser.Enabled = checkExtractUser.Checked;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            stop_thread = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combDecipherColumns_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCredentialsColumnsOrder_Leave(object sender, EventArgs e)
        {
            if(txtCredentialsColumnsOrder.Text.Length == 0)
            {
                txtCredentialsColumnsOrder.Text = "Ex: 3,1,2";
                txtCredentialsColumnsOrder.ForeColor = Color.LightGray;
            }
        }

        private void txtCredentialsColumnsOrder_Enter(object sender, EventArgs e)
        {
            txtCredentialsColumnsOrder.ForeColor = Color.Black;
            if (txtCredentialsColumnsOrder.Text == "Ex: 3,1,2")
                txtCredentialsColumnsOrder.Text = "";
        }

        private void timeStopwatch_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds > 59)
            {
                seconds = 0;
                minutes++;
            }

            if (minutes > 59)
            {
                minutes = 0;
                hours++;
            }

            lblElapsedTime.Text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            combTokenSpaces.Enabled = checkRemoveSpaces.Checked;
        }

        private void combTokenSpaces_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThreadStart childref = new ThreadStart(DecryptSingleHashThread);
            Thread fileBatchThread = new Thread(childref);
            fileBatchThread.Start();
        }

        private void checkReorderColumns_CheckedChanged(object sender, EventArgs e)
        {
            txtCredentialsColumnsOrder.Enabled = checkReorderColumns.Checked;
            if (txtCredentialsColumnsOrder.Text.Length == 0 || txtCredentialsColumnsOrder.Text == "Ex: 3,1,2")
            {
                txtCredentialsColumnsOrder.Text = "Ex: 3,1,2";
                txtCredentialsColumnsOrder.ForeColor = Color.LightGray;
            }
            else
                txtCredentialsColumnsOrder.ForeColor = Color.Black;
        }

    }
}
