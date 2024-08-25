using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Folder
{
    internal class Particepent:Person
    {
        public Particepent() { }

        public override void Register(string name, int age, string password, string comPassword, string email, long phoneNo, string role, Form f1)
        {
            // Checking for form validation!!
            if ((name.Replace(" ", string.Empty).Length < 2))
            {
                MessageBox.Show("Your Uname Entry's Invalid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((!(email.Contains("@"))) || email.Length < 11)
            {
                MessageBox.Show("Your Gmail Entry's Invalid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((($"{age}").Replace(" ", string.Empty).Length < 1))
            {
                MessageBox.Show("Please Enter Your Age!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((($"{phoneNo}").Replace(" ", string.Empty).Length < 10))
            {
                MessageBox.Show($"Your Tel. No. Entry's Invalid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((password != comPassword))
            {
                MessageBox.Show("Your Password Entry's Invalid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MyDb.RegisterPerson(name, email, age, phoneNo, password, role, f1);
            }
        }

        // Login
        public override void Login(string uname, string pass, string role, Form f1)
        {
            MyDb.UserLogin(uname, pass, role, f1);
        }


        // View Events
        public void ViewEventDetails(DataGridView G1)
        {
            MyDb.ViewEvents(G1);
        }


        // Display Join Event Page
        public void ViewEventJoinPage(string Uname, DataGridView G1, Form F1)
        {
            if (G1.SelectedRows.Count > 0)
            {
                string eventID = G1.SelectedRows[0].Cells["Id"].Value.ToString();

                MyDb.EventJoinPageView(Uname, eventID, F1);
            }
            else
            {
                MessageBox.Show("Please select the event first!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Join Event
        public void JoinEvent(string UserId, string EventId, Form f1)
        {
            Event e1 = new Event();
            e1.JoinEvent(UserId, EventId, f1);
        }
    }
}
