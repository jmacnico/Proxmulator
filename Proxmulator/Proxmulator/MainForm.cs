using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Xml;
using Proxmulator.Core;
using Proxmulator.Entities;
using Proxmulator.Forms;
using System.Windows.Forms;

namespace Proxmulator
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        delegate void OnLogChangedCallback(string text);
        delegate void OnAddMessage(MessageInfo msg);
        delegate void OnUpdateStep(TestStep step);

        private bool _running = false;
        private Listener _listener = null;

        private List<MessageInfo> _message;
        private ProjectInstance _currentProject;

        public ProjectInstance ProjectInstance { get { return _currentProject; } }



        public MainForm()
        {
            InitializeComponent();

            Configuration.Load();
            LoadProjects();

            _listener = new Listener(this);
            _message = new List<MessageInfo>();

            lbxMessages.DisplayMember = "Name";
            lbxMessages.ValueMember = "NPU";

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

        private void OnLogChanged(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.tbLog.InvokeRequired)
            {
                OnLogChangedCallback d = new OnLogChangedCallback(OnLogChanged);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (text != this.tbLog.Text)
                {
                    this.tbLog.Text = text;
                    tbLog.SelectionStart = tbLog.Text.Length;
                    tbLog.ScrollToCaret();
                }
            }
        }


        public void AddMessage(MessageInfo msg)
        {
            if (this.lbxMessages.InvokeRequired)
            {
                var a = new OnAddMessage(AddMessage);
                this.Invoke(a, new object[] { msg });
            }
            else
            {
                if (_currentProject != null)
                {
                    _currentProject.Received.Add(msg);
                }

                lbxMessages.Items.Add(msg);
                lbxMessages.SelectedIndex = lbxMessages.Items.Count - 1;
            }

        }


        public void UpdateStep(TestStep step)
        {
            if (this.tvProject.InvokeRequired)
            {
                var a = new OnUpdateStep(UpdateStep);
                this.Invoke(a, new object[] { step });
            }
            else
            {
                if(_currentProject != null){
                    UpdateProjectTree();
                }
            }
        }


        private void LoadProjects()
        {
            projectsToolStripMenuItem.DropDownItems.Clear();

            var path = Project.GetProjectDirectory();
            var files = Directory.GetFiles(path, "*.xml");

            foreach (var f in files)
            {

                var item = new ToolStripMenuItem();
                item.Click += new EventHandler(item_Click);
                item.Text = Path.GetFileNameWithoutExtension(f);

                projectsToolStripMenuItem.DropDownItems.Add(item);
            }

        }

        void item_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            var path = Project.GetProjectDirectory();

            var file = Directory.GetFiles(path, item.Text + ".xml");

            LoadProject(file[0]);

        }


        private void LoadProject(string path)
        {
            var proj = Project.Load(path);
            _currentProject = new ProjectInstance(proj);


            editToolStripMenuItem.Enabled = true;

            UpdateProjectTree();
        }


        private void UpdateProjectTree()
        {
            tvProject.Nodes.Clear();

            var rootNode = new TreeNode(_currentProject.Project.Name);
            rootNode.ImageIndex = 3;
            rootNode.SelectedImageIndex = 3;

            foreach (var step in _currentProject.Project.Steps)
            {
                var n = new TreeNode(step.Message.Name);
                n.Tag = step;
                n.ImageIndex = 0;
                n.SelectedImageIndex = 0;
                rootNode.Nodes.Add(n);

                var responses = _currentProject.MessagesSent.FirstOrDefault(m => m.Msg.NPU == step.Message.NPU);

                if (responses != null)
                {
                    var nResponse = new TreeNode("Response");
                    nResponse.Tag = responses;

                    if (responses.Status == MessageStatusEnum.OK)
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
                else if(step.Sent)
                {
                    n.ImageIndex = 4;
                    n.SelectedImageIndex = 4;
                }
            }

            tvProject.Nodes.Add(rootNode);
            rootNode.Expand();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (!_running)
            {
                timer1.Start();
                _running = true;
                btnStart.Text = "Stop";
                lblStatusBar.Text = "Running...";
                backgroundWorker1.RunWorkerAsync();



            }
            else
            {
                timer1.Stop();
                _listener.Stop();


                lblStatusBar.Text = "Stoped...";
                btnStart.Text = "Start";
                _running = false;
                backgroundWorker1.CancelAsync();


            }
        }




        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Focus();
            this.WindowState = FormWindowState.Normal;
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_listener != null)
                _listener.Stop();

            this.notifyIcon1.Icon = null;
            this.notifyIcon1.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Preferences();
            form.ShowDialog();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            _listener.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            OnLogChanged(Logger.GetLog());
            toolStripProgressBar1.PerformStep();

            if (toolStripProgressBar1.Value >= 100)
                toolStripProgressBar1.Value = 1;


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
                    lblStatusBar.Text = "NPU copy to clipboard";
                }
            }

        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            var sizePanel2 = this.Size.Height - splitContainer1.SplitterDistance;


            if (sizePanel2 <= 105)
            {
                splitContainer1.SplitterDistance = this.Size.Height - 300;
            }
            else
            {
                splitContainer1.SplitterDistance = this.Size.Height - 105;
            }
        }

        private void cleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbxMessages.Items.Clear();
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentProject != null)
            {
                var form = new ProjectForm(_currentProject.Project);
                form.ShowDialog();
                LoadProjects();
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var steps = _currentProject.Project.Steps;
            _currentProject.MessagesSent.Clear();
            _currentProject.Received.Clear();

            foreach (var s in steps)
            {
                s.Sent = false;
            }

            UpdateProjectTree();
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = tvProject.SelectedNode;

            if (item != null)
            {

                var msg = item.Tag as TestStep;

                if (msg != null)
                {
                    var result = Messaging.SendMsg(msg.Message);

                    if (result.Status != MessageStatusEnum.OK)
                    {
                        MessageBox.Show("Error: " + result.Received);
                    }
                }
            }

        }

        private void createProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new ProjectForm();
            form.ShowDialog();
            LoadProjects();
        }

        private void returnGenericReplyI2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msg = cmsLbxMessages.Tag as MessageInfo;

            if (msg != null)
            {
                try
                {
                    var result = Messaging.ReplyI2(msg);

                    if (result.Status != MessageStatusEnum.OK)
                    {
                        MessageBox.Show("Fail: " + result.Received);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    Logger.Exception(ex, "Sending I2");

                }
            }
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

        private void editMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editMessageSent();

        }

        private void tvProject_DoubleClick(object sender, EventArgs e)
        {
            editMessageSent();
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
        
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = sender as MsgSentForm;

            if (form.MsgSent != null)
            {
                _currentProject.MessagesSent.Add(form.MsgSent);
            }

            UpdateProjectTree();
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






    }
}
