using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proxmulator.Entities;
using Proxmulator.Core;

namespace Proxmulator.Forms.UserControls
{
    public partial class ReceivedMsgControl : UserControl
    {
        public event EventHandler StartClick;
        public event EventHandler StopClick;
        public event EventHandler NewStatusBarMsg;


        public ReceivedMsgControl()
        {
            InitializeComponent();
            lbxMessages.DisplayMember = "Name";
            lbxMessages.ValueMember = "NPU";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (StartClick != null)
            {
                this.StartClick(sender, e);
                this.btnStop.Enabled = true;
                this.btnStart.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (StopClick != null)
            {
                this.StopClick(sender, e);
                this.btnStop.Enabled = false;
                this.btnStart.Enabled = true;
            }
        }


        private void cleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbxMessages.Items.Clear();
        }

        private void lbxMessages_DoubleClick(object sender, EventArgs e)
        {
            var item = lbxMessages.SelectedItem as MessageInfo;

            if (item != null)
            {
                var f = new DetailsMsg(item);
                f.Show();
            }
        }


        private void lbxMessages_MouseDown(object sender, MouseEventArgs e)
        {
            var index = lbxMessages.IndexFromPoint(e.X, e.Y);

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                Point pt = lbxMessages.PointToScreen(e.Location);
                cmsLbxMessages.Show(pt);

                if (index != -1)
                {
                    cmsLbxMessages.Tag = lbxMessages.Items[index] as MessageInfo;
                    returnGenericReplyI2ToolStripMenuItem.Enabled = true;
                    genericReplyErrorToolStripMenuItem.Enabled = true;
                }
                else
                {
                    returnGenericReplyI2ToolStripMenuItem.Enabled = false;
                    genericReplyErrorToolStripMenuItem.Enabled = false;
                }

            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Middle)
            {

                if (index != -1)
                {
                    var msg = lbxMessages.Items[index] as MessageInfo;
                    lbxMessages.SelectedIndex = index;
                    Clipboard.SetText(msg.NPU);

                    if (NewStatusBarMsg != null)
                    {
                        this.NewStatusBarMsg("NPU copy to clipboard", null);
                    }
                }
            }

        }


        private void returnGenericReplyI2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void genericReplyErrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msg = cmsLbxMessages.Tag as MessageInfo;

            if (msg != null)
            {
                try
                {
                    var result = Messaging.ReplyGPError(msg);

                    if (result.Status != MessageStatusEnum.OK)
                    {
                        MessageBox.Show("Fail: " + result.Received);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    Logger.Exception(ex, "Sending E0");

                }
            }
        }

        public void AddMessage(MessageInfo msg)
        {
            lbxMessages.Items.Add(msg);
            lbxMessages.SelectedIndex = lbxMessages.Items.Count - 1;
        }

        private void copyNPUToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msg = cmsLbxMessages.Tag as MessageInfo;

            if (msg != null)
            {
                Clipboard.SetText(msg.NPU);
                if (NewStatusBarMsg != null)
                {
                    this.NewStatusBarMsg("NPU copy to clipboard", null);
                }
            }
        }

    }
}
