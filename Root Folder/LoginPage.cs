using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Root_Folder
{
    public partial class LoginPage : Form
    {
        private string role;
        private bool isPassVisible = false;

        public LoginPage(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        // Page Navigation
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Back Btn to the home page
            HomePage h1 = new HomePage();
            h1.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage r1 = new RegisterPage(role);
            r1.Show();
            this.Hide();
        }


        // View Password
        private void ShowPassBtn_Click(object sender, EventArgs e)
        {
            isPassVisible = !isPassVisible;

            if (isPassVisible)
            {
                PassIN.PasswordChar = '\0';
            }
            else
            {
                PassIN.PasswordChar = '•';
            }

        }


        // LKogin Btn
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string uname = UnameIN.Text;
                string pass = PassIN.Text;

                Person.Login(uname, pass, role, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please Fill the Form!!", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
