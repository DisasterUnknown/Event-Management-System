using Microsoft.VisualBasic.ApplicationServices;
using Root_Folder.Classes_Folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Folder
{
    internal class Participant : Person
    {
        public Participant() { }
        public Participant(string name, int age, string password, string email, string phoneNo, string role) : base(name, age, password, email, phoneNo, role) { }
        public Participant(string name, string password, string role) : base(name, password, role) { }


        // Loading the data in the event join page onload
        public void EventJoinPageOnLoad(string EventId, JoinEvent f1)
        {
            ParticipantController.EventJoinPageOnLoad(EventId, f1);
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
            string UserID = ParticipantController.EventsJoinedView(Uname, G1);
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
