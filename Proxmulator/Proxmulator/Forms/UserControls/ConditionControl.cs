using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proxmulator.Entities;

namespace Proxmulator.Forms.UserControls
{
    public partial class ConditionControl : UserControl
    {
        private Condition _condition;

        public bool ShowCommonXpath { get; set; }

        
        public ConditionControl()
        {
            InitializeComponent();
            combo1.SelectedIndex = 0;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (ShowCommonXpath)
            {
                tbXpath1.Visible = false;
                cbCommon.Visible = true;
                LoadCommonValues();
            }
        }



        public void Fill(Condition cond, string name = "1")
        {
            _condition = cond;
            label1.Text += name;
            cb1.Checked = cond.Active;
            tbValue1.Text = cond.ValueToCompare;
            tbXpath1.Text = cond.ValueLocation;
            combo1.SelectedIndex = ((int)cond.Comparator - 1);
        }

        private void LoadCommonValues()
        {
            cbCommon.Items.Add(".//cfs/attribute[name='businessServiceId']/value");
            cbCommon.Items.Add(".//cfs//attribute[name='lrName']/value");
        }

        public Condition GetCondition()
        {
            if(_condition == null && !cb1.Checked)
                return null;

            if (_condition == null)
                _condition = new Condition();


            _condition.Active = cb1.Checked;
            _condition.ValueToCompare = tbValue1.Text;

            if (ShowCommonXpath)
            {
                _condition.ValueLocation = cbCommon.SelectedItem.ToString();
            }
            else
            {
                _condition.ValueLocation = tbXpath1.Text;
            }

            _condition.Comparator = (EnumCondition)Enum.Parse(typeof(EnumCondition), combo1.SelectedItem.ToString());

            return _condition;
        }



    }
}
