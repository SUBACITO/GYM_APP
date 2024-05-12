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
        Bll_Member bll_member;
        string err = string.Empty;
        private bool selectionChanged;
        private DataTable allMembersData;

        public Frm_MembersManager(Bll_Member bll_mem)
        {
            InitializeComponent();
            this.bll_member = bll_mem;
        }
        private void Frm_MembersManager_Shown(object sender, EventArgs e)
        {
            dgvMembers.ClearSelection();
        }

        private void Frm_MembersManager_Load(object sender, EventArgs e)
        {
            bll_member = new Bll_Member(clsMain.path);
            LoadAllMembersData();
            DisplayMembersToDGV();
            cboxGenderFilter.SelectedIndex = 0;
            cboxGenderFilter_SelectedIndexChanged(this, EventArgs.Empty);
            cboxMembershipType.SelectedIndex = 0;
            cboxMembershipType_SelectedIndexChanged(this, EventArgs.Empty);
            cboxMembershipExpireState.SelectedIndex = 0;
            cboxMembershipExpireState_SelectedIndexChanged(this, EventArgs.Empty);
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
            allMembersData = bll_member.GetMembersListToDGV(ref err);
            dgvMembers.ClearSelection();
        }

        private void DisplayMembersToDGV()
        {
            dgvMembers.DataSource = allMembersData;
        }

        internal void refreshMemberDataGridView()
        {
            DataTable dtMember = bll_member.GetMembersListToDGV(ref err);
            dgvMembers.DataSource = dtMember.DefaultView;
            dgvMembers.ClearSelection();
        }


        ///////////////////////////////////////////////////// Filters 

        //Filters gender in datagridview
        string selectedGender;
        string selectedMembershipType;
        string selectedMembershipStatus;
        string searchText = "";
        private void cboxGenderFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGender = cboxGenderFilter.SelectedItem?.ToString();
            updateGenderFilter();
        }

        private void updateGenderFilter()
        {
            DataTable filteredData;

            if (selectedGender == "All")
            {
                // When "All" is selected for gender, reset the selected gender and update the filter based on membership type
                selectedGender = "All";
                if (selectedMembershipType == "All")
                {
                    // Show all members without filtering
                    filteredData = allMembersData.Copy();
                }
                else
                {
                    // Filter by membership type only
                    filteredData = FilterMembersByMembershipType(selectedMembershipType, allMembersData);
                }
            }
            else
            {
                filteredData = FilterMembersByGenderAndMembershipType(selectedGender, selectedMembershipType);
            }

            // Apply search criteria to the filtered data
            ApplySearchCriteria(filteredData);

            dgvMembers.DataSource = filteredData;
            dgvMembers.ClearSelection();
        }

        //// FIlter for membership Type
        private void cboxMembershipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMembershipType = cboxMembershipType.SelectedItem.ToString();
            updateMembershipFilter();
        }

        private void updateMembershipFilter()
        {
            DataTable filteredData;

            if (selectedMembershipType == "All")
            {
                // When "All" is selected for membership type, retain the previously selected gender filter
                if (selectedGender == "All")
                {
                    // Show all members without filtering
                    filteredData = allMembersData.Copy();
                }
                else
                {
                    // Apply gender filter only
                    filteredData = FilterMembersByGender(selectedGender, allMembersData);
                }
            }
            else
            {
                // Filter by membership type
                filteredData = FilterMembersByMembershipType(selectedMembershipType, allMembersData);

                // If a specific gender filter is applied, further filter by gender
                if (selectedGender != "All")
                {
                    filteredData = FilterMembersByGender(selectedGender, filteredData);
                }
            }

            // Apply search criteria to the filtered data
            ApplySearchCriteria(filteredData);

            dgvMembers.DataSource = filteredData;
            dgvMembers.ClearSelection();

            // Update the gender filter
            updateGenderFilter();
        }

        /// Filter for membership status
        private void cboxMembershipExpireState_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMembershipStatus = cboxMembershipExpireState.SelectedItem.ToString();
            updateMembershipStatusFilter();
        }

        private void updateMembershipStatusFilter()
        {
            DataTable filteredData;

            if (selectedMembershipStatus == "None")
            {
                filteredData = allMembersData.Copy();
            }
            else if (selectedMembershipStatus == "7 days left")
            {
                // Filter members expiring in the next 7 days
                filteredData = FilterMembersExpiringInNextSevenDays();
            }
            else if (selectedMembershipStatus == "Expired")
            {
                // Filter expired members
                filteredData = FilterExpiredMembers();
            }
            else
            {
                filteredData = allMembersData.Copy();
            }
            ApplySearchCriteria(filteredData);
            dgvMembers.DataSource = filteredData;
            dgvMembers.ClearSelection();
        }


        private DataTable FilterMembersByGender(string gender, DataTable data)
        {
            DataTable filteredData = data.Clone();
            foreach (DataRow row in data.Rows)
            {
                if (row.Field<string>("Gender") == gender)
                {
                    filteredData.ImportRow(row);
                }
            }
            return filteredData;
        }

        private DataTable FilterMembersByMembershipType(string membershipType, DataTable data)
        {
            DataTable filteredData = data.Clone();
            foreach (DataRow row in data.Rows)
            {
                if (row.Field<string>("MembershipType") == membershipType)
                {
                    filteredData.ImportRow(row);
                }
            }
            return filteredData;
        }


        private DataTable FilterMembersByGenderAndMembershipType(string gender, string membershipType)
        {
            DataTable filteredData = allMembersData.Clone();
            foreach (DataRow row in allMembersData.Rows)
            {
                string memberGender = row.Field<string>("Gender");
                string memberMembershipType = row.Field<string>("MembershipType");

                // Check if the member's gender and membership type match the selected filters
                bool genderMatch = selectedGender == "All" || memberGender == (selectedGender == "Male" ? "Nam" : "Nữ");
                bool membershipTypeMatch = selectedMembershipType == "All" || memberMembershipType == selectedMembershipType;

                if (genderMatch && membershipTypeMatch)
                {
                    filteredData.ImportRow(row);
                }
            }
            return filteredData;
        }

        private DataTable FilterMembersExpiringInNextSevenDays()
        {
            DataTable filteredData = allMembersData.Clone();
            DateTime today = DateTime.Today;

            foreach (DataRow row in allMembersData.Rows)
            {
                // Check if the expiration date is not null
                if (!row.IsNull("expiredDate"))
                {
                    DateTime expiredDate = row.Field<DateTime>("expiredDate");
                    int daysUntilExpiration = (expiredDate - today).Days;

                    if (daysUntilExpiration > 0 && daysUntilExpiration <= 7)
                    {
                        filteredData.ImportRow(row);
                    }
                }
            }

            return filteredData;
        }

        private DataTable FilterExpiredMembers()
        {
            DataTable filteredData = allMembersData.Clone();
            DateTime today = DateTime.Today.Date;

            foreach (DataRow row in allMembersData.Rows)
            {
                // Check if the expiration date is not null
                if (!row.IsNull("expiredDate"))
                {
                    DateTime expiredDate = row.Field<DateTime>("expiredDate").Date;

                    if (expiredDate < today)
                    {
                        filteredData.ImportRow(row);
                    }
                }
            }

            return filteredData;
        }

        private void ApplySearchCriteria(DataTable data)
        {
            if (data == null)
            {
                // If the data is null, display an empty table
                dgvMembers.DataSource = null;
                return;
            }

            string searchText = searchBarTxT.Text.Trim().ToLower(); // Get the entered search text
            string nameKeyword = searchText;
            string email = searchText;
            string phoneNum = searchText;

            for (int i = data.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = data.Rows[i];
                string fullName = row.Field<string>("FullName").ToLower();
                string memberPhone = row.Field<string>("Phone");
                string memberEmail = row.Field<string>("Email").ToLower();

                // Check if the row matches the search criteria based on the entered search text
                bool matchesSearchCriteria = (
                    fullName.Contains(nameKeyword) || // Check if the full name contains the search text
                    memberPhone.Contains(phoneNum) || // Check if the phone number contains the search text
                    memberEmail.Contains(email) // Check if the email contains the search text
                );

                if (!matchesSearchCriteria)
                {
                    data.Rows.RemoveAt(i);
                }
            }
        }

        private void searchBarTxT_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBarTxT.Text.Trim().ToLower(); // Get the entered search text
            dgvMembers.ClearSelection();

            // Filter the preloaded DataTable based on the search criteria
            DataTable filteredData = allMembersData.Clone();
            foreach (DataRow row in allMembersData.Rows)
            {
                string fullName = row.Field<string>("FullName").ToLower();
                string phoneNum = row.Field<string>("Phone");
                string email = row.Field<string>("Email").ToLower();

                // Check if the row matches the search criteria based on the entered search text
                bool matchesSearchCriteria = (
                    fullName.Contains(searchText) || // Check if the full name contains the search text
                    phoneNum.Contains(searchText) || // Check if the phone number contains the search text
                    email.Contains(searchText) // Check if the email contains the search text
                );

                // Apply additional filters if necessary
                if (matchesSearchCriteria)
                {
                    string memberGender = row.Field<string>("Gender");
                    string memberMembershipType = row.Field<string>("MembershipType");

                    // Check if the member's gender matches the selected gender filter, or if the filter is "All"
                    bool genderMatch = selectedGender == "All" || memberGender == (selectedGender == "Male" ? "Nam" : "Nữ");

                    // Check if the member's membership type matches the selected membership type filter, or if the filter is "All"
                    bool membershipTypeMatch = selectedMembershipType == "All" || memberMembershipType == selectedMembershipType;

                    // Apply additional filters based on gender and membership type
                    if (genderMatch && membershipTypeMatch)
                    {
                        filteredData.ImportRow(row);
                    }
                }
            }

            if (filteredData.Rows.Count > 0)
            {
                dgvMembers.DataSource = filteredData;
                dgvMembers.AutoResizeColumns();
            }
            else
            {
                // If no matching results, clear the DataGridView
                dgvMembers.DataSource = null;
            }

            dgvMembers.ClearSelection();
        }

       
        ///Add, Edit and Delete Members

        private void addMemberBTN_Click(object sender, EventArgs e)
        {
            addMemberBTN.Enabled = false;
            if(dgvMembers.SelectedRows.Count == 0)
            {
            Frm_MembersAdd frmMemAdd = new Frm_MembersAdd(this);
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
            addMemberBTN.Enabled = true;
        }

        private void editMemberBTN_Click(object sender, EventArgs e)
        {
            editMemberBTN.Enabled = false;

            if (dgvMembers.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgvMembers.SelectedRows[0];

                // Retrieve data using column indexes instead of names
                int memberID = Convert.ToInt32(selectedRow.Cells[0].Value); 
                string fullName = Convert.ToString(selectedRow.Cells[1].Value); 
                string gender = Convert.ToString(selectedRow.Cells[2].Value); 
                DateTime dateOfBirth = Convert.ToDateTime(selectedRow.Cells[3].Value); 
                string email = Convert.ToString(selectedRow.Cells[4].Value); 
                string phone = Convert.ToString(selectedRow.Cells[5].Value); 
                DateTime joinDate = Convert.ToDateTime(selectedRow.Cells[6].Value); 

                Frm_MemberUpdate frmMemUpdate = new Frm_MemberUpdate(memberID, fullName, gender, dateOfBirth, email, phone, joinDate, this);
                frmMemUpdate.StartPosition = FormStartPosition.CenterParent;
                var anim = new Transition(new TransitionType_EaseInEaseOut(400));
                anim.add(frmMemUpdate, "Top", 300);
                anim.run();
                frmMemUpdate.ShowDialog();
            }
            else
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
            editMemberBTN.Enabled = true;
        }

        private void addMembershipToMemberBTN_Click(object sender, EventArgs e)
        {
            addMembershipToMemberBTN.Enabled = false;
            if (dgvMembers.SelectedRows.Count == 1)
            { 
                int memberID = Convert.ToInt32(dgvMembers.SelectedRows[0].Cells["colMemberID"].Value);
                string userName = dgvMembers.SelectedRows[0].Cells["colFullName"].Value.ToString();
                Frm_MembershipPackage frm_membershipPackage = new Frm_MembershipPackage(memberID, userName, this);
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
            addMembershipToMemberBTN.Enabled = true;
        }
        private void deleteMemberBTN_Click(object sender, EventArgs e)
        {
            deleteMemberBTN.Enabled = false;
            if (dgvMembers.SelectedRows.Count == 1)
            {
                int memberID = Convert.ToInt32(dgvMembers.SelectedRows[0].Cells["colMemberID"].Value);
                string userName = dgvMembers.SelectedRows[0].Cells["colFullName"].Value.ToString();

                Frm_Messages delete_confirm = new Frm_Messages();
                delete_confirm.StartPosition = FormStartPosition.CenterParent;
                delete_confirm.TitleText = "Delete Member?";
                delete_confirm.MessageText = userName + " - ID: " + memberID;
                var anim = new Transition(new TransitionType_CriticalDamping(300));
                anim.add(delete_confirm, "Top", 500);
                anim.run();

                if (delete_confirm.ShowDialog() == DialogResult.OK)
                {
                    int result = bll_member.DeleteMemberFromDGV(ref err, new Member()
                    {
                        MemberID = memberID
                    });

                    Frm_Messages noti = new Frm_Messages();
                    noti.StartPosition = FormStartPosition.CenterParent;
                    noti.TitleText = "GYM APP";
                    noti.MessageText = userName + " has been deleted!";
                    Task.Delay(150).ContinueWith(_ =>
                    {
                        anim = new Transition(new TransitionType_CriticalDamping(300));
                        anim.add(noti, "Top", 500);
                        anim.run();
                        noti.ShowDialog();
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                    LoadAllMembersData();
                    refreshMemberDataGridView();
                }
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
            deleteMemberBTN.Enabled = true;
        }
    }
}
