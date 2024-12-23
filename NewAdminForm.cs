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
    public partial class NewAdminForm : Form
    {
        public NewAdminForm()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CancelFlight form16 = new CancelFlight();
            form16.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to add this user as an Admin?",
                "Adding Admin",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Handle the user's response
            if (result == DialogResult.Yes)
            {
                // Proceed with Ticket Generation logic
                MessageBox.Show("Adding Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoginForm form1 = new LoginForm();
                form1.Show();
            }
            else
            {
                // Cancel the ticket
                MessageBox.Show("Cancel adding admin.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
