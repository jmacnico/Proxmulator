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
            this.tbExportSoapUI = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxConnections = new System.Windows.Forms.ComboBox();
            this.cmsMsg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createMsgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testStepControl1 = new Proxmulator.Forms.UserControls.TestStepControl();
            this.cmsMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadMsg
            // 
            this.btnLoadMsg.Location = new System.Drawing.Point(333, 55);
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
            this.tvMsgs.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvMsgs_ItemDrag);
            this.tvMsgs.Click += new System.EventHandler(this.tvMsgs_DoubleClick);
            this.tvMsgs.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvMsgs_DragDrop);
            this.tvMsgs.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvMsgs_DragEnter);
            this.tvMsgs.DoubleClick += new System.EventHandler(this.tvMsgs_DoubleClick);
            this.tvMsgs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvMsgs_MouseUp);
            // 
            // tbReqNumber
            // 
            this.tbReqNumber.Location = new System.Drawing.Point(333, 25);
            this.tbReqNumber.Name = "tbReqNumber";
            this.tbReqNumber.Size = new System.Drawing.Size(131, 20);
            this.tbReqNumber.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 31);
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
            // tbExportSoapUI
            // 
            this.tbExportSoapUI.Location = new System.Drawing.Point(456, 55);
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
            this.btnSaveClose.Location = new System.Drawing.Point(884, 21);
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
            this.label7.Location = new System.Drawing.Point(482, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Connection";
            // 
            // cbxConnections
            // 
            this.cbxConnections.FormattingEnabled = true;
            this.cbxConnections.Location = new System.Drawing.Point(552, 24);
            this.cbxConnections.Name = "cbxConnections";
            this.cbxConnections.Size = new System.Drawing.Size(201, 21);
            this.cbxConnections.TabIndex = 13;
            // 
            // cmsMsg
            // 
            this.cmsMsg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMsgToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsMsg.Name = "cmsMsg";
            this.cmsMsg.Size = new System.Drawing.Size(130, 48);
            // 
            // createMsgToolStripMenuItem
            // 
            this.createMsgToolStripMenuItem.Name = "createMsgToolStripMenuItem";
            this.createMsgToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.createMsgToolStripMenuItem.Text = "Create Msg";
            this.createMsgToolStripMenuItem.Click += new System.EventHandler(this.createMsgToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // testStepControl1
            // 
            this.testStepControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testStepControl1.Location = new System.Drawing.Point(297, 84);
            this.testStepControl1.Name = "testStepControl1";
            this.testStepControl1.Size = new System.Drawing.Size(694, 436);
            this.testStepControl1.TabIndex = 14;
            this.testStepControl1.Save += new System.EventHandler(this.testStepControl1_Save);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 532);
            this.Controls.Add(this.testStepControl1);
            this.Controls.Add(this.cbxConnections);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbExportSoapUI);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbReqNumber);
            this.Controls.Add(this.tvMsgs);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadMsg);
            this.Name = "ProjectForm";
            this.Text = "ProjectForm";
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
        private System.Windows.Forms.Button tbExportSoapUI;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxConnections;
        private System.Windows.Forms.ContextMenuStrip cmsMsg;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMsgToolStripMenuItem;
        private UserControls.TestStepControl testStepControl1;
    }
}