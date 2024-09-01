using Root_Folder.Form_Folder;
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
    public partial class AdminDashbord : Form
    {
        private string name = "admin@123";
        public AdminDashbord()
        {
            InitializeComponent();
        }


        // Page onload Function
        private void AdminDashbord_Load(object sender, EventArgs e)
        {
            Person p1 = new Admin();
            p1.ViewEventDetails(EventListTable);
        }


        // Admin remove event function
        private void RemoveEventBtn_Click(object sender, EventArgs e)
        {
            if (EventListTable.SelectedRows.Count > 0)
            {
                DialogResult funcanality = MessageBox.Show("Are you sure that you want to remove the event?\nThis will remove all the participents from the events!!", "Imformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                Admin a1 = new Admin();
                a1.RemoveEvent(EventListTable);
            }
            else
            {
                MessageBox.Show("Please select the event to be removed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Logout btn
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


        // View event details
        private void ViewEventDetailsBtn_Click(object sender, EventArgs e)
        {
            if (EventListTable.SelectedRows.Count > 0)
            {
                string eventId = EventListTable.SelectedRows[0].Cells["Id"].Value.ToString();

                ViewEvent v1 = new ViewEvent(eventId, name);
                v1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select the event!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Navigate to view user details page
        private void ViewUsersBtn_Click(object sender, EventArgs e)
        {
            ViewUserAccounts v1 = new ViewUserAccounts();
            v1.Show();
            this.Hide();
        }
    }
}
