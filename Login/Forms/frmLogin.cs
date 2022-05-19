using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.BL;
using Login.DL;

namespace Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginAs=combxLoginAs.SelectedItem.ToString();
            string username = txtbxUsername.Text;
            string password = txtbxPassword.Text;
            Crediational crediational = new Crediational();
            bool checkCondition=crediational.checkUser(loginAs,username, password, CrediantialDL.getCrediationalList());
            if (checkCondition)
            {
                MessageBox.Show("Login Successfully", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            combxLoginAs.Text = "Select one option";
            txtbxUsername.Clear();
            txtbxPassword.Clear();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            frmCreateAccount f = new frmCreateAccount();
            f.Show();
            this.Hide();
        }
    }
}
