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
        private string id;
        private string password;
        private string email;
        private string phoneNo;
        private static string discription;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Id { get { return id; } set { id = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string PhoneNo { get { return phoneNo; } set { phoneNo = value; } }
        //public string Discription { get { return discription; } set { discription = value; } }

        public Person(string name, int age, string id, string password, string email, string phoneNo) 
        {
            this.name = name;
            this.age = age;
            this.id = id;
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

        public static void PersonDetails(Person p)
        {
            MessageBox.Show($"Name: {p.name}\nAge: {p.age}\nID: {p.id}\nPass: {p.password}\nEmail: {p.email}\nPhone: {p.phoneNo}");
        }

    }
}
