﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Folder
{
    internal class Particepent : Person
    {
        public Particepent() { }
        public Particepent(string name, int age, string password, string email, string phoneNo, string role) : base(name, age, password, email, phoneNo, role) { }

        // Person register function
        public override void Register(Person P1, Form f1)
        {
            MyDb.RegisterPerson(P1, f1);
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
        public void JoinEvent(string Uname, string UserId, string EventId, Form f1)
        {
            Event e1 = new Event();
            e1.JoinEvent(Uname, UserId, EventId, f1);
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
            if (G1.SelectedRows.Count > 0)
            {
                string EventID = G1.SelectedRows[0].Cells["Id"].Value.ToString();

                Event e1 = new Event();
                e1.LeaveEvent(UserID, EventID, Uname, G1);
            }
            else
            {
                MessageBox.Show("Please select the event first!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
