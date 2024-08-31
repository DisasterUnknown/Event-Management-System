using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Root_Folder
{
    public partial class ViewEvent : Form
    {
        private string name;
        private string EventID;
        public ViewEvent(string EventID, string organizer)
        {
            InitializeComponent();
            this.EventID = EventID;
            this.name = organizer;
        }

        private void ViewEvent_Load(object sender, EventArgs e)
        {
            MyDb.OrgViewEventDeatils(EventID, NameIN, PlaceIN, DateTimeIN, PriceIN, SeatsCountIN);
            MyDb.ParticipentGridOnload(EventID, ParticipentGrid);

            if (name == "admin@123")
            {
                DetailsBtn.Visible = true;
            }
            else
            {
                DetailsBtn.Visible = false;
            }
        }


        // Page back Btn
        private void BackBtn_Click(object sender, EventArgs e)
        {
            // Checking the redirect page
            if (name == "admin@123")
            {
                AdminDashbord a1 = new AdminDashbord();
                a1.Show();
                this.Hide();
            }
            else
            {
                OganizerDashbord o1 = new OganizerDashbord(name);
                o1.Show();
                this.Hide();
            }
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            if (ParticipentGrid.SelectedRows.Count > 0) 
            {
                string name = ParticipentGrid.SelectedRows[0].Cells["Uname"].Value.ToString();

                ViewParticipant vp = new ViewParticipant(name, EventID, name);
                vp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a participent from the grid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
