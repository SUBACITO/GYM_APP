using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiTapQuanLy.BussinessLayer;
using BaiTapQuanLy.Forms;
using BaiTapQuanLy.Properties;
using BaiTapQuanLy.DTO;
using Guna.UI2.WinForms;
using Transitions;

namespace BaiTapQuanLy
{
    public partial class Frm_Main : Form
    {
        private Form currentChildForm;
        private Guna2Button currentButton;
        private Dictionary<Guna2Button, bool> buttonPressedState = new Dictionary<Guna2Button, bool>();

        public Frm_Main()
        {
            InitializeComponent();
            currentButton = null;
        }

        private void InitializeButtonStates()
        {
            buttonPressedState.Add(homePageBTN, false);
            buttonPressedState.Add(dashBoardBTN, false);
            buttonPressedState.Add(memberManagerBTN, false);

            UpdateButtonImages();
        }

        private void UpdateButtonImages()
        {
            foreach (var button in buttonPressedState.Keys)
            {
                string imageName = buttonPressedState[button] ? "_pressed" : "_unpressed";
                button.Image = Image.FromFile($"..\\..\\..\\image\\{button.Name}{imageName}.png");
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            InitializeButtonStates();
            pressedBTN(homePageBTN);
            usernameLabel.Text = Account.userName;
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
        }

        private void UpdateButtonText(string state)
        {
            homePageBTN.Text = state == "Collapsed" ? "" : "Home";
            dashBoardBTN.Text = state == "Collapsed" ? "" : "Statistics";
            memberManagerBTN.Text = state == "Collapsed" ? "" : "Members Manager";
        }

        private void menuSidebarIcon_Click(object sender, EventArgs e)
        {
            sidebarTransistion.Start();
        }

        //Open child forms
        private async void OpenChildForm(Form childform, Guna2Button senderButton)
        {
            // Store the current button and cancel the previous action
            currentButton = senderButton;
            pressedBTN(senderButton);

            await Task.Delay(100);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childform);
            panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        //Change colors when button is pressed
        private void pressedBTN(Guna2Button button)
        {
            // Update appearance of the previously pressed button
            if (currentButton != null)
            {
                currentButton.FillColor = Color.Transparent;
                currentButton.ForeColor = Color.Black;
                currentButton.Image = Image.FromFile($"..\\..\\..\\image\\{currentButton.Name}_unpressed.png");
            }

            // Update appearance of the current button
            button.FillColor = Color.FromArgb(11, 87, 208);
            button.ForeColor = Color.White;
            button.Image = Image.FromFile($"..\\..\\..\\image\\{button.Name}_pressed.png");

            // Update the current button
            currentButton = button;
        }

        //Open other forms as a child form with button click
        private async void dashBoardBTN_Click(object sender, EventArgs e)
        {
            pressedBTN(dashBoardBTN);
            Frm_LoadingStats loadingForm = new Frm_LoadingStats();
            loadingForm.TopLevel = false;
            loadingForm.FormBorderStyle = FormBorderStyle.None;
            loadingForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(loadingForm);
            panelDesktop.Tag = loadingForm;
            loadingForm.BringToFront();
            loadingForm.Show();

            await Task.Delay(500);

            Bll_ThongKe bll_thongke = new Bll_ThongKe(clsMain.path);
            Frm_Statistic stat = new Frm_Statistic(bll_thongke);

            await Task.Run(() =>
            {
                stat.LoadDataDetailPackages();
                stat.LoadGenderStats();
            });
            OpenChildForm(stat, (Guna2Button)sender);
            await Task.Delay(500);
            loadingForm.Close();
        }

        private async void memberManagerBTN_Click(object sender, EventArgs e)
        {
            pressedBTN(memberManagerBTN);
            Frm_LoadingStats loadingForm = new Frm_LoadingStats();
            loadingForm.TopLevel = false;
            loadingForm.FormBorderStyle = FormBorderStyle.None;
            loadingForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(loadingForm);
            panelDesktop.Tag = loadingForm;
            loadingForm.BringToFront();
            loadingForm.Show();

            await Task.Delay(500);

            Bll_Member bll_mem = new Bll_Member(clsMain.path);
            Frm_MembersManager frmMem = new Frm_MembersManager(bll_mem);
            await Task.Run(() =>
            {
                frmMem.LoadAllMembersData();
            });
            OpenChildForm(frmMem, (Guna2Button)sender);
            await Task.Delay(500);
            loadingForm.Close();
        }

        private void homePageBTN_Click(object sender, EventArgs e)
        {
            // Check if the current form is the loading form and close it if it exists
            var loadingForm = panelDesktop.Controls.OfType<Frm_LoadingStats>().FirstOrDefault();
            if (loadingForm != null)
            {
                loadingForm.Close();
            }

            // Reset currentChildForm to null
            currentChildForm = null;
            pressedBTN(homePageBTN);

            // Close all child forms
            foreach (Control control in panelDesktop.Controls)
            {
                if (control is Form form)
                {
                    form.Close();
                }
            }
        }

        // Open popup form (User profile)
        private void userProfile_Click(object sender, EventArgs e)
        {
            var popupForm = new Frm_UserProfile();
            var anim = new Transition(new TransitionType_CriticalDamping(500));
            Point profileLocation = userProfile.PointToScreen(Point.Empty);
            popupForm.StartPosition = FormStartPosition.Manual;
            popupForm.Location = new Point(profileLocation.X - 40);
            var getWidthY = profileLocation.Y + userProfile.Height;
            anim.add(popupForm, "Top", getWidthY + 10);
            anim.run();
            popupForm.ShowDialog();
        }
    }
}
