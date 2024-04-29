using BaiTapQuanLy.BussinessLayer;
using Guna.UI2.WinForms;
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
    public partial class Frm_MembershipPurchaseConfirmation : Form
    {
        private int memberID, packageID;
        private string userName;
        Bll_HeThong bll_heThong;
        private string err = string.Empty;

        public Frm_MembershipPurchaseConfirmation(int memberID, string userName, int packageID)
        {
            InitializeComponent();
            this.memberID = memberID;
            this.userName = userName;
            this.packageID = packageID;
        }

        public Guna2GradientPanel topPanel
        {
            get { return  (Guna2GradientPanel)confirmGradienTopPanel; }
            set { confirmGradienTopPanel = value; }
        }

        public Guna2GradientButton buyPackageBTN
        {
            get { return (Guna2GradientButton)buyConfirmPackageBTN; }
            set { buyConfirmPackageBTN = value; } 
        }

        public string membershipType
        {
            get { return lblMembershipType.Text; }
            set { lblMembershipType.Text = value; }
        }

        public string durationMembership
        {
            get { return lblMembershipDuration.Text; }
            set { lblMembershipDuration.Text = value;}
        }

        private void cancelPackagePurchaseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_MembershipPurchaseConfirmation_Load(object sender, EventArgs e)
        {
            bll_heThong = new Bll_HeThong(clsMain.path);
            lblUsername.Text = userName + " - ID: " + memberID;
        }

        private void buyConfirmPackageBTN_Click(object sender, EventArgs e)
        {
            int result = bll_heThong.BuyOrRenewPackage(ref err, memberID, packageID);
            if(result > 0 && packageID == 1) 
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "SUCCESS";
                noti.MessageText = "Bronze package has been purchased for member!";
                Task.Delay(200).ContinueWith(_ =>
                {
                    var anim = new Transition(new TransitionType_CriticalDamping(300));
                    anim.add(noti, "Top", 500);
                    anim.run();
                    noti.ShowDialog();
                }, TaskScheduler.FromCurrentSynchronizationContext());    
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else if(result > 0 && packageID == 2)
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "SUCCESS";
                noti.MessageText = "Silver package has been purchased for member!";
                Task.Delay(200).ContinueWith(_ =>
                {
                    var anim = new Transition(new TransitionType_CriticalDamping(300));
                    anim.add(noti, "Top", 500);
                    anim.run();
                    noti.ShowDialog();
                }, TaskScheduler.FromCurrentSynchronizationContext());
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else if(result > 0 && packageID == 3)
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "SUCCESS";
                noti.MessageText = "Gold package has been purchased for member!";
                Task.Delay(200).ContinueWith(_ =>
                {
                    var anim = new Transition(new TransitionType_CriticalDamping(300));
                    anim.add(noti, "Top", 500);
                    anim.run();
                    noti.ShowDialog();
                }, TaskScheduler.FromCurrentSynchronizationContext());
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else if (result > 0 && packageID == 4)
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "SUCCESS";
                noti.MessageText = "Premium package has been purchased for member!";
                Task.Delay(200).ContinueWith(_ =>
                {
                    var anim = new Transition(new TransitionType_CriticalDamping(300));
                    anim.add(noti, "Top", 500);
                    anim.run();
                    noti.ShowDialog();
                }, TaskScheduler.FromCurrentSynchronizationContext());
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else if(result > 0 && packageID == 5)
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "SUCCESS";
                noti.MessageText = "Deluxe package has been purchased for member!";
                Task.Delay(200).ContinueWith(_ =>
                {
                    var anim = new Transition(new TransitionType_CriticalDamping(300));
                    anim.add(noti, "Top", 500);
                    anim.run();
                    noti.ShowDialog();
                }, TaskScheduler.FromCurrentSynchronizationContext());
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else
            {
                Frm_Messages noti = new Frm_Messages();
                noti.StartPosition = FormStartPosition.CenterParent;
                noti.TitleText = "ERROR";
                noti.MessageText = "Error buying membership for user!";
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
