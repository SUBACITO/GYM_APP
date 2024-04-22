using BaiTapQuanLy.BussinessLayer;
using BaiTapQuanLy.DTO;
using DevComponents.DotNetBar.Controls;
using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BaiTapQuanLy.Forms
{
    public partial class Frm_MembersManager : Form
    {
        Bll_HeThong bll_heThong;
        string err = string.Empty;
        private bool selectionChanged;
        public Frm_MembersManager()
        {
            InitializeComponent();
        }
        private void Frm_MembersManager_Shown(object sender, EventArgs e)
        {
            dgvMembers.ClearSelection();
        }

        private void Frm_MembersManager_Load(object sender, EventArgs e)
        {
            bll_heThong = new Bll_HeThong(clsMain.path);
            DisplayMembersToDGV();
        }
        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!selectionChanged)
            {
                dgvMembers.ClearSelection();
                selectionChanged = true;
            } else
            {
                selectionChanged = false;
            }
        }

        private void dgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            selectionChanged = true;
        }

        private void DisplayMembersToDGV()
        {
            DataTable dtMember = new DataTable();
            dtMember = bll_heThong.GetMembersListToDGV(ref err);
            dgvMembers.DataSource = dtMember.DefaultView;
        }

        internal void refreshMemberDataGridView()
        {
            DataTable dtMember = bll_heThong.GetMembersListToDGV(ref err);
            dgvMembers.DataSource = dtMember.DefaultView;
        }

        private void addMemberBTN_Click(object sender, EventArgs e)
        {
            if(dgvMembers.SelectedRows.Count == 0)
            {
            Frm_MembersAdd frmMemAdd = new Frm_MembersAdd();
            frmMemAdd.ParentForm = this;
            frmMemAdd.StartPosition = FormStartPosition.CenterParent;
            var anim = new Transition(new TransitionType_CriticalDamping(500));
            anim.add(frmMemAdd, "Top", 300);
            anim.run();
            frmMemAdd.ShowDialog();
            } else
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "NOTIFICATION";
                noti.MessageText = "Deselect an item to add a new member";
                var anim = new Transition(new TransitionType_Deceleration(300));
                anim.add(noti, "Top", 500);
                anim.run();
                noti.ShowDialog();
            }
        }

        private void editMemberBTN_Click(object sender, EventArgs e)
        {
            if(dgvMembers.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgvMembers.SelectedRows[0];
                int memberID = Convert.ToInt32(selectedRow.Cells["colMemberID"].Value);
                string fullName = Convert.ToString(selectedRow.Cells["colFullName"].Value);
                string gender = Convert.ToString(selectedRow.Cells["colGender"].Value);
                DateTime dateOfBirth = Convert.ToDateTime(selectedRow.Cells["colDateOfBirth"].Value);
                string email = Convert.ToString(selectedRow.Cells["colEmail"].Value);
                string phone = Convert.ToString(selectedRow.Cells["colPhone"].Value);
                DateTime joinDate = Convert.ToDateTime(selectedRow.Cells["colJoinDate"].Value);
                string membershipType = Convert.ToString(selectedRow.Cells["colMembershipType"].Value);

                Frm_MemberUpdate frmMemUpdate = new Frm_MemberUpdate(memberID, fullName, gender, dateOfBirth, email, phone, joinDate, membershipType);
                frmMemUpdate.ParentForm = this;
                frmMemUpdate.StartPosition = FormStartPosition.CenterParent;
                var anim = new Transition(new TransitionType_CriticalDamping(500));
                anim.add(frmMemUpdate, "Top", 300);
                anim.run();
                frmMemUpdate.ShowDialog();
            } else
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "NOTIFICATION";
                noti.MessageText = "Select a member to edit";
                var anim = new Transition(new TransitionType_Deceleration(300));
                anim.add(noti, "Top", 500);
                anim.run();
                noti.ShowDialog();
            }
        }

        private void deleteMemberBTN_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 1)
            {
                int memberID = Convert.ToInt32(dgvMembers.SelectedRows[0].Cells["colMemberID"].Value);

                int result = bll_heThong.DeleteMemberFromDGV(ref err, new Member()
                {
                    MemberID = memberID
                });
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "SUCCESS";
                noti.MessageText = "A member has been deleted";
                var anim = new Transition(new TransitionType_Deceleration(300));
                anim.add(noti, "Top", 500);
                anim.run();
                noti.ShowDialog();
                refreshMemberDataGridView();
            }
            else
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "NOTIFICATION";
                noti.MessageText = "Select a member to delete";
                var anim = new Transition(new TransitionType_Deceleration(300));
                anim.add(noti, "Top", 500);
                anim.run();
                noti.ShowDialog();
            }
        }
    }
}
