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
            try
            {
                string name = UnameIN.Text;
                string gmail = GmailIN.Text;
                int age = int.Parse(AgeIN.Text);
                int tel = int.Parse((TelIN.Text).Replace(" ", string.Empty));
                string pass = PassIN.Text;
                string comPass = ComPassIN.Text;



                // Checking for form validation!!
                if ((name.Replace(" ", string.Empty).Length < 2))
                {
                    MessageBox.Show("Your Uname Entry's Invalid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((!(gmail.Contains("@"))) || gmail.Length < 11)
                {
                    MessageBox.Show("Your Gmail Entry's Invalid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((($"{age}").Replace(" ", string.Empty).Length < 1))
                {
                    MessageBox.Show("Please Enter Your Age!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((($"{tel}").Replace(" ", string.Empty).Length < 10))
                {
                    MessageBox.Show("Your Tel. No. Entry's Invalid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((pass != comPass))
                {
                    MessageBox.Show("Your Password Entry's Invalid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                // Creating the object and calling the register method
                if ((name.Length != 0) && (($"{age}").Length != 0) && (gmail.Contains("@") && gmail.Length > 10) && (($"{tel}").Length == 10) && (pass == comPass))
                {
                    Person p1 = new Person(name, age, pass, gmail, tel, role);
                    p1.Register();
                }
            }
            catch 
            {
                MessageBox.Show("Please Fill the Form!!", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AgeIN_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            AgeIN.Text = string.Empty;
        }

        private void TelIN_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            TelIN.Text = string.Empty;
        }
    }
}
