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
    public partial class BookTicket : Form
    {
        public BookTicket()
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
            Form8 form8 = new Form8();
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

        private void button8_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to proceed with the generating ticket?",
                "Generating Ticket",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Handle the user's response
            if (result == DialogResult.Yes)
            {
                // Proceed with Ticket Generation logic
                MessageBox.Show("Generating Ticket!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form15 form15 = new Form15();
                form15.Show();
            }
            else
            {
                // Cancel the ticket
                MessageBox.Show("Cancel Ticket.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            HomePage form4 = new HomePage();
            form4.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
