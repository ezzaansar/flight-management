using System;
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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightsSchedule form10 = new FlightsSchedule();
            form10.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddFlightForm form11 = new AddFlightForm();
            form11.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PassengerBookingList form12 = new PassengerBookingList();
            form12.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NewAdminForm form14 = new NewAdminForm();
            form14.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminLogin form2 = new AdminLogin();
            form2.Show();
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
