namespace BloodManagmentSystem.UI
{
    partial class frmDonors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonors));
            picClose = new PictureBox();
            panelTop = new Panel();
            lblFormTitle = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvDonors = new DataGridView();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtContact = new TextBox();
            lblContact = new Label();
            lblGender = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtDonorID = new TextBox();
            lblDonorID = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            btnSelectImage = new Button();
            pictureBoxProfilePicture = new PictureBox();
            lblProfilePicture = new Label();
            lblBloodGroup = new Label();
            cmbGender = new ComboBox();
            cmbBloodGroup = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // picClose
            // 
            picClose.BackColor = SystemColors.ScrollBar;
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(1039, 45);
            picClose.Name = "picClose";
            picClose.Size = new Size(49, 47);
            picClose.TabIndex = 27;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.DeepSkyBlue;
            panelTop.Controls.Add(lblFormTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1100, 39);
            panelTop.TabIndex = 26;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.Location = new Point(498, 9);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(131, 21);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Manage Donors";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(621, 108);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(408, 25);
            txtSearch.TabIndex = 51;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(574, 112);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(41, 13);
            lblSearch.TabIndex = 50;
            lblSearch.Text = "Search";
            // 
            // dgvDonors
            // 
            dgvDonors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonors.Location = new Point(574, 143);
            dgvDonors.Name = "dgvDonors";
            dgvDonors.RowTemplate.Height = 25;
            dgvDonors.Size = new Size(455, 285);
            dgvDonors.TabIndex = 49;
            dgvDonors.RowHeaderMouseClick += dgvDonors_RowHeaderMouseClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Orange;
            btnClear.Location = new Point(426, 522);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 48;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.MenuHighlight;
            btnUpdate.Location = new Point(191, 522);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 47;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(301, 522);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 46;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Turquoise;
            btnAdd.Location = new Point(76, 522);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 45;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(177, 387);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(213, 41);
            txtAddress.TabIndex = 44;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(84, 391);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 13);
            lblAddress.TabIndex = 43;
            lblAddress.Text = "Address";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(177, 306);
            txtContact.MaxLength = 15;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(213, 25);
            txtContact.TabIndex = 42;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblContact.Location = new Point(84, 310);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(47, 13);
            lblContact.TabIndex = 41;
            lblContact.Text = "Contact";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(84, 348);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 13);
            lblGender.TabIndex = 39;
            lblGender.Text = "Gender";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(177, 234);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(213, 25);
            txtLastName.TabIndex = 38;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(84, 238);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(62, 13);
            lblLastName.TabIndex = 37;
            lblLastName.Text = "Last Name";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(177, 275);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 25);
            txtEmail.TabIndex = 36;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(84, 279);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(35, 13);
            lblEmail.TabIndex = 35;
            lblEmail.Text = "Email";
            // 
            // txtDonorID
            // 
            txtDonorID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonorID.Location = new Point(177, 143);
            txtDonorID.Name = "txtDonorID";
            txtDonorID.ReadOnly = true;
            txtDonorID.Size = new Size(213, 25);
            txtDonorID.TabIndex = 34;
            // 
            // lblDonorID
            // 
            lblDonorID.AutoSize = true;
            lblDonorID.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonorID.Location = new Point(84, 147);
            lblDonorID.Name = "lblDonorID";
            lblDonorID.Size = new Size(54, 13);
            lblDonorID.TabIndex = 33;
            lblDonorID.Text = "Donor ID";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(177, 188);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(213, 25);
            txtFirstName.TabIndex = 32;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(84, 192);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(63, 13);
            lblFirstName.TabIndex = 31;
            lblFirstName.Text = "Fisrt Name";
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(301, 98);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(89, 27);
            btnSelectImage.TabIndex = 30;
            btnSelectImage.Text = "Select Image";
            btnSelectImage.UseVisualStyleBackColor = true;
            // 
            // pictureBoxProfilePicture
            // 
            pictureBoxProfilePicture.Location = new Point(191, 54);
            pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            pictureBoxProfilePicture.Size = new Size(86, 71);
            pictureBoxProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfilePicture.TabIndex = 29;
            pictureBoxProfilePicture.TabStop = false;
            // 
            // lblProfilePicture
            // 
            lblProfilePicture.AutoSize = true;
            lblProfilePicture.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfilePicture.Location = new Point(84, 66);
            lblProfilePicture.Name = "lblProfilePicture";
            lblProfilePicture.Size = new Size(80, 13);
            lblProfilePicture.TabIndex = 28;
            lblProfilePicture.Text = "Profile Picture";
            // 
            // lblBloodGroup
            // 
            lblBloodGroup.AutoSize = true;
            lblBloodGroup.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBloodGroup.Location = new Point(84, 438);
            lblBloodGroup.Name = "lblBloodGroup";
            lblBloodGroup.Size = new Size(74, 13);
            lblBloodGroup.TabIndex = 52;
            lblBloodGroup.Text = "Blood Group";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(177, 348);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(213, 23);
            cmbGender.TabIndex = 54;
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.FormattingEnabled = true;
            cmbBloodGroup.Items.AddRange(new object[] { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" });
            cmbBloodGroup.Location = new Point(177, 438);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new Size(213, 23);
            cmbBloodGroup.TabIndex = 55;
            // 
            // frmDonors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1100, 592);
            Controls.Add(cmbBloodGroup);
            Controls.Add(cmbGender);
            Controls.Add(lblBloodGroup);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvDonors);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(lblGender);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtDonorID);
            Controls.Add(lblDonorID);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(btnSelectImage);
            Controls.Add(pictureBoxProfilePicture);
            Controls.Add(lblProfilePicture);
            Controls.Add(picClose);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDonors";
            Text = "Donors";
            Load += frmDonors_Load;
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonors).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picClose;
        private Panel panelTop;
        private Label lblFormTitle;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvDonors;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtContact;
        private Label lblContact;
        private Label lblGender;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtDonorID;
        private Label lblDonorID;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Button btnSelectImage;
        private PictureBox pictureBoxProfilePicture;
        private Label lblProfilePicture;
        private Label lblBloodGroup;
        private ComboBox cmbGender;
        private ComboBox cmbBloodGroup;
    }
}