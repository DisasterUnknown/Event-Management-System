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
    public partial class OganizerDashbord : Form
    {
        private string organizer;
        public OganizerDashbord(string organizer)
        {
            InitializeComponent();
            this.organizer = organizer;
        }


        // Caling the add event form
        private void AddEventBtn_Click(object sender, EventArgs e)
        {
            CreateEvent c1 = new CreateEvent(organizer, null, "Add");
            c1.Show();
            this.Hide();
        }


        // Loading the events
        private void OganizerDashbord_Load(object sender, EventArgs e)
        {
            Organizer o1 = new Organizer();
            o1.ViewEventDetails(EventTable);
        }


        // Calling the Update Event Form
        private void UpdateEvent_Click(object sender, EventArgs e)
        {
            if (EventTable.SelectedRows.Count > 0)
            {
                Organizer o1 = new Organizer();
                o1.ViewUpdate(organizer, EventTable, this);
            }
            else
            {
                MessageBox.Show("Please select the event to be edited!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Remove Event Btn Click
        private void EventRemoveBtn_Click(object sender, EventArgs e)
        {
            if (EventTable.SelectedRows.Count > 0)
            {
                DialogResult funcanality = MessageBox.Show("Are you sure that you want to remove the event?\nThis will remove all the participents from the events!!", "Imformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (funcanality == DialogResult.Yes)
                {
                    Organizer o1 = new Organizer();
                    o1.RemoveEvent(organizer, EventTable);
                }
            }
            else
            {
                MessageBox.Show("Please select the event to be removed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // LogOut Button
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to LogOut!!", "Imformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                HomePage h1 = new HomePage();
                h1.Show();
                this.Hide();
            }
        }


        // View Event Details
        private void ViewDetailsBtn_Click(object sender, EventArgs e)
        {
            if (EventTable.SelectedRows.Count > 0)
            {
                Organizer o1 = new Organizer();
                o1.OrgViewEventDetails(organizer, EventTable, this);
            }
            else
            {
                MessageBox.Show("Please select the event to be removed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
