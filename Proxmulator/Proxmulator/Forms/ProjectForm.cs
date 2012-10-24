using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proxmulator.Core;
using Proxmulator.Entities;

namespace Proxmulator.Forms
{
    public partial class ProjectForm : Form
    {
        private Project _project;
        private List<TestStep> _steps;


        public ProjectForm(Project p = null)
        {
            InitializeComponent();

            _steps = new List<TestStep>();

            _project = new Project();

            if (p != null)
            {
                _project = p;
                FillTreeView(_project.Steps);
                tbName.Text = _project.Name;
                tbReqNumber.Text = _project.BusinessId;

            }
            cbxConnections.DataSource = Configuration.Connections;
            cbxConnections.DisplayMember = "Name";



        }

        private bool ValidatePass()
        {
            return true;
            throw new Exception("Invalid Password, Paga uma Mini ao Sousa para ter acesso a esta funcionalidade!!!");
        }


        private void btnLoadMsg_Click(object sender, EventArgs e)
        {
            ValidatePass();

            var connection = cbxConnections.SelectedItem as DBConnection;

            var reqNumber = tbReqNumber.Text;
            var messages = DBAccess.GetMessages(reqNumber, connection);


            var i = 0;
            foreach (var msg in messages)
            {

                var step = new TestStep();
                step.Index = i++;

                if (string.IsNullOrEmpty(msg.CorrelationNPU))
                    step.Trigger = TriggerType.None;
                else
                    step.Trigger = TriggerType.Operation;

                step.Message = msg;
                step.Name = msg.Name;
                step.UrlResponse = CommunicationWS.GetUrl(msg.InterfaceToInvoke);

                _steps.Add(step);

            }

            _project.Steps = _steps;
            _project.BusinessId = reqNumber;

            if (string.IsNullOrEmpty(tbName.Text))
                tbName.Text = reqNumber;

            _project.Name = tbName.Text;


            FillTreeView(_steps);

        }


        private void FillTreeView(List<TestStep> steps)
        {
            tvMsgs.Nodes.Clear();

            var rootNode = new TreeNode(tbReqNumber.Text);

            foreach (var step in steps)
            {

                var n = new TreeNode(step.Message.Name);
                n.Tag = step;

                rootNode.Nodes.Add(n);

            }


            tvMsgs.Nodes.Add(rootNode);
            rootNode.Expand();
        }

        private void tvMsgs_DoubleClick(object sender, EventArgs e)
        {

            var item = tvMsgs.SelectedNode;


            if (item != null)
            {

                var step = item.Tag as TestStep;

                if (step != null)
                {
                    tbStepName.Text = step.Name;
                    tbMsg.Text = Utils.PrettyPrint(step.Message.xml);
                    cbStepTrigger.SelectedIndex = ((int)step.Trigger-1);
                    tbInterface.Text = step.Message.InterfaceToInvoke;
                }
            }
        }

        private void tbExportSoapUI_Click(object sender, EventArgs e)
        {
            ValidatePass();
            saveFileDialog1.FileName = _project.Name + ".xml";

            var r = saveFileDialog1.ShowDialog();

            if (r == System.Windows.Forms.DialogResult.OK)
            {
                var stream = SoapUI.Export(_project);

                var file = saveFileDialog1.OpenFile();


                stream.CopyTo(file);
                stream.Position = file.Position = 0;
                file.Close();
            }

        }

        private void tvMsgs_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void tvMsgs_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                var point = tvMsgs.PointToClient(new Point(e.X, e.Y));
                var node = tvMsgs.GetNodeAt(point);

            }
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (_project != null)
            {
                _project.Save();

            }

            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvMsgs.SelectedNode != null)
            {
                var msg = tvMsgs.SelectedNode.Tag as TestStep;
                _project.Steps.Remove(msg);
                FillTreeView(_project.Steps);
            }
        }



        private void tvMsgs_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                tvMsgs.SelectedNode = tvMsgs.GetNodeAt(e.X, e.Y);

                if (tvMsgs.SelectedNode != null)
                {
                    cmsMsg.Show(tvMsgs, e.Location);
                }

            }
        }


    }
}
