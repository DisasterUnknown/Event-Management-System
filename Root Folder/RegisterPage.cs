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

                Person p1 = new Person(name, age, pass, comPass, gmail, tel, role);  
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
