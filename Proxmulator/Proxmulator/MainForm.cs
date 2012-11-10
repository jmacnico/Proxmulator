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
using Proxmulator.Extras;

namespace Proxmulator
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        delegate void OnLogChangedCallback(string text);
        delegate void OnAddMessage(MessageInfo msg);
        delegate void OnUpdateStep(TestStep step);
        delegate void OnUpdateRecivedAndSent();

        private Listener _listener = null;

        private ProjectInstance _currentProject;

        public ProjectInstance ProjectInstance { get { return _currentProject; } }


        public MainForm()
        {
            InitializeComponent();

            Configuration.Load();
            LoadProjects();

            _listener = new Listener(this);
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            tabControl1_DoubleClick(null, null);
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

        public void UpdateStep(TestStep step)
        {
            
            if (this.treeVewProject1.InvokeRequired)
            {
                var a = new OnUpdateStep(UpdateStep);
                this.Invoke(a, new object[] { step });
            }
            else
            {
                if (_currentProject != null)
                {
                    treeVewProject1.UpdateStep();
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

            treeVewProject1.LoadProject(_currentProject);

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

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            _listener.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            OnLogChanged(Logger.GetLog());

            toolStripProgressBar1.PerformStep();

            if (toolStripProgressBar1.Value >= 100)
            {
                toolStripProgressBar1.Value = 1;
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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentProject != null)
            {
                var form = new ProjectForm(_currentProject.Project);
                var r = form.ShowDialog();
                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    var name = _currentProject.Project.Name;
                    _currentProject = null;
                    LoadProjects();

                    var path = Project.GetProjectDirectory();
                    var file = Directory.GetFiles(path, name + ".xml");
                    LoadProject(file[0]);

                }
            }
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

            treeVewProject1.LoadProject(_currentProject);

        }

      
        private void createProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new ProjectForm();
            form.ShowDialog();
            LoadProjects();
        }

   
        

      

         #region Msg Received Events

        public void AddMessage(MessageInfo msg)
        {
            if (this.receivedMsgControl1.InvokeRequired)
            {
                var a = new OnAddMessage(AddMessage);
                this.Invoke(a, new object[] { msg });
            }
            else
            {
                this.receivedMsgControl1.AddMessage(msg);
            }

        }

        private void receivedMsgControl1_NewStatusBarMsg(object sender, EventArgs e)
        {
            this.lblStatusBar.Text = sender.ToString();
        }

        private void receivedMsgControl1_StartClick(object sender, EventArgs e)
        {
            timer1.Start();
            lblStatusBar.Text = "Running...";
            backgroundWorker1.RunWorkerAsync();
        }

        private void receivedMsgControl1_StopClick(object sender, EventArgs e)
        {
            timer1.Stop();
            _listener.Stop();

            lblStatusBar.Text = "Stoped...";
            backgroundWorker1.CancelAsync();
        }

        #endregion

        #region Project TreeView

        private void treeVewProject1_EditProject(object sender, EventArgs e)
        {
            editToolStripMenuItem_Click(null, null);
        }

        private void treeVewProject1_MsgSent(object sender, EventArgs e)
        {

        }

        private void treeVewProject1_StartProject(object sender, EventArgs e)
        {

        }

        private void treeVewProject1_StopProject(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
