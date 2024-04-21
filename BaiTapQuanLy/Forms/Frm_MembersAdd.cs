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
        Bll_HeThong bll_heThong;
        public Frm_MembersManager ParentForm { get; set; }
        public Frm_MembersAdd()
        {
            InitializeComponent();
        }
        private void Frm_MembersAdd_Load(object sender, EventArgs e)
        {
            bll_heThong = new Bll_HeThong(clsMain.path);
        }

        private void cancelAddBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void addMemberBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect information from the user
                string fullName = txt_FullName.Text;
                string gender = cbox_Gender.SelectedItem.ToString();
                DateTime dateOfBirth = dtp_DateOfBirth.Value;
                string email = txt_Email.Text;
                string phone = txt_Phone.Text;
                DateTime joinDate = dtp_JoinDate.Value;
                string membershipType = cbox_MembershipType.Text;

                // Create a new Member object with the collected information
                Member newMember = new Member()
                {
                    FullName = fullName,
                    Gender = gender,
                    DateOfBirth = dateOfBirth,
                    Email = email,
                    Phone = phone,
                    JoinDate = joinDate,
                    MembershipType = membershipType
                };

                // Call the AddOrUpdateMemberToDGV method to add the new member
                string err = string.Empty;
                int result = bll_heThong.AddMemberToDGV(ref err, newMember);

                if (result > 0)
                {
                    // Member added successfully
                    ParentForm?.refreshMemberDataGridView();
                    MessageBox.Show("Member added successfully!", "Google", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    // Error occurred while adding member
                    MessageBox.Show("Error adding member: " + err, "Google", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Google", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
