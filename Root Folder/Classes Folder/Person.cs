using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Folder
{
    internal abstract class Person
    {
        private string name;
        private int age;
        private string password;
        private string email;
        private string phoneNo;
        private string role;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string PhoneNo { get { return phoneNo; } set { phoneNo = value; } }
        public string Role { get { return role; } set { role = value; } }

        public Person() { }

        public Person(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public Person(string name, int age, string password, string email, string phoneNo, string role) 
        {
            this.name = name;
            this.age = age;
            this.password = password;
            this.email = email;
            this.phoneNo = phoneNo;
            this.role = role;
        }

        // Debug function to print the user details
        public void PersonDetails()
        {
            MessageBox.Show($"Name: {Name}\nAge: {Age}\nPass: {Password}\nEmail: {Email}\nPhone: {PhoneNo}\n Role: {Role}");
        }


        // Abstract Methods
        public abstract void Register(Person P1, Form f1);
        public abstract void Login(string uname, string pass, string role, Form f1);

    }
}
