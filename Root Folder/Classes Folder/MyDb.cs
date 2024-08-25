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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Root_Folder
{
    internal class MyDb
    {
        private static string connectionstring = "server=localhost;database=event_management_system;user=root;password=;";

        // Function to register the user
        public static void RegisterPerson(string uname, string gmail, int age, long tel, string pass, string role, Form f1)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();


                    // Checking if there are any user with the same Uname
                    string q = "SELECT COUNT(*) FROM persondb WHERE Uname = @Uname";
                    MySqlCommand cmd0 = new MySqlCommand(q, con);
                    cmd0.Parameters.AddWithValue("@Uname", uname);

                    int userCount = Convert.ToInt32(cmd0.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("User alredy exists!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        return;
                    }

                    // Creating The UserId
                    string idLable;
                    if (role == "admin")
                    {
                        idLable = "AD";
                    }
                    else if (role == "particepent")
                    {
                        idLable = "PA";
                    }
                    else
                    {
                        idLable = "OR";
                    }


                    // Creating the user id
                    string q1 = "SELECT Id FROM persondb WHERE Id LIKE @Prefix ORDER BY Id DESC LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(q1, con);
                    cmd.Parameters.AddWithValue("@Prefix", idLable + "%");

                    string lastId = cmd.ExecuteScalar() as string;


                    string newId;
                    if (lastId == null)
                    {
                        newId = $"{idLable}0001";
                    }
                    else
                    {
                        int lastNumber = int.Parse(lastId.Substring(2));
                        int newNumber = lastNumber + 1;
                        newId = $"{idLable}{newNumber:D4}";
                    }


                    // Adding the user into the database
                    string q2 = "INSERT INTO persondb (Uname, Gmail, Age, Tel, Pass, Id, Role) " +
                                "VALUES (@Uname, @Gmail, @Age, @Tel, @Pass, @Id, @Role)";

                    MySqlCommand cmd1 = new MySqlCommand(q2, con);
                    cmd1.Parameters.AddWithValue("@Uname", uname);
                    cmd1.Parameters.AddWithValue("@Gmail", gmail);
                    cmd1.Parameters.AddWithValue("@Age", age);
                    cmd1.Parameters.AddWithValue("@Tel", tel);
                    cmd1.Parameters.AddWithValue("@Pass", pass);
                    cmd1.Parameters.AddWithValue("@Id", newId);
                    cmd1.Parameters.AddWithValue("@Role", idLable);

                    int addedRowIndex = cmd1.ExecuteNonQuery();

                    if (addedRowIndex != 1)
                    {
                        MessageBox.Show("Error Ocured During Registering!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                    else
                    {
                        // Dirrecting the user to the dashbord according to there role
                        if (role == "particepent")
                        {
                            CustemerDashbord cd1 = new CustemerDashbord();
                            cd1.Show();
                            f1.Hide();
                            con.Close();
                        }
                        else if (role == "orgnizer")
                        {
                            OganizerDashbord od1 = new OganizerDashbord(uname);
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


        // Login Function
        public static void UserLogin(string uname, string pass, string role, Form f1)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    string q0 = "SELECT COUNT(*) FROM persondb WHERE Uname = @Uname AND Pass = @Pass";
                    MySqlCommand cmd0 = new MySqlCommand(q0, con);
                    cmd0.Parameters.AddWithValue("@Uname", uname);
                    cmd0.Parameters.AddWithValue("@Pass", pass);

                    int noRow = Convert.ToInt32(cmd0.ExecuteScalar());

                    if (noRow == 1)
                    {
                        string q1 = "SELECT Role FROM persondb WHERE Uname = @Uname";
                        MySqlCommand cmd1 = new MySqlCommand(q1, con);
                        cmd1.Parameters.AddWithValue("@Uname", uname);

                        string dbRole = $"{cmd1.ExecuteScalar()}";

                        // Converting role into Database Role Format
                        if (role == "admin")
                        {
                            role = "AD";
                        }
                        else if (role == "particepent")
                        {
                            role = "PA";
                        }
                        else
                        {
                            role = "OR";
                        }

                        // Directing the user to the dashbord
                        if ((role == dbRole) && (role == "PA"))
                        {
                            CustemerDashbord cd1 = new CustemerDashbord();
                            cd1.Show();
                            f1.Hide();
                            con.Close();
                        }
                        else if ((role == dbRole) && (role == "OR"))
                        {
                            OganizerDashbord od1 = new OganizerDashbord(uname);
                            od1.Show();
                            f1.Hide();
                            con.Close();
                        }
                        else if ((role == dbRole) && (role == "AD"))
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
                        MessageBox.Show("User name or Password are incurect!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        // View Event function
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


        // Event add function
        public static void EventAdd(string name, string price, string place, int pCount, string time, string date, string orgnizer, string eventID, Form f1, string fnctionType)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

                    // Checking if there are any event with the same name
                    string q = "SELECT COUNT(*) FROM eventdb WHERE Ename = @Ename";
                    MySqlCommand cmd = new MySqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@Ename", name);

                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("Sorry event alredy exists!!\nTry changing the event name!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        return;
                    }

                    // Creating the event function
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

                    // SQL Quary Select Add or Update
                    string q1;
                    int addedRowCount;
                    if (fnctionType == "Add")
                    {
                        // Add Event
                        q1 = "INSERT INTO eventdb (Ename, Price, Place, Pamount, Time, Date, Id, Organizer) " +
                                    "VALUES (@Name, @Price, @Place, @Pcount, @Time, @Date, @NewId, @Organizer)";

                        MySqlCommand cmd1 = new MySqlCommand(q1, con);
                        cmd1.Parameters.AddWithValue("@Name", name);
                        cmd1.Parameters.AddWithValue("@Price", price);
                        cmd1.Parameters.AddWithValue("@Place", place);
                        cmd1.Parameters.AddWithValue("@Pcount", pCount);
                        cmd1.Parameters.AddWithValue("@Time", time);
                        cmd1.Parameters.AddWithValue("@Date", date);
                        cmd1.Parameters.AddWithValue("@NewId", newId);
                        cmd1.Parameters.AddWithValue("@Organizer", orgnizer);

                        addedRowCount = cmd1.ExecuteNonQuery();
                    }
                    else
                    {
                        // Update Event
                        q1 = "UPDATE eventdb " +
                            "SET Ename = @Name, " +
                            "Price = @Price, " +
                            "Place = @Place, " +
                            "Pamount = @Pcount, " +
                            "Time = @Time, " +
                            "Date = @Date, " +
                            "Organizer = @Organizer " +
                            "WHERE Id = @Id";

                        MySqlCommand cmd1 = new MySqlCommand(q1, con);
                        cmd1.Parameters.AddWithValue("@Name", name);
                        cmd1.Parameters.AddWithValue("@Price", price);
                        cmd1.Parameters.AddWithValue("@Place", place);
                        cmd1.Parameters.AddWithValue("@Pcount", pCount);
                        cmd1.Parameters.AddWithValue("@Time", time);
                        cmd1.Parameters.AddWithValue("@Date", date);
                        cmd1.Parameters.AddWithValue("@Organizer", orgnizer);
                        cmd1.Parameters.AddWithValue("@Id", eventID);

                        addedRowCount = cmd1.ExecuteNonQuery();
                    }

                    

                    if (addedRowCount != 1)
                    {
                        MessageBox.Show("SomeThing went wrong!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                    else
                    {
                        OganizerDashbord o1 = new OganizerDashbord(orgnizer);
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
    }
}
