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
        private int phoneNo;
        private string role;
        private static string discription;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int PhoneNo { get { return phoneNo; } set { phoneNo = value; } }
        public string Role { get { return role; } set { role = value; } }

        public Person(string name, int age, string password, string email, int phoneNo) 
        {
            this.name = name;
            this.age = age;
            this.password = password;
            this.email = email;
            this.phoneNo = phoneNo;
        }

        public static void SetDiscription(string userDiscription)
        {
            discription = userDiscription;
        }

        public static string GetDiscription() 
        { 
            return discription;
        }

        public void PersonDetails(Person p)
        {
            MessageBox.Show($"Name: {p.name}\nAge: {p.age}\nPass: {p.password}\nEmail: {p.email}\nPhone: {p.phoneNo}");
        }

        public void Register()
        {
            MyDb.RegisterPerson(Name, Email, Age, PhoneNo, Password, Role);
        }

    }
}
