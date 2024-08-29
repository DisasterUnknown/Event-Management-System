using System;
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
        private static string eventName; // For the update Function

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
            if (FunctionType != "Update")
            {
                PriceIN.Click += PriceIN_Clicked;
                PamountIN.Click += PamountIN_Clicked;
                EventNameIN.Click += EventNameIN_Clicked;
                PlaceIN.Click += PlaceIN_Clicked;
            }
            else if (FunctionType == "Update")
            {
                MyDb.Display(eventId, EventNameIN, PlaceIN, DateTimeIN, PamountIN, PriceIN);
                eventName = EventNameIN.Text;
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

            if ((name.Length < 2) || (name.Length > 20))
            {
                MessageBox.Show("Invalide Event Name!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((place.Length < 3) || (place.Length > 50))
            {
                MessageBox.Show("The place is invalide!!", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (pAmount < 5)
            {
                MessageBox.Show("Insuficent particepent count!!", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (price.Length < 2)
            {
                MessageBox.Show("The price should be grater thn Rs. 50!!", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (FunctionType == "Add")
                {   // Calling the Create Event Function
                    Event e1 = new Event(name, price, place, pAmount, time, date, organizer);

                    Organizer o1 = new Organizer();
                    o1.AddEvent(e1, this);
                }
                else if (FunctionType == "Update")
                {   // Calling the Update Event Function
                    Event e1 = new Event(name, price, place, pAmount, time, date, organizer);

                    Organizer o1 = new Organizer();
                    o1.UpdateEvent(e1, eventName, eventId, this);
                }
            }
        }
    }
}
