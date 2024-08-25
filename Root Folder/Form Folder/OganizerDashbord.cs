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
            Organizer o1 = new Organizer();
            o1.ViewUpdate(organizer, EventTable, this);
        }


        // Remove Event Btn Click
        private void EventRemoveBtn_Click(object sender, EventArgs e)
        {
            Organizer o1 = new Organizer();
            o1.RemoveEvent(organizer, EventTable);
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
    }
}
