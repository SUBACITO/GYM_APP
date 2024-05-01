using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapQuanLy.Forms
{
    public partial class Frm_Messages : Form
    {

        public Frm_Messages()
        {
            InitializeComponent();
            new makeFormRounded(this);
            AcceptButton = btnOK;
        }

        public string TitleText
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public string MessageText
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }
    }
}
