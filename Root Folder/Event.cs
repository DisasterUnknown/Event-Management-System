using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Folder
{
    internal class Event
    {
        private string date;
        private string name;
        private string time;
        private string place;
        private int amount;
        private int price;
        private string orgnizer;

        public string Date { get { return date; } set { date = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Time { get { return time; } set { time = value; } }
        public string Place { get { return place; } set { place = value; } }
        public int Amount { get { return amount; } set { amount = value; } }
        public int Price { get { return price; } set { price = value; } }
        public string Orgnizer { get { return orgnizer; } set { orgnizer = value; } }

        public Event(string date, string name, string time, string place,int amount, int price, string orgnizer) 
        {
            this.date = date;
            this.name = name;
            this.time = time;
            this.place = place;
            this.amount = amount;
            this.price = price;
            this.orgnizer = orgnizer;
        }
    }
}
