namespace Proxmulator.Forms.UserControls
{
    partial class ReceivedMsgControl
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbxMessages = new System.Windows.Forms.ListBox();
            this.cmsLbxMessages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returnGenericReplyI2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genericReplyErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyNPUToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLbxMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Image = global::Proxmulator.Properties.Resources.bullet_triangle_green;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Listener";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Image = global::Proxmulator.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(223, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(29, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbxMessages
            // 
            this.lbxMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxMessages.BackColor = System.Drawing.Color.AliceBlue;
            this.lbxMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMessages.FormattingEnabled = true;
            this.lbxMessages.Location = new System.Drawing.Point(0, 35);
            this.lbxMessages.Name = "lbxMessages";
            this.lbxMessages.ScrollAlwaysVisible = true;
            this.lbxMessages.Size = new System.Drawing.Size(255, 444);
            this.lbxMessages.TabIndex = 7;
            this.lbxMessages.UseTabStops = false;
            this.lbxMessages.DoubleClick += new System.EventHandler(this.lbxMessages_DoubleClick);
            this.lbxMessages.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbxMessages_MouseDown);
            // 
            // cmsLbxMessages
            // 
            this.cmsLbxMessages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnGenericReplyI2ToolStripMenuItem,
            this.genericReplyErrorToolStripMenuItem,
            this.toolStripSeparator2,
            this.copyNPUToClipboardToolStripMenuItem,
            this.cleanToolStripMenuItem});
            this.cmsLbxMessages.Name = "cmsLbxMessages";
            this.cmsLbxMessages.Size = new System.Drawing.Size(184, 120);
            this.cmsLbxMessages.Text = "Clean";
            // 
            // returnGenericReplyI2ToolStripMenuItem
            // 
            this.returnGenericReplyI2ToolStripMenuItem.Name = "returnGenericReplyI2ToolStripMenuItem";
            this.returnGenericReplyI2ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.returnGenericReplyI2ToolStripMenuItem.Text = "GenericReply I2";
            this.returnGenericReplyI2ToolStripMenuItem.Click += new System.EventHandler(this.returnGenericReplyI2ToolStripMenuItem_Click);
            // 
            // genericReplyErrorToolStripMenuItem
            // 
            this.genericReplyErrorToolStripMenuItem.Name = "genericReplyErrorToolStripMenuItem";
            this.genericReplyErrorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.genericReplyErrorToolStripMenuItem.Text = "GenericReply Error";
            this.genericReplyErrorToolStripMenuItem.Click += new System.EventHandler(this.genericReplyErrorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // copyNPUToClipboardToolStripMenuItem
            // 
            this.copyNPUToClipboardToolStripMenuItem.Name = "copyNPUToClipboardToolStripMenuItem";
            this.copyNPUToClipboardToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.copyNPUToClipboardToolStripMenuItem.Text = "Copy NPU to Clipboard";
            this.copyNPUToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyNPUToClipboardToolStripMenuItem_Click);
            // 
            // cleanToolStripMenuItem
            // 
            this.cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
            this.cleanToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cleanToolStripMenuItem.Text = "Clean";
            this.cleanToolStripMenuItem.Click += new System.EventHandler(this.cleanToolStripMenuItem_Click);
            // 
            // ReceivedMsgControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbxMessages);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "ReceivedMsgControl";
            this.Size = new System.Drawing.Size(255, 479);
            this.cmsLbxMessages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox lbxMessages;
        private System.Windows.Forms.ContextMenuStrip cmsLbxMessages;
        private System.Windows.Forms.ToolStripMenuItem returnGenericReplyI2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genericReplyErrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyNPUToClipboardToolStripMenuItem;
    }
}
