using BloodManagmentSystem.BLL;
using BloodManagmentSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagmentSystem.UI
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        string imageName = "no-image.jpg";

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            u.full_name = txtFullName.Text;
            u.email = txtEmail.Text;
            u.username = txtUserName.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            bool success = dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("New User Added Successfully");

                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Faild to Add user .");
            }


        }


        public void Clear()
        {
            txtUserID.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[RowIndex].Cells[0].Value.ToString();
            txtUserName.Text = dgvUsers.Rows[RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[RowIndex].Cells[3].Value.ToString();
            txtFullName.Text = dgvUsers.Rows[RowIndex].Cells[4].Value.ToString();
            txtContact.Text = dgvUsers.Rows[RowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[RowIndex].Cells[6].Value.ToString();
            imageName = dgvUsers.Rows[RowIndex].Cells[8].Value.ToString();
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            if (imageName != "no-image.jpg")
            {
                string imagePath = paths + "//images//" + imageName;
            }

        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            u.user_id = int.Parse(txtUserID.Text);
            u.full_name = txtFullName.Text;
            u.email = txtEmail.Text;
            u.username = txtUserName.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            bool success = dal.Update(u);
            if (success == true)
            {
                MessageBox.Show("User Updated Successfully");
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
                Clear();


            }
            else
            {
                MessageBox.Show("Faild to Add user .");
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            u.user_id = int.Parse(txtUserID.Text);
            bool success = dal.Delete(u);
            if (success == true)
            {
                MessageBox.Show("User Deleted Successfully");
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
                Clear();


            }
            else
            {
                MessageBox.Show("Faild to Delete user .");
            }



        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.PNG; *.gif;)|*.jpg; *.jpeg; *.png; *.PNG; *.gif;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    pictureBoxProfilePicture.Image = new Bitmap(open.FileName);


                    string ext = Path.GetExtension(open.FileName);
                    Random random = new Random();
                    int RandInt = random.Next(0, 1000);

                    imageName = "Blood_Bank_MS_" + RandInt + ext;

                    string sourcePath = open.FileName;
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length);
                    string destinationPath = paths + "//images//" + imageName;
                    File.Copy(sourcePath, destinationPath);
                    MessageBox.Show("Image Successfully Uploaded");

                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);

                dgvUsers.DataSource = dt;
            }

            else
            {

                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;


            }





        }
    }
}
