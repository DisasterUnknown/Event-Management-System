using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Root_Folder.Form_Folder
{
    public partial class ViewUserAccounts : Form
    {
        public ViewUserAccounts()
        {
            InitializeComponent();
        }


        // Page Onload Function
        private void ViewUserAccounts_Load(object sender, EventArgs e)
        {
            MyDb.ViewUserAccounts(UserAccountGrid);
        }


        // Back Btn
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminDashbord a1 = new AdminDashbord();
            a1.Show();
            this.Hide();
        }


        // View Details btn click function
        private void ViewDetailsBtn_Click(object sender, EventArgs e)
        {
            if (UserAccountGrid.SelectedRows.Count > 0)
            {

                string Uname = UserAccountGrid.SelectedRows[0].Cells["Uname"].Value.ToString();
                ViewParticipant v1 = new ViewParticipant(Uname, null, "admin@123", "accountView");

                v1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select the user row you need to see details!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
