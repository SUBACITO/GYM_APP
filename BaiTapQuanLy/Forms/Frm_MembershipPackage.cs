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
    public partial class Frm_MembershipPackage : Form
    {
        private int memberID;
        private string userName;
        public Frm_MembersManager ParentForm { get; set; }
        public Frm_MembershipPackage(int memberID, string userName)
        {
            InitializeComponent();
            this.memberID = memberID;
            this.userName = userName;
        }

        private void Frm_MembershipPackage_Load(object sender, EventArgs e)
        {
            lblForUser.Text = "For " + userName + " - ID: " + memberID;
        }

        private void buyBronzePackageBTN_Click(object sender, EventArgs e)
        {
            int packageID = 1;
            Frm_MembershipPurchaseConfirmation frm_confirmPurchase = new Frm_MembershipPurchaseConfirmation(memberID, userName, packageID);
            var anim = new Transition(new TransitionType_Deceleration(200));
            anim.add(frm_confirmPurchase, "Top", 400);
            anim.run();
            frm_confirmPurchase.topPanel.FillColor = Color.FromArgb(255, 128, 0);
            frm_confirmPurchase.topPanel.FillColor2 = Color.FromArgb(192, 64, 0);
            frm_confirmPurchase.buyPackageBTN.FillColor = Color.FromArgb(255, 128, 0);
            frm_confirmPurchase.buyPackageBTN.FillColor2 = Color.FromArgb(192, 64, 0);
            frm_confirmPurchase.membershipType = "Membership Type: Bronze";
            frm_confirmPurchase.durationMembership = "Duration: 1 Day";
            DialogResult result = frm_confirmPurchase.ShowDialog();  
            if (result == DialogResult.OK)
            {
                ParentForm?.refreshMemberDataGridView();
                this.Close();
            }
        }

        private void buySilverPackageBTN_Click(object sender, EventArgs e)
        {
            int packageID = 2;
            Frm_MembershipPurchaseConfirmation frm_confirmPurchase = new Frm_MembershipPurchaseConfirmation(memberID, userName, packageID);
            var anim = new Transition(new TransitionType_Deceleration(200));
            anim.add(frm_confirmPurchase, "Top", 400);
            anim.run();
            frm_confirmPurchase.topPanel.FillColor = Color.Silver;
            frm_confirmPurchase.topPanel.FillColor2 = Color.Gray;
            frm_confirmPurchase.buyPackageBTN.FillColor = Color.Silver;
            frm_confirmPurchase.buyPackageBTN.FillColor2 = Color.Gray;
            frm_confirmPurchase.membershipType = "Membership Type: Silver";
            frm_confirmPurchase.durationMembership = "Duration: 1 Month";
            DialogResult result = frm_confirmPurchase.ShowDialog();
            if (result == DialogResult.OK)
            {
                ParentForm?.refreshMemberDataGridView();
                this.Close();
            }
        }

        private void buyGoldPackageBTN_Click(object sender, EventArgs e)
        {
            int packageID = 3;
            Frm_MembershipPurchaseConfirmation frm_confirmPurchase = new Frm_MembershipPurchaseConfirmation(memberID, userName, packageID);
            var anim = new Transition(new TransitionType_Deceleration(200));
            anim.add(frm_confirmPurchase, "Top", 400);
            anim.run();
            frm_confirmPurchase.topPanel.FillColor = Color.Gold;
            frm_confirmPurchase.topPanel.FillColor2 = Color.Goldenrod;
            frm_confirmPurchase.buyPackageBTN.FillColor = Color.Gold;
            frm_confirmPurchase.buyPackageBTN.FillColor2 = Color.Goldenrod;
            frm_confirmPurchase.membershipType = "Membership Type: Gold";
            frm_confirmPurchase.durationMembership = "Duration: 3 Months";
            DialogResult result = frm_confirmPurchase.ShowDialog();
            if (result == DialogResult.OK)
            {
                ParentForm?.refreshMemberDataGridView();
                this.Close();
            }
        }

        private void buyPremiumPackageBTN_Click(object sender, EventArgs e)
        {
            int packageID = 4;
            Frm_MembershipPurchaseConfirmation frm_confirmPurchase = new Frm_MembershipPurchaseConfirmation(memberID, userName, packageID);
            var anim = new Transition(new TransitionType_Deceleration(200));
            anim.add(frm_confirmPurchase, "Top", 400);
            anim.run();
            frm_confirmPurchase.topPanel.FillColor = Color.SlateBlue;
            frm_confirmPurchase.topPanel.FillColor2 = Color.RoyalBlue;
            frm_confirmPurchase.buyPackageBTN.FillColor = Color.SlateBlue;
            frm_confirmPurchase.buyPackageBTN.FillColor2 = Color.RoyalBlue;
            frm_confirmPurchase.membershipType = "Membership Type: Premium";
            frm_confirmPurchase.durationMembership = "Duration: 6 Months";
            DialogResult result = frm_confirmPurchase.ShowDialog();
            if (result == DialogResult.OK)
            {
                ParentForm?.refreshMemberDataGridView();
                this.Close();
            }
        }

        private void buyDeluxePackageBTN_Click(object sender, EventArgs e)
        {
            int packageID = 5;
            Frm_MembershipPurchaseConfirmation frm_confirmPurchase = new Frm_MembershipPurchaseConfirmation(memberID, userName, packageID);
            var anim = new Transition(new TransitionType_Deceleration(200));
            anim.add(frm_confirmPurchase, "Top", 400);
            anim.run();
            frm_confirmPurchase.topPanel.FillColor = Color.BlueViolet;
            frm_confirmPurchase.topPanel.FillColor2 = Color.Fuchsia;
            frm_confirmPurchase.buyPackageBTN.FillColor = Color.BlueViolet;
            frm_confirmPurchase.buyPackageBTN.FillColor2 = Color.Fuchsia;
            frm_confirmPurchase.membershipType = "Membership Type: Deluxe";
            frm_confirmPurchase.durationMembership = "Duration: 1 Year";
            DialogResult result = frm_confirmPurchase.ShowDialog();
            if (result == DialogResult.OK)
            {
                ParentForm?.refreshMemberDataGridView();
                this.Close();
            }
        }
    }
}
