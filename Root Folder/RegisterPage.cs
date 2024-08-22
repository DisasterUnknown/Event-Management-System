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
    public partial class RegisterPage : Form
    {
        private string role;
        public RegisterPage(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
            if (role == "admin")
            {
                label8.Visible = true;
                AdminPassIN.Visible = true;
            }
            else
            {
                label8.Visible = false;
                AdminPassIN.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginPage l1 = new LoginPage(role);
            l1.Show();
            this.Hide();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = UnameIN.Text;
                string gmail = GmailIN.Text;
                int age = int.Parse(AgeIN.Text);
                long tel = long.Parse((TelIN.Text).Replace(" ", string.Empty));
                string pass = PassIN.Text;
                string comPass = ComPassIN.Text;

                if (role == "admin")
                {
                    string adminID = AdminPassIN.Text;
                    if (adminID == "admin123")
                    {
                        Person p1 = new Person(name, age, pass, comPass, gmail, tel, role);
                    }
                    else
                    {
                        MessageBox.Show("Invalide Admin ID!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Person p1 = new Person(name, age, pass, comPass, gmail, tel, role);
                }
            }
            catch (Exception ex)  
            {
                MessageBox.Show($"Please Fill the Form!!\n{ex}", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AgeIN_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            AgeIN.Text = string.Empty;
        }

        private void TelIN_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            TelIN.Text = string.Empty;
        }
    }
}
