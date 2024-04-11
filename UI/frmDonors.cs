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
    public partial class frmDonors : Form
    {
        public frmDonors()
        {
            InitializeComponent();
        }

        donorBLL d = new donorBLL();
        donorDAL dal = new donorDAL();


        string imageName = "no-image.jpg";

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            d.first_name = txtFirstName.Text;
            d.last_name = txtLastName.Text;
            d.email = txtEmail.Text;
            d.contact = txtContact.Text;
            d.gender = cmbGender.Text;
            d.address = txtAddress.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.added_date = DateTime.Now;
            d.added_by = 1;//to do later
            d.image_name = imageName;







            bool success = dal.Insert(d);
            if (success == true)
            {
                MessageBox.Show("New User Added Successfully");

                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Faild to Add user .");
            }
        }


        public void Clear()
        {
            txtDonorID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            cmbGender.Text = "";
            cmbBloodGroup.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void frmDonors_Load(object sender, EventArgs e)
        {

            DataTable dt = dal.Select();
            dgvDonors.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            d.donor_id = int.Parse(txtDonorID.Text);
            d.first_name = txtFirstName.Text;
            d.last_name = txtLastName.Text;
            d.email = txtEmail.Text;
            d.contact = txtContact.Text;
            d.gender = cmbGender.Text;
            d.address = txtAddress.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.added_date = DateTime.Now;
            d.added_by = 1;//to do later
            d.image_name = imageName;

            bool success = dal.Update(d);
            if (success == true)
            {
                MessageBox.Show("User Updated Successfully");
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
                Clear();


            }
            else
            {
                MessageBox.Show("Faild to Add user .");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            d.donor_id = int.Parse(txtDonorID.Text);
            bool success = dal.Delete(d);
            if (success == true)
            {
                MessageBox.Show("Donor Deleted Successfully");
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
                Clear();


            }
            else
            {
                MessageBox.Show("Faild to Delete Donor .");
            }

        }

        private void dgvDonors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtDonorID.Text = dgvDonors.Rows[RowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvDonors.Rows[RowIndex].Cells[1].Value.ToString(); ;
            txtLastName.Text = dgvDonors.Rows[RowIndex].Cells[2].Value.ToString(); ;
            txtEmail.Text = dgvDonors.Rows[RowIndex].Cells[3].Value.ToString(); ;
            cmbGender.Text = dgvDonors.Rows[RowIndex].Cells[5].Value.ToString(); ;
            cmbBloodGroup.Text = dgvDonors.Rows[RowIndex].Cells[7].Value.ToString(); ;
            txtContact.Text = dgvDonors.Rows[RowIndex].Cells[4].Value.ToString(); ;
            txtAddress.Text = dgvDonors.Rows[RowIndex].Cells[6].Value.ToString(); ;
            string paths = Application.StartupPath.Substring(0, ((Application.StartupPath.Length) - 10));

            if (imageName != "no-image.jpg")
            {
                string imagePath = paths + "//images//" + imageName;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);

                dgvDonors.DataSource = dt;
            }

            else
            {

                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;


            }
        }
    }
}
