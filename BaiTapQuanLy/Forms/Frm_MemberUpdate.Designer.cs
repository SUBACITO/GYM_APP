namespace BaiTapQuanLy.Forms
{
    partial class Frm_MemberUpdate
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
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.cancelUpdateBTN = new Guna.UI2.WinForms.Guna2Button();
            this.updateMemberBTN = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_JoinDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtp_DateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_Gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_FullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(87)))), ((int)(((byte)(208)))));
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(484, 73);
            this.topPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Member";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.cancelUpdateBTN);
            this.mainPanel.Controls.Add(this.updateMemberBTN);
            this.mainPanel.Controls.Add(this.dtp_JoinDate);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.txt_Phone);
            this.mainPanel.Controls.Add(this.txt_Email);
            this.mainPanel.Controls.Add(this.dtp_DateOfBirth);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.cbox_Gender);
            this.mainPanel.Controls.Add(this.txt_FullName);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 73);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(484, 419);
            this.mainPanel.TabIndex = 2;
            // 
            // cancelUpdateBTN
            // 
            this.cancelUpdateBTN.AutoRoundedCorners = true;
            this.cancelUpdateBTN.BorderRadius = 21;
            this.cancelUpdateBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelUpdateBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelUpdateBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelUpdateBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelUpdateBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelUpdateBTN.FillColor = System.Drawing.Color.Red;
            this.cancelUpdateBTN.Font = new System.Drawing.Font("Roboto", 12F);
            this.cancelUpdateBTN.ForeColor = System.Drawing.Color.White;
            this.cancelUpdateBTN.Location = new System.Drawing.Point(254, 350);
            this.cancelUpdateBTN.Name = "cancelUpdateBTN";
            this.cancelUpdateBTN.Size = new System.Drawing.Size(200, 45);
            this.cancelUpdateBTN.TabIndex = 12;
            this.cancelUpdateBTN.Text = "Cancel";
            this.cancelUpdateBTN.Click += new System.EventHandler(this.cancelUpdateBTN_Click);
            // 
            // updateMemberBTN
            // 
            this.updateMemberBTN.AutoRoundedCorners = true;
            this.updateMemberBTN.BorderRadius = 21;
            this.updateMemberBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateMemberBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateMemberBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateMemberBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateMemberBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateMemberBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(87)))), ((int)(((byte)(208)))));
            this.updateMemberBTN.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMemberBTN.ForeColor = System.Drawing.Color.White;
            this.updateMemberBTN.Location = new System.Drawing.Point(26, 350);
            this.updateMemberBTN.Name = "updateMemberBTN";
            this.updateMemberBTN.Size = new System.Drawing.Size(200, 45);
            this.updateMemberBTN.TabIndex = 11;
            this.updateMemberBTN.Text = "Update";
            this.updateMemberBTN.Click += new System.EventHandler(this.updateMemberBTN_Click);
            // 
            // dtp_JoinDate
            // 
            this.dtp_JoinDate.AutoRoundedCorners = true;
            this.dtp_JoinDate.BorderRadius = 17;
            this.dtp_JoinDate.Checked = true;
            this.dtp_JoinDate.FillColor = System.Drawing.Color.White;
            this.dtp_JoinDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_JoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_JoinDate.Location = new System.Drawing.Point(105, 293);
            this.dtp_JoinDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_JoinDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_JoinDate.Name = "dtp_JoinDate";
            this.dtp_JoinDate.Size = new System.Drawing.Size(349, 36);
            this.dtp_JoinDate.TabIndex = 8;
            this.dtp_JoinDate.Value = new System.DateTime(2024, 4, 21, 19, 0, 7, 564);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Join Date:";
            // 
            // txt_Phone
            // 
            this.txt_Phone.AutoRoundedCorners = true;
            this.txt_Phone.BorderRadius = 22;
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.DefaultText = "";
            this.txt_Phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txt_Phone.ForeColor = System.Drawing.Color.Black;
            this.txt_Phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.Location = new System.Drawing.Point(26, 240);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '\0';
            this.txt_Phone.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_Phone.PlaceholderText = "Phone";
            this.txt_Phone.SelectedText = "";
            this.txt_Phone.Size = new System.Drawing.Size(428, 46);
            this.txt_Phone.TabIndex = 6;
            // 
            // txt_Email
            // 
            this.txt_Email.AutoRoundedCorners = true;
            this.txt_Email.BorderRadius = 22;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.DefaultText = "";
            this.txt_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txt_Email.ForeColor = System.Drawing.Color.Black;
            this.txt_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Location = new System.Drawing.Point(26, 186);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_Email.PlaceholderText = "Email";
            this.txt_Email.SelectedText = "";
            this.txt_Email.Size = new System.Drawing.Size(428, 46);
            this.txt_Email.TabIndex = 5;
            // 
            // dtp_DateOfBirth
            // 
            this.dtp_DateOfBirth.AutoRoundedCorners = true;
            this.dtp_DateOfBirth.BorderRadius = 17;
            this.dtp_DateOfBirth.Checked = true;
            this.dtp_DateOfBirth.FillColor = System.Drawing.Color.White;
            this.dtp_DateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_DateOfBirth.Location = new System.Drawing.Point(131, 130);
            this.dtp_DateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_DateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_DateOfBirth.Name = "dtp_DateOfBirth";
            this.dtp_DateOfBirth.Size = new System.Drawing.Size(323, 36);
            this.dtp_DateOfBirth.TabIndex = 4;
            this.dtp_DateOfBirth.Value = new System.DateTime(2024, 4, 21, 19, 0, 7, 564);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender:";
            // 
            // cbox_Gender
            // 
            this.cbox_Gender.AutoRoundedCorners = true;
            this.cbox_Gender.BackColor = System.Drawing.Color.Transparent;
            this.cbox_Gender.BorderRadius = 17;
            this.cbox_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbox_Gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbox_Gender.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.cbox_Gender.ForeColor = System.Drawing.Color.Black;
            this.cbox_Gender.ItemHeight = 30;
            this.cbox_Gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbox_Gender.Location = new System.Drawing.Point(88, 79);
            this.cbox_Gender.Name = "cbox_Gender";
            this.cbox_Gender.Size = new System.Drawing.Size(366, 36);
            this.cbox_Gender.TabIndex = 1;
            // 
            // txt_FullName
            // 
            this.txt_FullName.AutoRoundedCorners = true;
            this.txt_FullName.BorderRadius = 22;
            this.txt_FullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_FullName.DefaultText = "";
            this.txt_FullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_FullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_FullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_FullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_FullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_FullName.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txt_FullName.ForeColor = System.Drawing.Color.Black;
            this.txt_FullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_FullName.Location = new System.Drawing.Point(26, 16);
            this.txt_FullName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.PasswordChar = '\0';
            this.txt_FullName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_FullName.PlaceholderText = "FullName";
            this.txt_FullName.SelectedText = "";
            this.txt_FullName.Size = new System.Drawing.Size(428, 46);
            this.txt_FullName.TabIndex = 0;
            // 
            // guna2BorderlessForm
            // 
            this.guna2BorderlessForm.BorderRadius = 20;
            this.guna2BorderlessForm.ContainerControl = this;
            this.guna2BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm.TransparentWhileDrag = true;
            // 
            // Frm_MemberUpdate
            // 
            this.AcceptButton = this.updateMemberBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 492);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MemberUpdate";
            this.Text = "Frm_MemberUpdate";
            this.Load += new System.EventHandler(this.Frm_MemberUpdate_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Button cancelUpdateBTN;
        private Guna.UI2.WinForms.Guna2Button updateMemberBTN;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_JoinDate;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_Phone;
        private Guna.UI2.WinForms.Guna2TextBox txt_Email;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_DateOfBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbox_Gender;
        private Guna.UI2.WinForms.Guna2TextBox txt_FullName;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm;
    }
}