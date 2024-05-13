using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace BaiTapQuanLy.Forms
{
    public partial class Frm_MemershipPackageControls : Form
    {
        private int memberID, packageID;
        private string memberName;
        private double packagePrice;
        private Frm_MembersManager parentForm;
        public Frm_MemershipPackageControls(int memberID, int packageID, string memberName, double packagePrice, Frm_MembersManager parentForm)
        {
            InitializeComponent();
            this.memberID = memberID;   
            this.packageID = packageID;
            this.memberName = memberName;
            this.packagePrice = packagePrice;
            this.parentForm = parentForm;
        }

        public Guna2GradientPanel GradientContolsPanel
        {
            get { return topGradientPanel; }
            set { topGradientPanel = value; }
        }

        public Label PackageName
        {
            get { return lblPackageName; }
            set { lblPackageName = value; }
        }

        public Label MembershipType
        {
            get { return lblMembershipType; }
            set { lblMembershipType = value; }
        }

        public Label PackageDuration
        {
            get { return lblPackageDuration; }
            set { lblPackageDuration = value; }
        }

        public Label PackagePrice
        {
            get { return lblPackagePrice; }
            set { lblPackagePrice = value; }
        }

        public Guna2GradientButton ButtonBuyPackage
        {
            get { return btnGradientBuyPackage; }
            set { btnGradientBuyPackage = value; }
        }

        private void btnGradientBuyPackage_Click(object sender, EventArgs e)
        {
            if(packageID == 1)
            {
                Frm_MembershipPurchaseConfirmation frm_confirm = new Frm_MembershipPurchaseConfirmation(memberID, memberName, packageID, packagePrice, parentForm);
                var anim = new Transition(new TransitionType_Deceleration(200));
                anim.add(frm_confirm, "Top", 400);
                frm_confirm.topPanel.FillColor = Color.FromArgb(255, 128, 0);
                frm_confirm.topPanel.FillColor2 = Color.FromArgb(192, 64, 0);
                frm_confirm.buyPackageBTN.FillColor = Color.FromArgb(255, 128, 0);
                frm_confirm.buyPackageBTN.FillColor2 = Color.FromArgb(192, 64, 0);
                frm_confirm.membershipType = "Membership Type: Bronze";
                frm_confirm.durationMembership = "Duration: 1 day";
                string formattedPrice = packagePrice.ToString("N0"); // Format price as VND
                frm_confirm.membershipPrice = "Price: " + formattedPrice + "đ";
                anim.run();
                frm_confirm.ShowDialog();
            } else if (packageID == 2)
            {
                Frm_MembershipPurchaseConfirmation frm_confirm = new Frm_MembershipPurchaseConfirmation(memberID, memberName, packageID, packagePrice, parentForm);
                var anim = new Transition(new TransitionType_Deceleration(200));
                anim.add(frm_confirm, "Top", 400);
                frm_confirm.topPanel.FillColor = Color.Silver;
                frm_confirm.topPanel.FillColor2 = Color.Gray;
                frm_confirm.buyPackageBTN.FillColor = Color.Silver;
                frm_confirm.buyPackageBTN.FillColor2 = Color.Gray;
                frm_confirm.membershipType = "Membership Type: Silver";
                frm_confirm.durationMembership = "Duration: 1 month";
                string formattedPrice = packagePrice.ToString("N0"); // Format price as VND
                frm_confirm.membershipPrice = "Price: " + formattedPrice + "đ";
                anim.run();
                frm_confirm.ShowDialog();
            } else if (packageID == 3)
            {
                Frm_MembershipPurchaseConfirmation frm_confirm = new Frm_MembershipPurchaseConfirmation(memberID, memberName, packageID, packagePrice, parentForm);
                var anim = new Transition(new TransitionType_Deceleration(200));
                anim.add(frm_confirm, "Top", 400);
                frm_confirm.topPanel.FillColor = Color.Gold;
                frm_confirm.topPanel.FillColor2 = Color.Goldenrod;
                frm_confirm.buyPackageBTN.FillColor = Color.Gold;
                frm_confirm.buyPackageBTN.FillColor2 = Color.Goldenrod;
                frm_confirm.membershipType = "Membership Type: Gold";
                frm_confirm.durationMembership = "Duration: 3 months";
                string formattedPrice = packagePrice.ToString("N0"); // Format price as VND
                frm_confirm.membershipPrice = "Price: " + formattedPrice + "đ";
                anim.run();
                frm_confirm.ShowDialog();
            } else if(packageID == 4)
            {
                Frm_MembershipPurchaseConfirmation frm_confirm = new Frm_MembershipPurchaseConfirmation(memberID, memberName, packageID, packagePrice, parentForm);
                var anim = new Transition(new TransitionType_Deceleration(200));
                anim.add(frm_confirm, "Top", 400);
                frm_confirm.topPanel.FillColor = Color.SlateBlue;
                frm_confirm.topPanel.FillColor2 = Color.RoyalBlue;
                frm_confirm.buyPackageBTN.FillColor = Color.SlateBlue;
                frm_confirm.buyPackageBTN.FillColor2 = Color.RoyalBlue;
                frm_confirm.membershipType = "Membership Type: Premium";
                frm_confirm.durationMembership = "Duration: 6 months";
                string formattedPrice = packagePrice.ToString("N0"); // Format price as VND
                frm_confirm.membershipPrice = "Price: " + formattedPrice + "đ";
                anim.run();
                frm_confirm.ShowDialog();
            } else if(packageID == 5)
            {
                Frm_MembershipPurchaseConfirmation frm_confirm = new Frm_MembershipPurchaseConfirmation(memberID, memberName, packageID, packagePrice, parentForm);
                var anim = new Transition(new TransitionType_Deceleration(200));
                anim.add(frm_confirm, "Top", 400);
                frm_confirm.topPanel.FillColor = Color.BlueViolet;
                frm_confirm.topPanel.FillColor2 = Color.Fuchsia;
                frm_confirm.buyPackageBTN.FillColor = Color.BlueViolet ;
                frm_confirm.buyPackageBTN.FillColor2 = Color.Fuchsia;
                frm_confirm.membershipType = "Membership Type: Deluxe";
                frm_confirm.durationMembership = "Duration: 1 year";
                string formattedPrice = packagePrice.ToString("N0"); // Format price as VND
                frm_confirm.membershipPrice = "Price: " + formattedPrice + "đ";
                anim.run();
                frm_confirm.ShowDialog();
            }
        }
    }
}
