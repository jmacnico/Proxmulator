namespace Proxmulator.Forms
{
    partial class ConnectionDB
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
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbSID = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSchema = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.cbxConnections = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(388, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(72, 83);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(247, 20);
            this.tbHost.TabIndex = 1;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(72, 116);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(165, 20);
            this.tbUser.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(316, 116);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(124, 20);
            this.tbPass.TabIndex = 3;
            // 
            // tbSID
            // 
            this.tbSID.Location = new System.Drawing.Point(72, 156);
            this.tbSID.Name = "tbSID";
            this.tbSID.Size = new System.Drawing.Size(165, 20);
            this.tbSID.TabIndex = 4;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(377, 83);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(63, 20);
            this.tbPort.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "SID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Schema";
            // 
            // tbSchema
            // 
            this.tbSchema.Location = new System.Drawing.Point(316, 153);
            this.tbSchema.Name = "tbSchema";
            this.tbSchema.Size = new System.Drawing.Size(124, 20);
            this.tbSchema.TabIndex = 12;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(192, 182);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 13;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTest.Location = new System.Drawing.Point(12, 208);
            this.lblTest.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblTest.MinimumSize = new System.Drawing.Size(350, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(350, 16);
            this.lblTest.TabIndex = 14;
            this.lblTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxConnections
            // 
            this.cbxConnections.DisplayMember = "Name";
            this.cbxConnections.FormattingEnabled = true;
            this.cbxConnections.Location = new System.Drawing.Point(72, 13);
            this.cbxConnections.Name = "cbxConnections";
            this.cbxConnections.Size = new System.Drawing.Size(368, 21);
            this.cbxConnections.TabIndex = 15;
            this.cbxConnections.ValueMember = "Name";
            this.cbxConnections.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Connection";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(72, 53);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(247, 20);
            this.tbName.TabIndex = 18;
            // 
            // ConnectionDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 247);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxConnections);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.tbSchema);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbSID);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionDB";
            this.Text = "ConnectionDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbSID;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSchema;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.ComboBox cbxConnections;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbName;
    }
}