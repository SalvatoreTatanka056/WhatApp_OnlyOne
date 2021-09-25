namespace WhatsApp_One
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lstMain = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdFolder = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstsPrg = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslblMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMain = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.conversationCtrl1 = new WhatsApp_One.ControlsSuite.ConversationCtrl();
            this.btnConnect = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPosizione = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSecondi = new System.Windows.Forms.Label();
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnAudio = new System.Windows.Forms.Button();
            this.btnCancellaCronologia = new System.Windows.Forms.Button();
            this.btnAllegaFile = new System.Windows.Forms.Button();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmrSecondiRegistrazione = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMain
            // 
            this.lstMain.FormattingEnabled = true;
            this.lstMain.Location = new System.Drawing.Point(34, 269);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(195, 264);
            this.lstMain.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtIdFolder);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.lblMain);
            this.splitContainer1.Panel1.Controls.Add(this.txtUserName);
            this.splitContainer1.Panel1.Controls.Add(this.propertyGrid1);
            this.splitContainer1.Panel1.Controls.Add(this.btnConnect);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.splitContainer1.Size = new System.Drawing.Size(1607, 1045);
            this.splitContainer1.SplitterDistance = 535;
            this.splitContainer1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id Interlocutore";
            // 
            // txtIdFolder
            // 
            this.txtIdFolder.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFolder.Location = new System.Drawing.Point(146, 131);
            this.txtIdFolder.Multiline = true;
            this.txtIdFolder.Name = "txtIdFolder";
            this.txtIdFolder.Size = new System.Drawing.Size(346, 47);
            this.txtIdFolder.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(146, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "Unisci";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstsPrg,
            this.tsslblMain,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 212);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(518, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "stsMain";
            // 
            // tstsPrg
            // 
            this.tstsPrg.AutoToolTip = true;
            this.tstsPrg.Name = "tstsPrg";
            this.tstsPrg.Size = new System.Drawing.Size(100, 16);
            this.tstsPrg.Step = 1;
            // 
            // tsslblMain
            // 
            this.tsslblMain.Name = "tsslblMain";
            this.tsslblMain.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(8, 101);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(89, 21);
            this.lblMain.TabIndex = 13;
            this.lblMain.Text = "Nickname";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(146, 93);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(192, 32);
            this.txtUserName.TabIndex = 12;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 234);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.conversationCtrl1;
            this.propertyGrid1.Size = new System.Drawing.Size(518, 1111);
            this.propertyGrid1.TabIndex = 11;
            // 
            // conversationCtrl1
            // 
            this.conversationCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conversationCtrl1.BackColor = System.Drawing.Color.Transparent;
            this.conversationCtrl1.BalloonBackColor = System.Drawing.Color.MediumSeaGreen;
            this.conversationCtrl1.BalloonTextPadding = new System.Windows.Forms.Padding(10);
            this.conversationCtrl1.DataSource = null;
            this.conversationCtrl1.DateColumnName = "";
            this.conversationCtrl1.DateTimeRegionHeight = ((uint)(20u));
            this.conversationCtrl1.DateTimeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.conversationCtrl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversationCtrl1.IdColumnName = "";
            this.conversationCtrl1.IsIncomingColumnName = "";
            this.conversationCtrl1.Location = new System.Drawing.Point(17, 78);
            this.conversationCtrl1.Margin = new System.Windows.Forms.Padding(4);
            this.conversationCtrl1.MeBalloonPadding = new System.Windows.Forms.Padding(10, 20, 20, 10);
            this.conversationCtrl1.MeCellPadding = new System.Windows.Forms.Padding(10);
            this.conversationCtrl1.MessageColumnName = "";
            this.conversationCtrl1.MessageToDateTimeVerticalIndent = 10;
            this.conversationCtrl1.MeText = "Me";
            this.conversationCtrl1.MinimalBalloonWidth = 250;
            this.conversationCtrl1.Name = "conversationCtrl1";
            this.conversationCtrl1.PanelDividersBackColor = System.Drawing.Color.Sienna;
            this.conversationCtrl1.RemoteBalloonPadding = new System.Windows.Forms.Padding(20, 20, 10, 10);
            this.conversationCtrl1.RemoteCellPadding = new System.Windows.Forms.Padding(10);
            this.conversationCtrl1.RemoteText = "You";
            this.conversationCtrl1.Size = new System.Drawing.Size(1049, 769);
            this.conversationCtrl1.TabIndex = 10;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConnect.Image = global::WhatsApp_One.Properties.Resources.CCC;
            this.btnConnect.Location = new System.Drawing.Point(344, 93);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(148, 32);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.conversationCtrl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Size = new System.Drawing.Size(1068, 1045);
            this.splitContainer2.SplitterDistance = 858;
            this.splitContainer2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPosizione);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblSecondi);
            this.panel1.Controls.Add(this.btnConferma);
            this.panel1.Controls.Add(this.btnAnnulla);
            this.panel1.Controls.Add(this.btnAudio);
            this.panel1.Controls.Add(this.btnCancellaCronologia);
            this.panel1.Controls.Add(this.btnAllegaFile);
            this.panel1.Controls.Add(this.txtSendMessage);
            this.panel1.Controls.Add(this.btnSendMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 183);
            this.panel1.TabIndex = 10;
            // 
            // btnPosizione
            // 
            this.btnPosizione.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPosizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosizione.Image = global::WhatsApp_One.Properties.Resources.ic_send_Message;
            this.btnPosizione.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosizione.Location = new System.Drawing.Point(0, 125);
            this.btnPosizione.Name = "btnPosizione";
            this.btnPosizione.Size = new System.Drawing.Size(46, 47);
            this.btnPosizione.TabIndex = 19;
            this.btnPosizione.UseVisualStyleBackColor = true;
            this.btnPosizione.Click += new System.EventHandler(this.btnPosizione_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(653, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblSecondi
            // 
            this.lblSecondi.AutoSize = true;
            this.lblSecondi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondi.Location = new System.Drawing.Point(346, 85);
            this.lblSecondi.Name = "lblSecondi";
            this.lblSecondi.Size = new System.Drawing.Size(29, 31);
            this.lblSecondi.TabIndex = 17;
            this.lblSecondi.Text = "0";
            // 
            // btnConferma
            // 
            this.btnConferma.Image = global::WhatsApp_One.Properties.Resources.conferma;
            this.btnConferma.Location = new System.Drawing.Point(420, 72);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(46, 47);
            this.btnConferma.TabIndex = 16;
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Image = global::WhatsApp_One.Properties.Resources.annulla;
            this.btnAnnulla.Location = new System.Drawing.Point(257, 72);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(46, 47);
            this.btnAnnulla.TabIndex = 15;
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.Image = global::WhatsApp_One.Properties.Resources.microphone;
            this.btnAudio.Location = new System.Drawing.Point(205, 72);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(46, 47);
            this.btnAudio.TabIndex = 14;
            this.btnAudio.UseVisualStyleBackColor = true;
            this.btnAudio.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancellaCronologia
            // 
            this.btnCancellaCronologia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancellaCronologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancellaCronologia.Image = global::WhatsApp_One.Properties.Resources.cestino1;
            this.btnCancellaCronologia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancellaCronologia.Location = new System.Drawing.Point(135, 72);
            this.btnCancellaCronologia.Name = "btnCancellaCronologia";
            this.btnCancellaCronologia.Size = new System.Drawing.Size(46, 47);
            this.btnCancellaCronologia.TabIndex = 13;
            this.btnCancellaCronologia.UseVisualStyleBackColor = true;
            this.btnCancellaCronologia.Click += new System.EventHandler(this.btnCancellaCronologia_Click);
            // 
            // btnAllegaFile
            // 
            this.btnAllegaFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllegaFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllegaFile.Image = global::WhatsApp_One.Properties.Resources.attach_file;
            this.btnAllegaFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllegaFile.Location = new System.Drawing.Point(48, 72);
            this.btnAllegaFile.Name = "btnAllegaFile";
            this.btnAllegaFile.Size = new System.Drawing.Size(46, 47);
            this.btnAllegaFile.TabIndex = 12;
            this.btnAllegaFile.UseVisualStyleBackColor = true;
            this.btnAllegaFile.Click += new System.EventHandler(this.btnAllegaFile_Click);
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.AcceptsTab = true;
            this.txtSendMessage.AllowDrop = true;
            this.txtSendMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSendMessage.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSendMessage.Location = new System.Drawing.Point(0, 0);
            this.txtSendMessage.Multiline = true;
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSendMessage.Size = new System.Drawing.Size(1068, 66);
            this.txtSendMessage.TabIndex = 11;
            this.txtSendMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendMessage_KeyDown);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessage.Image = global::WhatsApp_One.Properties.Resources.ic_send_Message;
            this.btnSendMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendMessage.Location = new System.Drawing.Point(0, 72);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(46, 47);
            this.btnSendMessage.TabIndex = 10;
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(62, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "&Send Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1607, 58);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "tlsMain";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(408, 55);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrSecondiRegistrazione
            // 
            this.tmrSecondiRegistrazione.Interval = 1000;
            this.tmrSecondiRegistrazione.Tick += new System.EventHandler(this.tmrSecondiRegistrazione_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1607, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.toolStripMenuItem1.Text = "&Command";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 1045);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lstMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Opacity = 0.95D;
            this.Text = "tate-a-tate ( Chat Apps ).";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ControlsSuite.ConversationCtrl conversationCtrl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button btnAllegaFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tstsPrg;
        private System.Windows.Forms.ToolStripStatusLabel tsslblMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCancellaCronologia;
        private System.Windows.Forms.Button btnAudio;
        private System.Windows.Forms.Label lblSecondi;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Timer tmrSecondiRegistrazione;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPosizione;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdFolder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

