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
    public partial class RegisterPage : Form
    {
        private string role;
        public RegisterPage(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginPage l1 = new LoginPage(role);
            l1.Show();
            this.Hide();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string name = UnameIN.Text;
            string gmail = GmailIN.Text;
            int age = int.Parse(AgeIN.Text);
            int tel = int.Parse((TelIN.Text).Replace(" ", string.Empty));
            string pass = PassIN.Text;
            string comPass = ComPassIN.Text;

            if (pass != comPass)
            { 
                MessageBox.Show("Your Password Entry's Invalid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Person p1 = new Person(name, age, pass, gmail, tel, role);
                p1.Register();
            }
        }
    }
}
