using BaiTapQuanLy.BussinessLayer;
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
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == null && tbPassword.Text == null) return;

            if (KiemTraDangNhap(tbUsername.Text, tbPassword.Text))
            {
                clsMain.nickname = dtUser.Rows[0]["FullName"].ToString();
                this.Close();
            }

        }

        
        private bool KiemTraDangNhap(string username, string password)
        {
            dtUser = new DataTable();
            dtUser = bll_HeThong.KiemTraDangNhap(ref err, tbUsername.Text, tbPassword.Text);
            if(dtUser.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Failed!");
            }
      
            return false;
        }

        

        string err = string.Empty;
        Bll_HeThong bll_HeThong;
        DataTable dtUser;

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
            bll_HeThong = new Bll_HeThong(clsMain.path);
            tbPassword.UseSystemPasswordChar = false; 
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = checkBox1.Checked;
        }

    

 

    }
}
