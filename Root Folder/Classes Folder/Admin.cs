using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Folder
{
    internal class Admin : Person
    {
        public Admin() { }
        public Admin(string name, int age, string password, string email, string phoneNo, string role) : base(name, age, password, email, phoneNo, role) { }

        // Person register function
        public override void Register(Person A1, Form f1)
        {
            MyDb.RegisterPerson(A1, f1);
        }

        public override void Login(string uname, string pass, string role, Form f1)
        {
            MyDb.UserLogin(uname, pass, role, f1);
        }
    }
}
