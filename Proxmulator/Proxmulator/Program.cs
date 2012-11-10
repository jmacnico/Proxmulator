using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Xml;
using System.IO;
using System.Threading;
using System.Net;
using System.Configuration;
using Proxmulator.Forms.UserControls;
using System.Windows.Forms;

namespace Proxmulator
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var form = new MainForm();
            Application.Run(form);
        }
    }
}
