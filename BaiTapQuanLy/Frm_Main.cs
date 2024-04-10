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
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            pressedBTN(homePageBTN);
        }

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

        private void pressedBTN(Guna2Button button)
        {
            if (currentButton != null)
            {
                currentButton.FillColor = System.Drawing.Color.Transparent;
                currentButton.ForeColor = System.Drawing.Color.Black;
            }
            currentButton = button;
            currentButton.FillColor = System.Drawing.Color.FromArgb(79, 125, 217);
            currentButton.ForeColor = System.Drawing.Color.White;
        }

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
    }
}
