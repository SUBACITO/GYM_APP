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
        Bll_Member bll_member;
        string err = string.Empty;
        Frm_MembersManager parentForm;

        private int memberID;
        private string fullName;
        private string gender;
        private DateTime dateOfBirth;
        private string email;
        private string phone;
        private DateTime joinDate;
        public Frm_MemberUpdate(int memberID, string fullName, string gender, DateTime dateOfBirth, string email, string phone, DateTime joinDate, Frm_MembersManager parentForm)
        {
            InitializeComponent();
            this.memberID = memberID;
            this.fullName = fullName;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
            this.phone = phone;
            this.joinDate = joinDate;
            this.parentForm = parentForm;
        }

        private void cancelUpdateBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_MemberUpdate_Load(object sender, EventArgs e)
        {
            bll_member = new Bll_Member(clsMain.path);
            txt_FullName.Text = fullName;
            cbox_Gender.SelectedItem = gender;
            dtp_DateOfBirth.Value = dateOfBirth;
            txt_Email.Text = email;
            txt_Phone.Text = phone;
            dtp_JoinDate.Value = joinDate;
            /////////////////////////////////////////////////
            txt_FullName.Focus();
            txt_FullName.Select(txt_FullName.Text.Length, 0);
        }

        private void updateMemberBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the modified member information from the form controls
                string newFullName = txt_FullName.Text;
                string newGender = cbox_Gender.SelectedItem.ToString();
                DateTime newDateOfBirth = dtp_DateOfBirth.Value;
                string newEmail = txt_Email.Text;
                string newPhone = txt_Phone.Text;
                DateTime newJoinDate = dtp_JoinDate.Value;

                // Check if any information has changed
                if (newFullName == fullName &&
                    newGender == gender &&
                    newDateOfBirth == dateOfBirth &&
                    newEmail == email &&
                    newPhone == phone &&
                    newJoinDate == joinDate)
                {
                    // Nothing was changed
                    Frm_Messages noti = new Frm_Messages();
                    noti.StartPosition = FormStartPosition.CenterParent;
                    noti.TitleText = "GYM APP";
                    noti.MessageText = "Nothing was changed!";
                    Task.Delay(200).ContinueWith(_ =>
                    {
                        var anim = new Transition(new TransitionType_CriticalDamping(300));
                        anim.add(noti, "Top", 500);
                        anim.run();
                        noti.ShowDialog();
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                    return; // Skip the update process
                }

                // Call the appropriate method from your business layer to update the member's information
                int result = bll_member.UpdateMemberToDGV(ref err, new Member()
                {
                    MemberID = memberID,
                    FullName = newFullName,
                    Gender = newGender,
                    DateOfBirth = newDateOfBirth,
                    Email = newEmail,
                    Phone = newPhone,
                    JoinDate = newJoinDate
                });

                if (result > 0)
                {
                    // Member updated successfully
                    Frm_Messages noti = new Frm_Messages();
                    noti.StartPosition = FormStartPosition.CenterParent;
                    noti.TitleText = "SUCCESS";
                    noti.MessageText = "A member has been updated!";
                    Task.Delay(150).ContinueWith(_ =>
                    {
                        var anim = new Transition(new TransitionType_CriticalDamping(300));
                        anim.add(noti, "Top", 500);
                        anim.run();
                        noti.ShowDialog();
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                    parentForm.refreshMemberDataGridView();
                    parentForm.LoadAllMembersData();
                    this.Close();
                }
                else
                {
                    // Error occurred while updating member
                    Frm_Messages noti = new Frm_Messages();
                    noti.StartPosition = FormStartPosition.CenterParent;
                    noti.TitleText = "ERROR";
                    noti.MessageText = "Error updating member!";
                    Task.Delay(150).ContinueWith(_ =>
                    {
                        var anim = new Transition(new TransitionType_CriticalDamping(300));
                        anim.add(noti, "Top", 500);
                        anim.run();
                        noti.ShowDialog();
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                }
            }
            catch (Exception ex)
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "ERROR";
                noti.MessageText = "An error occured " + ex.Message;
                Task.Delay(150).ContinueWith(_ =>
                {
                    var anim = new Transition(new TransitionType_CriticalDamping(300));
                    anim.add(noti, "Top", 500);
                    anim.run();
                    noti.ShowDialog();
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }
    }
}
