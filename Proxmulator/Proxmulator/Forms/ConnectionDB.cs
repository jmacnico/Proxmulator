using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proxmulator.Entities;
using Oracle.DataAccess.Client;

namespace Proxmulator.Forms
{
    public partial class ConnectionDB : Form
    {
        private List<DBConnection> _connections;
        private static string _NewConnection = "<New Connection>";

        public ConnectionDB()
        {
            InitializeComponent();

            _connections = Configuration.Connections;
            LoadConnection();
        }

        private void LoadConnection()
        {
            var con = new DBConnection();
            con.Name = _NewConnection;

            cbxConnections.Items.Add(con);

            foreach (var c in _connections)
            {
                cbxConnections.Items.Add(c);
            }


            cbxConnections.SelectedIndex = 0;
            cbxConnections.SelectedIndex = 0;
        }


        private void Load(DBConnection c)
        {
            tbName.Text = c.Name;
            tbHost.Text = c.Host;
            tbPort.Text = c.Port;
            tbUser.Text = c.User;
            tbPass.Text = c.Password;
            tbSID.Text = c.SID;
            tbSchema.Text = c.Schema;
        }


        private void btnTest_Click(object sender, EventArgs e)
        {
            var c = new DBConnection();
            c.Host = tbHost.Text;
            c.Port = tbPort.Text;
            c.User = tbUser.Text;
            c.Password = tbPass.Text;
            c.SID = tbSID.Text;
            c.Schema = tbSchema.Text;


            var result = Test(c);

            lblTest.Text = result;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var item = cbxConnections.SelectedItem as DBConnection;

            if (item != null)
            {
                if (item.Name == _NewConnection)
                    _connections.Add(item);

                item.Name = tbName.Text;
                item.Host = tbHost.Text;
                item.Port = tbPort.Text;
                item.User = tbUser.Text;
                item.Password = tbPass.Text;
                item.SID = tbSID.Text;
                item.Schema = tbSchema.Text;


                

            }


            Configuration.Connections = _connections;

            Configuration.Save();
            this.Close();
        }



        public static string Test(DBConnection conn)
        {
            try
            {
                var connectionString = conn.getConnectionString();
                var dbConnection = new OracleConnection(connectionString);

                var command = dbConnection.CreateCommand();
                command.CommandText = "select * from dual";

                dbConnection.Open();

                var r = command.ExecuteNonQuery();

                dbConnection.Close();
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }


            return "OK";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = cbxConnections.SelectedItem as DBConnection;

            if (item != null)
            {

                if (item.Name == _NewConnection)
                {
                    tbName.Text = string.Empty;
                    tbHost.Text = string.Empty;
                    tbPort.Text = string.Empty;
                    tbUser.Text = string.Empty;
                    tbPass.Text = string.Empty;
                    tbSID.Text = string.Empty;
                    tbSchema.Text = string.Empty;

                }
                else
                {
                    Load(item);
                }
            }
            
        }
    }
}
