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
        public Admin(string name, string password, string role) :base(name, password, role) { }

        // Person register function
        public override void Register(Person A1, Form f1)
        {
            MyDb.RegisterPerson(A1, f1);
        }

        public override void Login(Person P1, Form f1)
        {
            MyDb.UserLogin(P1, f1);
        }

        public override void ViewEventDetails(DataGridView G1)
        {
            MyDb.ViewEvents(G1);
        }


        // Event remove function
        public void RemoveEvent(DataGridView G1)
        {
            string eventId = G1.SelectedRows[0].Cells["Id"].Value.ToString();

            Event e1 = new Event();
            e1.RemoveEvent(eventId, G1);
        }
    }
}
