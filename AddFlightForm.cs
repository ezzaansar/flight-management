using SE3.Models;
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
    public partial class AddFlightForm : Form
    {
        public AddFlightForm()
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminHomePage form9 = new AdminHomePage();
            form9.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CancelFlight form16 = new CancelFlight();
            form16.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string flightNumber = FlightNumberTextBox.Text.Trim();
            DateTime arrivalTime = ArrivalTimePicker.Value;
            DateTime departureTime = DepartureTimePicker.Value;
            int seatCapacity = int.Parse(TotalSeatsTextBox.Text.Trim());
            int availableSeats = seatCapacity;
            double ticketPrice = double.Parse(TicketPriceTextBox.Text.Trim());

            if (flightNumber == string.Empty || seatCapacity <= 0 || ticketPrice <= 0) return;

            var flight = new Flight(
                FlightId: -1,
                FlightNumber: flightNumber,
                ArrivalTime: arrivalTime,
                DepartureTime: departureTime,
                SeatCapacity: seatCapacity,
                AvailableSeats: availableSeats,
                TicketPrice: ticketPrice
            );

            var service = DatabaseService.Instance;
            var savedFlight = service.SaveFlight(flight);

            if (flight != null)
            {
                var flightsScheduleForm = new FlightsSchedule();
                flightsScheduleForm.Show();
            } else
            {
                MessageBox.Show("Failed to save flight data.");
            }
        }
    }
}
