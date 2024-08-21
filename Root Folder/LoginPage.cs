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

        public LoginPage(string role)
        {
            InitializeComponent();
            this.role = role;
        }

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

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (role == "particepent")
            {
                CustemerDashbord c1 = new CustemerDashbord();
                this.Hide();
                c1.Show();
            }
            else if (role == "orgnizer")
            {
                OganizerDashbord o1 = new OganizerDashbord();
                this.Hide();
                o1.Show();
            }
            else
            {
                AdminDashbord a1 = new AdminDashbord();
                this.Hide();
                a1.Show();
            }
        }
    }
}
