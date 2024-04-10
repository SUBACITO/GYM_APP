using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapQuanLy
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Frm_DangNhap f = new Frm_DangNhap();
            f.ShowDialog();
            statusLogin.Text = clsMain.nickname;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
