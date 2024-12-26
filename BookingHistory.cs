using System.Data;

namespace SE3
{
    public partial class BookingHistory : Form
    {
        public BookingHistory()
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
            SearchFlight form6 = new SearchFlight();
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

        private void BookingHistory_Load(object sender, EventArgs e)
        {
            var databaseService = DatabaseService.Instance;
            var userService = UserService.Instance;
            var bookings = databaseService.GetBooking(userService.CurrentUser?.UserId);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("bookingid",typeof(int));
            dataTable.Columns.Add("userid", typeof(int));
            dataTable.Columns.Add("flightid", typeof(int));
            dataTable.Columns.Add("totalseats",typeof (int));
            dataTable.Columns.Add("Status", typeof(string));
            foreach (var booking in bookings)
            {
                dataTable.Rows.Add(new Object[] { booking.Id,booking.UserId, booking.FlightId,booking.TotalSeats,booking.Status});

            }
            GridView.DataSource = dataTable;
        }
    }
}
