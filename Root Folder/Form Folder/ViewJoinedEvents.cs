﻿using System;
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
            Participant p1 = new Participant();
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
            if (DisplayJoinedEvents.SelectedRows.Count > 0)
            {
                Participant p1 = new Participant();
                p1.LeaveEvent(UserID, Uname, DisplayJoinedEvents);
            }
            else
            {
                MessageBox.Show("Please select the event first!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
