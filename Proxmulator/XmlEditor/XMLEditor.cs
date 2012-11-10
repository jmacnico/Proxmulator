using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XmlEditor
{
    public partial class XMLEditor : UserControl
    {
        public event EventHandler TextChange;

        public XMLEditor()
        {
            InitializeComponent();
        }


        public string Text
        {
            get { return scintilla1.Text; }
            set { scintilla1.Text = value; }

        }

        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            if (this.TextChange != null)
            {
                this.TextChange(sender, e);
            }
        }





    }
}
