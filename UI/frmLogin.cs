using BloodManagmentSystem.BLL;
using BloodManagmentSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagmentSystem.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text;
            l.password = txtPassword.Text;

            bool isSuccess = dal.loginCheck(l);
            if (isSuccess==true) {
                MessageBox.Show("Login successful");
                FrmHome home = new FrmHome();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Try Again");
            }





        }
    }
}
