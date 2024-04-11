namespace BloodManagmentSystem.UI
{
    partial class FrmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
            panelTop = new Panel();
            lblFormTitle = new Label();
            lblProfilePicture = new Label();
            pictureBoxProfilePicture = new PictureBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            txtUserID = new TextBox();
            lblUserID = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtContact = new TextBox();
            lblContact = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            dgvUsers = new DataGridView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            picClose = new PictureBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Salmon;
            panelTop.Controls.Add(lblFormTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1100, 39);
            panelTop.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.Location = new Point(498, 9);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(117, 21);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Manage Users";
            // 
            // lblProfilePicture
            // 
            lblProfilePicture.AutoSize = true;
            lblProfilePicture.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfilePicture.Location = new Point(32, 66);
            lblProfilePicture.Name = "lblProfilePicture";
            lblProfilePicture.Size = new Size(80, 13);
            lblProfilePicture.TabIndex = 1;
            lblProfilePicture.Text = "Profile Picture";
            // 
            // pictureBoxProfilePicture
            // 
            pictureBoxProfilePicture.Location = new Point(139, 54);
            pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            pictureBoxProfilePicture.Size = new Size(86, 71);
            pictureBoxProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfilePicture.TabIndex = 2;
            pictureBoxProfilePicture.TabStop = false;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFullName.Location = new Point(32, 192);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(60, 13);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(125, 188);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(213, 25);
            txtFullName.TabIndex = 5;
            // 
            // txtUserID
            // 
            txtUserID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserID.Location = new Point(125, 143);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(213, 25);
            txtUserID.TabIndex = 7;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserID.Location = new Point(32, 147);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(44, 13);
            lblUserID.TabIndex = 6;
            lblUserID.Text = "User ID";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(125, 229);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 25);
            txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(32, 233);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 13);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "UserEmail";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(125, 306);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'x';
            txtPassword.Size = new Size(213, 25);
            txtPassword.TabIndex = 13;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(32, 310);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 13);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(125, 265);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(213, 25);
            txtUserName.TabIndex = 11;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(32, 269);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(64, 13);
            lblUserName.TabIndex = 10;
            lblUserName.Text = "User Name";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(125, 387);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(213, 41);
            txtAddress.TabIndex = 17;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(32, 391);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 13);
            lblAddress.TabIndex = 16;
            lblAddress.Text = "Address";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(125, 346);
            txtContact.MaxLength = 15;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(213, 25);
            txtContact.TabIndex = 15;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblContact.Location = new Point(32, 350);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(47, 13);
            lblContact.TabIndex = 14;
            lblContact.Text = "Contact";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Turquoise;
            btnAdd.Location = new Point(24, 452);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(249, 452);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.MenuHighlight;
            btnUpdate.Location = new Point(139, 452);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Orange;
            btnClear.Location = new Point(374, 452);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(522, 143);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowTemplate.Height = 25;
            dgvUsers.Size = new Size(455, 285);
            dgvUsers.TabIndex = 22;
            dgvUsers.RowHeaderMouseClick += dgvUsers_RowHeaderMouseClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(569, 108);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(408, 25);
            txtSearch.TabIndex = 24;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(522, 112);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(41, 13);
            lblSearch.TabIndex = 23;
            lblSearch.Text = "Search";
            // 
            // picClose
            // 
            picClose.BackColor = SystemColors.ScrollBar;
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(1039, 45);
            picClose.Name = "picClose";
            picClose.Size = new Size(49, 47);
            picClose.TabIndex = 25;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // FrmUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1100, 500);
            Controls.Add(picClose);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvUsers);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtUserID);
            Controls.Add(lblUserID);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(pictureBoxProfilePicture);
            Controls.Add(lblProfilePicture);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsers";
            Load += FrmUsers_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Label lblFormTitle;
        private Label lblProfilePicture;
        private PictureBox pictureBoxProfilePicture;
        private Label lblFullName;
        private TextBox txtFullName;
        private TextBox txtUserID;
        private Label lblUserID;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUserName;
        private Label lblUserName;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtContact;
        private Label lblContact;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private DataGridView dgvUsers;
        private TextBox txtSearch;
        private Label lblSearch;
        private PictureBox picClose;
    }
}