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
using Proxmulator.Forms.UserControls;
using Proxmulator.Extras;

namespace Proxmulator.Forms
{
    public partial class ProjectForm : Form
    {
        private Project _project;


        public ProjectForm(Project p = null)
        {
            InitializeComponent();

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

            testStepControl1.LoadTestStep(null);
        }

        private bool ValidatePass()
        {
            return true;
            throw new Exception("Invalid Password, Paga uma Mini ao Sousa para ter acesso a esta funcionalidade!!!");
        }


        private void btnLoadMsg_Click(object sender, EventArgs e)
        {
            ValidatePass();

            ShowLoading.Show();

            _project.Steps.Clear();

            var connection = cbxConnections.SelectedItem as DBConnection;

            var reqNumber = tbReqNumber.Text;
            var messages = DBAccess.GetMessages(reqNumber, connection);


            var i = 0;
            foreach (var msg in messages)
            {

                var step = new TestStep();
                step.Index = i++;

                if (string.IsNullOrEmpty(msg.CorrelationNPU))
                    step.Trigger = new TriggerNone(msg);
                else
                    step.Trigger = new TriggerOperation(msg);

                step.Message = msg;
                step.Name = msg.Name;
                step.UrlResponse = CommunicationWS.GetUrl(msg.InterfaceToInvoke);

                _project.Steps.Add(step);

            }

            _project.BusinessId = reqNumber;

            if (string.IsNullOrEmpty(tbName.Text))
                tbName.Text = reqNumber;

            _project.Name = tbName.Text;

            FillTreeView(_project.Steps);

            ShowLoading.Hide();

        }


        private void FillTreeView(List<TestStep> steps)
        {
            tvMsgs.Nodes.Clear();

            var rootNode = new TreeNode(_project.Name);

            foreach (var step in steps)
            {

                var n = new TreeNode(step.Name);
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
                testStepControl1.LoadTestStep(step);
            }
        }

        private void tbExportSoapUI_Click(object sender, EventArgs e)
        {
            ShowLoading.Show();
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

            ShowLoading.Hide();

        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (_project != null)
            {
                _project.BusinessId = tbReqNumber.Text;
                _project.Name = tbName.Text;

                _project.Save();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
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
                    testStepControl1.LoadTestStep(tvMsgs.SelectedNode.Tag as TestStep);
                }
                else
                {
                    testStepControl1.LoadTestStep(null);
                }


            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                tvMsgs.SelectedNode = tvMsgs.GetNodeAt(e.X, e.Y);

                if (tvMsgs.SelectedNode != null)
                {
                    testStepControl1.LoadTestStep(tvMsgs.SelectedNode.Tag as TestStep);
                }
                else
                {
                    testStepControl1.LoadTestStep(null);
                }
            }

        }

        #region DRAG 'n' DROP

        private void tvMsgs_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void tvMsgs_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void tvMsgs_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                var point = tvMsgs.PointToClient(new Point(e.X, e.Y));
                var destinationNode = tvMsgs.GetNodeAt(point);
                var NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

                tvMsgs.Nodes[0].Nodes.Remove(NewNode);
                tvMsgs.Nodes[0].Nodes.Insert(destinationNode.Index, NewNode);

                var step = NewNode.Tag as TestStep;
                _project.Steps.Remove(step);
                _project.Steps.Insert(destinationNode.Index-1, step);
            }
        }

        #endregion

  

        private void createMsgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var step = new TestStep();
            step.Name = "New";
            step.Index = 999;
            step.Message = new MessageInfo();

            _project.Steps.Add(step);

            FillTreeView(_project.Steps);
        }

        private void testStepControl1_Save(object sender, EventArgs e)
        {
            FillTreeView(_project.Steps);
        }
    }
}
