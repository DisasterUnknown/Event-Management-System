using Root_Folder.Classes_Folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Folder
{
    internal class Admin : Person, PersonInterface
    {
        public Admin() { }
        public Admin(string name, int age, string password, string email, string phoneNo, string role) : base(name, age, password, email, phoneNo, role) { }
        public Admin(string name, string password, string role) :base(name, password, role) { }


        // Event remove function
        public void RemoveEvent(DataGridView G1)
        {
            string eventId = G1.SelectedRows[0].Cells["Id"].Value.ToString();

            Event e1 = new Event();
            e1.RemoveEvent(eventId, G1);
        }


        // Display all the user accounts in the grid
        public void ViewUserAccounts(DataGridView G1)
        {
            AdminController.ViewUserAccounts(G1);
        }


        // Remove Participant
        public void RemoveUser(string EventID, string Uname)
        {
            Event e1 = new Event();
            e1.RemoveParticipant(EventID, Uname);
        }


        // Kick user from the System
        public void KickUser(string Uname)
        {
            AdminController.KickUser(Uname);
        }
    }
}
