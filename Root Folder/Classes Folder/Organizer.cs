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

namespace Root_Folder
{
    internal class Organizer : Person
    {
        public Organizer() { }
        public Organizer(string name, int age, string password, string email, string phoneNo, string role) : base(name, age, password, email, phoneNo, role) { }
        public Organizer(string name, string password, string role) : base(name, password, role) { }

        // Person register function
        public override void Register(Person P1, Form f1)
        {
            MyDb.RegisterPerson(P1, f1);
        }

        public override void Login(Person P1, Form f1)
        {
            MyDb.UserLogin(P1, f1);
        }


        // View events
        public override void ViewEventDetails(DataGridView G1)
        {
            MyDb.ViewEvents(G1);
        }


        // Add event
        public void AddEvent(Event E1, Form f1)
        {
            E1.AddEvent(E1, f1);
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
