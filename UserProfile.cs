﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE3
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchFlight form5 = new SearchFlight();
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookTicket form6 = new BookTicket();
            form6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookingHistory form7 = new BookingHistory();
            form7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserProfile form8 = new UserProfile();
            form8.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?",
                                     "Exit Application",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
