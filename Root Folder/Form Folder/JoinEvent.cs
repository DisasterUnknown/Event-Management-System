﻿using Org.BouncyCastle.Bcpg;
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
    public partial class JoinEvent : Form
    {
        private string EventId;
        private string Uname;

        public JoinEvent(string EventId, string Uname)
        {
            InitializeComponent();
            this.EventId = EventId;
            this.Uname = Uname;
        }

        // Page onload Function
        private void JoinEvent_Load(object sender, EventArgs e)
        {
            Participant p1 = new Participant();
            p1.EventJoinPageOnLoad(EventId, this);
            //MyDb.EventJoinPageOnLoad(EventId, NameIN, LocationIN, DateTimeIN, PriceIN);
        }

        // Page Back Btn
        private void BackBtn_Click(object sender, EventArgs e)
        {
            CustemerDashbord c1 = new CustemerDashbord(Uname);
            c1.Show();
            this.Hide();
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            CustemerDashbord c1 = new CustemerDashbord(Uname);
            c1.Show();
            this.Hide();
        }

        private void JoinBtn_Click(object sender, EventArgs e)
        {
            Participant p1 =new Participant();
            p1.JoinEvent(Uname, EventId, this);
        }
    }
}
