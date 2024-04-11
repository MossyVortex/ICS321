namespace BloodManagmentSystem.UI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            picClose = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUser_Name = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            lblAppName = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // picClose
            // 
            picClose.BackColor = SystemColors.GradientActiveCaption;
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(705, 12);
            picClose.Name = "picClose";
            picClose.Size = new Size(49, 47);
            picClose.TabIndex = 28;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(396, 108);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(251, 23);
            txtUsername.TabIndex = 29;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(396, 221);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'x';
            txtPassword.Size = new Size(251, 23);
            txtPassword.TabIndex = 30;
            // 
            // lblUser_Name
            // 
            lblUser_Name.AutoSize = true;
            lblUser_Name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser_Name.Location = new Point(402, 54);
            lblUser_Name.Name = "lblUser_Name";
            lblUser_Name.Size = new Size(94, 21);
            lblUser_Name.TabIndex = 31;
            lblUser_Name.Text = "User Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(396, 173);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 21);
            lblPassword.TabIndex = 32;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumAquamarine;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(396, 270);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(251, 42);
            btnLogin.TabIndex = 33;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppName.Location = new Point(49, 148);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(313, 65);
            lblAppName.TabIndex = 34;
            lblAppName.Text = " Blood Bank ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(149, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 106);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 213);
            label1.Name = "label1";
            label1.Size = new Size(270, 40);
            label1.TabIndex = 36;
            label1.Text = "Managment System";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(775, 356);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblAppName);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUser_Name);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(picClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picClose;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUser_Name;
        private Label lblPassword;
        private Button btnLogin;
        private Label lblAppName;
        private PictureBox pictureBox1;
        private Label label1;
    }
}