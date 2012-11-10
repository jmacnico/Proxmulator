namespace Proxmulator.Forms
{
    partial class TriggerForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.conditionControl6 = new Proxmulator.Forms.UserControls.ConditionControl();
            this.conditionControl5 = new Proxmulator.Forms.UserControls.ConditionControl();
            this.conditionControl4 = new Proxmulator.Forms.UserControls.ConditionControl();
            this.conditionControl3 = new Proxmulator.Forms.UserControls.ConditionControl();
            this.conditionControl2 = new Proxmulator.Forms.UserControls.ConditionControl();
            this.conditionControl1 = new Proxmulator.Forms.UserControls.ConditionControl();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(636, 242);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Value To Compare";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "XPath in Msg";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(278, 242);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 33;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(635, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Comperer";
            // 
            // conditionControl6
            // 
            this.conditionControl6.Location = new System.Drawing.Point(3, 173);
            this.conditionControl6.Name = "conditionControl6";
            this.conditionControl6.ShowCommonXpath = true;
            this.conditionControl6.Size = new System.Drawing.Size(733, 25);
            this.conditionControl6.TabIndex = 41;
            // 
            // conditionControl5
            // 
            this.conditionControl5.Location = new System.Drawing.Point(2, 152);
            this.conditionControl5.Name = "conditionControl5";
            this.conditionControl5.ShowCommonXpath = true;
            this.conditionControl5.Size = new System.Drawing.Size(733, 25);
            this.conditionControl5.TabIndex = 40;
            // 
            // conditionControl4
            // 
            this.conditionControl4.Location = new System.Drawing.Point(3, 103);
            this.conditionControl4.Name = "conditionControl4";
            this.conditionControl4.ShowCommonXpath = false;
            this.conditionControl4.Size = new System.Drawing.Size(733, 25);
            this.conditionControl4.TabIndex = 39;
            // 
            // conditionControl3
            // 
            this.conditionControl3.Location = new System.Drawing.Point(3, 82);
            this.conditionControl3.Name = "conditionControl3";
            this.conditionControl3.ShowCommonXpath = false;
            this.conditionControl3.Size = new System.Drawing.Size(733, 25);
            this.conditionControl3.TabIndex = 38;
            // 
            // conditionControl2
            // 
            this.conditionControl2.Location = new System.Drawing.Point(3, 61);
            this.conditionControl2.Name = "conditionControl2";
            this.conditionControl2.ShowCommonXpath = false;
            this.conditionControl2.Size = new System.Drawing.Size(733, 25);
            this.conditionControl2.TabIndex = 37;
            // 
            // conditionControl1
            // 
            this.conditionControl1.Location = new System.Drawing.Point(3, 39);
            this.conditionControl1.Name = "conditionControl1";
            this.conditionControl1.ShowCommonXpath = false;
            this.conditionControl1.Size = new System.Drawing.Size(733, 25);
            this.conditionControl1.TabIndex = 36;
            // 
            // TriggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 275);
            this.Controls.Add(this.conditionControl6);
            this.Controls.Add(this.conditionControl5);
            this.Controls.Add(this.conditionControl4);
            this.Controls.Add(this.conditionControl3);
            this.Controls.Add(this.conditionControl2);
            this.Controls.Add(this.conditionControl1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TriggerForm";
            this.ShowInTaskbar = false;
            this.Text = "TriggerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label9;
        private UserControls.ConditionControl conditionControl1;
        private UserControls.ConditionControl conditionControl2;
        private UserControls.ConditionControl conditionControl3;
        private UserControls.ConditionControl conditionControl4;
        private UserControls.ConditionControl conditionControl5;
        private UserControls.ConditionControl conditionControl6;
    }
}