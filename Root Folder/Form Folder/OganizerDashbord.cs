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

        private void AddEventBtn_Click(object sender, EventArgs e)
        {
            CreateEvent c1 = new CreateEvent(organizer);
            c1.Show();
            this.Hide();
        }

        private void OganizerDashbord_Load(object sender, EventArgs e)
        {
            Organizer o1 = new Organizer();
            o1.ViewEventDetails(EventTable);
        }

        private void UpdateEvent_Click(object sender, EventArgs e)
        {
            MyDb.ViewUpdate(organizer, EventTable, this);
        }
    }
}
