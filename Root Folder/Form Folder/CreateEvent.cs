﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Root_Folder
{
    public partial class CreateEvent : Form
    {
        // CreateEvent(organizer, eventId, "Update")
        private string organizer;
        private string eventId;
        private string FunctionType;

        public CreateEvent(string organizer, string eventId, string functionType)
        {
            InitializeComponent();
            this.organizer = organizer;
            this.eventId = eventId;
            FunctionType = functionType;
        }

        // Functions to happen when on load
        private void CreateEvent_Load(object sender, EventArgs e)
        {
            PriceIN.Text = "Rs. ";
            PriceIN.Click += PriceIN_Clicked;
            PamountIN.Click += PamountIN_Clicked;
            EventNameIN.Click += EventNameIN_Clicked;
            PlaceIN.Click += PlaceIN_Clicked;

            if (FunctionType == "Update")
            {
                MyDb.Display(eventId, EventNameIN, PlaceIN, DateTimeIN, PamountIN, PriceIN);
            }
        }


        // Emptying the text in the boxes
        private void PamountIN_Clicked(object sender, EventArgs e)
        {
            PamountIN.Text = string.Empty;
        }

        private void PriceIN_Clicked(object sender, EventArgs e)
        {
            PriceIN.Text = string.Empty;
        }

        private void EventNameIN_Clicked(object sender, EventArgs e)
        {
            EventNameIN.Text = string.Empty;
        }

        private void PlaceIN_Clicked(object sender, EventArgs e)
        {
            PlaceIN.Text = string.Empty;
        }


        // Price Box Styling
        private void PriceIN_TextChanged(object sender, EventArgs e)
        {
            string userInput = PriceIN.Text;

            if (userInput.Length > 15)
            {
                PriceIN.Text = userInput.Substring(0, 15);
            }

            userInput = PriceIN.Text.Replace(",", "").Replace("Rs. ", "").Trim();

            if (long.TryParse(userInput, out long num))
            {
                string formatedStr = string.Format("{0:N0}", long.Parse(userInput));

                PriceIN.Text = $"Rs. {formatedStr}";

                PriceIN.SelectionStart = PriceIN.Text.Length;
            }
        }

        // Page Back Btn
        private void BackBtn_Click(object sender, EventArgs e)
        {
            OganizerDashbord o1 = new OganizerDashbord(organizer);
            o1.Show();
            this.Hide();
        }

        // Creating & Updating events
        private void EventCreation_Click(object sender, EventArgs e)
        {

            string name = EventNameIN.Text;
            string place = PlaceIN.Text;
            DateTime dateTime = DateTimeIN.Value;
            int pAmount = int.Parse(PamountIN.Text);
            string price = PriceIN.Text;

            string date = (dateTime.Date).ToString("yyyy-MM-dd");
            string time = (dateTime.TimeOfDay).ToString(@"hh\:mm\:ss");

            if (FunctionType == "Add")
            {
                Organizer o1 = new Organizer();
                o1.orgAddAndUpdateEvent(name, price, place, pAmount, time, date, organizer, null, this, "Add");
            }
            else if (FunctionType == "Update")
            {
                Organizer o1 = new Organizer();
                o1.orgAddAndUpdateEvent(name, price, place, pAmount, time, date, organizer, eventId, this, "Update");
            }
        }
    }
}
