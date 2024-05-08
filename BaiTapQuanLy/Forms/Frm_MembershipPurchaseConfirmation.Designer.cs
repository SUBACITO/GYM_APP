namespace BaiTapQuanLy.Forms
{
    partial class Frm_MembershipPurchaseConfirmation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.confirmGradienTopPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.buyConfirmPackageBTN = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblMembershipDuration = new System.Windows.Forms.Label();
            this.lblMembershipType = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cancelPackagePurchaseBTN = new Guna.UI2.WinForms.Guna2Button();
            this.lblMembershipPrice = new System.Windows.Forms.Label();
            this.confirmGradienTopPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm
            // 
            this.guna2BorderlessForm.BorderRadius = 20;
            this.guna2BorderlessForm.ContainerControl = this;
            this.guna2BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm.TransparentWhileDrag = true;
            // 
            // confirmGradienTopPanel
            // 
            this.confirmGradienTopPanel.Controls.Add(this.labelHeader);
            this.confirmGradienTopPanel.Location = new System.Drawing.Point(0, 0);
            this.confirmGradienTopPanel.Name = "confirmGradienTopPanel";
            this.confirmGradienTopPanel.Size = new System.Drawing.Size(651, 61);
            this.confirmGradienTopPanel.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(3, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(648, 38);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Confirm Your Purchase";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblMembershipPrice);
            this.guna2Panel1.Controls.Add(this.buyConfirmPackageBTN);
            this.guna2Panel1.Controls.Add(this.lblMembershipDuration);
            this.guna2Panel1.Controls.Add(this.lblMembershipType);
            this.guna2Panel1.Controls.Add(this.lblUsername);
            this.guna2Panel1.Controls.Add(this.cancelPackagePurchaseBTN);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 67);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(651, 254);
            this.guna2Panel1.TabIndex = 1;
            // 
            // buyConfirmPackageBTN
            // 
            this.buyConfirmPackageBTN.AutoRoundedCorners = true;
            this.buyConfirmPackageBTN.BorderRadius = 21;
            this.buyConfirmPackageBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyConfirmPackageBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buyConfirmPackageBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buyConfirmPackageBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buyConfirmPackageBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buyConfirmPackageBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buyConfirmPackageBTN.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyConfirmPackageBTN.ForeColor = System.Drawing.Color.White;
            this.buyConfirmPackageBTN.Location = new System.Drawing.Point(75, 189);
            this.buyConfirmPackageBTN.Name = "buyConfirmPackageBTN";
            this.buyConfirmPackageBTN.Size = new System.Drawing.Size(200, 45);
            this.buyConfirmPackageBTN.TabIndex = 17;
            this.buyConfirmPackageBTN.Text = "Buy";
            this.buyConfirmPackageBTN.Click += new System.EventHandler(this.buyConfirmPackageBTN_Click);
            // 
            // lblMembershipDuration
            // 
            this.lblMembershipDuration.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipDuration.Location = new System.Drawing.Point(0, 90);
            this.lblMembershipDuration.Name = "lblMembershipDuration";
            this.lblMembershipDuration.Size = new System.Drawing.Size(648, 38);
            this.lblMembershipDuration.TabIndex = 16;
            this.lblMembershipDuration.Text = "Duration";
            this.lblMembershipDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMembershipType
            // 
            this.lblMembershipType.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipType.Location = new System.Drawing.Point(0, 52);
            this.lblMembershipType.Name = "lblMembershipType";
            this.lblMembershipType.Size = new System.Drawing.Size(648, 38);
            this.lblMembershipType.TabIndex = 15;
            this.lblMembershipType.Text = "Membership Type";
            this.lblMembershipType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(0, 14);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(648, 38);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username + ID";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelPackagePurchaseBTN
            // 
            this.cancelPackagePurchaseBTN.AutoRoundedCorners = true;
            this.cancelPackagePurchaseBTN.BorderRadius = 21;
            this.cancelPackagePurchaseBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelPackagePurchaseBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelPackagePurchaseBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelPackagePurchaseBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelPackagePurchaseBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelPackagePurchaseBTN.FillColor = System.Drawing.Color.Red;
            this.cancelPackagePurchaseBTN.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelPackagePurchaseBTN.ForeColor = System.Drawing.Color.White;
            this.cancelPackagePurchaseBTN.Location = new System.Drawing.Point(356, 189);
            this.cancelPackagePurchaseBTN.Name = "cancelPackagePurchaseBTN";
            this.cancelPackagePurchaseBTN.Size = new System.Drawing.Size(200, 45);
            this.cancelPackagePurchaseBTN.TabIndex = 13;
            this.cancelPackagePurchaseBTN.Text = "Cancel";
            this.cancelPackagePurchaseBTN.Click += new System.EventHandler(this.cancelPackagePurchaseBTN_Click);
            // 
            // lblMembershipPrice
            // 
            this.lblMembershipPrice.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipPrice.Location = new System.Drawing.Point(0, 128);
            this.lblMembershipPrice.Name = "lblMembershipPrice";
            this.lblMembershipPrice.Size = new System.Drawing.Size(648, 38);
            this.lblMembershipPrice.TabIndex = 18;
            this.lblMembershipPrice.Text = "Price";
            this.lblMembershipPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_MembershipPurchaseConfirmation
            // 
            this.AcceptButton = this.buyConfirmPackageBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 333);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.confirmGradienTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MembershipPurchaseConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_MembershipPurchaseConfirmation";
            this.Load += new System.EventHandler(this.Frm_MembershipPurchaseConfirmation_Load);
            this.confirmGradienTopPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel confirmGradienTopPanel;
        private System.Windows.Forms.Label labelHeader;
        private Guna.UI2.WinForms.Guna2Button cancelPackagePurchaseBTN;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblMembershipType;
        private System.Windows.Forms.Label lblMembershipDuration;
        private Guna.UI2.WinForms.Guna2GradientButton buyConfirmPackageBTN;
        private System.Windows.Forms.Label lblMembershipPrice;
    }
}