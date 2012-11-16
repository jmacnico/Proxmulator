using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proxmulator.Entities;

namespace Proxmulator.Forms
{
    public partial class Preferences : Form
    {
      

        public Preferences()
        {
            InitializeComponent();

            LoadFields();
        }


        private void LoadFields()
        {
            tbPort.Text = Configuration.ListenerPort.ToString();
            tbUrl.Text = Configuration.UrlReturn;
            tbIgonerOper.Text = Configuration.IgnoreOperations;
            if (!string.IsNullOrEmpty(Configuration.IgnoreChunks))
            {
                tbChunks.Text = Configuration.IgnoreChunks;
            }
            else
            {
                tbChunks.Text = "818,78a,6e5,f9c,465";
            }

            foreach (var ope in Configuration.OperationNames)
            {
                dataGridView1.Rows.Add(ope.Operation, ope.Name);
            }

            foreach (var url in Configuration.Urls)
            {
                dgUrls.Rows.Add(url.Key, url.Value);
            }

            foreach (var action in Configuration.SoapActions)
            {
                dgSoapAction.Rows.Add(action.InterfaceToInvoke, action.Operation, action.Action);
            }
        }


        private void btSave_Click(object sender, EventArgs e)
        {
            Configuration.UrlReturn = tbUrl.Text;
            Configuration.ListenerPort = int.Parse(tbPort.Text);
            Configuration.IgnoreOperations = tbIgonerOper.Text;
            Configuration.IgnoreChunks = tbChunks.Text;
            
            Configuration.OperationNames.Clear();
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var ope = new OperationName();
                ope.Name = row.Cells["PrettyName"].Value != null ? row.Cells["PrettyName"].Value.ToString() : null;
                ope.Operation = row.Cells["Operation"].Value != null ? row.Cells["Operation"].Value.ToString(): null;

                if (ope.Name == null || ope.Operation == null)
                    continue;

                Configuration.OperationNames.Add(ope);
            }


            Configuration.SoapActions.Clear();
            foreach (DataGridViewRow row in dgSoapAction.Rows)
            {
                var interf = row.Cells["Interface"].Value != null ? row.Cells["Interface"].Value.ToString() : null;
                var action = row.Cells["SoapAction"].Value != null ? row.Cells["SoapAction"].Value.ToString() : null;
                var oper = row.Cells["Oper"].Value != null ? row.Cells["Oper"].Value.ToString() : null;

                if (interf == null || action == null) continue;

                Configuration.SoapActions.Add(new SoapAction(interf, oper, action));
            }


            Configuration.Urls.Clear();
            foreach (DataGridViewRow row in dgUrls.Rows)
            {
                var interf = row.Cells["Url_Interfaces"].Value != null ? row.Cells["Url_Interfaces"].Value.ToString() : null;
                var url = row.Cells["Urls_Url"].Value != null ? row.Cells["Urls_Url"].Value.ToString() : null;

                if (interf == null || url == null) continue;

                Configuration.Urls.Add(new KeyValueInfo(interf, url));
            }

            Configuration.Save();

            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDBConnection_Click(object sender, EventArgs e)
        {
            var form = new ConnectionDB();

            form.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



       
    }
}
