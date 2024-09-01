using Microsoft.VisualBasic.ApplicationServices;
using Root_Folder.Classes_Folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Folder
{
    internal class Participant : Person, Interface
    {
        public Participant() { }
        public Participant(string name, int age, string password, string email, string phoneNo, string role) : base(name, age, password, email, phoneNo, role) { }
        public Participant(string name, string password, string role) : base(name, password, role) { }

        // Person register function
        public override void Register(Person P1, Form f1)
        {
            MyDb.RegisterPerson(P1, f1);
        }

        // Login
        public override void Login(Person P1, Form f1)
        {
            MyDb.UserLogin(P1, f1);
        }


        // View Events
        public override void ViewEventDetails(DataGridView G1)
        {
            MyDb.ViewEvents(G1);
        }


        // Join Event
        public void JoinEvent(string Uname, string EventId, Form f1)
        {
            Event e1 = new Event();
            e1.JoinEvent(Uname, EventId, f1);
        }


        // View Joined Events
        public string ViewJoinedEvents(string Uname, DataGridView G1)
        {
            string UserID = MyDb.EventsJoinedView(Uname, G1);
            return UserID;
        }


        // Leave Event
        public void LeaveEvent(string UserID, string Uname, DataGridView G1)
        {
            string EventID = G1.SelectedRows[0].Cells["Id"].Value.ToString();

            Event e1 = new Event();
            e1.LeaveEvent(EventID, Uname, G1);
        }
    }
}
