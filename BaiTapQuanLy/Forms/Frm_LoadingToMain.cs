using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapQuanLy.Forms
{
    public partial class Frm_LoadingToMain : Form
    {
        public Frm_LoadingToMain()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Frm_LoadingToMain_Load(object sender, EventArgs e)
        {
            circularProgressBar.Value = 0;
            circularProgressBar.Minimum = 0;
            circularProgressBar.Maximum = 100;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            circularProgressBar.Value += 2;
            circularProgressBar.Text = circularProgressBar.Value.ToString() + "%";
            if(circularProgressBar.Value == 100)
            {
                timer.Enabled = false;
                Frm_Main frmMain = new Frm_Main();
                frmMain.Show();
                this.Close();
            }
        }
    }
}
