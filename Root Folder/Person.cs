using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Folder
{
    internal class Person
    {
        private string name;
        private int age;
        private string password;
        private string email;
        private long phoneNo;
        private string role;
        private static string discription;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
        public long PhoneNo { get { return phoneNo; } set { phoneNo = value; } }
        public string Role { get { return role; } set { role = value; } }

        public Person(string name, int age, string password, string comPassword, string email, long phoneNo, string role, Form f1) 
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
                this.name = name;
                this.age = age;
                this.password = password;
                this.email = email;
                this.phoneNo = phoneNo;
                this.role = role;

                Register(f1);
            }
        }

        // Fun to set discription
        public static void SetDiscription(string userDiscription)
        {
            discription = userDiscription;
        }

        // Fun to return discription
        public static string GetDiscription() 
        { 
            return discription;
        }

        // Debug function to print the user details
        public void PersonDetails()
        {
            MessageBox.Show($"Name: {Name}\nAge: {Age}\nPass: {Password}\nEmail: {Email}\nPhone: {PhoneNo}\n Role: {Role}");
        }

        // Function used to register the user
        public void Register(Form f1)
        {
                MyDb.RegisterPerson(Name, Email, Age, PhoneNo, Password, Role, f1);
        }

        // Function to login the user
        public static void Login(string uname, string pass, string role, Form f1)
        {
            MyDb.UserLogin(uname, pass, role, f1);
        }

    }
}
