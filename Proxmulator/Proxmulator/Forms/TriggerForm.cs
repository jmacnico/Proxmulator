using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proxmulator.Entities;
using Proxmulator.Entities.Interfaces;
using Proxmulator.Forms.UserControls;

namespace Proxmulator.Forms
{
    public partial class TriggerForm : Form
    {
        public Trigger Trigger { get; set; }
        private MessageInfo _msg;

        public TriggerForm(MessageInfo msg, Trigger t)
        {
            InitializeComponent();
            _msg = msg;
            Trigger = t;
            LoadTrigger();
        }


        private void LoadTrigger()
        {
            if (Trigger != null)
            {
                var i = 1;
                foreach (var cond in Trigger.Conditions)
                {
                    var cb = FindConditionControlByName("conditionControl" + i);

                    cb.Fill(cond, i.ToString());

                    i++;
                }
            }
        }


        private void LoadCommonXPath(ComboBox cb)
        {


        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            Trigger = new TriggerCustom(_msg);


            for (var i = 1; i <= 6; i++)
            {
                var cb = FindConditionControlByName("conditionControl" + i);

                var cond = cb.GetCondition();
                if (cond != null)
                {
                    if (!cond.Active)
                        Trigger.Conditions.Remove(cond);
                    else
                        Trigger.AddCondition(cond);

                }
            }


            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            this.Close();
        }





        private ConditionControl FindConditionControlByName(string name)
        {
            ConditionControl cb = null;
            var ctr = this.Controls.Find(name, true);

            if (ctr.Length > 0)
            {
                cb = ctr[0] as ConditionControl;
            }

            return cb;
        }






    }
}
