namespace Proxmulator.Forms
{
    partial class Preferences
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
            this.btSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.MaskedTextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btnDBConnection = new System.Windows.Forms.Button();
            this.tbIgonerOper = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpGeral = new System.Windows.Forms.TabPage();
            this.tbChunks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrettyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgSoapAction = new System.Windows.Forms.DataGridView();
            this.Interface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoapAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgUrls = new System.Windows.Forms.DataGridView();
            this.Url_Interfaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urls_Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tpGeral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoapAction)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrls)).BeginInit();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(887, 477);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url Destination:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Listener Port:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(115, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(371, 20);
            this.tbUrl.TabIndex = 3;
            this.tbUrl.Text = "http://localhost:8080/cwf/services/ptMsgInInt";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(580, 12);
            this.tbPort.Mask = "000000";
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 20);
            this.tbPort.TabIndex = 7;
            this.tbPort.Text = "8888";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(806, 477);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 8;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btnDBConnection
            // 
            this.btnDBConnection.Location = new System.Drawing.Point(839, 10);
            this.btnDBConnection.Name = "btnDBConnection";
            this.btnDBConnection.Size = new System.Drawing.Size(119, 23);
            this.btnDBConnection.TabIndex = 9;
            this.btnDBConnection.Text = "DB Connection";
            this.btnDBConnection.UseVisualStyleBackColor = true;
            this.btnDBConnection.Click += new System.EventHandler(this.btnDBConnection_Click);
            // 
            // tbIgonerOper
            // 
            this.tbIgonerOper.Location = new System.Drawing.Point(115, 49);
            this.tbIgonerOper.Multiline = true;
            this.tbIgonerOper.Name = "tbIgonerOper";
            this.tbIgonerOper.Size = new System.Drawing.Size(710, 70);
            this.tbIgonerOper.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ignore Operations";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpGeral);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 467);
            this.tabControl1.TabIndex = 1;
            // 
            // tpGeral
            // 
            this.tpGeral.Controls.Add(this.tbChunks);
            this.tpGeral.Controls.Add(this.label3);
            this.tpGeral.Controls.Add(this.tbIgonerOper);
            this.tpGeral.Controls.Add(this.btnDBConnection);
            this.tpGeral.Controls.Add(this.label4);
            this.tpGeral.Controls.Add(this.label1);
            this.tpGeral.Controls.Add(this.label2);
            this.tpGeral.Controls.Add(this.tbUrl);
            this.tpGeral.Controls.Add(this.tbPort);
            this.tpGeral.Location = new System.Drawing.Point(4, 22);
            this.tpGeral.Name = "tpGeral";
            this.tpGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeral.Size = new System.Drawing.Size(983, 441);
            this.tpGeral.TabIndex = 3;
            this.tpGeral.Text = "Geral";
            this.tpGeral.UseVisualStyleBackColor = true;
            // 
            // tbChunks
            // 
            this.tbChunks.Location = new System.Drawing.Point(115, 126);
            this.tbChunks.Name = "tbChunks";
            this.tbChunks.Size = new System.Drawing.Size(710, 20);
            this.tbChunks.TabIndex = 13;
            this.tbChunks.Text = "818,78a,6e5,f9c,465";
            this.tbChunks.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ignore Chunks (CSV)";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operations Description";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Operation,
            this.PrettyName});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(977, 435);
            this.dataGridView1.TabIndex = 7;
            // 
            // Operation
            // 
            this.Operation.HeaderText = "Operation/SoapAction";
            this.Operation.Name = "Operation";
            this.Operation.Width = 300;
            // 
            // PrettyName
            // 
            this.PrettyName.HeaderText = "PrettyName";
            this.PrettyName.Name = "PrettyName";
            this.PrettyName.Width = 400;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgSoapAction);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Soap Actions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgSoapAction
            // 
            this.dgSoapAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoapAction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Interface,
            this.Oper,
            this.SoapAction});
            this.dgSoapAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSoapAction.Location = new System.Drawing.Point(3, 3);
            this.dgSoapAction.Name = "dgSoapAction";
            this.dgSoapAction.Size = new System.Drawing.Size(977, 435);
            this.dgSoapAction.TabIndex = 0;
            // 
            // Interface
            // 
            this.Interface.HeaderText = "Interface";
            this.Interface.Name = "Interface";
            this.Interface.Width = 300;
            // 
            // Oper
            // 
            this.Oper.HeaderText = "Operation";
            this.Oper.Name = "Oper";
            this.Oper.Width = 150;
            // 
            // SoapAction
            // 
            this.SoapAction.HeaderText = "SoapAction";
            this.SoapAction.Name = "SoapAction";
            this.SoapAction.Width = 500;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgUrls);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(983, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Urls";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgUrls
            // 
            this.dgUrls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUrls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Url_Interfaces,
            this.Urls_Url});
            this.dgUrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUrls.Location = new System.Drawing.Point(0, 0);
            this.dgUrls.Name = "dgUrls";
            this.dgUrls.Size = new System.Drawing.Size(983, 441);
            this.dgUrls.TabIndex = 0;
            // 
            // Url_Interfaces
            // 
            this.Url_Interfaces.HeaderText = "Interface";
            this.Url_Interfaces.Name = "Url_Interfaces";
            this.Url_Interfaces.Width = 300;
            // 
            // Urls_Url
            // 
            this.Urls_Url.HeaderText = "Url";
            this.Urls_Url.Name = "Urls_Url";
            this.Urls_Url.Width = 500;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 505);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.tabControl1.ResumeLayout(false);
            this.tpGeral.ResumeLayout(false);
            this.tpGeral.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSoapAction)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUrls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.MaskedTextBox tbPort;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btnDBConnection;
        private System.Windows.Forms.TextBox tbIgonerOper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrettyName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgSoapAction;
        private System.Windows.Forms.DataGridView dgUrls;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url_Interfaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urls_Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interface;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oper;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoapAction;
        private System.Windows.Forms.TabPage tpGeral;
        private System.Windows.Forms.TextBox tbChunks;
        private System.Windows.Forms.Label label3;
    }
}