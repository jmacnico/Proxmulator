namespace Proxmulator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbxMessages = new System.Windows.Forms.ListBox();
            this.tvProject = new System.Windows.Forms.TreeView();
            this.cmsTVProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmsLbxMessages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returnGenericReplyI2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genericReplyErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAsSentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.cmsTVProject.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.cmsLbxMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(480, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 20);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "PTSI";
            this.notifyIcon1.BalloonTipTitle = "Proxmulator";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Proxmulator";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProjectToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripSeparator3,
            this.runToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // createProjectToolStripMenuItem
            // 
            this.createProjectToolStripMenuItem.Name = "createProjectToolStripMenuItem";
            this.createProjectToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.createProjectToolStripMenuItem.Text = "Create Project";
            this.createProjectToolStripMenuItem.Click += new System.EventHandler(this.createProjectToolStripMenuItem_Click_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusBar,
            this.toolStripProgressBar1});
            this.statusBar.Location = new System.Drawing.Point(0, 562);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(775, 22);
            this.statusBar.TabIndex = 7;
            this.statusBar.Text = "statusStrip1";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.AutoSize = false;
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(500, 17);
            this.lblStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 16);
            this.toolStripProgressBar1.Step = 20;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.tvProject);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(775, 538);
            this.splitContainer1.SplitterDistance = 505;
            this.splitContainer1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.lbxMessages, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(213, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.189621F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.81038F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 501);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lbxMessages
            // 
            this.lbxMessages.BackColor = System.Drawing.Color.AliceBlue;
            this.lbxMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMessages.FormattingEnabled = true;
            this.lbxMessages.Location = new System.Drawing.Point(361, 29);
            this.lbxMessages.Name = "lbxMessages";
            this.lbxMessages.Size = new System.Drawing.Size(194, 469);
            this.lbxMessages.TabIndex = 2;
            this.lbxMessages.DoubleClick += new System.EventHandler(this.lbxMessages_DoubleClick);
            this.lbxMessages.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbxMessages_MouseDown);
            // 
            // tvProject
            // 
            this.tvProject.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvProject.HideSelection = false;
            this.tvProject.ImageIndex = 0;
            this.tvProject.ImageList = this.imageList1;
            this.tvProject.Location = new System.Drawing.Point(0, 0);
            this.tvProject.Name = "tvProject";
            this.tvProject.SelectedImageIndex = 0;
            this.tvProject.Size = new System.Drawing.Size(213, 501);
            this.tvProject.TabIndex = 3;
            this.tvProject.DoubleClick += new System.EventHandler(this.tvProject_DoubleClick);
            this.tvProject.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tvProject_MouseUp);
            // 
            // cmsTVProject
            // 
            this.cmsTVProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToolStripMenuItem,
            this.editMessageToolStripMenuItem,
            this.markAsSentToolStripMenuItem});
            this.cmsTVProject.Name = "cmsTVProject";
            this.cmsTVProject.Size = new System.Drawing.Size(138, 70);
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sendToolStripMenuItem.Text = "Send";
            this.sendToolStripMenuItem.Click += new System.EventHandler(this.sendToolStripMenuItem_Click);
            // 
            // editMessageToolStripMenuItem
            // 
            this.editMessageToolStripMenuItem.Name = "editMessageToolStripMenuItem";
            this.editMessageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editMessageToolStripMenuItem.Text = "Edit Message";
            this.editMessageToolStripMenuItem.Click += new System.EventHandler(this.editMessageToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 25);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DoubleClick += new System.EventHandler(this.tabControl1_DoubleClick);
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.tbLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(763, 0);
            this.tabLog.TabIndex = 0;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.HideSelection = false;
            this.tbLog.Location = new System.Drawing.Point(3, 3);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(757, 0);
            this.tbLog.TabIndex = 0;
            this.tbLog.TabStop = false;
            this.tbLog.WordWrap = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmsLbxMessages
            // 
            this.cmsLbxMessages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnGenericReplyI2ToolStripMenuItem,
            this.genericReplyErrorToolStripMenuItem,
            this.toolStripSeparator2,
            this.cleanToolStripMenuItem});
            this.cmsLbxMessages.Name = "cmsLbxMessages";
            this.cmsLbxMessages.Size = new System.Drawing.Size(165, 76);
            this.cmsLbxMessages.Text = "Clean";
            // 
            // returnGenericReplyI2ToolStripMenuItem
            // 
            this.returnGenericReplyI2ToolStripMenuItem.Name = "returnGenericReplyI2ToolStripMenuItem";
            this.returnGenericReplyI2ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.returnGenericReplyI2ToolStripMenuItem.Text = "GenericReply I2";
            this.returnGenericReplyI2ToolStripMenuItem.Click += new System.EventHandler(this.returnGenericReplyI2ToolStripMenuItem_Click);
            // 
            // genericReplyErrorToolStripMenuItem
            // 
            this.genericReplyErrorToolStripMenuItem.Name = "genericReplyErrorToolStripMenuItem";
            this.genericReplyErrorToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.genericReplyErrorToolStripMenuItem.Text = "GenericReply Error";
            this.genericReplyErrorToolStripMenuItem.Click += new System.EventHandler(this.genericReplyErrorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // cleanToolStripMenuItem
            // 
            this.cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
            this.cleanToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cleanToolStripMenuItem.Text = "Clean";
            this.cleanToolStripMenuItem.Click += new System.EventHandler(this.cleanToolStripMenuItem_Click);
            // 
            // markAsSentToolStripMenuItem
            // 
            this.markAsSentToolStripMenuItem.Name = "markAsSentToolStripMenuItem";
            this.markAsSentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.markAsSentToolStripMenuItem.Text = "Bypass";
            this.markAsSentToolStripMenuItem.Click += new System.EventHandler(this.markAsSentToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(775, 584);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Proxmulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cmsTVProject.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.cmsLbxMessages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusBar;
        private System.Windows.Forms.ListBox lbxMessages;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ContextMenuStrip cmsLbxMessages;
        private System.Windows.Forms.ToolStripMenuItem cleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TreeView tvProject;
        private System.Windows.Forms.ToolStripMenuItem returnGenericReplyI2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genericReplyErrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip cmsTVProject;
        private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMessageToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem markAsSentToolStripMenuItem;
    }
}