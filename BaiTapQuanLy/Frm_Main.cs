using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BaiTapQuanLy.Forms;
using Guna.UI2.WinForms;

namespace BaiTapQuanLy
{
    public partial class Frm_Main : Form
    {
        private Form currentChildForm;
        private Guna2Button currentButton;

        public Frm_Main()
        {
            InitializeComponent();
            currentButton = null;
        }

        //Drag From
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        ///////////////////////////////////////////////
        

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            pressedBTN(homePageBTN);
        }

        //Sidebar expand and collapse
        bool sidebarExpand = true;
        private void sidebarTransistion_Tick(object sender, EventArgs e)
        {
            const int targetWidthCollapsed = 50;
            const int targetWidthExpanded = 270;
            const int transitionSpeed = 25;
            if (sidebarExpand)
            {
                // Collapse sidebar
                if (sidebarPanel.Width > targetWidthCollapsed)
                {
                    sidebarPanel.Width -= transitionSpeed;
                    panelDesktop.Left -= transitionSpeed; 
                    panelDesktop.Width += transitionSpeed; 
                    UpdateButtonWidths(sidebarPanel.Width);
                    UpdateButtonText("Collapsed");
                }
                else
                {
                    sidebarPanel.Width = targetWidthCollapsed;
                    panelDesktop.Left = targetWidthCollapsed; 
                    panelDesktop.Width = this.ClientSize.Width - targetWidthCollapsed; 
                    sidebarExpand = false;
                    sidebarTransistion.Stop();
                }
            }
            else
            {
                // Expand sidebar
                if (sidebarPanel.Width < targetWidthExpanded)
                {
                    sidebarPanel.Width += transitionSpeed;
                    panelDesktop.Left += transitionSpeed; 
                    panelDesktop.Width -= transitionSpeed; 
                    UpdateButtonWidths(sidebarPanel.Width - 15);
                    UpdateButtonText("Expanded");
                }
                else
                {
                    sidebarPanel.Width = targetWidthExpanded;
                    panelDesktop.Left = targetWidthExpanded; 
                    panelDesktop.Width = this.ClientSize.Width - targetWidthExpanded; 
                    sidebarExpand = true;
                    sidebarTransistion.Stop();
                }
            }
        }

        private void UpdateButtonWidths(int width)
        {
            homePageBTN.Width = width;
            dashBoardBTN.Width = width;
            memberManagerBTN.Width = width;
            privateTrainerBTN.Width = width;
        }

        private void UpdateButtonText(string state)
        {
            homePageBTN.Text = state == "Collapsed" ? "" : "Home";
            dashBoardBTN.Text = state == "Collapsed" ? "" : "Dashboard";
            memberManagerBTN.Text = state == "Collapsed" ? "" : "Members Management";
            privateTrainerBTN.Text = state == "Collapsed" ? "" : "Personal Trainer";
        }

        private void menuSidebarIcon_Click(object sender, EventArgs e)
        {
            sidebarTransistion.Start();
        }
        ////////////////////////////////////////////////////////////// 


        //Open child forms
        private void OpenChildForm(Form childform, Guna2Button senderButton)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childform;
            pressedBTN(senderButton);
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childform);
            panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        //////////////////////////////////////////////////

        //Change colors when button is pressed
        private void pressedBTN(Guna2Button button)
        {
            if (currentButton != null)
            {
                currentButton.FillColor = System.Drawing.Color.Transparent;
                currentButton.ForeColor = System.Drawing.Color.Black;
            }
            currentButton = button;
            currentButton.FillColor = System.Drawing.Color.FromArgb(254, 239, 195);
        }
        /////////////////////////////////////////////////
        
        //Open other forms as a child form with button click
        private void dashBoardBTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Dashboard(), (Guna2Button)sender);
        }

        private void memberManagerBTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_MembersManager(), (Guna2Button)sender);
        }

        private void privateTrainerBTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_PT(), (Guna2Button)sender);
        }

        private void homePageBTN_Click(object sender, EventArgs e)
        {
            // Close all child forms
            foreach (Control control in panelDesktop.Controls)
            {
                if (control is Form form)
                {
                    form.Close();
                }
            }
            // Reset currentChildForm to null
            currentChildForm = null;
            pressedBTN(homePageBTN);
        }

        /////////////////////////////////////////////////////////
        private void userProfile_Click(object sender, EventArgs e)
        {
            var popupForm = new Frm_UserProfile();
            Point profileLocation = userProfile.PointToScreen(Point.Empty);
            popupForm.StartPosition = FormStartPosition.Manual;
            popupForm.Location = new Point(profileLocation.X - 40, (profileLocation.Y + userProfile.Height) + 10);
            popupForm.ShowDialog();
        }
    }
}
