using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Crypto.Fpe;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ZstdSharp.Unsafe;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Root_Folder
{
    internal class MyDb
    {
        private static string connectionstring = "server=localhost;database=event_management_system;user=root;password=;";

        // Register User Function
        public static void RegisterPerson(Person P1, Form f1)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();


                    // Checking if there are any user with the same Uname
                    string q = "SELECT COUNT(*) FROM persondb WHERE Uname = @Uname";
                    MySqlCommand cmd0 = new MySqlCommand(q, con);
                    cmd0.Parameters.AddWithValue("@Uname", P1.Name);

                    int userCount = Convert.ToInt32(cmd0.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("User already exists!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        return;
                    }

                    // Creating the user id
                    string q1 = "SELECT Id FROM persondb WHERE Id LIKE @Prefix ORDER BY Id DESC LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(q1, con);
                    cmd.Parameters.AddWithValue("@Prefix", P1.Role + "%");

                    string lastId = cmd.ExecuteScalar() as string;


                    string newId;
                    if (lastId == null)
                    {
                        newId = $"{P1.Role}0001";
                    }
                    else
                    {
                        int lastNumber = int.Parse(lastId.Substring(2));
                        int newNumber = lastNumber + 1;
                        newId = $"{P1.Role}{newNumber:D4}";
                    }


                    // Adding the user into the database
                    string q2 = "INSERT INTO persondb (Uname, Gmail, Age, Tel, Pass, Id, Role) " +
                                "VALUES (@Uname, @Gmail, @Age, @Tel, @Pass, @Id, @Role)";

                    MySqlCommand cmd1 = new MySqlCommand(q2, con);
                    cmd1.Parameters.AddWithValue("@Uname", P1.Name);
                    cmd1.Parameters.AddWithValue("@Gmail", P1.Email);
                    cmd1.Parameters.AddWithValue("@Age", P1.Age);
                    cmd1.Parameters.AddWithValue("@Tel", P1.PhoneNo);
                    cmd1.Parameters.AddWithValue("@Pass", P1.Password);
                    cmd1.Parameters.AddWithValue("@Id", newId);
                    cmd1.Parameters.AddWithValue("@Role", P1.Role);

                    int addedRowIndex = cmd1.ExecuteNonQuery();

                    if (addedRowIndex != 1)
                    {
                        MessageBox.Show("Error Ocured During Registering!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                    else
                    {
                        // Dirrecting the user to the dashbord according to there role
                        if (P1.Role == "PA")
                        {
                            CustemerDashbord cd1 = new CustemerDashbord(P1.Name);
                            cd1.Show();
                            f1.Hide();
                            con.Close();
                        }
                        else if (P1.Role == "OR")
                        {
                            OganizerDashbord od1 = new OganizerDashbord(P1.Name);
                            od1.Show();
                            f1.Hide();
                            con.Close();
                        }
                        else
                        {
                            AdminDashbord ad1 = new AdminDashbord();
                            ad1.Show();
                            f1.Hide();
                            con.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                    con.Close();
                }
            }
        }


        // Login User Function
        public static void UserLogin(Person P1, Form f1)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    string q0 = "SELECT COUNT(*) FROM persondb WHERE Uname = @Uname AND Pass = @Pass";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    cmd0.Parameters.AddWithValue("@Uname", P1.Name);
                    cmd0.Parameters.AddWithValue("@Pass", P1.Password);

                    int noRow = Convert.ToInt32(cmd0.ExecuteScalar());

                    if (noRow == 1)
                    {
                        string q1 = "SELECT Role FROM persondb WHERE Uname = @Uname";
                        MySqlCommand cmd1 = new MySqlCommand(q1, con);
                        cmd1.Parameters.AddWithValue("@Uname", P1.Name);

                        string dbRole = $"{cmd1.ExecuteScalar()}";

                        // Directing the user to the dashbord
                        if ((P1.Role == dbRole) && (P1.Role == "PA"))
                        {
                            CustemerDashbord cd1 = new CustemerDashbord(P1.Name);
                            cd1.Show();
                            f1.Hide();
                            con.Close();
                        }
                        else if ((P1.Role == dbRole) && (P1.Role == "OR"))
                        {
                            OganizerDashbord od1 = new OganizerDashbord(P1.Name);
                            od1.Show();
                            f1.Hide();
                            con.Close();
                        }
                        else if ((P1.Role == dbRole) && (P1.Role == "AD"))
                        {
                            AdminDashbord ad1 = new AdminDashbord();
                            ad1.Show();
                            f1.Hide();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show($"User can't login as other user roles!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User name or Password are incorrect!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erroe: {ex}");
                    con.Close();
                }
            }
        }


        // View Event Function (Display events in grids)
        public static void ViewEvents(DataGridView EventViewGrid)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    string q0 = "SELECT * FROM eventdb";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    MySqlDataAdapter bridge = new MySqlDataAdapter(cmd0);

                    DataTable G1 = new DataTable();
                    bridge.Fill(G1);

                    EventViewGrid.DataSource = G1;

                    // Formating the grid view
                    EventViewGrid.Columns["Participants"].Visible = false;

                    EventViewGrid.Columns["Ename"].HeaderText = "Event";
                    EventViewGrid.Columns["Pamount"].HeaderText = "Particepent Amount";
                    EventViewGrid.Columns["Id"].HeaderText = "ID";

                    EventViewGrid.Columns["Id"].DisplayIndex = 0;
                    EventViewGrid.Columns["Ename"].DisplayIndex = 1;
                    EventViewGrid.Columns["Place"].DisplayIndex = 2;
                    EventViewGrid.Columns["Price"].DisplayIndex = 3;
                    EventViewGrid.Columns["Date"].DisplayIndex = 4;
                    EventViewGrid.Columns["Time"].DisplayIndex = 5;
                    EventViewGrid.Columns["Pamount"].DisplayIndex = 6;
                    EventViewGrid.Columns["Organizer"].DisplayIndex = 7;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
        }


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


        // Display Content in Update Page
        public static void Display(string eventId, TextBox NameIN, TextBox PlaceIN, DateTimePicker DateTimeIN, MaskedTextBox TicketCIN, TextBox PriceIN)
        {
            // Displaying the data in the fields
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    string q0 = "SELECT * FROM eventdb WHERE Id = @Id;";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    cmd0.Parameters.AddWithValue("@Id", eventId);

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
                            NameIN.Text = Ename;
                            PlaceIN.Text = Place;
                            TicketCIN.Text = Amount;
                            PriceIN.Text = Price;

                            // Formating the time
                            DateTime eventDate = DateTime.Parse(Date);
                            TimeSpan eventTime = TimeSpan.Parse(Time.Substring(0, 8));

                            // Adding the time
                            DateTimeIN.Value = eventDate.Add(eventTime);

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
                    ViewEvents(G1);

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


        // Join event page onload Function (Display Event Details)
        public static void EventJoinPageOnLoad(string EventId, Label NameIN, Label LocationIN, Label DateTimeIN, Label PriceIN)
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

                            NameIN.Text = name;
                            LocationIN.Text = location;
                            PriceIN.Text = price;
                            DateTimeIN.Text = $"{date} {time}";
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


        // Display Joined Events Function
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
                        EventsJoinedView(Uname, G1);
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
        }


        // View Event Details Function (Admin and Organizer)
        public static void OrgViewEventDeatils(string EventID, Label NameIN, Label PlaceIN, Label DateTimeIN, Label PriceIN, Label SeatsCountIN, Label OrgIN)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    string q0 = "SELECT Ename, Price, Place, Pamount, Time, Date, Organizer FROM eventdb WHERE Id = @Id";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    cmd0.Parameters.AddWithValue("@Id", EventID);

                    // Reading the data and storing them in the Lables
                    using (MySqlDataReader reader = cmd0.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader["Ename"].ToString();
                            string price = reader["Price"].ToString();
                            string place = reader["Place"].ToString();
                            string time = reader["Time"].ToString();
                            string date = reader["Date"].ToString();
                            string particepentAmount = reader["Pamount"].ToString();
                            string organizer = reader["Organizer"].ToString();

                            NameIN.Text = name;
                            PlaceIN.Text = place;
                            DateTimeIN.Text = $"{date} {time}";
                            PriceIN.Text = price;
                            SeatsCountIN.Text = particepentAmount;
                            OrgIN.Text = organizer;
                        }

                        con.Close();
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
        }


        // Display Participants joined in the event Function
        public static void ParticipentGridOnload(string EventID, DataGridView G1)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    // Getting the list of users joined in the event
                    string q0 = "SELECT Participants FROM eventdb WHERE Id = @Id";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    cmd0.Parameters.AddWithValue("@Id", EventID);

                    string eventParticipents = $"{cmd0.ExecuteScalar()}";

                    if (eventParticipents != "")
                    {
                        List<string> eventParticipentsList = eventParticipents
                            .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(id => id.Trim())
                            .ToList();

                        // Geting the users and adding them to the grid
                        string userIds = string.Join(",", eventParticipentsList.Select((id, index) => $"@Id{index}"));
                        string q1 = $"SELECT Uname, Tel FROM persondb WHERE Id IN ({userIds})";

                        MySqlCommand cmd1 = new MySqlCommand(q1, con);
                        for (int i = 0; i < eventParticipentsList.Count; i++)
                        {
                            cmd1.Parameters.AddWithValue($"@Id{i}", eventParticipentsList[i]);
                        }

                        MySqlDataAdapter data = new MySqlDataAdapter(cmd1);
                        DataTable dt = new DataTable();
                        data.Fill(dt);

                        // Adding a new Column
                        dt.Columns.Add("NewTel", typeof(string));

                        // Formating the Tel. No.
                        foreach (DataRow row in dt.Rows)
                        {
                            string telNo = row["Tel"].ToString();
                            row["NewTel"] = $"{telNo.Substring(0, 3)} {telNo.Substring(3, 3)} {telNo.Substring(6, 4)}";
                        }

                        G1.DataSource = dt;

                        G1.Columns["Tel"].Visible = false;
                        G1.Columns["NewTel"].HeaderText = "Tel. No.";

                        G1.Columns["Uname"].HeaderText = "Participent";

                        // Ajusting the grid view
                        int gridWith = G1.Width;
                        G1.Columns["Uname"].Width = (int)(gridWith * 0.445);
                        G1.Columns["NewTel"].Width = (int)(gridWith * 0.45);

                        G1.Columns["Uname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        G1.Columns["NewTel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                        con.Close();
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
        }


        // ViewParticipant  Details
        public static void DisplayParticipentDetails(string Uname, Label NameIN, Label TelIN, Label GmailIN)
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
                            NameIN.Text = reader["Uname"].ToString();
                            TelIN.Text = reader["Tel"].ToString();
                            GmailIN.Text = reader["Gmail"].ToString();
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
    }
}
