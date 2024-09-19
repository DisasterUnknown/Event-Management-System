using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root_Folder.Classes_Folder
{
    internal class PersonController
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
    }
}
