using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proxmulator.Entities;
using Proxmulator.Extras;
using Proxmulator.Entities.Interfaces;

namespace Proxmulator.Forms.UserControls
{
    public partial class TestStepControl : UserControl
    {
        private TestStep _step;
        public event EventHandler Save;


        public TestStepControl()
        {
            InitializeComponent();
        }

        public void LoadTestStep(TestStep step)
        {
            _step = step;

            if (step != null)
            {
                tbStepName.Enabled = true;
                xmlEditor.Enabled = true;
                cbStepTrigger.Enabled = true;
                tbInterface.Enabled = true;
                tbOperation.Enabled = true;
                cbOnlyOneUse.Enabled = true;
                btnSave.Enabled = true;

                tbStepName.Text = step.Name;
                xmlEditor.Text = Utils.PrettyPrint(step.Message.xml);
                cbStepTrigger.SelectedIndex = ((int)step.Trigger.Type - 1);
                tbInterface.Text = step.Message.InterfaceToInvoke;
                tbOperation.Text = step.Message.Operation;
                cbOnlyOneUse.Checked = step.Trigger.OnlyOneUse;
            }
            else
            {
                tbStepName.Enabled = false;
                xmlEditor.Enabled = false;
                cbStepTrigger.Enabled = false;
                tbInterface.Enabled = false;
                tbOperation.Enabled = false;
                cbOnlyOneUse.Enabled = false;
                btnSave.Enabled = false;
            }
        }


        private void llEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (_step != null)
            {
                var msg = _step.Message;
                var f = new TriggerForm(msg, _step.Trigger);
                var r = f.ShowDialog();

                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    _step.Trigger = f.Trigger;
                }
            }
        }

        private void cbStepTrigger_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = cbStepTrigger.SelectedItem.ToString();
            if (value == "Custom")
                llEdit.Enabled = true;
            else
                llEdit.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Save != null)
            {
                _step.Name = tbStepName.Text;
                _step.Message.Payload = xmlEditor.Text;
                _step.Message.InterfaceToInvoke = tbInterface.Text;
                _step.Message.Operation = tbOperation.Text;

                var triggerType = (TriggerType)Enum.Parse(typeof(TriggerType), cbStepTrigger.SelectedItem.ToString());

                if (_step.Trigger.Type != triggerType && triggerType != TriggerType.Custom)
                {
                    if (triggerType == TriggerType.None)
                    {
                        _step.Trigger = new TriggerNone(_step.Message);
                    }
                    else if (triggerType == TriggerType.Operation)
                    {
                        _step.Trigger = new TriggerOperation(_step.Message);
                    }
                }
                

                this.Save(_step, null);
            }
        }

    }
}
