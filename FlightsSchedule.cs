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
    public partial class FlightsSchedule : Form
    {
        public FlightsSchedule()
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            CancelFlight form16 = new CancelFlight();
            form16.Show();
        }

        private void FlightsSchedule_Load(object sender, EventArgs e)
        {
            var service = DatabaseService.Instance;
            var flights = service.GetFlights();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Flight Id", typeof(int));
            dataTable.Columns.Add("Flight Number", typeof(string));
            dataTable.Columns.Add("Arrival Time", typeof(DateTime));
            dataTable.Columns.Add("Departure Time", typeof(DateTime));
            dataTable.Columns.Add("Seat Capacity", typeof(int));
            dataTable.Columns.Add("Available Seats", typeof(int));
            dataTable.Columns.Add("Ticket Price", typeof(double));
            foreach (var flight in flights)
            {
                dataTable.Rows.Add(new Object[] { flight.FlightId, flight.FlightNumber, flight.ArrivalTime, flight.DepartureTime, flight.SeatCapacity, flight.AvailableSeats, flight.TicketPrice });

            }
            FlightsGridView.DataSource = dataTable;
        }
    }
}
