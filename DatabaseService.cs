using MySqlConnector;
using SE3.Models;

namespace SE3
{
    public class DatabaseService
    {

        private static DatabaseService? _instance = null;
        public static DatabaseService Instance
        {
            get
            {
                if (_instance == null) _instance = new DatabaseService();
                return _instance;
            }
        }

        private String _connectionString = "";
        public void SetConnectionString(String connectionString) => _connectionString = connectionString;

        public Models.User? GetUser(String username, String password)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand("SELECT * FROM Users WHERE Email = @Username AND Password = @Password", connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User(
                                UserId: reader.GetInt32("UserID"),
                                FirstName: reader.GetString("FirstName"),
                                LastName: reader.GetString("LastName"),
                                Gender: reader.GetString("Gender"),
                                DateOfBirth: reader.GetDateOnly("DateOfBirth"),
                                CNIC: reader.GetString("UserCNIC"),
                                Email: reader.GetString("Email"),
                                PhoneNumber: reader.GetString("PhoneNumber"),
                                Address: reader.GetString("Address"),
                                Password: reader.GetString("Password"),
                                Country: reader.GetString("country"),
                                City: reader.GetString("city"),
                                State: reader.GetString("state_province"),
                                Role: reader.GetString("Role")
                            );
                        }
                    }
                }
            }

            return null;
        }

        public User? SaveUser(User user)
        {
            // save user to database
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand("INSERT INTO Users (FirstName, LastName, Gender, DateOfBirth, UserCNIC, Email, PhoneNumber, Address, Password, country, city, state_province) VALUES (@FirstName, @LastName, @Gender, @DateOfBirth, @UserCNIC, @Email, @PhoneNumber, @Address, @Password, @Country, @City, @State)", connection))
                {
                    command.Parameters.AddWithValue("@FirstName", user.FirstName);
                    command.Parameters.AddWithValue("@LastName", user.LastName);
                    command.Parameters.AddWithValue("@Gender", user.Gender);
                    command.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                    command.Parameters.AddWithValue("@UserCNIC", user.CNIC);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", user.Address);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Country", user.Country);
                    command.Parameters.AddWithValue("@City", user.City);
                    command.Parameters.AddWithValue("@State", user.State);
                    command.ExecuteNonQuery();
                    return GetUser(user.Email, user.Password);
                }
            }
        }

        public List<Booking> GetBooking(int? UserId = null)
        {
            var bookings = new List<Booking>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string commandStr = "Select * from bookings";
                if (UserId != null) commandStr += " where UserId = " + UserId;
                using (var command = new MySqlCommand(commandStr,connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var booking = new Booking(
                            Id: reader.GetInt32("BookingID"),
                            UserId: reader.GetInt32("UserId"),
                            FlightId:reader.GetInt32("FlightId"),
                            Status:reader.GetString("Status"),
                            TotalSeats:reader.GetInt32("TotalSeats")

                            );
                        bookings.Add(booking);

                     
                    }
                }
            }

            return bookings;
        }

        public List<Flight> GetFlights() { 
            var flights = new List<Flight>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand("Select * from Flights", connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var flight = new Flight(
                            FlightId: reader.GetInt32("FlightID"),
                            FlightNumber: reader.GetString("FlightNumber"),
                            ArrivalTime: reader.GetDateTime("DepartureTime"),
                            DepartureTime: reader.GetDateTime("ArrivalTime"),
                            SeatCapacity: reader.GetInt32("SeatCapacity"),
                            AvailableSeats: reader.GetInt32("AvailableSeats"),
                            TicketPrice: reader.GetDouble("TicketPrice")
                        );
                        flights.Add(flight);
                    }
                }
            }

            return flights;
        }

        public Flight? SaveFlight(Flight flight) {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand("INSERT INTO Flights(FlightNumber, DepartureTime, ArrivalTime, SeatCapacity, AvailableSeats, TicketPrice) values (@FlightNumber, @DepartureTime, @ArrivalTime, @SeatCapacity, @AvailableSeats, @TicketPrice);", connection))
                {
                    command.Parameters.AddWithValue("@FlightNumber", flight.FlightNumber);
                    command.Parameters.AddWithValue("@DepartureTime", flight.DepartureTime.ToString("yyyy-MM-dd H:mm:ss"));
                    command.Parameters.AddWithValue("@ArrivalTime", flight.ArrivalTime.ToString("yyyy-MM-dd H:mm:ss"));
                    command.Parameters.AddWithValue("@SeatCapacity", flight.SeatCapacity);
                    command.Parameters.AddWithValue("@AvailableSeats", flight.AvailableSeats);
                    command.Parameters.AddWithValue("@TicketPrice", flight.TicketPrice);
                    command.ExecuteNonQuery();
                    return flight with { FlightId = (int) command.LastInsertedId };
                }
            }
        }

        public bool CancelFlight(int FlightId)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    using (var command = new MySqlCommand("Delete from Flights where FlightId = @FlightId;", connection))
                    {
                        command.Parameters.AddWithValue("@FlightId", FlightId);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (MySqlException ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
