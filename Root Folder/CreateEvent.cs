using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Root_Folder
{
    public partial class CreateEvent : Form
    {
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {
            PriceIN.Text = "Rs. ";
            PriceIN.Click += PriceIN_Clicked;
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

        }
    }
}
