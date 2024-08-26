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
    public partial class ViewJoinedEvents : Form
    {
        private string Uname;
        private string UserID;

        public ViewJoinedEvents(string uname)
        {
            InitializeComponent();
            Uname = uname;
        }

        // Page Onload functions
        private void ViewJoinedEvents_Load(object sender, EventArgs e)
        {
            Particepent p1 = new Particepent();
            UserID = p1.ViewJoinedEvents(Uname, DisplayJoinedEvents);
        }

        // Back Btn
        private void BackBtn_Click(object sender, EventArgs e)
        {
            CustemerDashbord c1 = new CustemerDashbord(Uname);
            c1.Show();
            this.Hide();
        }

        private void LeaveBtn_Click(object sender, EventArgs e)
        {
            Particepent p1 = new Particepent();
            p1.LeaveEvent(UserID, Uname, DisplayJoinedEvents);
        }
    }
}
