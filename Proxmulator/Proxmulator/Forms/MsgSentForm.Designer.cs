namespace Proxmulator.Forms
{
    partial class MsgSentForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.xmlSent = new XmlEditor();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.xmlReceived = new XmlEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxNpu = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.xmlSent);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(961, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sent";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // xmlSent
            // 
            this.xmlSent.AllowXmlFormatting = false;
            this.xmlSent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlSent.Location = new System.Drawing.Point(3, 3);
            this.xmlSent.Name = "xmlSent";
            this.xmlSent.ReadOnly = false;
            this.xmlSent.Size = new System.Drawing.Size(955, 443);
            this.xmlSent.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.xmlReceived);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(961, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Received";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // xmlReceived
            // 
            this.xmlReceived.AllowXmlFormatting = false;
            this.xmlReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlReceived.Location = new System.Drawing.Point(3, 3);
            this.xmlReceived.Name = "xmlReceived";
            this.xmlReceived.ReadOnly = false;
            this.xmlReceived.Size = new System.Drawing.Size(955, 443);
            this.xmlReceived.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(66, 6);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(620, 20);
            this.tbUrl.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(692, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(91, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Generate NPU:";
            // 
            // cbxNpu
            // 
            this.cbxNpu.AutoSize = true;
            this.cbxNpu.Checked = true;
            this.cbxNpu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxNpu.Location = new System.Drawing.Point(884, 8);
            this.cbxNpu.Name = "cbxNpu";
            this.cbxNpu.Size = new System.Drawing.Size(15, 14);
            this.cbxNpu.TabIndex = 5;
            this.cbxNpu.UseVisualStyleBackColor = true;
            // 
            // MsgSentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 510);
            this.Controls.Add(this.cbxNpu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MsgSentForm";
            this.Text = "Message Sent";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxNpu;
        private XmlEditor xmlSent;
        private XmlEditor xmlReceived;
    }
}