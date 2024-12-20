﻿using Root_Folder.Classes_Folder;
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
        private string Oname;
        private string EventID;

        public ViewEvent(string EventID, string organizer)
        {
            InitializeComponent();
            this.EventID = EventID;
            this.Oname = organizer;
        }

        private void ViewEvent_Load(object sender, EventArgs e)
        {
            Admin_Organizer_Interface AO = new Admin();
            AO.OrgViewEventDeatils(EventID, this);
            AO.ParticipentGridOnload(EventID, ParticipentGrid);

            if (Oname == "admin@123")
            {
                DetailsBtn.Visible = true;
                RemoveParticipantBtn.Visible = false;
            }
            else
            {
                DetailsBtn.Visible = false;
                RemoveParticipantBtn.Visible = true;
            }
        }


        // Page back Btn
        private void BackBtn_Click(object sender, EventArgs e)
        {
            // Checking the redirect page
            if (Oname == "admin@123")
            {
                AdminDashbord a1 = new AdminDashbord();
                a1.Show();
                this.Hide();
            }
            else
            {
                OganizerDashbord o1 = new OganizerDashbord(Oname);
                o1.Show();
                this.Hide();
            }
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            if (ParticipentGrid.SelectedRows.Count > 0)
            {
                string name = ParticipentGrid.SelectedRows[0].Cells["Uname"].Value.ToString();

                ViewParticipant vp = new ViewParticipant(name, EventID, Oname, "EventView");
                vp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a participent from the grid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RemoveParticipantBtn_Click(object sender, EventArgs e)
        {
            if (ParticipentGrid.SelectedRows.Count > 0)
            {
                string name = ParticipentGrid.SelectedRows[0].Cells["Uname"].Value.ToString();
                
                Event e1 = new Event();
                e1.RemoveParticipant(EventID, name);

                // Loading the form again
                ViewEvent f1 = new ViewEvent(EventID, Oname);
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select the participant row to remove the participant", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
