using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Fpe;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        // Event add function
        public static void EventAdd(string name, int price, string place, int pCount, string time, string date, string orgnizer, Form f1)
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {
                try
                {
                    con.Open();

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

                    // Adding the data to the DataBase
                    string q1 = "INSERT INTO eventdb (Ename, Price, Place, Pamount, Time, Date, Id, Organizer) " +
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

                    int addedRowCount = cmd1.ExecuteNonQuery();

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
    }
}
