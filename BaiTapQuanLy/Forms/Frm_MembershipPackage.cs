using BaiTapQuanLy.BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace BaiTapQuanLy.Forms
{
    public partial class Frm_MembershipPackage : Form
    {
        private int memberID;
        private string userName;
        Bll_Member bll_member;
        string err = string.Empty;
        private Frm_MembersManager parentForm;
        public Frm_MembershipPackage(int memberID, string userName, Frm_MembersManager parentForm)
        {
            InitializeComponent();
            bll_member = new Bll_Member(clsMain.path);
            this.memberID = memberID;
            this.userName = userName;
            this.parentForm = parentForm;
        }

        private void Frm_MembershipPackage_Load(object sender, EventArgs e)
        {
            lblForUser.Text = "For " + userName + " - ID: " + memberID;
            LoadPackage();
        }

        private void LoadPackage()
        {
            DataTable packageData = bll_member.GetPackage(ref err);

            if (packageData != null && packageData.Rows.Count > 0)
            {
                foreach (DataRow row in packageData.Rows)
                {
                    int packageId = Convert.ToInt32(row["PackageID"]);
                    double packagePrice = Convert.ToInt32(row["Price"]);
                    string formattedPrice = packagePrice.ToString("N0"); // Format price as VND

                    // Create an instance of Frm_MemershipPackageControls
                    Frm_MemershipPackageControls packageControl = new Frm_MemershipPackageControls(memberID, packageId, userName, packagePrice, parentForm);

                    // Set properties of packageControl with data from the current row
                    packageControl.PackageName.Text = "Package: " + row["PackageName"].ToString();
                    int duration = Convert.ToInt32(row["DurationInDays"]); // Convert duration to integer
                    string durationText = (duration == 1) ? "day" : "days"; // Determine text based on duration value
                    packageControl.PackageDuration.Text = "Duration: " + duration.ToString() + " " + durationText;
                    packageControl.PackagePrice.Text = "Package Price: " + formattedPrice + "đ";

                    packageControl.TopLevel = false;

                    if (packageId == 1)
                    {
                        packageControl.GradientContolsPanel.FillColor = Color.FromArgb(255, 128, 0);
                        packageControl.GradientContolsPanel.FillColor2 = Color.FromArgb(192, 64, 0);
                        packageControl.ButtonBuyPackage.FillColor = Color.FromArgb(255, 128, 0);
                        packageControl.ButtonBuyPackage.FillColor2 = Color.FromArgb(192, 64, 0);
                        packageControl.MembershipType.Text = "Bronze";
                    }
                    else if (packageId == 2)
                    {
                        packageControl.GradientContolsPanel.FillColor = Color.Silver;
                        packageControl.GradientContolsPanel.FillColor2 = Color.Gray;
                        packageControl.ButtonBuyPackage.FillColor = Color.Silver;
                        packageControl.ButtonBuyPackage.FillColor2 = Color.Gray;
                        packageControl.MembershipType.Text = "Silver";
                    }
                    else if (packageId == 3)
                    {
                        packageControl.GradientContolsPanel.FillColor = Color.Gold;
                        packageControl.GradientContolsPanel.FillColor2 = Color.Goldenrod;
                        packageControl.ButtonBuyPackage.FillColor = Color.Gold;
                        packageControl.ButtonBuyPackage.FillColor2 = Color.Goldenrod;
                        packageControl.MembershipType.Text = "Gold";
                    }
                    else if (packageId == 4)
                    {
                        packageControl.GradientContolsPanel.FillColor = Color.SlateBlue;
                        packageControl.GradientContolsPanel.FillColor2 = Color.RoyalBlue;
                        packageControl.ButtonBuyPackage.FillColor = Color.SlateBlue;
                        packageControl.ButtonBuyPackage.FillColor2 = Color.RoyalBlue;
                        packageControl.MembershipType.Text = "Premium";
                    }
                    else if (packageId == 5)
                    {
                        packageControl.GradientContolsPanel.FillColor = Color.BlueViolet;
                        packageControl.GradientContolsPanel.FillColor2 = Color.Fuchsia;
                        packageControl.ButtonBuyPackage.FillColor = Color.BlueViolet;
                        packageControl.ButtonBuyPackage.FillColor2 = Color.Fuchsia;
                        packageControl.MembershipType.Text = "Deluxe";
                    }

                    // Add packageControl to the flowLayoutPanel
                    flowLayoutPanel.Controls.Add(packageControl);
                    packageControl.Show();
                }
            }
            else
            {
                // Handle case where no package data is retrieved
                MessageBox.Show("No package data available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshPackages()
        {
            // Clear existing controls before reloading
            flowLayoutPanel.Controls.Clear();
            // Reload packages
            LoadPackage();
        }

    }
}
