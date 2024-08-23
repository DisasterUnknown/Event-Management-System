using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Folder
{
    internal class Event
    {
        private string name;
        private int price;
        private string place;
        private int patientCount;
        private string time;
        private string date;
        private string organizerName;

        public string Name { get { return name; } set { name = value; } }
        public int Price { get { return price; } set { price = value; } }
        public string Place { get { return place; } set { place = value; } }
        public int PatientCount { get { return patientCount; } set { patientCount = value; } }
        public string Time { get { return time; } set { time = value; } }
        public string Date { get { return date; } set { date = value; } }
        public string OrganizerName { get { return organizerName; } set { organizerName = value; } }

        public Event(string name, int price, string place, int patientCount, string time, string date, string organizerName) 
        {
            this.name = name;
            this.price = price;
            this.place = place;
            this.patientCount = patientCount;
            this.time = time;
            this.date = date;
            this.organizerName = organizerName;

            AddEvent(name, price, place, patientCount, time, date, organizerName);
        }


        // Adding events to the data base
        public void AddEvent(string name, int price, string place, int patientCount, string time, string date, string organizerName)
        {
            MyDb.EventAdd(name, price, place, patientCount, time, date, organizerName);
        }
    }
}
