namespace Proxmulator.Forms.UserControls
{
    partial class TestStepControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.xmlEditor = new XmlEditor.XMLEditor();
            this.tbOperation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbOnlyOneUse = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.llEdit = new System.Windows.Forms.LinkLabel();
            this.tbInterface = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStepTrigger = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStepName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.xmlEditor);
            this.groupBox1.Controls.Add(this.tbOperation);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbOnlyOneUse);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.llEdit);
            this.groupBox1.Controls.Add(this.tbInterface);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbStepTrigger);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbStepName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 548);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Step";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Image = global::Proxmulator.Properties.Resources.save_as;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(282, 516);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 26);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // xmlEditor
            // 
            this.xmlEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xmlEditor.Location = new System.Drawing.Point(6, 88);
            this.xmlEditor.Name = "xmlEditor";
            this.xmlEditor.Size = new System.Drawing.Size(694, 422);
            this.xmlEditor.TabIndex = 15;
            // 
            // tbOperation
            // 
            this.tbOperation.Location = new System.Drawing.Point(451, 46);
            this.tbOperation.Name = "tbOperation";
            this.tbOperation.Size = new System.Drawing.Size(214, 20);
            this.tbOperation.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Operation";
            // 
            // cbOnlyOneUse
            // 
            this.cbOnlyOneUse.AutoSize = true;
            this.cbOnlyOneUse.Location = new System.Drawing.Point(320, 55);
            this.cbOnlyOneUse.Name = "cbOnlyOneUse";
            this.cbOnlyOneUse.Size = new System.Drawing.Size(15, 14);
            this.cbOnlyOneUse.TabIndex = 12;
            this.cbOnlyOneUse.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Only one use";
            // 
            // llEdit
            // 
            this.llEdit.AutoSize = true;
            this.llEdit.Enabled = false;
            this.llEdit.Location = new System.Drawing.Point(199, 53);
            this.llEdit.Name = "llEdit";
            this.llEdit.Size = new System.Drawing.Size(24, 13);
            this.llEdit.TabIndex = 10;
            this.llEdit.TabStop = true;
            this.llEdit.Text = "edit";
            this.llEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llEdit_LinkClicked);
            // 
            // tbInterface
            // 
            this.tbInterface.Location = new System.Drawing.Point(451, 19);
            this.tbInterface.Name = "tbInterface";
            this.tbInterface.Size = new System.Drawing.Size(214, 20);
            this.tbInterface.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 26);
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
            "Operation",
            "Custom"});
            this.cbStepTrigger.Location = new System.Drawing.Point(52, 48);
            this.cbStepTrigger.Name = "cbStepTrigger";
            this.cbStepTrigger.Size = new System.Drawing.Size(141, 21);
            this.cbStepTrigger.TabIndex = 6;
            this.cbStepTrigger.SelectedIndexChanged += new System.EventHandler(this.cbStepTrigger_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trigger";
            // 
            // tbStepName
            // 
            this.tbStepName.Location = new System.Drawing.Point(51, 22);
            this.tbStepName.Name = "tbStepName";
            this.tbStepName.Size = new System.Drawing.Size(142, 20);
            this.tbStepName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // TestStepControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "TestStepControl";
            this.Size = new System.Drawing.Size(706, 548);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private XmlEditor.XMLEditor xmlEditor;
        private System.Windows.Forms.TextBox tbOperation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbOnlyOneUse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel llEdit;
        private System.Windows.Forms.TextBox tbInterface;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStepTrigger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStepName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
    }
}
