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
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NewAdminForm form14 = new NewAdminForm();
            form14.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            AdminLogin form2 = new AdminLogin();
            form2.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CancelFlight form16 = new CancelFlight();
            form16.Show();
        }
    }
}
