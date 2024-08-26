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
            Particepent p1 = new Particepent();
            p1.ViewEventJoinPage(Uname, EventDashBord, this);
        }

        // Navigate to View Joined events Page
        private void ViewJoined_Click(object sender, EventArgs e)
        {
            ViewJoinedEvents v1 = new ViewJoinedEvents(Uname);
            v1.Show();
            this.Hide();
        }
    }
}
