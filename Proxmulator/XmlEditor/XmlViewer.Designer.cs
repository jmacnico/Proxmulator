namespace XmlEditor
{
    partial class XmlViewer
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
            this.txtEditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.SuspendLayout();
            // 
            // txtEditor
            // 
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.IndentStyle = ICSharpCode.TextEditor.Document.IndentStyle.Auto;
            this.txtEditor.IsIconBarVisible = false;
            this.txtEditor.Location = new System.Drawing.Point(0, 0);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ShowEOLMarkers = true;
            this.txtEditor.ShowInvalidLines = false;
            this.txtEditor.ShowMatchingBracket = false;
            this.txtEditor.ShowTabs = true;
            this.txtEditor.ShowVRuler = true;
            this.txtEditor.Size = new System.Drawing.Size(441, 379);
            this.txtEditor.TabIndex = 0;
            // 
            // XmlViewer
            // 
            this.Controls.Add(this.txtEditor);
            this.Name = "XmlViewer";
            this.Size = new System.Drawing.Size(441, 379);
            this.ResumeLayout(false);

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl txtEditor;
    }
}
