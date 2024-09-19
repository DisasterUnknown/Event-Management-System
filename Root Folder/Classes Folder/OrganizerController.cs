using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Folder.Classes_Folder
{
    internal class OrganizerController
    {
        private static string connectionstring = "server=localhost;database=event_management_system;user=root;password=;";


        // Update events page onload display event details function
        public static void UpdateEventDispayContent(string eventID, CreateEvent f1)
        {
            // Displaying the data in the fields
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    string q0 = "SELECT * FROM eventdb WHERE Id = @Id;";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    cmd0.Parameters.AddWithValue("@Id", eventID);

                    // Gets the data and displayes them
                    using (MySqlDataReader read = cmd0.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            string Ename = read["Ename"].ToString();
                            string Price = read["Price"].ToString();
                            string Place = read["Place"].ToString();
                            string Amount = read["Pamount"].ToString();
                            string Time = read["Time"].ToString();
                            string Date = read["Date"].ToString();

                            // Fille the text boxes
                            f1.EventNameIN.Text = Ename;
                            f1.PlaceIN.Text = Place;
                            f1.PamountIN.Text = Amount;
                            f1.PriceIN.Text = Price;

                            // Formating the time
                            DateTime eventDate = DateTime.Parse(Date);
                            TimeSpan eventTime = TimeSpan.Parse(Time.Substring(0, 8));

                            // Adding the time
                            f1.DateTimeIN.Value = eventDate.Add(eventTime);

                            // Debug Message
                            // MessageBox.Show($"Name: {Ename}\nPrice: {Price}\nPlace: {Place}\nAmount: {Amount}\nTime: {Time}\nDate: {Date}");
                        }
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                    con.Close();
                }
            }
        }
    }
}
