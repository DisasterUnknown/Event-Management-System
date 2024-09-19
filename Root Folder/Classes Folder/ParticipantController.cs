using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace Root_Folder.Classes_Folder
{
    internal class ParticipantController
    {
        private static string connectionstring = "server=localhost;database=event_management_system;user=root;password=;";


        // Participant "Join event page" onload Function (Display Event Details)
        public static void EventJoinPageOnLoad(string EventId, JoinEvent f1)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    string q0 = "SELECT Ename, Place, Time, Date, Price FROM eventdb WHERE Id = @Id;";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    cmd0.Parameters.AddWithValue("@Id", EventId);

                    using (MySqlDataReader reader = cmd0.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["Ename"].ToString();
                            string time = reader["Time"].ToString();
                            string date = reader["Date"].ToString();
                            string price = reader["Price"].ToString();
                            string location = reader["Place"].ToString();

                            f1.NameIN.Text = name;
                            f1.LocationIN.Text = location;
                            f1.PriceIN.Text = price;
                            f1.DateTimeIN.Text = $"{date} {time}";
                        }
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
        }


        // Display All the events joined by the participant in the DataGridView
        public static string EventsJoinedView(string Uname, DataGridView G1)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    // Get the user Id
                    string q0 = "SELECT Id FROM persondb WHERE Uname = @Uname";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    cmd0.Parameters.AddWithValue("@Uname", Uname);

                    string UserID = $"{cmd0.ExecuteScalar()}";

                    // Get the Joined Events List
                    string q1 = "SELECT JoinedEvents FROM persondb WHERE Id = @Id";
                    MySqlCommand cmd1 = new MySqlCommand(q1, con);
                    cmd1.Parameters.AddWithValue("@Id", UserID);

                    string JoinedEvents = $"{cmd1.ExecuteScalar()}";

                    // Formating the string
                    string[] eventIDs = JoinedEvents.Split(",");
                    string eventIDQuary = string.Join(",", eventIDs.Select(id => $"'{id.Trim()}'"));

                    string q2 = $"SELECT * FROM eventdb WHERE Id IN ({eventIDQuary})";
                    MySqlDataAdapter data = new MySqlDataAdapter(q2, con);
                    DataTable dt = new DataTable();
                    data.Fill(dt);

                    // Display data in the grid
                    G1.DataSource = dt;

                    // Table formating
                    G1.Columns["Participants"].Visible = false;
                    G1.Columns["Pamount"].Visible = false;

                    G1.Columns["Ename"].HeaderText = "Event";

                    G1.Columns["Id"].DisplayIndex = 0;
                    G1.Columns["Ename"].DisplayIndex = 1;
                    G1.Columns["Place"].DisplayIndex = 2;
                    G1.Columns["Date"].DisplayIndex = 3;
                    G1.Columns["Time"].DisplayIndex = 4;
                    G1.Columns["Price"].DisplayIndex = 5;
                    G1.Columns["Organizer"].DisplayIndex = 6;

                    con.Close();
                    return UserID;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                    return "";
                }
            }
        }
    }
}
