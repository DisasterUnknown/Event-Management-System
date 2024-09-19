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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using Root_Folder.Classes_Folder;

namespace Root_Folder
{
    internal class Organizer : Person, Admin_Organizer_Interface
    {
        public Organizer() { }
        public Organizer(string name, int age, string password, string email, string phoneNo, string role) : base(name, age, password, email, phoneNo, role) { }
        public Organizer(string name, string password, string role) : base(name, password, role) { }


        // Add event
        public void AddEvent(Event E1, Form f1)
        {
            E1.AddEvent(E1, f1);
        }


        // Display content in the update page
        public void UpdateEventDispayContent(string eventID, CreateEvent f1)
        {
            OrganizerController.UpdateEventDispayContent(eventID, f1);
        }

        // Upadte event
        public void UpdateEvent(Event E1, string eventName, string eventId, Form f1)
        {
            E1.UpdateEvent(E1, eventName, eventId, f1);
        }


        // Remove Event
        public void RemoveEvent(string organizer, DataGridView G1)
        {
            string eventOrganizer = G1.SelectedRows[0].Cells["Organizer"].Value.ToString();
            string eventId = G1.SelectedRows[0].Cells["Id"].Value.ToString();

            if (organizer == eventOrganizer)
            {
                Event e1 = new Event();
                e1.RemoveEvent(eventId, G1);
            }
            else
            {
                MessageBox.Show("Permision denieled!!\nOnly the event owner can remove the event!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
