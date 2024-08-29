using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Root_Folder
{
    public partial class RegisterPage : Form
    {
        private string role;
        private bool isPassVisible = false;

        public RegisterPage(string role)
        {
            InitializeComponent();
            this.role = role;
        }


        // Page Onload
        private void RegisterPage_Load(object sender, EventArgs e)
        {
            if (role == "admin")
            {
                label8.Visible = true;
                AdminPassIN.Visible = true;
            }
            else
            {
                label8.Visible = false;
                AdminPassIN.Visible = false;
            }
        }


        // Back Btn
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginPage l1 = new LoginPage(role);
            l1.Show();
            this.Hide();
        }


        // Register Button function
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = UnameIN.Text;
                string gmail = GmailIN.Text;
                int age = int.Parse(AgeIN.Text);
                string tel = (TelIN.Text).Replace(" ", string.Empty);
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
                    MessageBox.Show($"Your Tel. No. Entry's Invalid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pass == "")
                {
                    MessageBox.Show("Pleas enter a password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((pass != comPass))
                {
                    MessageBox.Show("Your Password Entry's Invalid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Creating the objects
                    if (role == "AD")
                    {
                        string adminID = AdminPassIN.Text;
                        if (adminID == "admin123")
                        {
                            Person p1 = new Admin(name, age, pass, gmail, tel, role);
                            p1.Register(p1, this);
                        }
                        else
                        {
                            MessageBox.Show("Invalide Admin ID!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (role == "OR")
                    {
                        Person p1 = new Organizer(name, age, pass, gmail, tel, role);
                        p1.Register(p1, this);
                    }
                    else
                    {
                        Person p1 = new Organizer(name, age, pass, gmail, tel, role);
                        p1.Register(p1, this);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please Fill the Form!!", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Functions to empty the strin in the MaskInputBoxes (Styling)
        private void AgeIN_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            AgeIN.Text = string.Empty;
        }

        private void TelIN_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            TelIN.Text = string.Empty;
        }


        // Functions to show the password (togle)
        private void ViewPass1_Click(object sender, EventArgs e)
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

        private void ViewPass2_Click(object sender, EventArgs e)
        {
            isPassVisible = !isPassVisible;

            if (isPassVisible)
            {
                ComPassIN.PasswordChar = '\0';
            }
            else
            {
                ComPassIN.PasswordChar = '•';
            }
        }
    }
}
