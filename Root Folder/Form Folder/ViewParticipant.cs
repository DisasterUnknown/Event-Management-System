using Root_Folder.Classes_Folder;
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
    public partial class ViewParticipant : Form
    {
        private string Uname;
        private string EventId;
        private string organizer;
        private string functionType;

        public ViewParticipant(string Uname, string eventId, string organizer, string functionType)
        {
            InitializeComponent();
            this.Uname = Uname;
            EventId = eventId;
            this.organizer = organizer;
            this.functionType = functionType;
        }


        // Page onload function
        private void ViewParticepent_Load(object sender, EventArgs e)
        {
            Admin a1 = new Admin();
            a1.DisplayParticipentDetails(Uname, this);

            if (functionType == "accountView")
            {
                RemoveUserBtn.Visible = false;
            }
        }


        // Back Btn
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (functionType == "accountView")
            {
                ViewUserAccounts v1 = new ViewUserAccounts();
                v1.Show();
                this.Hide();
            }
            else
            {
                ViewEvent e1 = new ViewEvent(EventId, organizer);
                e1.Show();
                this.Hide();
            }
        }


        // Remove user from the event function
        private void RemoveUserBtn_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure that you want to remov the user from this event!!\nThis will remove the user from the event!!", "Imformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.OK)
            {
                Admin a1 = new Admin();
                a1.RemoveUser(EventId, Uname);

                ViewEvent e1 = new ViewEvent(EventId, organizer);
                e1.Show();
                this.Hide();
            }
        }


        // Delete user account function
        private void KickUserBtn_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you need to kick the user from the system!!\nThis will lead to use account delection in the DataBase!!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (DialogResult == DialogResult.OK)
            {
                Admin a1 = new Admin();
                a1.KickUser(Uname);

                // Navigating to the correct page
                if (functionType == "accountView")
                {
                    ViewUserAccounts v1 = new ViewUserAccounts();
                    v1.Show();
                    this.Hide();
                }
                else
                {
                    ViewEvent e1 = new ViewEvent(EventId, organizer);
                    e1.Show();
                    this.Hide();
                }
            }
        }
    }
}
