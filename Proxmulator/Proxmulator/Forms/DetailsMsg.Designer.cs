namespace Proxmulator.Forms
{
    partial class DetailsMsg
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
            this.xmlSend = new XmlEditor.XmlViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbRaw = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 573);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.xmlSend);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Xml";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // xmlSend
            // 
            this.xmlSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlSend.Location = new System.Drawing.Point(3, 3);
            this.xmlSend.Name = "xmlSend";
            this.xmlSend.Size = new System.Drawing.Size(978, 541);
            this.xmlSend.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbRaw);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Raw";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbRaw
            // 
            this.tbRaw.BackColor = System.Drawing.Color.White;
            this.tbRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRaw.Location = new System.Drawing.Point(3, 3);
            this.tbRaw.Multiline = true;
            this.tbRaw.Name = "tbRaw";
            this.tbRaw.ReadOnly = true;
            this.tbRaw.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbRaw.Size = new System.Drawing.Size(978, 541);
            this.tbRaw.TabIndex = 0;
            // 
            // DetailsMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 573);
            this.Controls.Add(this.tabControl1);
            this.Name = "DetailsMsg";
            this.Text = "DetailsMsg";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbRaw;
        private XmlEditor.XmlViewer xmlSend;
    }
}