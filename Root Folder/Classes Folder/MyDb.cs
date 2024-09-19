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
    }
}
