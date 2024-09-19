using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Folder.Classes_Folder
{
    internal class EventController
    {
        private static string connectionstring = "server=localhost;database=event_management_system;user=root;password=;";


        // Add Event Function
        public static void EventAdd(Event E1, Form f1)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    // Checking if there are any event with the same name
                    string q = "SELECT COUNT(*) FROM eventdb WHERE Ename = @Ename";
                    MySqlCommand cmd = new MySqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@Ename", E1.Name);

                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("Sorry event alredy exists!!\nTry changing the event name!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        return;
                    }

                    // Creating the event ID
                    string q0 = "SELECT Id FROM eventdb WHERE Id LIKE @Prifix ORDER BY Id DESC LIMIT 1";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    cmd0.Parameters.AddWithValue("@Prifix", "EV%");

                    string lastId = cmd0.ExecuteScalar() as string;

                    string newId;
                    if (lastId == null)
                    {
                        newId = "EV0001";
                    }
                    else
                    {
                        int lastNumber = int.Parse(lastId.Substring(2));
                        newId = $"EV{(lastNumber + 1):D4}";
                    }

                    // Add Event
                    string q1 = "INSERT INTO eventdb (Ename, Price, Place, Pamount, Time, Date, Id, Organizer) " +
                                "VALUES (@Name, @Price, @Place, @Pcount, @Time, @Date, @NewId, @Organizer)";

                    MySqlCommand cmd1 = new MySqlCommand(q1, con);
                    cmd1.Parameters.AddWithValue("@Name", E1.Name);
                    cmd1.Parameters.AddWithValue("@Price", E1.Price);
                    cmd1.Parameters.AddWithValue("@Place", E1.Place);
                    cmd1.Parameters.AddWithValue("@Pcount", E1.PatientCount);
                    cmd1.Parameters.AddWithValue("@Time", E1.Time);
                    cmd1.Parameters.AddWithValue("@Date", E1.Date);
                    cmd1.Parameters.AddWithValue("@NewId", newId);
                    cmd1.Parameters.AddWithValue("@Organizer", E1.OrganizerName);

                    int addedRowCount = cmd1.ExecuteNonQuery();

                    if (addedRowCount != 1)
                    {
                        MessageBox.Show("SomeThing went wrong!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                    else
                    {
                        OganizerDashbord o1 = new OganizerDashbord(E1.OrganizerName);
                        o1.Show();
                        f1.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
        }



        // Update Event Function
        public static void EventUpdate(Event E1, string eventName, string eventID, Form f1)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    // Checking if there are any event with the same name
                    string q = "SELECT COUNT(*) FROM eventdb WHERE Ename = @Ename";
                    MySqlCommand cmd = new MySqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@Ename", E1.Name);

                    int eventCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if ((eventCount > 0) && (E1.Name != eventName))
                    {
                        MessageBox.Show("Sorry event alredy exists!!\nTry changing the event name!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        return;
                    }

                    // Update Event
                    string q1 = "UPDATE eventdb " +
                        "SET Ename = @Name, " +
                        "Price = @Price, " +
                        "Place = @Place, " +
                        "Pamount = @Pcount, " +
                        "Time = @Time, " +
                        "Date = @Date, " +
                        "Organizer = @Organizer " +
                        "WHERE Id = @Id";

                    MySqlCommand cmd1 = new MySqlCommand(q1, con);
                    cmd1.Parameters.AddWithValue("@Name", E1.Name);
                    cmd1.Parameters.AddWithValue("@Price", E1.Price);
                    cmd1.Parameters.AddWithValue("@Place", E1.Place);
                    cmd1.Parameters.AddWithValue("@Pcount", E1.PatientCount);
                    cmd1.Parameters.AddWithValue("@Time", E1.Time);
                    cmd1.Parameters.AddWithValue("@Date", E1.Date);
                    cmd1.Parameters.AddWithValue("@Organizer", E1.OrganizerName);
                    cmd1.Parameters.AddWithValue("@Id", eventID);

                    int addedRowCount = cmd1.ExecuteNonQuery();

                    if (addedRowCount != 1)
                    {
                        MessageBox.Show("SomeThing went wrong!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                    else
                    {
                        OganizerDashbord o1 = new OganizerDashbord(E1.OrganizerName);
                        o1.Show();
                        f1.Hide();

                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
        }



        // Remove Event Function
        public static void EventRemove(string eventID, DataGridView G1)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    // Getting the customers who has joined the event
                    string q = "SELECT Participants FROM eventdb WHERE Id = @Id";
                    MySqlCommand cmd = new MySqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@Id", eventID);

                    string joinedParticipents = $"{cmd.ExecuteScalar()}";

                    // Deleting the event
                    string q0 = "DELETE FROM eventdb WHERE Id = @Id;";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    cmd0.Parameters.AddWithValue("@Id", eventID);

                    int deletedRows = Convert.ToInt32(cmd0.ExecuteNonQuery());
                    PersonController.ViewEvents(G1);

                    if (deletedRows != 1)
                    {
                        MessageBox.Show("Event didn't get deleted!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                    else
                    {
                        if (joinedParticipents != "")
                        {
                            // Removing the event from the users
                            List<string> joinedParticipentsList = joinedParticipents
                                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(i => i.Trim())
                                .ToList();

                            foreach (string userId in joinedParticipentsList)
                            {
                                string q1 = "SELECT JoinedEvents FROM persondb WHERE Id = @Id";
                                MySqlCommand cmd1 = new MySqlCommand(q1, con);
                                cmd1.Parameters.AddWithValue("@Id", userId);

                                string userJoinedEvents = $"{cmd1.ExecuteScalar()}";

                                // Converting into a list
                                List<string> userJoinedEventsList = userJoinedEvents
                                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(i => i.Trim())
                                    .ToList();

                                userJoinedEventsList.Remove(eventID);
                                string updatedUserJoinedEvents = string.Join(", ", userJoinedEventsList);

                                // Updating the user joinedEvents
                                string q2 = "UPDATE persondb SET JoinedEvents = @updatedJoinedEvents WHERE Id = @Id";
                                MySqlCommand cmd2 = new MySqlCommand(q2, con);
                                cmd2.Parameters.AddWithValue("@updatedJoinedEvents", updatedUserJoinedEvents);
                                cmd2.Parameters.AddWithValue("@Id", userId);

                                int affectedRows = cmd2.ExecuteNonQuery();

                                if (affectedRows != 1)
                                {
                                    MessageBox.Show("Something went wrong!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    con.Close();
                                }
                                else
                                {
                                    con.Close();
                                }
                            }
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



        // Join event
        public static void EventJoin(string Uname, string EventId, Form f1)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    // Getting the user Id
                    string q = "SELECT Id FROM persondb WHERE Uname = @Uname";
                    MySqlCommand cmd = new MySqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@Uname", Uname);

                    string UserId = $"{cmd.ExecuteScalar()}";

                    // Getting the particepents joined in the event
                    string q0 = "SELECT Participants, Pamount FROM eventdb WHERE Id = @Id";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    cmd0.Parameters.AddWithValue("@Id", EventId);

                    string particepents = "";
                    int particepentsAmount = 0;
                    using (MySqlDataReader reader = cmd0.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            particepents = reader["Participants"].ToString();
                            particepentsAmount = Convert.ToInt32(reader["Pamount"]);
                        }
                    }

                    string[] particepentsArray = particepents.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToArray();
                    int numberOfparticepents = particepentsArray.Length;

                    // Checking if already joined
                    if (numberOfparticepents >= particepentsAmount)
                    {
                        MessageBox.Show("Sorry but the booking are full!!", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        return;
                    }
                    else if (particepentsArray.Contains(UserId))
                    {
                        MessageBox.Show("The user has already joined the event!!", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        return;
                    }
                    else
                    {
                        // Creating the joinedParticepents format
                        string joinedParticepents;
                        if (particepents == "")
                        {
                            joinedParticepents = $"{UserId}";
                        }
                        else
                        {
                            joinedParticepents = $"{particepents}, {UserId}";
                        }

                        // Add the participent to the event
                        string q1 = "UPDATE eventdb SET Participants = @Participants WHERE Id = @Id";
                        MySqlCommand cmd1 = new MySqlCommand(q1, con);
                        cmd1.Parameters.AddWithValue("@Participants", joinedParticepents);
                        cmd1.Parameters.AddWithValue("@Id", EventId);

                        int changedRows = cmd1.ExecuteNonQuery();

                        if (changedRows != 1)
                        {
                            MessageBox.Show("Something went wrong!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                        }
                        else
                        {
                            // Getting the joined event list
                            string q2 = "SELECT JoinedEvents FROM persondb WHERE Id = @Id";
                            MySqlCommand cmd2 = new MySqlCommand(q2, con);
                            cmd2.Parameters.AddWithValue("@Id", UserId);

                            string joinedEvents = "";
                            using (MySqlDataReader reader = cmd2.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    joinedEvents = reader["JoinedEvents"].ToString();
                                }
                            }

                            // Creating the updatedJoinedEvents format
                            string updatedJoinedEvents;
                            if (joinedEvents == "")
                            {
                                updatedJoinedEvents = $"{EventId}";
                            }
                            else
                            {
                                updatedJoinedEvents = $"{joinedEvents}, {EventId}";
                            }

                            // Adding the new event to the event list
                            string q3 = "UPDATE persondb SET JoinedEvents = @updatedJoinedEvents WHERE Id = @Id";
                            MySqlCommand cmd3 = new MySqlCommand(q3, con);
                            cmd3.Parameters.AddWithValue("@updatedJoinedEvents", updatedJoinedEvents);
                            cmd3.Parameters.AddWithValue("@Id", UserId);

                            int changedRows1 = cmd3.ExecuteNonQuery();

                            if (changedRows1 != 1)
                            {
                                MessageBox.Show("Something went wrong!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                con.Close();
                            }
                            else
                            {
                                CustemerDashbord c1 = new CustemerDashbord(Uname);
                                c1.Show();
                                f1.Hide();

                                con.Close();
                            }
                        }
                    }
                }
                catch (Exception ex1)
                {
                    MessageBox.Show($"{ex1}");
                }
            }
        }



        // Leave Event Function
        public static void EventLaeve(string EventID, string Uname, string FunctionType, DataGridView G1)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    // Geting the user Id
                    string q = "SELECT Id FROM persondb WHERE Uname = @Uname";
                    MySqlCommand cmd = new MySqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@Uname", Uname);

                    string UserID = $"{cmd.ExecuteScalar()}";

                    // Geting the participent joined event list
                    string q0 = "SELECT JoinedEvents FROM persondb WHERE Id = @Id";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    cmd0.Parameters.AddWithValue("@Id", UserID);

                    string joinedEvents = $"{cmd0.ExecuteScalar()}";

                    // Geting the event joined participent list
                    string q1 = "SELECT Participants FROM eventdb WHERE Id = @Id";
                    MySqlCommand cmd1 = new MySqlCommand(q1, con);
                    cmd1.Parameters.AddWithValue("@Id", EventID);

                    string joinedParticipents = $"{cmd1.ExecuteScalar()}";

                    // Removing the IDs
                    List<string> joinedEventsList = joinedEvents
                        .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(i => i.Trim())
                        .ToList();

                    List<string> joinedParticipentsList = joinedParticipents
                        .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(i => i.Trim())
                        .ToList();

                    joinedEventsList.Remove(EventID);
                    joinedParticipentsList.Remove(UserID);

                    // Converting into database format
                    string updatedJoinedEvents = string.Join(", ", joinedEventsList);
                    string updatedJoinedParticipents = string.Join(", ", joinedParticipentsList);

                    // Updating the databases
                    string q2 = "UPDATE persondb SET JoinedEvents = @updatedJoinedEvents WHERE Id = @Id";
                    MySqlCommand cmd2 = new MySqlCommand(q2, con);
                    cmd2.Parameters.AddWithValue("@updatedJoinedEvents", updatedJoinedEvents);
                    cmd2.Parameters.AddWithValue("@Id", UserID);

                    string q3 = "UPDATE eventdb SET Participants = @updatedJoinedParticipents WHERE Id = @Id";
                    MySqlCommand cmd3 = new MySqlCommand(q3, con);
                    cmd3.Parameters.AddWithValue("@updatedJoinedParticipents", updatedJoinedParticipents);
                    cmd3.Parameters.AddWithValue("@Id", EventID);

                    int affectedRows1 = Convert.ToInt32(cmd2.ExecuteNonQuery());
                    int affectedRows2 = Convert.ToInt32(cmd3.ExecuteNonQuery());

                    if ((affectedRows1 != 1) && (affectedRows2 != 1))
                    {
                        MessageBox.Show("Something went wrong!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }

                    // Calling the Display joined events function
                    if (FunctionType == "Leave")
                    {
                        ParticipantController.EventsJoinedView(Uname, G1);
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
