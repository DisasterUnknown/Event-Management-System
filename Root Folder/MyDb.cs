using MySql.Data.MySqlClient;
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
        public static void RegisterPerson(string uname, string gmail, int age, int tel, string pass, string role)
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
