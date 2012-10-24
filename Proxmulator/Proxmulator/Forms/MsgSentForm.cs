using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proxmulator.Entities;
using Proxmulator.Core;

namespace Proxmulator.Forms
{
    public partial class MsgSentForm : Form
    {
        private TestStep _step;
        public MessageSent MsgSent { get; set; }

        public MsgSentForm(TestStep  testStep, string url)
        {
            InitializeComponent();
            _step = testStep;

            LoadSend();
            tbUrl.Text = url;
        }


        public MsgSentForm(MessageSent sent)
        {
            InitializeComponent();
            MsgSent = sent;
            btnSend.Enabled = false;
            xmlSent.Text = Utils.PrettyPrint(sent.Send);
            xmlReceived.Text = Utils.PrettyPrint(sent.Received);
        }


        private void LoadSend()
        {
            xmlSent.Text = Utils.PrettyPrint(_step.Message.Payload);
           
            this.Text = _step.Name;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            _step.Message.Payload = Utils.PrettyPrint(xmlSent.Text);
            _step.Sent = true;

            if (cbxNpu.Checked)
            {
                var newNpu = Messaging.createNpu(_step.Message.Operation);

                var n = Utils.SelectNode(_step.Message.xml, "npu");
                n.InnerText = newNpu;

                _step.Message.Payload = _step.Message.xml.OuterXml;
                xmlSent.Text = Utils.PrettyPrint(_step.Message.Payload);
            }


            var msgSent = Messaging.SendMsg(_step.Message, tbUrl.Text);

            MsgSent = msgSent;
            xmlReceived.Text = Utils.PrettyPrint(msgSent.Received);

            tabControl1.SelectedIndex = 1;

        }

       
    }
}
