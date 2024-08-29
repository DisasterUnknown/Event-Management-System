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
        public void ViewEventDetails(DataGridView G1)
        {
            MyDb.ViewEvents(G1);
        }


        // Function to call the AddEvent method in Event.cs
        public void orgAddAndUpdateEvent(string name, string eventName, string price, string place, int patientCount, string time, string date, string organizerName, string eventId, Form f1, string functionType)
        {
            if ((name.Length < 2) || (name.Length > 20))
            {
                MessageBox.Show("Invalide Event Name!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((place.Length < 3) || (place.Length > 50))
            {
                MessageBox.Show("The place is invalide!!", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (patientCount < 5)
            {
                MessageBox.Show("Insuficent particepent count!!", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (price.Length < 2)
            {
                MessageBox.Show("The price should be grater thn Rs. 50!!", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Debug MessageBox
                //MessageBox.Show($"Name: {name}\nPrice: {price}\nPlace: {place}\nPcount: {patientCount}\nTime: {time}\nDate: {date}\nOrg: {organizerName}");

                Event e1 = new Event(name, eventName, price, place, patientCount, time, date, organizerName, eventId, f1, functionType);
            }
        }


        // Update Page navigation (Display the update page by checking the permision)
        public void ViewUpdate(string organizer, DataGridView G1, Form f1)
        {
            if (G1.SelectedRows.Count > 0)
            {
                string eventOrganizer = G1.SelectedRows[0].Cells["Organizer"].Value.ToString();
                string eventId = G1.SelectedRows[0].Cells["Id"].Value.ToString();

                if (eventOrganizer == organizer)
                {
                    CreateEvent c1 = new CreateEvent(organizer, eventId, "Update");
                    c1.Show();
                    f1.Hide();
                }
                else
                {
                    MessageBox.Show("Permision denieled!!\nOnly the event owner can update the event!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select the event to be edited!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Remove Event
        public void RemoveEvent(string organizer, DataGridView G1)
        {
            if (G1.SelectedRows.Count > 0)
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
            else
            {
                MessageBox.Show("Please select the event to be removed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // View Event Details
        public void OrgViewEventDetails(string organizer, DataGridView G1, Form f1)
        {
            if (G1.SelectedRows.Count > 0)
            {
                string eventOrganizer = G1.SelectedRows[0].Cells["Organizer"].Value.ToString();
                string eventId = G1.SelectedRows[0].Cells["Id"].Value.ToString();

                if (organizer == eventOrganizer)
                {
                    ViewEvent v1 = new ViewEvent(eventId, organizer);
                    v1.Show();
                    f1.Hide();
                }
                else
                {
                    MessageBox.Show("Permision denieled!!\nOnly the event owner can view event details!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select the event to be removed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
