namespace BloodManagmentSystem
{
    partial class FrmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            menuStripTop = new MenuStrip();
            usersToolStripMenuItem = new ToolStripMenuItem();
            donorsToolStripMenuItem = new ToolStripMenuItem();
            panelFooter = new Panel();
            label1 = new Label();
            panelOpostive = new Panel();
            lblName = new Label();
            lblOpositiveCount = new Label();
            lblOpositive = new Label();
            panelOnegative = new Panel();
            label2 = new Label();
            lblOnegativeCount = new Label();
            lblOnegative = new Label();
            panelAnegative = new Panel();
            label5 = new Label();
            lblAnegativeCount = new Label();
            lblAnegative = new Label();
            panelApositive = new Panel();
            label8 = new Label();
            lblApositiveCount = new Label();
            lblApositive = new Label();
            panelABnegative = new Panel();
            label11 = new Label();
            lblABnegativeCount = new Label();
            lblABnegative = new Label();
            panelABpositive = new Panel();
            label14 = new Label();
            lblABpositiveCount = new Label();
            lblABpositive = new Label();
            panelBnegative = new Panel();
            label17 = new Label();
            lblBnegativeCount = new Label();
            lblBnegative = new Label();
            panelBpositive = new Panel();
            label20 = new Label();
            lblBpositiveCount = new Label();
            lblBpositive = new Label();
            dgvDonors = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            picClose = new PictureBox();
            menuStripTop.SuspendLayout();
            panelFooter.SuspendLayout();
            panelOpostive.SuspendLayout();
            panelOnegative.SuspendLayout();
            panelAnegative.SuspendLayout();
            panelApositive.SuspendLayout();
            panelABnegative.SuspendLayout();
            panelABpositive.SuspendLayout();
            panelBnegative.SuspendLayout();
            panelBpositive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            SuspendLayout();
            // 
            // menuStripTop
            // 
            menuStripTop.BackColor = SystemColors.Control;
            menuStripTop.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuStripTop.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem, donorsToolStripMenuItem });
            menuStripTop.Location = new Point(0, 0);
            menuStripTop.Name = "menuStripTop";
            menuStripTop.Padding = new Padding(6, 10, 0, 10);
            menuStripTop.Size = new Size(1138, 44);
            menuStripTop.TabIndex = 0;
            menuStripTop.Text = "menuStripTop";
            menuStripTop.ItemClicked += menuStripTop_ItemClicked;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(60, 24);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click_1;
            // 
            // donorsToolStripMenuItem
            // 
            donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            donorsToolStripMenuItem.Size = new Size(72, 24);
            donorsToolStripMenuItem.Text = "Donors";
            donorsToolStripMenuItem.Click += donorsToolStripMenuItem_Click;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = SystemColors.Control;
            panelFooter.Controls.Add(label1);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 614);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1138, 25);
            panelFooter.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(91, 8);
            label1.Name = "label1";
            label1.Size = new Size(204, 17);
            label1.TabIndex = 0;
            label1.Text = "Blood Bank Managment System";
            // 
            // panelOpostive
            // 
            panelOpostive.BackColor = SystemColors.Control;
            panelOpostive.Controls.Add(lblName);
            panelOpostive.Controls.Add(lblOpositiveCount);
            panelOpostive.Controls.Add(lblOpositive);
            panelOpostive.Location = new Point(12, 72);
            panelOpostive.Name = "panelOpostive";
            panelOpostive.Size = new Size(200, 100);
            panelOpostive.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(127, 62);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 21);
            lblName.TabIndex = 2;
            lblName.Text = "Donors";
            // 
            // lblOpositiveCount
            // 
            lblOpositiveCount.AutoSize = true;
            lblOpositiveCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpositiveCount.Location = new Point(136, 15);
            lblOpositiveCount.Name = "lblOpositiveCount";
            lblOpositiveCount.Size = new Size(40, 47);
            lblOpositiveCount.TabIndex = 1;
            lblOpositiveCount.Text = "0";
            // 
            // lblOpositive
            // 
            lblOpositive.AutoSize = true;
            lblOpositive.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpositive.ForeColor = Color.Firebrick;
            lblOpositive.Location = new Point(3, 15);
            lblOpositive.Name = "lblOpositive";
            lblOpositive.Size = new Size(98, 65);
            lblOpositive.TabIndex = 0;
            lblOpositive.Text = "O+";
            // 
            // panelOnegative
            // 
            panelOnegative.BackColor = SystemColors.Control;
            panelOnegative.Controls.Add(label2);
            panelOnegative.Controls.Add(lblOnegativeCount);
            panelOnegative.Controls.Add(lblOnegative);
            panelOnegative.Location = new Point(265, 72);
            panelOnegative.Name = "panelOnegative";
            panelOnegative.Size = new Size(200, 100);
            panelOnegative.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(127, 62);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 2;
            label2.Text = "Donors";
            // 
            // lblOnegativeCount
            // 
            lblOnegativeCount.AutoSize = true;
            lblOnegativeCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOnegativeCount.Location = new Point(136, 15);
            lblOnegativeCount.Name = "lblOnegativeCount";
            lblOnegativeCount.Size = new Size(40, 47);
            lblOnegativeCount.TabIndex = 1;
            lblOnegativeCount.Text = "0";
            // 
            // lblOnegative
            // 
            lblOnegative.AutoSize = true;
            lblOnegative.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblOnegative.ForeColor = Color.Firebrick;
            lblOnegative.Location = new Point(3, 15);
            lblOnegative.Name = "lblOnegative";
            lblOnegative.Size = new Size(83, 65);
            lblOnegative.TabIndex = 0;
            lblOnegative.Text = "O-";
            // 
            // panelAnegative
            // 
            panelAnegative.BackColor = SystemColors.Control;
            panelAnegative.Controls.Add(label5);
            panelAnegative.Controls.Add(lblAnegativeCount);
            panelAnegative.Controls.Add(lblAnegative);
            panelAnegative.Location = new Point(265, 199);
            panelAnegative.Name = "panelAnegative";
            panelAnegative.Size = new Size(200, 100);
            panelAnegative.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(127, 62);
            label5.Name = "label5";
            label5.Size = new Size(60, 21);
            label5.TabIndex = 2;
            label5.Text = "Donors";
            // 
            // lblAnegativeCount
            // 
            lblAnegativeCount.AutoSize = true;
            lblAnegativeCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnegativeCount.Location = new Point(136, 15);
            lblAnegativeCount.Name = "lblAnegativeCount";
            lblAnegativeCount.Size = new Size(40, 47);
            lblAnegativeCount.TabIndex = 1;
            lblAnegativeCount.Text = "0";
            // 
            // lblAnegative
            // 
            lblAnegative.AutoSize = true;
            lblAnegative.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnegative.ForeColor = Color.Firebrick;
            lblAnegative.Location = new Point(3, 15);
            lblAnegative.Name = "lblAnegative";
            lblAnegative.Size = new Size(81, 65);
            lblAnegative.TabIndex = 0;
            lblAnegative.Text = "A-";
            // 
            // panelApositive
            // 
            panelApositive.BackColor = SystemColors.Control;
            panelApositive.Controls.Add(label8);
            panelApositive.Controls.Add(lblApositiveCount);
            panelApositive.Controls.Add(lblApositive);
            panelApositive.Location = new Point(12, 199);
            panelApositive.Name = "panelApositive";
            panelApositive.Size = new Size(200, 100);
            panelApositive.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(127, 62);
            label8.Name = "label8";
            label8.Size = new Size(60, 21);
            label8.TabIndex = 2;
            label8.Text = "Donors";
            // 
            // lblApositiveCount
            // 
            lblApositiveCount.AutoSize = true;
            lblApositiveCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblApositiveCount.Location = new Point(136, 15);
            lblApositiveCount.Name = "lblApositiveCount";
            lblApositiveCount.Size = new Size(40, 47);
            lblApositiveCount.TabIndex = 1;
            lblApositiveCount.Text = "0";
            // 
            // lblApositive
            // 
            lblApositive.AutoSize = true;
            lblApositive.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblApositive.ForeColor = Color.Firebrick;
            lblApositive.Location = new Point(3, 15);
            lblApositive.Name = "lblApositive";
            lblApositive.Size = new Size(96, 65);
            lblApositive.TabIndex = 0;
            lblApositive.Text = "A+";
            // 
            // panelABnegative
            // 
            panelABnegative.BackColor = SystemColors.Control;
            panelABnegative.Controls.Add(label11);
            panelABnegative.Controls.Add(lblABnegativeCount);
            panelABnegative.Controls.Add(lblABnegative);
            panelABnegative.Location = new Point(268, 456);
            panelABnegative.Name = "panelABnegative";
            panelABnegative.Size = new Size(200, 100);
            panelABnegative.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(127, 62);
            label11.Name = "label11";
            label11.Size = new Size(60, 21);
            label11.TabIndex = 2;
            label11.Text = "Donors";
            // 
            // lblABnegativeCount
            // 
            lblABnegativeCount.AutoSize = true;
            lblABnegativeCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblABnegativeCount.Location = new Point(136, 15);
            lblABnegativeCount.Name = "lblABnegativeCount";
            lblABnegativeCount.Size = new Size(40, 47);
            lblABnegativeCount.TabIndex = 1;
            lblABnegativeCount.Text = "0";
            // 
            // lblABnegative
            // 
            lblABnegative.AutoSize = true;
            lblABnegative.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblABnegative.ForeColor = Color.Firebrick;
            lblABnegative.Location = new Point(3, 15);
            lblABnegative.Name = "lblABnegative";
            lblABnegative.Size = new Size(112, 65);
            lblABnegative.TabIndex = 0;
            lblABnegative.Text = "AB-";
            // 
            // panelABpositive
            // 
            panelABpositive.BackColor = SystemColors.Control;
            panelABpositive.Controls.Add(label14);
            panelABpositive.Controls.Add(lblABpositiveCount);
            panelABpositive.Controls.Add(lblABpositive);
            panelABpositive.Location = new Point(15, 456);
            panelABpositive.Name = "panelABpositive";
            panelABpositive.Size = new Size(200, 100);
            panelABpositive.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(127, 62);
            label14.Name = "label14";
            label14.Size = new Size(60, 21);
            label14.TabIndex = 2;
            label14.Text = "Donors";
            // 
            // lblABpositiveCount
            // 
            lblABpositiveCount.AutoSize = true;
            lblABpositiveCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblABpositiveCount.Location = new Point(136, 15);
            lblABpositiveCount.Name = "lblABpositiveCount";
            lblABpositiveCount.Size = new Size(40, 47);
            lblABpositiveCount.TabIndex = 1;
            lblABpositiveCount.Text = "0";
            // 
            // lblABpositive
            // 
            lblABpositive.AutoSize = true;
            lblABpositive.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblABpositive.ForeColor = Color.Firebrick;
            lblABpositive.Location = new Point(3, 15);
            lblABpositive.Name = "lblABpositive";
            lblABpositive.Size = new Size(127, 65);
            lblABpositive.TabIndex = 0;
            lblABpositive.Text = "AB+";
            lblABpositive.Click += label16_Click;
            // 
            // panelBnegative
            // 
            panelBnegative.BackColor = SystemColors.Control;
            panelBnegative.Controls.Add(label17);
            panelBnegative.Controls.Add(lblBnegativeCount);
            panelBnegative.Controls.Add(lblBnegative);
            panelBnegative.Location = new Point(268, 324);
            panelBnegative.Name = "panelBnegative";
            panelBnegative.Size = new Size(200, 100);
            panelBnegative.TabIndex = 7;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(127, 62);
            label17.Name = "label17";
            label17.Size = new Size(60, 21);
            label17.TabIndex = 2;
            label17.Text = "Donors";
            // 
            // lblBnegativeCount
            // 
            lblBnegativeCount.AutoSize = true;
            lblBnegativeCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBnegativeCount.Location = new Point(136, 15);
            lblBnegativeCount.Name = "lblBnegativeCount";
            lblBnegativeCount.Size = new Size(40, 47);
            lblBnegativeCount.TabIndex = 1;
            lblBnegativeCount.Text = "0";
            // 
            // lblBnegative
            // 
            lblBnegative.AutoSize = true;
            lblBnegative.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblBnegative.ForeColor = Color.Firebrick;
            lblBnegative.Location = new Point(3, 15);
            lblBnegative.Name = "lblBnegative";
            lblBnegative.Size = new Size(78, 65);
            lblBnegative.TabIndex = 0;
            lblBnegative.Text = "B-";
            // 
            // panelBpositive
            // 
            panelBpositive.BackColor = SystemColors.Control;
            panelBpositive.Controls.Add(label20);
            panelBpositive.Controls.Add(lblBpositiveCount);
            panelBpositive.Controls.Add(lblBpositive);
            panelBpositive.Location = new Point(15, 324);
            panelBpositive.Name = "panelBpositive";
            panelBpositive.Size = new Size(200, 100);
            panelBpositive.TabIndex = 6;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(127, 62);
            label20.Name = "label20";
            label20.Size = new Size(60, 21);
            label20.TabIndex = 2;
            label20.Text = "Donors";
            // 
            // lblBpositiveCount
            // 
            lblBpositiveCount.AutoSize = true;
            lblBpositiveCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBpositiveCount.Location = new Point(136, 15);
            lblBpositiveCount.Name = "lblBpositiveCount";
            lblBpositiveCount.Size = new Size(40, 47);
            lblBpositiveCount.TabIndex = 1;
            lblBpositiveCount.Text = "0";
            // 
            // lblBpositive
            // 
            lblBpositive.AutoSize = true;
            lblBpositive.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblBpositive.ForeColor = Color.Firebrick;
            lblBpositive.Location = new Point(3, 15);
            lblBpositive.Name = "lblBpositive";
            lblBpositive.Size = new Size(93, 65);
            lblBpositive.TabIndex = 0;
            lblBpositive.Text = "B+";
            // 
            // dgvDonors
            // 
            dgvDonors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonors.Location = new Point(620, 153);
            dgvDonors.Name = "dgvDonors";
            dgvDonors.RowTemplate.Height = 25;
            dgvDonors.Size = new Size(496, 403);
            dgvDonors.TabIndex = 10;
            dgvDonors.CellContentClick += dgvDonors_CellContentClick;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(620, 125);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(88, 15);
            lblSearch.TabIndex = 11;
            lblSearch.Text = "Search Donors";
            lblSearch.Click += lblSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(714, 124);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(372, 23);
            txtSearch.TabIndex = 12;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // picClose
            // 
            picClose.BackColor = SystemColors.GradientInactiveCaption;
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(1077, 47);
            picClose.Name = "picClose";
            picClose.Size = new Size(49, 47);
            picClose.TabIndex = 13;
            picClose.TabStop = false;
            picClose.Click += pictureBox1_Click;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1138, 639);
            Controls.Add(picClose);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvDonors);
            Controls.Add(panelABnegative);
            Controls.Add(panelAnegative);
            Controls.Add(panelABpositive);
            Controls.Add(panelApositive);
            Controls.Add(panelBnegative);
            Controls.Add(panelBpositive);
            Controls.Add(panelOnegative);
            Controls.Add(panelOpostive);
            Controls.Add(panelFooter);
            Controls.Add(menuStripTop);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStripTop;
            Name = "FrmHome";
            Text = "Home";
            Activated += FrmHome_Activated;
            Load += FrmHome_Load;
            menuStripTop.ResumeLayout(false);
            menuStripTop.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            panelOpostive.ResumeLayout(false);
            panelOpostive.PerformLayout();
            panelOnegative.ResumeLayout(false);
            panelOnegative.PerformLayout();
            panelAnegative.ResumeLayout(false);
            panelAnegative.PerformLayout();
            panelApositive.ResumeLayout(false);
            panelApositive.PerformLayout();
            panelABnegative.ResumeLayout(false);
            panelABnegative.PerformLayout();
            panelABpositive.ResumeLayout(false);
            panelABpositive.PerformLayout();
            panelBnegative.ResumeLayout(false);
            panelBnegative.PerformLayout();
            panelBpositive.ResumeLayout(false);
            panelBpositive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonors).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripTop;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem donorsToolStripMenuItem;
        private Panel panelFooter;
        private Label label1;
        private Panel panelOpostive;
        private Label lblOpositiveCount;
        private Label lblOpositive;
        private Label lblName;
        private Panel panelOnegative;
        private Label label2;
        private Label lblOnegativeCount;
        private Label lblOnegative;
        private Panel panelAnegative;
        private Label label5;
        private Label lblAnegativeCount;
        private Label lblAnegative;
        private Panel panelApositive;
        private Label label8;
        private Label lblApositiveCount;
        private Label lblApositive;
        private Panel panelABnegative;
        private Label label11;
        private Label lblABnegativeCount;
        private Label lblABnegative;
        private Panel panelABpositive;
        private Label label14;
        private Label lblABpositiveCount;
        private Label lblABpositive;
        private Panel panelBnegative;
        private Label label17;
        private Label lblBnegativeCount;
        private Label lblBnegative;
        private Panel panelBpositive;
        private Label label20;
        private Label lblBpositiveCount;
        private Label lblBpositive;
        private DataGridView dgvDonors;
        private Label lblSearch;
        private TextBox txtSearch;
        private PictureBox picClose;
    }
}