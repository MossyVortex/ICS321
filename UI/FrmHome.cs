using BloodManagmentSystem.DAL;
using BloodManagmentSystem.UI;
using System.Data;
using System.Windows.Forms;

namespace BloodManagmentSystem
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        donorDAL Dal = new donorDAL();

        private void menuStripTop_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvDonors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void usersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmUsers users = new FrmUsers();
            users.Show();
        }

        private void donorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonors donors = new frmDonors();
            donors.Show();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            allDonorCount();

            DataTable dt = Dal.Select();
            dgvDonors.DataSource = dt;


        }

        public void allDonorCount()
        {
            // get the blood count from all donors

            //O
            lblOpositiveCount.Text = Dal.countDonors("O+");
            lblOnegativeCount.Text = Dal.countDonors("O-");

            //A
            lblApositiveCount.Text = Dal.countDonors("A+");
            lblAnegativeCount.Text = Dal.countDonors("A-");


            //B
            lblBpositiveCount.Text = Dal.countDonors("B+");
            lblBnegativeCount.Text = Dal.countDonors("B-");

            //AB
            lblABpositiveCount.Text = Dal.countDonors("AB+");
            lblABnegativeCount.Text = Dal.countDonors("AB-");



        }

        private void FrmHome_Activated(object sender, EventArgs e)
        {
            allDonorCount();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = Dal.Search(keywords);

                dgvDonors.DataSource = dt;
            }
            else
            {

                DataTable dt = Dal.Select();
                dgvDonors.DataSource = dt;


            }
        }
    }
}