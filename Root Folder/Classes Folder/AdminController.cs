using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Folder.Classes_Folder
{
    internal class AdminController
    {
        private static string connectionstring = "server=localhost;database=event_management_system;user=root;password=;";

        // Kick the user from the DataBase function
        public static void KickUser(string Uname)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    // Checking if the user is a admin
                    string q = "SELECT Role FROM persondb WHERE Uname = @Uname";
                    MySqlCommand cmd = new MySqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@Uname", Uname);

                    string role = $"{cmd.ExecuteScalar()}";

                    // Getting the userId
                    string q0 = "SELECT Id FROM persondb WHERE Uname = @Uname";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    cmd0.Parameters.AddWithValue("@Uname", Uname);

                    string UserID = $"{cmd0.ExecuteScalar()}";

                    if (role == "AD")
                    {
                        // If the user is an admin
                        MessageBox.Show("Admins are unable to remove from the application!!", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        con.Close();
                    }
                    else if (role == "PA")
                    {
                        // If the user is a participant
                        string q1 = "SELECT JoinedEvents FROM persondb WHERE Uname = @Uname";
                        MySqlCommand cmd1 = new MySqlCommand(q1, con);
                        cmd1.Parameters.AddWithValue("@Uname", Uname);

                        string joinedEvents = $"{cmd1.ExecuteScalar()}";

                        // Converting to a list
                        List<string> joinedEventsList = joinedEvents
                            .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(i => i.Trim())
                            .ToList();

                        // Removing the user id from the events joined user list
                        foreach (var EventID in joinedEventsList)
                        {
                            // Getting the participant list
                            string q2 = "SELECT Participants FROM eventdb WHERE Id = @Id";
                            MySqlCommand cmd2 = new MySqlCommand(q2, con);
                            cmd2.Parameters.AddWithValue("@Id", EventID);

                            string joinedParticipants = $"{cmd2.ExecuteScalar()}";

                            List<string> joinedParticipantsList = joinedParticipants
                                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(i => i.Trim())
                                .ToList();

                            joinedParticipantsList.Remove(UserID);

                            // Converting to database format 
                            string formatedJoinedParticipants = string.Join(", ", joinedParticipantsList);

                            // Update the new list
                            string q3 = "UPDATE eventdb SET Participants = @formatedJoinedParticipants WHERE Id = @EventID";
                            MySqlCommand cmd3 = new MySqlCommand(q3, con);
                            cmd3.Parameters.AddWithValue("@formatedJoinedParticipants", formatedJoinedParticipants);
                            cmd3.Parameters.AddWithValue("@EventID", EventID);

                            int rowsAffected = Convert.ToInt32(cmd3.ExecuteNonQuery());
                        }

                        // Removing the user from the database
                        string q4 = "DELETE FROM persondb WHERE Id = @UserID";
                        MySqlCommand cmd4 = new MySqlCommand(q4, con);
                        cmd4.Parameters.AddWithValue("@UserID", UserID);

                        int rowsAffected1 = Convert.ToInt32(cmd4.ExecuteNonQuery());

                        con.Close();
                    }
                    else
                    {
                        // If the user is a organizer
                        // Get Event ids that the organizer created
                        string q6 = "SELECT Id FROM eventdb WHERE Organizer = @Uname";
                        MySqlCommand cmd6 = new MySqlCommand(q6, con);
                        cmd6.Parameters.AddWithValue("@Uname", Uname);

                        // Adding the events to the list
                        List<string> orgEvents = new List<string>();
                        using (MySqlDataReader reader = cmd6.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string EventID = reader.GetString(0);
                                orgEvents.Add(EventID);
                            }
                        }

                        // Removing the users from the events and deleting the events
                        foreach (string EventID in orgEvents)
                        {
                            // Getting the participant list
                            string q7 = "SELECT Participants FROM eventdb WHERE Id = @Id";
                            MySqlCommand cmd7 = new MySqlCommand(q7, con);
                            cmd7.Parameters.AddWithValue("@Id", EventID);

                            string joinedParticipants = $"{cmd7.ExecuteScalar()}";

                            List<string> joinedParticipantsList = joinedParticipants
                                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(i => i.Trim())
                                .ToList();

                            // Removing the event from the participant
                            foreach (var ID in joinedParticipantsList)
                            {
                                // Getting the participant joined eventId List
                                string q8 = "SELECT JoinedEvents FROM persondb WHERE Id = @Id";
                                MySqlCommand cmd8 = new MySqlCommand(q8, con);
                                cmd8.Parameters.AddWithValue("@Id", ID);

                                string joinedEvents = $"{cmd8.ExecuteScalar()}";

                                List<string> joinedEventsList = joinedEvents
                                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(i => i.Trim())
                                    .ToList();

                                // Removing the eventId from participant joined event list
                                joinedEventsList.Remove(EventID);

                                // Converting to database format 
                                string formatedJoinedEventsList = string.Join(", ", joinedEventsList);

                                // Update the new list
                                string q9 = "UPDATE persondb SET JoinedEvents = @formatedJoinedEventsList WHERE Id = @ID";
                                MySqlCommand cmd9 = new MySqlCommand(q9, con);
                                cmd9.Parameters.AddWithValue("@formatedJoinedEventsList", formatedJoinedEventsList);
                                cmd9.Parameters.AddWithValue("@ID", ID);

                                int rowsAffected = Convert.ToInt32(cmd9.ExecuteNonQuery());
                            }

                            // Deleting the event
                            string q10 = "DELETE FROM eventdb WHERE Id = @EventID";
                            MySqlCommand cmd10 = new MySqlCommand(q10, con);
                            cmd10.Parameters.AddWithValue("@EventID", EventID);

                            cmd10.ExecuteNonQuery();
                        }

                        // Deleting the user
                        string q11 = "DELETE FROM persondb WHERE Uname = @Uname";
                        MySqlCommand cmd11 = new MySqlCommand(q11, con);
                        cmd11.Parameters.AddWithValue("@Uname", Uname);

                        cmd11.ExecuteNonQuery();

                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
        }


        // Display all the user accounts in the grid
        public static void ViewUserAccounts(DataGridView G1)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    string q0 = "SELECT * FROM persondb";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    MySqlDataAdapter bridge = new MySqlDataAdapter(cmd0);

                    DataTable table = new DataTable();
                    bridge.Fill(table);

                    G1.DataSource = table;

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
        }


        // ViewParticipant  Details
        public static void DisplayParticipentDetails(string Uname, ViewParticipant f1)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    string q0 = "SELECT Uname, Tel, Gmail FROM persondb WHERE Uname = @Uname";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    cmd0.Parameters.AddWithValue("@Uname", Uname);

                    using (MySqlDataReader reader = cmd0.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            f1.NameIN.Text = reader["Uname"].ToString();
                            f1.TelIN.Text = reader["Tel"].ToString();
                            f1.GmailIN.Text = reader["Gmail"].ToString();
                        }

                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
        }
    }
}
