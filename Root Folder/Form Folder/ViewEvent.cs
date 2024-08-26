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
        private string organizer;
        private string EventID;
        public ViewEvent(string EventID, string organizer)
        {
            InitializeComponent();
            this.EventID = EventID;
            this.organizer = organizer;
        }

        private void ViewEvent_Load(object sender, EventArgs e)
        {
            MyDb.OrgViewEventDeatils(EventID, NameIN, PlaceIN, DateTimeIN, PriceIN, SeatsCountIN);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            OganizerDashbord o1 = new OganizerDashbord(organizer);
            o1.Show();
            this.Hide();
        }
    }
}
