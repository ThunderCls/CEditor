namespace CEditor
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.checkDecrypt = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripEntries = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timeStatus = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWordslist = new System.Windows.Forms.TextBox();
            this.lstComboPreview = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboTrimToken = new System.Windows.Forms.ComboBox();
            this.radioTrimRight = new System.Windows.Forms.RadioButton();
            this.radioTrimLeft = new System.Windows.Forms.RadioButton();
            this.txtTrimToken = new System.Windows.Forms.TextBox();
            this.checkTrimSearch = new System.Windows.Forms.CheckBox();
            this.combTokenSpaces = new System.Windows.Forms.ComboBox();
            this.checkRemoveSpaces = new System.Windows.Forms.CheckBox();
            this.combTokenExtractUser = new System.Windows.Forms.ComboBox();
            this.checkExtractUser = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileSeparator = new System.Windows.Forms.TextBox();
            this.txtCredentialsColumnsOrder = new System.Windows.Forms.TextBox();
            this.checkReorderColumns = new System.Windows.Forms.CheckBox();
            this.txtNewSeparator = new System.Windows.Forms.TextBox();
            this.checkChangeSeparator = new System.Windows.Forms.CheckBox();
            this.txtStripLine = new System.Windows.Forms.TextBox();
            this.checkRemoveLinesText = new System.Windows.Forms.CheckBox();
            this.checkRemBlank = new System.Windows.Forms.CheckBox();
            this.checkRemDuplicates = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnFusion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkMergeFiles = new System.Windows.Forms.CheckBox();
            this.checkMergeTokens = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFusionFile = new System.Windows.Forms.TextBox();
            this.richFusionFile = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtSingleHashDecrypted = new System.Windows.Forms.TextBox();
            this.txtSingleHashStr = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.combHashType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numDecryptThreads = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.combDecipherColumns = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkKeepHashOnServerError = new System.Windows.Forms.CheckBox();
            this.checkKeepNotFoundHash = new System.Windows.Forms.CheckBox();
            this.txtLastResult = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLastHash = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCurrentHash = new System.Windows.Forms.TextBox();
            this.lblCurrentHash = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblWorkingThreads = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblServerErrors = new System.Windows.Forms.Label();
            this.lblDecryptNotFound = new System.Windows.Forms.Label();
            this.lblDecryptFound = new System.Windows.Forms.Label();
            this.lblDecryptCurrentProgress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.timeStopwatch = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDecryptThreads)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkDecrypt
            // 
            this.checkDecrypt.AutoSize = true;
            this.checkDecrypt.Location = new System.Drawing.Point(24, 26);
            this.checkDecrypt.Name = "checkDecrypt";
            this.checkDecrypt.Size = new System.Drawing.Size(162, 17);
            this.checkDecrypt.TabIndex = 24;
            this.checkDecrypt.Text = "Try to decrypt token number:";
            this.checkDecrypt.UseVisualStyleBackColor = true;
            this.checkDecrypt.CheckedChanged += new System.EventHandler(this.checkDecrypt_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.stripEntries,
            this.toolStripStatusLabel1,
            this.stripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 672);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(527, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel2.Text = "Total Entries:";
            // 
            // stripEntries
            // 
            this.stripEntries.Name = "stripEntries";
            this.stripEntries.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.stripEntries.Size = new System.Drawing.Size(20, 17);
            this.stripEntries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // stripStatus
            // 
            this.stripStatus.Name = "stripStatus";
            this.stripStatus.Size = new System.Drawing.Size(26, 17);
            this.stripStatus.Text = "Idle";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.resetFileToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // resetFileToolStripMenuItem
            // 
            this.resetFileToolStripMenuItem.Name = "resetFileToolStripMenuItem";
            this.resetFileToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.resetFileToolStripMenuItem.Text = "Reset File";
            this.resetFileToolStripMenuItem.Click += new System.EventHandler(this.resetFileToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 6);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "Text files|*.txt";
            this.openFileDialog1.Title = "Select Wordlist";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text files|*.txt";
            this.saveFileDialog1.Title = "Save Wordlist as";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CEditor.Properties.Resources.logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 105);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // timeStatus
            // 
            this.timeStatus.Tick += new System.EventHandler(this.timeStatus_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 128);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 505);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtWordslist);
            this.tabPage1.Controls.Add(this.lstComboPreview);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(531, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 20);
            this.button2.TabIndex = 9;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wordlist File: ";
            // 
            // txtWordslist
            // 
            this.txtWordslist.Location = new System.Drawing.Point(93, 19);
            this.txtWordslist.Name = "txtWordslist";
            this.txtWordslist.ReadOnly = true;
            this.txtWordslist.Size = new System.Drawing.Size(367, 20);
            this.txtWordslist.TabIndex = 7;
            // 
            // lstComboPreview
            // 
            this.lstComboPreview.ContextMenuStrip = this.contextMenuStrip1;
            this.lstComboPreview.FullRowSelect = true;
            this.lstComboPreview.GridLines = true;
            this.lstComboPreview.LabelEdit = true;
            this.lstComboPreview.Location = new System.Drawing.Point(13, 54);
            this.lstComboPreview.Name = "lstComboPreview";
            this.lstComboPreview.Size = new System.Drawing.Size(495, 410);
            this.lstComboPreview.TabIndex = 11;
            this.lstComboPreview.UseCompatibleStateImageBehavior = false;
            this.lstComboPreview.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.copyAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.copyAllToolStripMenuItem.Text = "Copy All";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(531, 479);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Options";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.comboTrimToken);
            this.groupBox1.Controls.Add(this.radioTrimRight);
            this.groupBox1.Controls.Add(this.radioTrimLeft);
            this.groupBox1.Controls.Add(this.txtTrimToken);
            this.groupBox1.Controls.Add(this.checkTrimSearch);
            this.groupBox1.Controls.Add(this.combTokenSpaces);
            this.groupBox1.Controls.Add(this.checkRemoveSpaces);
            this.groupBox1.Controls.Add(this.combTokenExtractUser);
            this.groupBox1.Controls.Add(this.checkExtractUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFileSeparator);
            this.groupBox1.Controls.Add(this.txtCredentialsColumnsOrder);
            this.groupBox1.Controls.Add(this.checkReorderColumns);
            this.groupBox1.Controls.Add(this.txtNewSeparator);
            this.groupBox1.Controls.Add(this.checkChangeSeparator);
            this.groupBox1.Controls.Add(this.txtStripLine);
            this.groupBox1.Controls.Add(this.checkRemoveLinesText);
            this.groupBox1.Controls.Add(this.checkRemBlank);
            this.groupBox1.Controls.Add(this.checkRemDuplicates);
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 377);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Text Search:";
            // 
            // comboTrimToken
            // 
            this.comboTrimToken.Enabled = false;
            this.comboTrimToken.FormattingEnabled = true;
            this.comboTrimToken.Location = new System.Drawing.Point(191, 156);
            this.comboTrimToken.Name = "comboTrimToken";
            this.comboTrimToken.Size = new System.Drawing.Size(39, 21);
            this.comboTrimToken.TabIndex = 33;
            // 
            // radioTrimRight
            // 
            this.radioTrimRight.AutoSize = true;
            this.radioTrimRight.Location = new System.Drawing.Point(114, 207);
            this.radioTrimRight.Name = "radioTrimRight";
            this.radioTrimRight.Size = new System.Drawing.Size(92, 17);
            this.radioTrimRight.TabIndex = 32;
            this.radioTrimRight.TabStop = true;
            this.radioTrimRight.Text = "Trim Full Right";
            this.radioTrimRight.UseVisualStyleBackColor = true;
            // 
            // radioTrimLeft
            // 
            this.radioTrimLeft.AutoSize = true;
            this.radioTrimLeft.Location = new System.Drawing.Point(114, 226);
            this.radioTrimLeft.Name = "radioTrimLeft";
            this.radioTrimLeft.Size = new System.Drawing.Size(85, 17);
            this.radioTrimLeft.TabIndex = 31;
            this.radioTrimLeft.TabStop = true;
            this.radioTrimLeft.Text = "Trim Full Left";
            this.radioTrimLeft.UseVisualStyleBackColor = true;
            // 
            // txtTrimToken
            // 
            this.txtTrimToken.Enabled = false;
            this.txtTrimToken.Location = new System.Drawing.Point(114, 181);
            this.txtTrimToken.Name = "txtTrimToken";
            this.txtTrimToken.Size = new System.Drawing.Size(116, 20);
            this.txtTrimToken.TabIndex = 29;
            // 
            // checkTrimSearch
            // 
            this.checkTrimSearch.AutoSize = true;
            this.checkTrimSearch.Location = new System.Drawing.Point(24, 159);
            this.checkTrimSearch.Name = "checkTrimSearch";
            this.checkTrimSearch.Size = new System.Drawing.Size(127, 17);
            this.checkTrimSearch.TabIndex = 28;
            this.checkTrimSearch.Text = "Trim Search in token:";
            this.checkTrimSearch.UseVisualStyleBackColor = true;
            // 
            // combTokenSpaces
            // 
            this.combTokenSpaces.Enabled = false;
            this.combTokenSpaces.FormattingEnabled = true;
            this.combTokenSpaces.Location = new System.Drawing.Point(425, 31);
            this.combTokenSpaces.Name = "combTokenSpaces";
            this.combTokenSpaces.Size = new System.Drawing.Size(39, 21);
            this.combTokenSpaces.TabIndex = 27;
            // 
            // checkRemoveSpaces
            // 
            this.checkRemoveSpaces.AutoSize = true;
            this.checkRemoveSpaces.Location = new System.Drawing.Point(244, 33);
            this.checkRemoveSpaces.Name = "checkRemoveSpaces";
            this.checkRemoveSpaces.Size = new System.Drawing.Size(175, 17);
            this.checkRemoveSpaces.TabIndex = 26;
            this.checkRemoveSpaces.Text = "Remove white spaces in token:";
            this.checkRemoveSpaces.UseVisualStyleBackColor = true;
            // 
            // combTokenExtractUser
            // 
            this.combTokenExtractUser.Enabled = false;
            this.combTokenExtractUser.FormattingEnabled = true;
            this.combTokenExtractUser.Location = new System.Drawing.Point(425, 123);
            this.combTokenExtractUser.Name = "combTokenExtractUser";
            this.combTokenExtractUser.Size = new System.Drawing.Size(39, 21);
            this.combTokenExtractUser.TabIndex = 25;
            // 
            // checkExtractUser
            // 
            this.checkExtractUser.AutoSize = true;
            this.checkExtractUser.Location = new System.Drawing.Point(244, 125);
            this.checkExtractUser.Name = "checkExtractUser";
            this.checkExtractUser.Size = new System.Drawing.Size(181, 17);
            this.checkExtractUser.TabIndex = 24;
            this.checkExtractUser.Text = "Extract users from email in token:";
            this.checkExtractUser.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Separator used on current wordlist:";
            // 
            // txtFileSeparator
            // 
            this.txtFileSeparator.Location = new System.Drawing.Point(198, 27);
            this.txtFileSeparator.MaxLength = 1;
            this.txtFileSeparator.Name = "txtFileSeparator";
            this.txtFileSeparator.Size = new System.Drawing.Size(21, 20);
            this.txtFileSeparator.TabIndex = 22;
            this.txtFileSeparator.Text = ":";
            // 
            // txtCredentialsColumnsOrder
            // 
            this.txtCredentialsColumnsOrder.Enabled = false;
            this.txtCredentialsColumnsOrder.Location = new System.Drawing.Point(244, 76);
            this.txtCredentialsColumnsOrder.Name = "txtCredentialsColumnsOrder";
            this.txtCredentialsColumnsOrder.Size = new System.Drawing.Size(222, 20);
            this.txtCredentialsColumnsOrder.TabIndex = 16;
            this.txtCredentialsColumnsOrder.Enter += new System.EventHandler(this.txtCredentialsColumnsOrder_Enter);
            this.txtCredentialsColumnsOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCredentialsColumnsOrder_KeyPress);
            this.txtCredentialsColumnsOrder.Leave += new System.EventHandler(this.txtCredentialsColumnsOrder_Leave);
            // 
            // checkReorderColumns
            // 
            this.checkReorderColumns.AutoSize = true;
            this.checkReorderColumns.Location = new System.Drawing.Point(244, 56);
            this.checkReorderColumns.Name = "checkReorderColumns";
            this.checkReorderColumns.Size = new System.Drawing.Size(148, 17);
            this.checkReorderColumns.TabIndex = 15;
            this.checkReorderColumns.Text = "Reorder credential tokens";
            this.checkReorderColumns.UseVisualStyleBackColor = true;
            this.checkReorderColumns.CheckedChanged += new System.EventHandler(this.checkReorderColumns_CheckedChanged);
            // 
            // txtNewSeparator
            // 
            this.txtNewSeparator.Enabled = false;
            this.txtNewSeparator.Location = new System.Drawing.Point(425, 100);
            this.txtNewSeparator.MaxLength = 1;
            this.txtNewSeparator.Name = "txtNewSeparator";
            this.txtNewSeparator.Size = new System.Drawing.Size(40, 20);
            this.txtNewSeparator.TabIndex = 12;
            // 
            // checkChangeSeparator
            // 
            this.checkChangeSeparator.AutoSize = true;
            this.checkChangeSeparator.Location = new System.Drawing.Point(244, 102);
            this.checkChangeSeparator.Name = "checkChangeSeparator";
            this.checkChangeSeparator.Size = new System.Drawing.Size(151, 17);
            this.checkChangeSeparator.TabIndex = 10;
            this.checkChangeSeparator.Text = "Change wordlist separator:";
            this.checkChangeSeparator.UseVisualStyleBackColor = true;
            // 
            // txtStripLine
            // 
            this.txtStripLine.Enabled = false;
            this.txtStripLine.Location = new System.Drawing.Point(24, 125);
            this.txtStripLine.Name = "txtStripLine";
            this.txtStripLine.Size = new System.Drawing.Size(206, 20);
            this.txtStripLine.TabIndex = 9;
            // 
            // checkRemoveLinesText
            // 
            this.checkRemoveLinesText.AutoSize = true;
            this.checkRemoveLinesText.Location = new System.Drawing.Point(24, 105);
            this.checkRemoveLinesText.Name = "checkRemoveLinesText";
            this.checkRemoveLinesText.Size = new System.Drawing.Size(179, 17);
            this.checkRemoveLinesText.TabIndex = 8;
            this.checkRemoveLinesText.Text = "Remove lines with following text:";
            this.checkRemoveLinesText.UseVisualStyleBackColor = true;
            // 
            // checkRemBlank
            // 
            this.checkRemBlank.AutoSize = true;
            this.checkRemBlank.Location = new System.Drawing.Point(24, 82);
            this.checkRemBlank.Name = "checkRemBlank";
            this.checkRemBlank.Size = new System.Drawing.Size(206, 17);
            this.checkRemBlank.TabIndex = 7;
            this.checkRemBlank.Text = "Remove empty lines/blank credentials";
            this.checkRemBlank.UseVisualStyleBackColor = true;
            // 
            // checkRemDuplicates
            // 
            this.checkRemDuplicates.AutoSize = true;
            this.checkRemDuplicates.Location = new System.Drawing.Point(24, 59);
            this.checkRemDuplicates.Name = "checkRemDuplicates";
            this.checkRemDuplicates.Size = new System.Drawing.Size(117, 17);
            this.checkRemDuplicates.TabIndex = 6;
            this.checkRemDuplicates.Text = "Remove duplicates";
            this.checkRemDuplicates.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnFusion);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtFusionFile);
            this.tabPage3.Controls.Add(this.richFusionFile);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(531, 479);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Combo Fusion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnFusion
            // 
            this.btnFusion.Enabled = false;
            this.btnFusion.Location = new System.Drawing.Point(326, 77);
            this.btnFusion.Name = "btnFusion";
            this.btnFusion.Size = new System.Drawing.Size(124, 23);
            this.btnFusion.TabIndex = 14;
            this.btnFusion.Text = "Fusion Combos";
            this.btnFusion.UseVisualStyleBackColor = true;
            this.btnFusion.Click += new System.EventHandler(this.btnFusion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkMergeFiles);
            this.groupBox2.Controls.Add(this.checkMergeTokens);
            this.groupBox2.Location = new System.Drawing.Point(13, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 96);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // checkMergeFiles
            // 
            this.checkMergeFiles.AutoSize = true;
            this.checkMergeFiles.Location = new System.Drawing.Point(12, 55);
            this.checkMergeFiles.Name = "checkMergeFiles";
            this.checkMergeFiles.Size = new System.Drawing.Size(80, 17);
            this.checkMergeFiles.TabIndex = 1;
            this.checkMergeFiles.Text = "Merge Files";
            this.checkMergeFiles.UseVisualStyleBackColor = true;
            // 
            // checkMergeTokens
            // 
            this.checkMergeTokens.AutoSize = true;
            this.checkMergeTokens.Location = new System.Drawing.Point(12, 32);
            this.checkMergeTokens.Name = "checkMergeTokens";
            this.checkMergeTokens.Size = new System.Drawing.Size(95, 17);
            this.checkMergeTokens.TabIndex = 0;
            this.checkMergeTokens.Text = "Merge Tokens";
            this.checkMergeTokens.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fusion File: ";
            // 
            // txtFusionFile
            // 
            this.txtFusionFile.Location = new System.Drawing.Point(93, 19);
            this.txtFusionFile.Name = "txtFusionFile";
            this.txtFusionFile.ReadOnly = true;
            this.txtFusionFile.Size = new System.Drawing.Size(367, 20);
            this.txtFusionFile.TabIndex = 10;
            // 
            // richFusionFile
            // 
            this.richFusionFile.Location = new System.Drawing.Point(13, 147);
            this.richFusionFile.Name = "richFusionFile";
            this.richFusionFile.Size = new System.Drawing.Size(495, 319);
            this.richFusionFile.TabIndex = 0;
            this.richFusionFile.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.combHashType);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.numDecryptThreads);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.combDecipherColumns);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.txtLastResult);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtLastHash);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtCurrentHash);
            this.tabPage2.Controls.Add(this.lblCurrentHash);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.checkDecrypt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(531, 479);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Decryptor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.txtSingleHashDecrypted);
            this.groupBox5.Controls.Add(this.txtSingleHashStr);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(21, 365);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(481, 95);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Single Hash Decrypt";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(396, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 23);
            this.button4.TabIndex = 42;
            this.button4.Text = "Decrypt";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtSingleHashDecrypted
            // 
            this.txtSingleHashDecrypted.Location = new System.Drawing.Point(79, 54);
            this.txtSingleHashDecrypted.Name = "txtSingleHashDecrypted";
            this.txtSingleHashDecrypted.ReadOnly = true;
            this.txtSingleHashDecrypted.Size = new System.Drawing.Size(307, 20);
            this.txtSingleHashDecrypted.TabIndex = 41;
            // 
            // txtSingleHashStr
            // 
            this.txtSingleHashStr.Location = new System.Drawing.Point(79, 30);
            this.txtSingleHashStr.Name = "txtSingleHashStr";
            this.txtSingleHashStr.Size = new System.Drawing.Size(307, 20);
            this.txtSingleHashStr.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Decrypted: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Hash: ";
            // 
            // combHashType
            // 
            this.combHashType.FormattingEnabled = true;
            this.combHashType.Items.AddRange(new object[] {
            "MD5/Sha1",
            "Base64"});
            this.combHashType.Location = new System.Drawing.Point(339, 24);
            this.combHashType.Name = "combHashType";
            this.combHashType.Size = new System.Drawing.Size(163, 21);
            this.combHashType.TabIndex = 38;
            this.combHashType.Text = "MD5/Sha1";
            this.combHashType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Hash type: ";
            // 
            // numDecryptThreads
            // 
            this.numDecryptThreads.Location = new System.Drawing.Point(448, 62);
            this.numDecryptThreads.Name = "numDecryptThreads";
            this.numDecryptThreads.Size = new System.Drawing.Size(54, 20);
            this.numDecryptThreads.TabIndex = 36;
            this.numDecryptThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(279, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Amount of threads for decryption:";
            // 
            // combDecipherColumns
            // 
            this.combDecipherColumns.Enabled = false;
            this.combDecipherColumns.FormattingEnabled = true;
            this.combDecipherColumns.Location = new System.Drawing.Point(184, 24);
            this.combDecipherColumns.Name = "combDecipherColumns";
            this.combDecipherColumns.Size = new System.Drawing.Size(48, 21);
            this.combDecipherColumns.TabIndex = 34;
            this.combDecipherColumns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combDecipherColumns_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkKeepHashOnServerError);
            this.groupBox4.Controls.Add(this.checkKeepNotFoundHash);
            this.groupBox4.Location = new System.Drawing.Point(21, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 85);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // checkKeepHashOnServerError
            // 
            this.checkKeepHashOnServerError.AutoSize = true;
            this.checkKeepHashOnServerError.Location = new System.Drawing.Point(20, 51);
            this.checkKeepHashOnServerError.Name = "checkKeepHashOnServerError";
            this.checkKeepHashOnServerError.Size = new System.Drawing.Size(159, 17);
            this.checkKeepHashOnServerError.TabIndex = 1;
            this.checkKeepHashOnServerError.Text = "Keep hashes on server error";
            this.checkKeepHashOnServerError.UseVisualStyleBackColor = true;
            // 
            // checkKeepNotFoundHash
            // 
            this.checkKeepNotFoundHash.AutoSize = true;
            this.checkKeepNotFoundHash.Location = new System.Drawing.Point(20, 28);
            this.checkKeepNotFoundHash.Name = "checkKeepNotFoundHash";
            this.checkKeepNotFoundHash.Size = new System.Drawing.Size(136, 17);
            this.checkKeepNotFoundHash.TabIndex = 0;
            this.checkKeepNotFoundHash.Text = "Keep hashes not found";
            this.checkKeepNotFoundHash.UseVisualStyleBackColor = true;
            // 
            // txtLastResult
            // 
            this.txtLastResult.Location = new System.Drawing.Point(279, 225);
            this.txtLastResult.Name = "txtLastResult";
            this.txtLastResult.ReadOnly = true;
            this.txtLastResult.Size = new System.Drawing.Size(220, 20);
            this.txtLastResult.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Last result:";
            // 
            // txtLastHash
            // 
            this.txtLastHash.Location = new System.Drawing.Point(279, 181);
            this.txtLastHash.Name = "txtLastHash";
            this.txtLastHash.ReadOnly = true;
            this.txtLastHash.Size = new System.Drawing.Size(220, 20);
            this.txtLastHash.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Last hash:";
            // 
            // txtCurrentHash
            // 
            this.txtCurrentHash.Location = new System.Drawing.Point(279, 118);
            this.txtCurrentHash.Name = "txtCurrentHash";
            this.txtCurrentHash.ReadOnly = true;
            this.txtCurrentHash.Size = new System.Drawing.Size(220, 20);
            this.txtCurrentHash.TabIndex = 28;
            // 
            // lblCurrentHash
            // 
            this.lblCurrentHash.AutoSize = true;
            this.lblCurrentHash.Location = new System.Drawing.Point(315, 99);
            this.lblCurrentHash.Name = "lblCurrentHash";
            this.lblCurrentHash.Size = new System.Drawing.Size(151, 13);
            this.lblCurrentHash.TabIndex = 27;
            this.lblCurrentHash.Text = "Current hash being processed:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblWorkingThreads);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lblElapsedTime);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblServerErrors);
            this.groupBox3.Controls.Add(this.lblDecryptNotFound);
            this.groupBox3.Controls.Add(this.lblDecryptFound);
            this.groupBox3.Controls.Add(this.lblDecryptCurrentProgress);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(21, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 214);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            // 
            // lblWorkingThreads
            // 
            this.lblWorkingThreads.Location = new System.Drawing.Point(127, 141);
            this.lblWorkingThreads.Name = "lblWorkingThreads";
            this.lblWorkingThreads.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWorkingThreads.Size = new System.Drawing.Size(87, 13);
            this.lblWorkingThreads.TabIndex = 11;
            this.lblWorkingThreads.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Working threads:";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.Location = new System.Drawing.Point(127, 170);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblElapsedTime.Size = new System.Drawing.Size(87, 13);
            this.lblElapsedTime.TabIndex = 9;
            this.lblElapsedTime.Text = "00:00:00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Elapsed time:";
            // 
            // lblServerErrors
            // 
            this.lblServerErrors.Location = new System.Drawing.Point(127, 112);
            this.lblServerErrors.Name = "lblServerErrors";
            this.lblServerErrors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblServerErrors.Size = new System.Drawing.Size(87, 13);
            this.lblServerErrors.TabIndex = 7;
            this.lblServerErrors.Text = "0";
            // 
            // lblDecryptNotFound
            // 
            this.lblDecryptNotFound.Location = new System.Drawing.Point(127, 84);
            this.lblDecryptNotFound.Name = "lblDecryptNotFound";
            this.lblDecryptNotFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDecryptNotFound.Size = new System.Drawing.Size(87, 13);
            this.lblDecryptNotFound.TabIndex = 6;
            this.lblDecryptNotFound.Text = "0";
            // 
            // lblDecryptFound
            // 
            this.lblDecryptFound.Location = new System.Drawing.Point(127, 55);
            this.lblDecryptFound.Name = "lblDecryptFound";
            this.lblDecryptFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDecryptFound.Size = new System.Drawing.Size(87, 13);
            this.lblDecryptFound.TabIndex = 5;
            this.lblDecryptFound.Text = "0";
            // 
            // lblDecryptCurrentProgress
            // 
            this.lblDecryptCurrentProgress.Location = new System.Drawing.Point(127, 29);
            this.lblDecryptCurrentProgress.Name = "lblDecryptCurrentProgress";
            this.lblDecryptCurrentProgress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDecryptCurrentProgress.Size = new System.Drawing.Size(87, 13);
            this.lblDecryptCurrentProgress.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Server errors:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Not Found:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Found:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Decryption progress:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "txt";
            this.openFileDialog2.Filter = "Text files|*.txt";
            this.openFileDialog2.Title = "Select File";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(325, 639);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(86, 639);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(205, 639);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(104, 23);
            this.btnPause.TabIndex = 16;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // timeStopwatch
            // 
            this.timeStopwatch.Interval = 1000;
            this.timeStopwatch.Tick += new System.EventHandler(this.timeStopwatch_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 694);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEditor v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDecryptThreads)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel stripEntries;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem resetFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stripStatus;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timeStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWordslist;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richFusionFile;
        private System.Windows.Forms.CheckBox checkDecrypt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lstComboPreview;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
        private System.Windows.Forms.Button btnFusion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkMergeFiles;
        private System.Windows.Forms.CheckBox checkMergeTokens;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFusionFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkKeepHashOnServerError;
        private System.Windows.Forms.CheckBox checkKeepNotFoundHash;
        private System.Windows.Forms.TextBox txtLastResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLastHash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCurrentHash;
        private System.Windows.Forms.Label lblCurrentHash;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblServerErrors;
        private System.Windows.Forms.Label lblDecryptNotFound;
        private System.Windows.Forms.Label lblDecryptFound;
        private System.Windows.Forms.Label lblDecryptCurrentProgress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combDecipherColumns;
        private System.Windows.Forms.NumericUpDown numDecryptThreads;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblWorkingThreads;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timeStopwatch;
        private System.Windows.Forms.ComboBox combHashType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtSingleHashDecrypted;
        private System.Windows.Forms.TextBox txtSingleHashStr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioTrimRight;
        private System.Windows.Forms.TextBox txtTrimToken;
        private System.Windows.Forms.CheckBox checkTrimSearch;
        private System.Windows.Forms.ComboBox combTokenSpaces;
        private System.Windows.Forms.CheckBox checkRemoveSpaces;
        private System.Windows.Forms.ComboBox combTokenExtractUser;
        private System.Windows.Forms.CheckBox checkExtractUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFileSeparator;
        private System.Windows.Forms.TextBox txtCredentialsColumnsOrder;
        private System.Windows.Forms.CheckBox checkReorderColumns;
        private System.Windows.Forms.TextBox txtNewSeparator;
        private System.Windows.Forms.CheckBox checkChangeSeparator;
        private System.Windows.Forms.TextBox txtStripLine;
        private System.Windows.Forms.CheckBox checkRemoveLinesText;
        private System.Windows.Forms.CheckBox checkRemBlank;
        private System.Windows.Forms.CheckBox checkRemDuplicates;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboTrimToken;
        private System.Windows.Forms.RadioButton radioTrimLeft;
    }
}

