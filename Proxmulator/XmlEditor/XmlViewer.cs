using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XmlEditor
{
    public partial class XmlViewer : UserControl
    {
        public XmlViewer()
        {
            InitializeComponent();
            txtEditor.SetHighlighting("XML");

        }


        public string Text
        {
            get
            {
                return txtEditor.Text;
            }
            set
            {
                txtEditor.Text = value;
            }
        }

    }
}
