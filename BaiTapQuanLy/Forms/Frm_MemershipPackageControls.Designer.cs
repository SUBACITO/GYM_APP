namespace BaiTapQuanLy.Forms
{
    partial class Frm_MemershipPackageControls
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
            this.lblPackageName = new System.Windows.Forms.Label();
            this.bottomPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPackageDuration = new System.Windows.Forms.Label();
            this.lblPackagePrice = new System.Windows.Forms.Label();
            this.topGradientPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblMembershipType = new System.Windows.Forms.Label();
            this.guna2BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnGradientBuyPackage = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bottomPanel.SuspendLayout();
            this.topGradientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPackageName
            // 
            this.lblPackageName.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageName.Location = new System.Drawing.Point(11, 12);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(377, 42);
            this.lblPackageName.TabIndex = 0;
            this.lblPackageName.Text = "Package Type";
            this.lblPackageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.guna2HtmlLabel1);
            this.bottomPanel.Controls.Add(this.btnGradientBuyPackage);
            this.bottomPanel.Controls.Add(this.lblPackageName);
            this.bottomPanel.Controls.Add(this.lblPackagePrice);
            this.bottomPanel.Controls.Add(this.lblPackageDuration);
            this.bottomPanel.Location = new System.Drawing.Point(-4, 57);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(415, 270);
            this.bottomPanel.TabIndex = 1;
            // 
            // lblPackageDuration
            // 
            this.lblPackageDuration.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageDuration.Location = new System.Drawing.Point(11, 54);
            this.lblPackageDuration.Name = "lblPackageDuration";
            this.lblPackageDuration.Size = new System.Drawing.Size(377, 40);
            this.lblPackageDuration.TabIndex = 2;
            this.lblPackageDuration.Text = "Package Duration";
            this.lblPackageDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPackagePrice
            // 
            this.lblPackagePrice.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackagePrice.Location = new System.Drawing.Point(15, 94);
            this.lblPackagePrice.Name = "lblPackagePrice";
            this.lblPackagePrice.Size = new System.Drawing.Size(373, 38);
            this.lblPackagePrice.TabIndex = 3;
            this.lblPackagePrice.Text = "Package Price";
            this.lblPackagePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topGradientPanel
            // 
            this.topGradientPanel.Controls.Add(this.lblMembershipType);
            this.topGradientPanel.FillColor = System.Drawing.Color.BlueViolet;
            this.topGradientPanel.FillColor2 = System.Drawing.Color.Fuchsia;
            this.topGradientPanel.Location = new System.Drawing.Point(-4, -3);
            this.topGradientPanel.Name = "topGradientPanel";
            this.topGradientPanel.Size = new System.Drawing.Size(415, 65);
            this.topGradientPanel.TabIndex = 2;
            // 
            // lblMembershipType
            // 
            this.lblMembershipType.BackColor = System.Drawing.Color.Transparent;
            this.lblMembershipType.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipType.ForeColor = System.Drawing.Color.White;
            this.lblMembershipType.Location = new System.Drawing.Point(16, 9);
            this.lblMembershipType.Name = "lblMembershipType";
            this.lblMembershipType.Size = new System.Drawing.Size(379, 48);
            this.lblMembershipType.TabIndex = 5;
            this.lblMembershipType.Text = "Membership Type";
            this.lblMembershipType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2BorderlessForm
            // 
            this.guna2BorderlessForm.BorderRadius = 20;
            this.guna2BorderlessForm.ContainerControl = this;
            this.guna2BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm.DragForm = false;
            this.guna2BorderlessForm.TransparentWhileDrag = true;
            // 
            // btnGradientBuyPackage
            // 
            this.btnGradientBuyPackage.AutoRoundedCorners = true;
            this.btnGradientBuyPackage.BorderRadius = 24;
            this.btnGradientBuyPackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGradientBuyPackage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGradientBuyPackage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGradientBuyPackage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGradientBuyPackage.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGradientBuyPackage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGradientBuyPackage.FillColor = System.Drawing.Color.BlueViolet;
            this.btnGradientBuyPackage.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnGradientBuyPackage.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradientBuyPackage.ForeColor = System.Drawing.Color.White;
            this.btnGradientBuyPackage.Location = new System.Drawing.Point(91, 148);
            this.btnGradientBuyPackage.Name = "btnGradientBuyPackage";
            this.btnGradientBuyPackage.Size = new System.Drawing.Size(220, 50);
            this.btnGradientBuyPackage.TabIndex = 5;
            this.btnGradientBuyPackage.Text = "Choose Package";
            this.btnGradientBuyPackage.Click += new System.EventHandler(this.btnGradientBuyPackage_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(19, 204);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(369, 24);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "You can renew this package anytime.\r\n";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_MemershipPackageControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 322);
            this.Controls.Add(this.topGradientPanel);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MemershipPackageControls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_MemershipPackageControls";
            this.bottomPanel.ResumeLayout(false);
            this.topGradientPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPackageName;
        private Guna.UI2.WinForms.Guna2Panel bottomPanel;
        private System.Windows.Forms.Label lblPackageDuration;
        private System.Windows.Forms.Label lblPackagePrice;
        private Guna.UI2.WinForms.Guna2GradientPanel topGradientPanel;
        private System.Windows.Forms.Label lblMembershipType;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm;
        private Guna.UI2.WinForms.Guna2GradientButton btnGradientBuyPackage;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}