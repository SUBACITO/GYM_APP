using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace BaiTapQuanLy
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            txtPassword.Visible = false;
            cboxShowPassword.Visible = false;
            btnForgotPassword.Visible = false;
            btnPassword.Visible = false;
            label_Username.Visible = false;
            label_UserEmail.Visible = false;
            backToEmailorPhoneBTN.Visible = false;
        }
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            cboxShowPassword.Checked = false;
            txtPassword.UseSystemPasswordChar = true;

            Frm_Main frm_Main = new Frm_Main();
            frm_Main.Close();
        }

        private void btnNext_EmailorPhone_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtEmailorPhone.Text))
            {
                backToEmailorPhoneBTN.Visible=true;
                backToEmailorPhoneBTN.Location = new Point(-100, 60);
                txtPassword.Visible = true;
                txtPassword.Location = new Point(txtEmailorPhone.Location.X - 100, txtEmailorPhone.Location.Y + 50);
                cboxShowPassword.Visible = true;
                cboxShowPassword.Location = new Point(txtPassword.Location.X - 100, txtPassword.Location.Y + 60);
                //////////////////////////////////////////////////////
                var anim = new Transition(new TransitionType_EaseInEaseOut(300));
                anim.add(txtEmailorPhone, "Left", this.Width - (txtEmailorPhone.Left + txtEmailorPhone.Width));
                anim.add(btnForgotEmail, "Left", this.Width - (btnForgotEmail.Left + btnForgotEmail.Width));
                anim.add(label_LearnMore, "Left", this.Width - (label_LearnMore.Left + label_LearnMore.Width));
                anim.add(btnLearnMore, "Left", this.Width - (btnLearnMore.Left + btnLearnMore.Width));
                anim.add(backToEmailorPhoneBTN, "Left", 6);
                anim.add(txtPassword, "Left", 0);
                anim.add(cboxShowPassword, "Left", 0);
                anim.run();
                //////////////////////////////////
                btnCreateAccount.Visible = false;
                btnNext_EmailorPhone.Visible = false;
                lbl_SignIn.Visible = false;
                lblUseYourAccount.Visible = false;
                /////////////////////////////////
                label_Username.Text = "Quang Nguyen";
                label_UserEmail.Text = txtEmailorPhone.Text;
                /////////////////////////////////
                btnForgotPassword.Visible = true;
                btnForgotPassword.Location = new Point(btnCreateAccount.Location.X - 40, btnCreateAccount.Location.Y);
                btnPassword.Visible = true;
                btnPassword.Location = new Point(btnNext_EmailorPhone.Location.X, btnNext_EmailorPhone.Location.Y);
                label_Username.Visible = true;
                label_Username.Location = new Point(lbl_SignIn.Location.X, lbl_SignIn.Location.Y);
                label_UserEmail.Visible = true;
                label_UserEmail.Location = new Point(lblUseYourAccount.Location.X, lblUseYourAccount.Location.Y);
                ////////////////////////////////
            } else
            {
                MessageBox.Show("Please enter your email!", "Google", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backToEmailorPhoneBTN_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////
            int goBack = 0;
            var anim = new Transition(new TransitionType_EaseInEaseOut(300));
            anim.add(txtEmailorPhone, "Left", goBack);
            anim.add(btnForgotEmail, "Left", goBack);
            anim.add(label_LearnMore, "Left", goBack);
            anim.add(btnLearnMore, "Left", goBack);
            anim.add(backToEmailorPhoneBTN, "Left", -150);
            anim.add(txtPassword, "Left", -1000);
            anim.add(cboxShowPassword, "Left", -150);
            anim.run();
            /////////////////////////////////
            btnCreateAccount.Visible = true;
            btnNext_EmailorPhone.Visible = true;
            lbl_SignIn.Visible = true;
            lblUseYourAccount.Visible = true;
            //////////////////////////////////
            label_Username.Text = "";
            label_UserEmail.Text = "";
            txtPassword.Text = "";
            //////////////////////////////////
            btnForgotPassword.Visible = false;
            btnPassword.Visible = false;
            label_Username.Visible = false;
            label_UserEmail.Visible = false;
        }

        private void cboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cboxShowPassword.Checked;
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPassword.Text))
            {
                Frm_Main frm_Main = new Frm_Main();
                frm_Main.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Please enter your password!", "Google", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
