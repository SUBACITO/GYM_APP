using BaiTapQuanLy.BussinessLayer;
using BaiTapQuanLy.DTO;
using BaiTapQuanLy.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace BaiTapQuanLy
{
    public partial class Frm_Login : Form
    {
        Bll_HeThong bll;
        string err = string.Empty;
        DataTable dt;
        public Frm_Login()
        {
            InitializeComponent();

            /// Hide password items
            hidePasswordFieldItems();
            // Default accept button
            this.AcceptButton = btnNext_EmailorPhone;
        }

        private void hidePasswordFieldItems()
        {
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
            bll = new Bll_HeThong(clsMain.path);
            //comment
            btnCreateAccount.Visible = false;
            cboxShowPassword.Checked = false;
            txtPassword.UseSystemPasswordChar = true;
            txtEmailorPhone.Focus();
        }

        //Check if email is valid (contain '@gmail.com')
        private bool isValidEmail(string email)
        {
            // Regular expression pattern for email validation
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, emailPattern);
        }


        //Click next if email is valid -> move to password form
        private void btnNext_EmailorPhone_Click(object sender, EventArgs e)
        {
            string userEmailText = txtEmailorPhone.Text.Trim();
            if (!string.IsNullOrEmpty(txtEmailorPhone.Text))
            {
                if (isValidEmail(userEmailText))
                {
                    // Kiểm tra sự tồn tại của username trước khi chuyển đến form nhập mật khẩu
                    int usernameExists = bll.CheckUsernameExistence(ref err, userEmailText);
                    if (usernameExists == 1)
                    {
                        // Nếu username tồn tại, hiển thị các mục nhập mật khẩu và chuyển đến form nhập mật khẩu
                        doTransitionAnimationToPasswordFormField();
                    }
                    else
                    {
                        Frm_Messages noti = new Frm_Messages();
                        noti.StartPosition = FormStartPosition.CenterParent;
                        noti.TitleText = "GYM APP";
                        noti.MessageText = "User does not exist!";
                        var anim = new Transition(new TransitionType_CriticalDamping(200));
                        anim.add(noti, "Top", 450);
                        anim.run();
                        noti.ShowDialog();
                        txtEmailorPhone.Focus();
                    }
                }
                else
                {
                    Frm_Messages noti = new Frm_Messages();
                    noti.StartPosition = FormStartPosition.CenterParent;
                    noti.TitleText = "GYM APP";
                    noti.MessageText = "Please enter a valid email!";

                    Task.Delay(200).ContinueWith(_ =>
                    {
                        var anim = new Transition(new TransitionType_CriticalDamping(200));
                        anim.add(noti, "Top", 450);
                        anim.run();

                        noti.ShowDialog();
                        txtEmailorPhone.Focus();
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                }
            }
            else
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "GYM APP";
                noti.MessageText = "Please enter your email!";

                Task.Delay(200).ContinueWith(_ =>
                {
                    var anim = new Transition(new TransitionType_CriticalDamping(200));
                    anim.add(noti, "Top", 450);
                    anim.run();

                    noti.ShowDialog();
                    txtEmailorPhone.Focus();
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }

        }

        //private bool KiemTraDangNhap(string taiKhoan, string matKhau)
        //{
        //    dtNhanVien = new DataTable();
        //    dtNhanVien = bll.KiemTraDangNhap(ref err, taiKhoan, matKhau);
        //    return false;
        //}

        //Do transition animation to move to password form
        private void doTransitionAnimationToPasswordFormField()
        {
            //////////////////////////////////
            //btnCreateAccount.Visible = false;
            btnNext_EmailorPhone.Visible = false;
            lbl_SignIn.Visible = false;
            lblUseYourAccount.Visible = false;
            /////////////////////////////////
            label_Username.Text = "Hi";
            label_UserEmail.Text = txtEmailorPhone.Text;
            /////////////////////////////////
            backToEmailorPhoneBTN.Visible = true;
            backToEmailorPhoneBTN.Location = new Point(-100, 60);
            txtPassword.Visible = true;
            txtPassword.Location = new Point(txtEmailorPhone.Location.X - 1000, txtEmailorPhone.Location.Y + 50);
            cboxShowPassword.Visible = true;
            cboxShowPassword.Location = new Point(txtPassword.Location.X - 100, txtPassword.Location.Y + 60);
            btnForgotPassword.Visible = false;
            btnForgotPassword.Location = new Point(btnCreateAccount.Location.X - 40, btnCreateAccount.Location.Y);
            btnPassword.Visible = true;
            btnPassword.Location = new Point(btnNext_EmailorPhone.Location.X, btnNext_EmailorPhone.Location.Y);
            label_Username.Visible = true;
            label_Username.Location = new Point(lbl_SignIn.Location.X, lbl_SignIn.Location.Y);
            label_UserEmail.Visible = true;
            label_UserEmail.Location = new Point(lblUseYourAccount.Location.X, lblUseYourAccount.Location.Y);
            ////////////////////////////////
            txtPassword.Focus();
            this.AcceptButton = btnPassword;
            //////////////////////////////////////////////////////
            var anim = new Transition(new TransitionType_EaseInEaseOut(500));
            anim.add(txtEmailorPhone, "Left", this.Width - (txtEmailorPhone.Left + txtEmailorPhone.Width));
            anim.add(btnForgotEmail, "Left", this.Width - (btnForgotEmail.Left + btnForgotEmail.Width));
            anim.add(label_LearnMore, "Left", this.Width - (label_LearnMore.Left + label_LearnMore.Width));
            anim.add(btnLearnMore, "Left", this.Width - (btnLearnMore.Left + btnLearnMore.Width));
            anim.add(backToEmailorPhoneBTN, "Left", 6);
            anim.add(txtPassword, "Left", 0);
            anim.add(cboxShowPassword, "Left", 0);
            anim.run();
        }

        //Back to email form with transition (current in password form)
        private void backToEmailorPhoneBTN_Click(object sender, EventArgs e)
        {
            /////////////////////////////////
            //btnCreateAccount.Visible = true;
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
            /////////////////////////////////
            txtEmailorPhone.Focus();
            this.AcceptButton = btnNext_EmailorPhone;
            ///////////////////////////////////
            int goBack = 0;
            var anim = new Transition(new TransitionType_EaseInEaseOut(500));
            anim.add(txtEmailorPhone, "Left", goBack);
            anim.add(btnForgotEmail, "Left", goBack);
            anim.add(label_LearnMore, "Left", goBack);
            anim.add(btnLearnMore, "Left", goBack);
            anim.add(backToEmailorPhoneBTN, "Left", -150);
            anim.add(txtPassword, "Left", -1000);
            anim.add(cboxShowPassword, "Left", -150);
            anim.run();
        }

        //Check box to show and hide password
        private void cboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cboxShowPassword.Checked;
        }

        //Check if password correct with the email address, if yes then move to Main form
        private void btnPassword_Click(object sender, EventArgs e)
        {
            // Kiểm tra đăng nhập khi người dùng nhấp vào nút Đăng nhập
            string userEmailText = txtEmailorPhone.Text.Trim();
            string userPassword = txtPassword.Text.Trim();
            string loginStatus = bll.AuthenticateUser(ref err, userEmailText, userPassword).ToString();
            if(!string.IsNullOrEmpty(txtPassword.Text))
            {
                if (!string.IsNullOrEmpty(loginStatus))
                {
                    // Nếu đăng nhập thành công, chuyển đến form chính
                    Frm_Main frm_Main = new Frm_Main();
                    frm_Main.Show();
                    this.Hide();
                }
                else
                {
                    Frm_Messages noti = new Frm_Messages();
                    noti.StartPosition = FormStartPosition.CenterParent;
                    noti.TitleText = "GYM APP";
                    noti.MessageText = "Invalid password! Please try again.";

                    Task.Delay(100).ContinueWith(_ =>
                    {
                        var anim = new Transition(new TransitionType_CriticalDamping(200));
                        anim.add(noti, "Top", 450);
                        anim.run();

                        noti.ShowDialog();
                        txtPassword.Focus();
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                }

            } else
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "GYM APP";
                noti.MessageText = "Please enter your password!";

                Task.Delay(100).ContinueWith(_ =>
                {
                    var anim = new Transition(new TransitionType_CriticalDamping(200));
                    anim.add(noti, "Top", 450);
                    anim.run();

                    noti.ShowDialog();
                    txtPassword.Focus();
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }

        
    }
}
