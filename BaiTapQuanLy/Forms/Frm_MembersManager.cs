using BaiTapQuanLy.BussinessLayer;
using BaiTapQuanLy.DTO;
using DevComponents.DotNetBar.Controls;
using Guna.UI2.WinForms;
using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
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
        private DataTable allMembersData;

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
            LoadAllMembersData();
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

        internal void LoadAllMembersData()
        {
            allMembersData = bll_heThong.GetMembersListToDGV(ref err);
        }

        private void DisplayMembersToDGV()
        {
            dgvMembers.DataSource = allMembersData;
        }

        internal void refreshMemberDataGridView()
        {
            DataTable dtMember = bll_heThong.GetMembersListToDGV(ref err);
            dgvMembers.DataSource = dtMember.DefaultView;
        }

        ///Search bar
        private void searchBarTxT_TextChanged(object sender, EventArgs e)
        {
            string keyword = searchBarTxT.Text.Trim().ToLower();
            dgvMembers.ClearSelection();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                // Filter the preloaded DataTable based on the search keyword
                DataTable filteredData = FilterMembersByName(keyword);
                dgvMembers.DataSource = filteredData;
            }
            else
            {
                DisplayMembersToDGV();
            }
        }

        private DataTable FilterMembersByName(string keyword)
        {
            DataTable filteredData = allMembersData.Clone(); // Create a clone of the original structure
            foreach (DataRow row in allMembersData.Rows)
            {
                string fullName = row.Field<string>("FullName").ToLower();
                if (fullName.Contains(keyword))
                {
                    filteredData.ImportRow(row);
                }
            }
            return filteredData;
        }


        ///Add, Edit and Delete Members

        private void addMemberBTN_Click(object sender, EventArgs e)
        {
            if(dgvMembers.SelectedRows.Count == 0)
            {
            Frm_MembersAdd frmMemAdd = new Frm_MembersAdd();
            frmMemAdd.ParentForm = this;
            frmMemAdd.StartPosition = FormStartPosition.CenterParent;
            var anim = new Transition(new TransitionType_EaseInEaseOut(400));
            anim.add(frmMemAdd, "Top", 300);
            anim.run();
            frmMemAdd.ShowDialog();
            } else
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "GYM APP";
                noti.MessageText = "Deselect an item to add a new member!";
                Task.Delay(200).ContinueWith(_ =>
                {
                    var anim = new Transition(new TransitionType_CriticalDamping(300));
                    anim.add(noti, "Top", 500);
                    anim.run();
                    noti.ShowDialog();
                }, TaskScheduler.FromCurrentSynchronizationContext());
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

                Frm_MemberUpdate frmMemUpdate = new Frm_MemberUpdate(memberID, fullName, gender, dateOfBirth, email, phone, joinDate);
                frmMemUpdate.ParentForm = this;
                frmMemUpdate.StartPosition = FormStartPosition.CenterParent;
                var anim = new Transition(new TransitionType_EaseInEaseOut(400));
                anim.add(frmMemUpdate, "Top", 300);
                anim.run();
                frmMemUpdate.ShowDialog();
            } else
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "GYM APP";
                noti.MessageText = "Select a member to edit!";
                Task.Delay(200).ContinueWith(_ =>
                {
                    var anim = new Transition(new TransitionType_CriticalDamping(300));
                    anim.add(noti, "Top", 500);
                    anim.run();
                    noti.ShowDialog();
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }

        private void addMembershipToMemberBTN_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 1)
            { 
                int memberID = Convert.ToInt32(dgvMembers.SelectedRows[0].Cells["colMemberID"].Value);
                string userName = dgvMembers.SelectedRows[0].Cells["colFullName"].Value.ToString();
                Frm_MembershipPackage frm_membershipPackage = new Frm_MembershipPackage(memberID, userName);
                frm_membershipPackage.ParentForm = this;
                frm_membershipPackage.StartPosition = FormStartPosition.CenterParent;
                frm_membershipPackage.ShowDialog();
            }
            else
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "GYM APP";
                noti.MessageText = "Select a member to add memership!";
                Task.Delay(200).ContinueWith(_ =>
                {
                    var anim = new Transition(new TransitionType_CriticalDamping(300));
                    anim.add(noti, "Top", 500);
                    anim.run();
                    noti.ShowDialog();
                }, TaskScheduler.FromCurrentSynchronizationContext());
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
                noti.TitleText = "GYM APP";
                noti.MessageText = "A member has been deleted!";
                Task.Delay(150).ContinueWith(_ =>
                {
                    var anim = new Transition(new TransitionType_CriticalDamping(300));
                    anim.add(noti, "Top", 500);
                    anim.run();
                    noti.ShowDialog();
                }, TaskScheduler.FromCurrentSynchronizationContext());
                LoadAllMembersData();
                refreshMemberDataGridView();
            }
            else
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "GYM APP";
                noti.MessageText = "Select a member to delete!";
                Task.Delay(200).ContinueWith(_ =>
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
