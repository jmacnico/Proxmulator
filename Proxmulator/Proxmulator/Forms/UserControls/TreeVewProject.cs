using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proxmulator.Extras;
using Proxmulator.Entities;
using Proxmulator.Core;

namespace Proxmulator.Forms.UserControls
{
    public partial class TreeVewProject : UserControl
    {
        public event EventHandler StartProject;
        public event EventHandler StopProject;
        public event EventHandler EditProject;
        public event EventHandler MsgSent;

        private bool _running = true;

        private ProjectInstance _projInstance;
     
        
        public TreeVewProject()
        {
            InitializeComponent();
            LoadImages();
        }

        private void LoadImages()
        {
            imageList1.Images.Add(Image.FromStream(Utils.GetResourceImage("bullet_ball_blue.png")));
            imageList1.Images.Add(Image.FromStream(Utils.GetResourceImage("bullet_ball_green.png")));
            imageList1.Images.Add(Image.FromStream(Utils.GetResourceImage("bullet_ball_red.png")));
            imageList1.Images.Add(Image.FromStream(Utils.GetResourceImage("component_green.png")));
            imageList1.Images.Add(Image.FromStream(Utils.GetResourceImage("bullet_ball_yellow.png")));
        }

        private void OnMsgSent(MessageSent msg)
        {
            _projInstance.MessagesSent.Add(msg);

            if (MsgSent != null)
            {
                this.MsgSent(msg, null);
            }
            
            UpdateProjectTree();
        }


        public void UpdateStep()
        {
            UpdateProjectTree();
        }

        public void LoadProject(ProjectInstance proj)
        {
            _projInstance = proj;
            _projInstance.Active = true;
            btnEdit.Enabled = true;
            btnRun.Enabled = true;
            UpdateProjectTree();
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (_running)
            {
                btnRun.Text = "Run";
                btnRun.Image = global::Proxmulator.Properties.Resources.bullet_triangle_green;
                _running = false;

                if (StopProject != null)
                    this.StopProject(this, e);

                _projInstance.Active = false;
            }
            else
            {
                btnRun.Image = global::Proxmulator.Properties.Resources.media_pause;
                btnRun.Text = "Pause";
                _running = true;
                _projInstance.Active = true;

                if (StartProject != null)
                {
                    this.StartProject(this, e);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (EditProject != null)
            {
                this.EditProject(sender, e);
            }
        }

        private void editMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editMessageSent();
        }

        private void tvProject_DoubleClick(object sender, EventArgs e)
        {
            editMessageSent();
        }

        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = sender as MsgSentForm;

            if (form.MsgSent != null)
            {
                OnMsgSent(form.MsgSent);
            }
        }

        private void editMessageSent()
        {
            var item = tvProject.SelectedNode;

            if (item != null)
            {
                var step = item.Tag as TestStep;

                MsgSentForm form = null;

                if (step != null)
                {
                    var url = CommunicationWS.GetUrl(step.Message.InterfaceToInvoke);
                    step.UrlResponse = url;

                    form = new MsgSentForm(step, step.UrlResponse);
                    form.FormClosed += new FormClosedEventHandler(form_FormClosed);
                    form.Show();
                }
                else
                {
                    var sent = item.Tag as MessageSent;

                    if (sent != null)
                    {
                        form = new MsgSentForm(sent);
                        form.ShowDialog();
                    }
                }

            }

        }

        private void SendMessage(TestStep msg)
        {
            if (msg != null)
            {
                var result = Messaging.SendMsg(msg.Message);
                msg.Sent = true;

                OnMsgSent(result);

                if (result.Status != MessageStatusEnum.OK)
                {
                    Logger.Log("Erro sending msg! " + result.Received);
                    MessageBox.Show("Error: " + result.Received);
                }
            }
        }

        private void tvProject_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                tvProject.SelectedNode = tvProject.GetNodeAt(e.X, e.Y);

                if (tvProject.SelectedNode != null)
                {
                    cmsTVProject.Show(tvProject, e.Location);
                }
            }
        }

        private void markAsSentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = tvProject.SelectedNode;

            if (item != null)
            {
                var step = item.Tag as TestStep;

                if (step != null)
                {
                    if (step.Sent == true)
                    {
                        step.Sent = false;
                    }
                    else
                    {
                        step.Sent = true;
                    }

                    UpdateProjectTree();
                }
            }
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = tvProject.SelectedNode;

            if (item != null)
            {

                var msg = item.Tag as TestStep;

                SendMessage(msg);
            }

        }

        private void startFromHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = tvProject.SelectedNode;

            if (item != null)
            {
                var step = item.Tag as TestStep;


                var index = _projInstance.Project.Steps.IndexOf(step);

                for (int i = 0; i < index; i++)
                {
                    _projInstance.Project.Steps[i].Sent = true;
                }

                UpdateProjectTree();


            }
        }

        private void UpdateProjectTree()
        {
            tvProject.Nodes.Clear();

            if (_projInstance == null)
                return;

            var rootNode = new TreeNode(_projInstance.Project.Name);
            rootNode.ImageIndex = 3;
            rootNode.SelectedImageIndex = 3;

            foreach (var step in _projInstance.Project.Steps)
            {
                var n = new TreeNode(step.Message.Name);
                n.Tag = step;
                n.ImageIndex = 0;
                n.SelectedImageIndex = 0;
                rootNode.Nodes.Add(n);

                var responses = _projInstance.MessagesSent.Where(m => m.Msg.NPU == step.Message.NPU);

                foreach (var r in responses)
                {
                    var nResponse = new TreeNode("Response [" + r.Date.ToString("hh24:MM:sss") + "]");
                    nResponse.Tag = r;

                    if (r.Status == MessageStatusEnum.OK)
                    {
                        nResponse.ImageIndex = 1;
                        nResponse.SelectedImageIndex = 1;
                        n.ImageIndex = 1;
                        n.SelectedImageIndex = 1;
                    }
                    else
                    {
                        nResponse.ImageIndex = 2;
                        nResponse.SelectedImageIndex = 2;
                        n.ImageIndex = 2;
                        n.SelectedImageIndex = 2;
                    }

                    n.Nodes.Add(nResponse);
                }

                if (responses.Count() == 0 && step.Sent)
                {
                    n.ImageIndex = 4;
                    n.SelectedImageIndex = 4;
                }
            }

            tvProject.Nodes.Add(rootNode);
            rootNode.Expand();
        }
    }
}
