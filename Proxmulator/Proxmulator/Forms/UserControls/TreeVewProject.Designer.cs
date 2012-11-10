namespace Proxmulator.Forms.UserControls
{
    partial class TreeVewProject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tvProject = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmsTVProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.markAsSentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startFromHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cmsTVProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvProject
            // 
            this.tvProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvProject.HideSelection = false;
            this.tvProject.ImageIndex = 0;
            this.tvProject.ImageList = this.imageList1;
            this.tvProject.Location = new System.Drawing.Point(0, 32);
            this.tvProject.Name = "tvProject";
            this.tvProject.SelectedImageIndex = 0;
            this.tvProject.Size = new System.Drawing.Size(252, 469);
            this.tvProject.TabIndex = 4;
            this.tvProject.DoubleClick += new System.EventHandler(this.editMessageToolStripMenuItem_Click);
            this.tvProject.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tvProject_MouseUp);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cmsTVProject
            // 
            this.cmsTVProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToolStripMenuItem,
            this.editMessageToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.markAsSentToolStripMenuItem,
            this.startFromHereToolStripMenuItem});
            this.cmsTVProject.Name = "cmsTVProject";
            this.cmsTVProject.Size = new System.Drawing.Size(149, 104);
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.sendToolStripMenuItem.Text = "Send";
            this.sendToolStripMenuItem.Click += new System.EventHandler(this.sendToolStripMenuItem_Click);
            // 
            // editMessageToolStripMenuItem
            // 
            this.editMessageToolStripMenuItem.Name = "editMessageToolStripMenuItem";
            this.editMessageToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.editMessageToolStripMenuItem.Text = "Edit Message";
            this.editMessageToolStripMenuItem.Click += new System.EventHandler(this.editMessageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // markAsSentToolStripMenuItem
            // 
            this.markAsSentToolStripMenuItem.Name = "markAsSentToolStripMenuItem";
            this.markAsSentToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.markAsSentToolStripMenuItem.Text = "Bypass";
            this.markAsSentToolStripMenuItem.Click += new System.EventHandler(this.markAsSentToolStripMenuItem_Click);
            // 
            // startFromHereToolStripMenuItem
            // 
            this.startFromHereToolStripMenuItem.Name = "startFromHereToolStripMenuItem";
            this.startFromHereToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.startFromHereToolStripMenuItem.Text = "Start from here";
            this.startFromHereToolStripMenuItem.Click += new System.EventHandler(this.startFromHereToolStripMenuItem_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Image = global::Proxmulator.Properties.Resources.document_into;
            this.btnEdit.Location = new System.Drawing.Point(222, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRun.Image = global::Proxmulator.Properties.Resources.media_pause;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(70, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(105, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Pause";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Image = global::Proxmulator.Properties.Resources.folders;
            this.btnLoad.Location = new System.Drawing.Point(0, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(36, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // TreeVewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tvProject);
            this.Name = "TreeVewProject";
            this.Size = new System.Drawing.Size(256, 501);
            this.cmsTVProject.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvProject;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ContextMenuStrip cmsTVProject;
        private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAsSentToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem startFromHereToolStripMenuItem;
    }
}
