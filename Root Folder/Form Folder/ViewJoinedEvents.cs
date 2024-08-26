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

        public ViewJoinedEvents(string uname)
        {
            InitializeComponent();
            Uname = uname;
        }

        private void ViewJoinedEvents_Load(object sender, EventArgs e)
        {
            Particepent p1 = new Particepent();
            p1.ViewJoinedEvents(Uname, DisplayJoinedEvents);
        }
    }
}
