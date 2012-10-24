namespace Proxmulator.Forms
{
    partial class ProjectForm
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
            this.btnLoadMsg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tvMsgs = new System.Windows.Forms.TreeView();
            this.tbReqNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbInterface = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStepTrigger = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStepName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbExportSoapUI = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxConnections = new System.Windows.Forms.ComboBox();
            this.cmsMsg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.cmsMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadMsg
            // 
            this.btnLoadMsg.Location = new System.Drawing.Point(506, 54);
            this.btnLoadMsg.Name = "btnLoadMsg";
            this.btnLoadMsg.Size = new System.Drawing.Size(117, 23);
            this.btnLoadMsg.TabIndex = 0;
            this.btnLoadMsg.Text = "Load Msg from DB";
            this.btnLoadMsg.UseVisualStyleBackColor = true;
            this.btnLoadMsg.Click += new System.EventHandler(this.btnLoadMsg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(53, 24);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(181, 20);
            this.tbName.TabIndex = 2;
            // 
            // tvMsgs
            // 
            this.tvMsgs.AllowDrop = true;
            this.tvMsgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvMsgs.HideSelection = false;
            this.tvMsgs.HotTracking = true;
            this.tvMsgs.Location = new System.Drawing.Point(12, 81);
            this.tvMsgs.Name = "tvMsgs";
            this.tvMsgs.Size = new System.Drawing.Size(263, 439);
            this.tvMsgs.TabIndex = 3;
            this.tvMsgs.Click += new System.EventHandler(this.tvMsgs_DoubleClick);
            this.tvMsgs.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvMsgs_DragDrop);
            this.tvMsgs.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvMsgs_DragEnter);
            this.tvMsgs.DoubleClick += new System.EventHandler(this.tvMsgs_DoubleClick);
            this.tvMsgs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tvMsgs_MouseUp);
            // 
            // tbReqNumber
            // 
            this.tbReqNumber.Location = new System.Drawing.Point(363, 25);
            this.tbReqNumber.Name = "tbReqNumber";
            this.tbReqNumber.Size = new System.Drawing.Size(131, 20);
            this.tbReqNumber.TabIndex = 4;
            this.tbReqNumber.Text = "GRP.12.2002";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Request Number";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(12, 65);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(55, 13);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Messages";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbMsg);
            this.groupBox1.Controls.Add(this.tbInterface);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbStepTrigger);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbStepName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(296, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 427);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Step";
            // 
            // tbInterface
            // 
            this.tbInterface.Location = new System.Drawing.Point(482, 34);
            this.tbInterface.Name = "tbInterface";
            this.tbInterface.Size = new System.Drawing.Size(148, 20);
            this.tbInterface.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Interface";
            // 
            // cbStepTrigger
            // 
            this.cbStepTrigger.FormattingEnabled = true;
            this.cbStepTrigger.Items.AddRange(new object[] {
            "None",
            "Operation"});
            this.cbStepTrigger.Location = new System.Drawing.Point(300, 34);
            this.cbStepTrigger.Name = "cbStepTrigger";
            this.cbStepTrigger.Size = new System.Drawing.Size(121, 21);
            this.cbStepTrigger.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trigger";
            // 
            // tbStepName
            // 
            this.tbStepName.Location = new System.Drawing.Point(85, 35);
            this.tbStepName.Name = "tbStepName";
            this.tbStepName.Size = new System.Drawing.Size(163, 20);
            this.tbStepName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // tbExportSoapUI
            // 
            this.tbExportSoapUI.Location = new System.Drawing.Point(657, 54);
            this.tbExportSoapUI.Name = "tbExportSoapUI";
            this.tbExportSoapUI.Size = new System.Drawing.Size(117, 23);
            this.tbExportSoapUI.TabIndex = 8;
            this.tbExportSoapUI.Text = "Export to SoapUI";
            this.tbExportSoapUI.UseVisualStyleBackColor = true;
            this.tbExportSoapUI.Click += new System.EventHandler(this.tbExportSoapUI_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "Xml File | *.xml";
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(850, 12);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(97, 23);
            this.btnSaveClose.TabIndex = 11;
            this.btnSaveClose.Text = "Save & Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Connection";
            // 
            // cbxConnections
            // 
            this.cbxConnections.FormattingEnabled = true;
            this.cbxConnections.Location = new System.Drawing.Point(573, 25);
            this.cbxConnections.Name = "cbxConnections";
            this.cbxConnections.Size = new System.Drawing.Size(201, 21);
            this.cbxConnections.TabIndex = 13;
            // 
            // cmsMsg
            // 
            this.cmsMsg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmsMsg.Name = "cmsMsg";
            this.cmsMsg.Size = new System.Drawing.Size(106, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tbMsg
            // 
            this.tbMsg.AcceptsReturn = true;
            this.tbMsg.AcceptsTab = true;
            this.tbMsg.AllowDrop = true;
            this.tbMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMsg.Location = new System.Drawing.Point(7, 108);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMsg.Size = new System.Drawing.Size(638, 313);
            this.tbMsg.TabIndex = 9;
            this.tbMsg.WordWrap = false;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 532);
            this.Controls.Add(this.cbxConnections);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.tbExportSoapUI);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbReqNumber);
            this.Controls.Add(this.tvMsgs);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadMsg);
            this.Name = "ProjectForm";
            this.Text = "ProjectForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmsMsg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TreeView tvMsgs;
        private System.Windows.Forms.TextBox tbReqNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStepName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStepTrigger;
        private System.Windows.Forms.Button tbExportSoapUI;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxConnections;
        private System.Windows.Forms.TextBox tbInterface;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip cmsMsg;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox tbMsg;
    }
}