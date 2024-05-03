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
    public partial class Frm_MembersAdd : Form
    {
        Bll_Member bll_member;
        public Frm_MembersManager ParentForm { get; set; }
        public Frm_MembersAdd()
        {
            InitializeComponent();
        }
        private void Frm_MembersAdd_Load(object sender, EventArgs e)
        {
            bll_member = new Bll_Member(clsMain.path);
        }

        private void cancelAddBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void addMemberBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any required fields are empty
                if (string.IsNullOrWhiteSpace(txt_FullName.Text) ||
                    cbox_Gender.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txt_Email.Text) ||
                    string.IsNullOrWhiteSpace(txt_Phone.Text) )
                {
                    // Notify the user about missing information
                    Frm_Messages noti = new Frm_Messages();
                    noti.StartPosition = FormStartPosition.CenterParent;
                    noti.TitleText = "GYM APP";
                    noti.MessageText = "Please fill in all required fields!";
                    Task.Delay(200).ContinueWith(_ =>
                    {
                        var anim = new Transition(new TransitionType_CriticalDamping(300));
                        anim.add(noti, "Top", 500);
                        anim.run();
                        noti.ShowDialog();
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                    return;
                }

                // Collect information from the user
                string fullName = txt_FullName.Text;
                string gender = cbox_Gender.SelectedItem.ToString();
                DateTime dateOfBirth = dtp_DateOfBirth.Value;
                string email = txt_Email.Text;
                string phone = txt_Phone.Text;
                DateTime joinDate = dtp_JoinDate.Value;

                // Create a new Member object with the collected information
                Member newMember = new Member()
                {
                    FullName = fullName,
                    Gender = gender,
                    DateOfBirth = dateOfBirth,
                    Email = email,
                    Phone = phone,
                    JoinDate = joinDate
                };

                // Call the AddOrUpdateMemberToDGV method to add the new member
                string err = string.Empty;
                int result = bll_member.AddMemberToDGV(ref err, newMember);

                if (result > 0)
                {
                    // Member added successfully
                    Frm_Messages noti = new Frm_Messages();
                    noti.StartPosition = FormStartPosition.CenterParent;
                    noti.TitleText = "SUCCESS";
                    noti.MessageText = "A new member has been added!";
                    Task.Delay(150).ContinueWith(_ =>
                    {
                        var anim = new Transition(new TransitionType_CriticalDamping(300));
                        anim.add(noti, "Top", 500);
                        anim.run();
                        noti.ShowDialog();
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                    ParentForm?.refreshMemberDataGridView();
                    ParentForm?.LoadAllMembersData();
                    this.Close();
                }
                else
                {
                    // Error occurred while adding member
                    Frm_Messages noti = new Frm_Messages();
                    noti.StartPosition = FormStartPosition.CenterParent;
                    noti.TitleText = "ERROR";
                    noti.MessageText = "Error adding member!";
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
                noti.MessageText = "An error occured "+ex.Message;
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
