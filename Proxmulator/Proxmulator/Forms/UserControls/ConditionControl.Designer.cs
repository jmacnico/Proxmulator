namespace Proxmulator.Forms.UserControls
{
    partial class ConditionControl
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
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.tbXpath1 = new System.Windows.Forms.TextBox();
            this.tbValue1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cbCommon = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // combo1
            // 
            this.combo1.FormattingEnabled = true;
            this.combo1.Items.AddRange(new object[] {
            "EQUAL",
            "LIKE"});
            this.combo1.Location = new System.Drawing.Point(626, 2);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(93, 21);
            this.combo1.TabIndex = 39;
            // 
            // tbXpath1
            // 
            this.tbXpath1.Location = new System.Drawing.Point(313, 2);
            this.tbXpath1.Name = "tbXpath1";
            this.tbXpath1.Size = new System.Drawing.Size(296, 20);
            this.tbXpath1.TabIndex = 38;
            // 
            // tbValue1
            // 
            this.tbValue1.Location = new System.Drawing.Point(99, 2);
            this.tbValue1.Name = "tbValue1";
            this.tbValue1.Size = new System.Drawing.Size(192, 20);
            this.tbValue1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Cond ";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(67, 6);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(15, 14);
            this.cb1.TabIndex = 35;
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cbCommon
            // 
            this.cbCommon.FormattingEnabled = true;
            this.cbCommon.Location = new System.Drawing.Point(313, 2);
            this.cbCommon.Name = "cbCommon";
            this.cbCommon.Size = new System.Drawing.Size(296, 21);
            this.cbCommon.TabIndex = 40;
            this.cbCommon.Visible = false;
            // 
            // ConditionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.combo1);
            this.Controls.Add(this.tbXpath1);
            this.Controls.Add(this.tbValue1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.cbCommon);
            this.Name = "ConditionControl";
            this.Size = new System.Drawing.Size(721, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.TextBox tbXpath1;
        private System.Windows.Forms.TextBox tbValue1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.ComboBox cbCommon;
    }
}
