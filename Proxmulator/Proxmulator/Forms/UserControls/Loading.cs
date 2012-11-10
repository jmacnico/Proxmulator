using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proxmulator.Core;
using System.Threading;

namespace Proxmulator.Forms.UserControls
{
    public partial class Loading : Form
    {
        private delegate void OnIncrement();

        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 100)
            {
                progressBar1.Value = 0;
            }

            progressBar1.PerformStep();
        }



    }

    public static class ShowLoading
    {
        private static Thread _thread = null;
       

        public static void Hide()
        {
            if (_thread != null)
            {
                _thread.Abort();
            }
        }

        public static void Show()
        {
            _thread = new Thread(new ThreadStart(StartUIThread));
            _thread.Start();
        }


        public static void StartUIThread()
        {
             var _form = new Loading();
            _form.ShowDialog();

        }


    }
}
