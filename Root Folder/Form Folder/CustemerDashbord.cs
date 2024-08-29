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
    public partial class CustemerDashbord : Form
    {
        private string Uname;
        public CustemerDashbord(string Uname)
        {
            InitializeComponent();
            this.Uname = Uname;
        }

        // Page Onlaod Function
        private void CustemerDashbord_Load(object sender, EventArgs e)
        {
            Particepent p1 = new Particepent();
            p1.ViewEventDetails(EventDashBord);
        }

        // Navigate to JoinPage
        private void ViewJoinPageBtn_Click(object sender, EventArgs e)
        {
            if (EventDashBord.SelectedRows.Count > 0)
            {
                string eventID = EventDashBord.SelectedRows[0].Cells["Id"].Value.ToString();
                JoinEvent j1 = new JoinEvent(eventID, Uname);
                j1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select the event first!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Navigate to View Joined events Page
        private void ViewJoined_Click(object sender, EventArgs e)
        {
            ViewJoinedEvents v1 = new ViewJoinedEvents(Uname);
            v1.Show();
            this.Hide();
        }

        // LogOut Btn
        private void button1_Click(object sender, EventArgs e)
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
