using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3.Models
{
    public record Booking
    (
        int Id,
        int UserId,
        int FlightId,
        int TotalSeats,
        string Status
    );

    public record BookingWithUserAndFlight(
        int Id,
        User User,
        Flight Flight,
        int TotalSeats,
        string Status
    );
}
