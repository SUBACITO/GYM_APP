using BaiTapQuanLy.BussinessLayer;
using BaiTapQuanLy.DTO;
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

namespace BaiTapQuanLy.Forms
{
    public partial class Frm_MemberUpdate : Form
    {
        Bll_HeThong bll_heThong;
        string err = string.Empty;
        public Frm_MembersManager ParentForm { get; set; }

        private int memberID;
        private string fullName;
        private string gender;
        private DateTime dateOfBirth;
        private string email;
        private string phone;
        private DateTime joinDate;
        private string membershipType;
        public Frm_MemberUpdate(int memberID, string fullName, string gender, DateTime dateOfBirth, string email, string phone, DateTime joinDate, string membershipType)
        {
            InitializeComponent();
            this.memberID = memberID;
            this.fullName = fullName;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
            this.phone = phone;
            this.joinDate = joinDate;
            this.membershipType = membershipType;
        }

        private void cancelUpdateBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_MemberUpdate_Load(object sender, EventArgs e)
        {
            bll_heThong = new Bll_HeThong(clsMain.path);
            txt_FullName.Text = fullName;
            cbox_Gender.SelectedItem = gender;
            dtp_DateOfBirth.Value = dateOfBirth;
            txt_Email.Text = email;
            txt_Phone.Text = phone;
            dtp_JoinDate.Value = joinDate;
            cbox_MembershipType.SelectedItem = membershipType;
            /////////////////////////////////////////////////
            txt_FullName.Focus();
            txt_FullName.Select(txt_FullName.Text.Length, 0);
        }

        private void updateMemberBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the modified member information from the form controls
                string fullName = txt_FullName.Text;
                string gender = cbox_Gender.SelectedItem.ToString();
                DateTime dateOfBirth = dtp_DateOfBirth.Value;
                string email = txt_Email.Text;
                string phone = txt_Phone.Text;
                DateTime joinDate = dtp_JoinDate.Value;
                string membershipType = cbox_MembershipType.SelectedItem.ToString();

                // Call the appropriate method from your business layer to update the member's information
                int result = bll_heThong.UpdateMemberToDGV(ref err, new Member()
                {
                    MemberID = memberID, 
                    FullName = fullName,
                    Gender = gender,
                    DateOfBirth = dateOfBirth,
                    Email = email,
                    Phone = phone,
                    JoinDate = joinDate,
                    MembershipType = membershipType
                });

                if (result > 0)
                {
                    // Member updated successfully
                    Frm_Messages noti = new Frm_Messages();
                    noti.StartPosition = FormStartPosition.CenterParent;
                    noti.TitleText = "SUCCESS";
                    noti.MessageText = "A member has been updated";
                    var anim = new Transition(new TransitionType_Deceleration(300));
                    anim.add(noti, "Top", 500);
                    anim.run();
                    noti.ShowDialog();
                    ParentForm?.refreshMemberDataGridView();
                    this.Close();
                }
                else
                {
                    // Error occurred while updating member
                    Frm_Messages noti = new Frm_Messages();
                    noti.StartPosition = FormStartPosition.CenterParent;
                    noti.TitleText = "ERROR";
                    noti.MessageText = "Error updaing member";
                    var anim = new Transition(new TransitionType_Deceleration(300));
                    anim.add(noti, "Top", 500);
                    anim.run();
                    noti.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "ERROR";
                noti.MessageText = "An error occured "+ex;
                var anim = new Transition(new TransitionType_Deceleration(300));
                anim.add(noti, "Top", 500);
                anim.run();
                noti.ShowDialog();
            }
        }
    }
}
