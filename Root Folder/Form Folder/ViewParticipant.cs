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
    public partial class ViewParticipant : Form
    {
        private string Uname;
        private string EventId;
        private string organizer;

        public ViewParticipant(string Uname, string eventId, string organizer)
        {
            InitializeComponent();
            this.Uname = Uname;
            EventId = eventId;
            this.organizer = organizer;
        }

        private void ViewParticepent_Load(object sender, EventArgs e)
        {
            MyDb.DisplayParticipentDetails(Uname ,NameIN, TelIN, GmailIN);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            ViewEvent e1 = new ViewEvent(EventId, organizer);
            e1.Show();
            this.Hide();
        }
    }
}
