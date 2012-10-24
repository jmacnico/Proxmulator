using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proxmulator.Entities;
using System.IO;
using System.Xml;

namespace Proxmulator.Forms
{
    public partial class DetailsMsg : Form
    {
        private MessageInfo _message;

        public DetailsMsg(MessageInfo msg)
        {
            InitializeComponent();
            _message = msg;
            FillForm();
           
        }


        private void FillForm()
        {
            tbRaw.Text = _message.Payload;
            xmlSend.Text = _message.xml.OuterXml;
        }


    }
}
