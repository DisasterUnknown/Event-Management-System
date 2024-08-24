using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Org.BouncyCastle.Crypto.Macs;

namespace Root_Folder
{
    internal class Organizer:Person
    {
        public Organizer() { }

        public override void Register(string name, int age, string password, string comPassword, string email, long phoneNo, string role, Form f1)
        {
            // Checking for form validation!!
            if ((name.Replace(" ", string.Empty).Length < 2))
            {
                MessageBox.Show("Your Uname Entry's Invalid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((!(email.Contains("@"))) || email.Length < 11)
            {
                MessageBox.Show("Your Gmail Entry's Invalid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((($"{age}").Replace(" ", string.Empty).Length < 1))
            {
                MessageBox.Show("Please Enter Your Age!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((($"{phoneNo}").Replace(" ", string.Empty).Length < 10))
            {
                MessageBox.Show($"Your Tel. No. Entry's Invalid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((password != comPassword))
            {
                MessageBox.Show("Your Password Entry's Invalid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MyDb.RegisterPerson(name, email, age, phoneNo, password, role, f1);
            }
        }

        public override void Login(string uname, string pass, string role, Form f1)
        {
            MyDb.UserLogin(uname, pass, role, f1);
        }
    }
}
