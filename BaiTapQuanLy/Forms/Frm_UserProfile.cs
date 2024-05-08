using BaiTapQuanLy.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapQuanLy
{
    public partial class Frm_UserProfile : Form
    {
        public Frm_UserProfile()
        {
            InitializeComponent();
        }

        private void closeProfileButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_UserProfile_Load(object sender, EventArgs e)
        {
            lbl_username.Text = "Hi, "+Account.userName;
        }

        private void logOutBTN_Click(object sender, EventArgs e)
        {
            // Close the current form (Frm_UserProfile)
            this.Close();

            // Dispose the Frm_Main form if it's not null
            Frm_Main frm_Main = Application.OpenForms["Frm_Main"] as Frm_Main;
            frm_Main?.Dispose();

            // Open the Frm_Login form
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
        }
    }
}
