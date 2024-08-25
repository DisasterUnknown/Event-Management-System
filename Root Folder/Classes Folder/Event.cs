﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Folder
{
    internal class Event
    {
        private string name;
        private string price;
        private string place;
        private int patientCount;
        private string time;
        private string date;
        private string organizerName;

        public string Name { get { return name; } set { name = value; } }
        public string Price { get { return price; } set { price = value; } }
        public string Place { get { return place; } set { place = value; } }
        public int PatientCount { get { return patientCount; } set { patientCount = value; } }
        public string Time { get { return time; } set { time = value; } }
        public string Date { get { return date; } set { date = value; } }
        public string OrganizerName { get { return organizerName; } set { organizerName = value; } }

        public Event() { }

        public Event(string name, string eventName, string price, string place, int patientCount, string time, string date, string organizerName, string eventID, Form f1, string functionType) 
        {
            this.name = name;
            this.price = price;
            this.place = place;
            this.patientCount = patientCount;
            this.time = time;
            this.date = date;
            this.organizerName = organizerName;

            if (functionType == "Add")
            {
                AddEvent(name, price, place, patientCount, time, date, organizerName, f1);
            }
            else
            {
                UpdateEvent(name, eventName, price, place, patientCount, time, date, organizerName, eventID, f1);
            }
        }


        // Adding events to the data base
        public void AddEvent(string name, string price, string place, int patientCount, string time, string date, string organizerName, Form f1)
        {
            MyDb.EventAdd(name, price, place, patientCount, time, date, organizerName, f1);
        }

        // Update Event
        public void UpdateEvent(string name, string eventName, string price, string place, int patientCount, string time, string date, string organizerName, string eventID,Form f1)
        {
            MyDb.EventUpdate(name, eventName, price, place, patientCount, time, date, organizerName, eventID, f1);
        }

        // Remove Event
        public void RemoveEvent(string eventID, DataGridView G1)
        {
            MyDb.EventRemove(eventID, G1);
        }

        // Join Event
        public void JoinEvent(string UserId, string EventId, Form f1)
        {
            MyDb.EventJoin(UserId, EventId, f1);
        }
    }
}
