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
            new makeFormRounded(this);
        }

        private void closeProfileButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_UserProfile_Load(object sender, EventArgs e)
        {
            gunaShadowForm.SetShadowForm(this);
        }

    }
}
