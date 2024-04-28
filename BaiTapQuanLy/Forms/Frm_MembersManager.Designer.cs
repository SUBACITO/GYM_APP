namespace BaiTapQuanLy.Forms
{
    partial class Frm_MembersManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MembersManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.addMembershipToMemberBTN = new Guna.UI2.WinForms.Guna2CircleButton();
            this.addMemberBTN = new Guna.UI2.WinForms.Guna2CircleButton();
            this.editMemberBTN = new Guna.UI2.WinForms.Guna2CircleButton();
            this.deleteMemberBTN = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dgvMembers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMembershipType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colexpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBarTxT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Controls.Add(this.dgvMembers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 339);
            this.panel2.TabIndex = 6;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.Controls.Add(this.addMembershipToMemberBTN);
            this.guna2Panel1.Controls.Add(this.addMemberBTN);
            this.guna2Panel1.Controls.Add(this.editMemberBTN);
            this.guna2Panel1.Controls.Add(this.deleteMemberBTN);
            this.guna2Panel1.Location = new System.Drawing.Point(686, -5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(102, 332);
            this.guna2Panel1.TabIndex = 2;
            // 
            // addMembershipToMemberBTN
            // 
            this.addMembershipToMemberBTN.BackColor = System.Drawing.Color.Transparent;
            this.addMembershipToMemberBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMembershipToMemberBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addMembershipToMemberBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addMembershipToMemberBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addMembershipToMemberBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addMembershipToMemberBTN.FillColor = System.Drawing.Color.White;
            this.addMembershipToMemberBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addMembershipToMemberBTN.ForeColor = System.Drawing.Color.White;
            this.addMembershipToMemberBTN.Image = ((System.Drawing.Image)(resources.GetObject("addMembershipToMemberBTN.Image")));
            this.addMembershipToMemberBTN.ImageSize = new System.Drawing.Size(66, 65);
            this.addMembershipToMemberBTN.Location = new System.Drawing.Point(19, 0);
            this.addMembershipToMemberBTN.Name = "addMembershipToMemberBTN";
            this.addMembershipToMemberBTN.PressedDepth = 0;
            this.addMembershipToMemberBTN.ShadowDecoration.BorderRadius = 0;
            this.addMembershipToMemberBTN.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.addMembershipToMemberBTN.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.addMembershipToMemberBTN.Size = new System.Drawing.Size(70, 70);
            this.addMembershipToMemberBTN.TabIndex = 6;
            this.addMembershipToMemberBTN.Click += new System.EventHandler(this.addMembershipToMemberBTN_Click);
            // 
            // addMemberBTN
            // 
            this.addMemberBTN.BackColor = System.Drawing.Color.Transparent;
            this.addMemberBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMemberBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addMemberBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addMemberBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addMemberBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addMemberBTN.FillColor = System.Drawing.Color.White;
            this.addMemberBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addMemberBTN.ForeColor = System.Drawing.Color.White;
            this.addMemberBTN.Image = ((System.Drawing.Image)(resources.GetObject("addMemberBTN.Image")));
            this.addMemberBTN.ImageSize = new System.Drawing.Size(66, 65);
            this.addMemberBTN.Location = new System.Drawing.Point(19, 81);
            this.addMemberBTN.Name = "addMemberBTN";
            this.addMemberBTN.PressedDepth = 0;
            this.addMemberBTN.ShadowDecoration.BorderRadius = 0;
            this.addMemberBTN.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.addMemberBTN.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.addMemberBTN.Size = new System.Drawing.Size(70, 70);
            this.addMemberBTN.TabIndex = 5;
            this.addMemberBTN.Click += new System.EventHandler(this.addMemberBTN_Click);
            // 
            // editMemberBTN
            // 
            this.editMemberBTN.BackColor = System.Drawing.Color.Transparent;
            this.editMemberBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editMemberBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editMemberBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editMemberBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editMemberBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editMemberBTN.FillColor = System.Drawing.Color.White;
            this.editMemberBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editMemberBTN.ForeColor = System.Drawing.Color.White;
            this.editMemberBTN.Image = ((System.Drawing.Image)(resources.GetObject("editMemberBTN.Image")));
            this.editMemberBTN.ImageSize = new System.Drawing.Size(66, 65);
            this.editMemberBTN.Location = new System.Drawing.Point(19, 163);
            this.editMemberBTN.Name = "editMemberBTN";
            this.editMemberBTN.PressedDepth = 0;
            this.editMemberBTN.ShadowDecoration.BorderRadius = 0;
            this.editMemberBTN.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.editMemberBTN.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.editMemberBTN.Size = new System.Drawing.Size(70, 70);
            this.editMemberBTN.TabIndex = 4;
            this.editMemberBTN.Click += new System.EventHandler(this.editMemberBTN_Click);
            // 
            // deleteMemberBTN
            // 
            this.deleteMemberBTN.BackColor = System.Drawing.Color.Transparent;
            this.deleteMemberBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteMemberBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteMemberBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteMemberBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteMemberBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteMemberBTN.FillColor = System.Drawing.Color.White;
            this.deleteMemberBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteMemberBTN.ForeColor = System.Drawing.Color.White;
            this.deleteMemberBTN.Image = ((System.Drawing.Image)(resources.GetObject("deleteMemberBTN.Image")));
            this.deleteMemberBTN.ImageSize = new System.Drawing.Size(66, 65);
            this.deleteMemberBTN.Location = new System.Drawing.Point(19, 249);
            this.deleteMemberBTN.Name = "deleteMemberBTN";
            this.deleteMemberBTN.PressedDepth = 0;
            this.deleteMemberBTN.ShadowDecoration.BorderRadius = 0;
            this.deleteMemberBTN.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.deleteMemberBTN.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.deleteMemberBTN.Size = new System.Drawing.Size(70, 70);
            this.deleteMemberBTN.TabIndex = 3;
            this.deleteMemberBTN.Click += new System.EventHandler(this.deleteMemberBTN_Click);
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AllowUserToResizeColumns = false;
            this.dgvMembers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembers.ColumnHeadersHeight = 30;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemberID,
            this.colFullName,
            this.colGender,
            this.colDateOfBirth,
            this.colEmail,
            this.colPhone,
            this.colJoinDate,
            this.colMembershipType,
            this.colexpiredDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(87)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMembers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMembers.Location = new System.Drawing.Point(25, 6);
            this.dgvMembers.MultiSelect = false;
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMembers.RowTemplate.Height = 50;
            this.dgvMembers.Size = new System.Drawing.Size(655, 321);
            this.dgvMembers.TabIndex = 0;
            this.dgvMembers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMembers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMembers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMembers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMembers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMembers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMembers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMembers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMembers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMembers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMembers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMembers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMembers.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvMembers.ThemeStyle.ReadOnly = true;
            this.dgvMembers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMembers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMembers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMembers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMembers.ThemeStyle.RowsStyle.Height = 50;
            this.dgvMembers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMembers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellClick);
            this.dgvMembers.SelectionChanged += new System.EventHandler(this.dgvMembers_SelectionChanged);
            // 
            // colMemberID
            // 
            this.colMemberID.DataPropertyName = "MemberID";
            this.colMemberID.FillWeight = 80.23825F;
            this.colMemberID.HeaderText = "Member ID";
            this.colMemberID.Name = "colMemberID";
            this.colMemberID.ReadOnly = true;
            // 
            // colFullName
            // 
            this.colFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.FillWeight = 163.3248F;
            this.colFullName.HeaderText = "Full Name";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.FillWeight = 80.23825F;
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.DataPropertyName = "DateOfBirth";
            this.colDateOfBirth.FillWeight = 80.23825F;
            this.colDateOfBirth.HeaderText = "Date of Birth";
            this.colDateOfBirth.Name = "colDateOfBirth";
            this.colDateOfBirth.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.FillWeight = 184.4933F;
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.FillWeight = 80.23825F;
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colJoinDate
            // 
            this.colJoinDate.DataPropertyName = "JoinDate";
            this.colJoinDate.FillWeight = 80.23825F;
            this.colJoinDate.HeaderText = "Join Date";
            this.colJoinDate.Name = "colJoinDate";
            this.colJoinDate.ReadOnly = true;
            // 
            // colMembershipType
            // 
            this.colMembershipType.DataPropertyName = "MembershipType";
            this.colMembershipType.FillWeight = 80.23825F;
            this.colMembershipType.HeaderText = "Membership Type";
            this.colMembershipType.Name = "colMembershipType";
            this.colMembershipType.ReadOnly = true;
            // 
            // colexpiredDate
            // 
            this.colexpiredDate.DataPropertyName = "expiredDate";
            this.colexpiredDate.FillWeight = 79.38195F;
            this.colexpiredDate.HeaderText = "Expired Date";
            this.colexpiredDate.Name = "colexpiredDate";
            this.colexpiredDate.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchBarTxT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 111);
            this.panel1.TabIndex = 5;
            // 
            // searchBarTxT
            // 
            this.searchBarTxT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBarTxT.AutoRoundedCorners = true;
            this.searchBarTxT.BackColor = System.Drawing.Color.Transparent;
            this.searchBarTxT.BorderColor = System.Drawing.Color.Silver;
            this.searchBarTxT.BorderRadius = 21;
            this.searchBarTxT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBarTxT.DefaultText = "";
            this.searchBarTxT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBarTxT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBarTxT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBarTxT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBarTxT.FillColor = System.Drawing.Color.WhiteSmoke;
            this.searchBarTxT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBarTxT.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.searchBarTxT.ForeColor = System.Drawing.Color.Black;
            this.searchBarTxT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBarTxT.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchBarTxT.IconLeft")));
            this.searchBarTxT.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.searchBarTxT.Location = new System.Drawing.Point(25, 58);
            this.searchBarTxT.Margin = new System.Windows.Forms.Padding(5);
            this.searchBarTxT.Name = "searchBarTxT";
            this.searchBarTxT.PasswordChar = '\0';
            this.searchBarTxT.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.searchBarTxT.PlaceholderText = "Search";
            this.searchBarTxT.SelectedText = "";
            this.searchBarTxT.ShadowDecoration.Depth = 50;
            this.searchBarTxT.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1);
            this.searchBarTxT.Size = new System.Drawing.Size(655, 45);
            this.searchBarTxT.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Members Manager";
            // 
            // Frm_MembersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_MembersManager";
            this.Text = "Frm_MembersManager";
            this.Load += new System.EventHandler(this.Frm_MembersManager_Load);
            this.Shown += new System.EventHandler(this.Frm_MembersManager_Shown);
            this.panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMembers;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton deleteMemberBTN;
        private Guna.UI2.WinForms.Guna2CircleButton addMemberBTN;
        private Guna.UI2.WinForms.Guna2CircleButton editMemberBTN;
        private Guna.UI2.WinForms.Guna2TextBox searchBarTxT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMembershipType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colexpiredDate;
        private Guna.UI2.WinForms.Guna2CircleButton addMembershipToMemberBTN;
    }
}