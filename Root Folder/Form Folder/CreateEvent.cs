using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Root_Folder
{
    public partial class CreateEvent : Form
    {
        private string organizer;
        public CreateEvent(string organizer)
        {
            InitializeComponent();
            this.organizer = organizer;
        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {
            PriceIN.Text = "Rs. ";
            PriceIN.Click += PriceIN_Clicked;
            PamountIN.Click += PamountIN_Clicked;
        }


        // Particepent amount Styling
        private void PamountIN_Clicked(object sender, EventArgs e)
        {
            PamountIN.Text = string.Empty;
        }


        // Form Price box styling
        private void PriceIN_Clicked(object sender, EventArgs e)
        {
            PriceIN.Text = string.Empty;
        }

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


        // Creating a new event
        private void EventCreation_Click(object sender, EventArgs e)
        {
            string name = EventNameIN.Text;
            string place = PlaceIN.Text;
            DateTime dateTime = DateTimeIN.Value;
            int pAmount = int.Parse(PamountIN.Text);
            string price = PriceIN.Text;

            string date = (dateTime.Date).ToString("yyyy-MM-dd");
            string time = (dateTime.TimeOfDay).ToString(@"hh\:mm\:ss");

            Organizer o1 = new Organizer();
            o1.orgAddEvent(name, price, place, pAmount, time, date, organizer, this);
        }
    }
}
