using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3.Models
{
  public record Flight
    (
        int FlightId,
        string FlightNumber,
        DateTime ArrivalTime,
        DateTime DepartureTime,
        int SeatCapacity,
        int AvailableSeats,
        double TicketPrice

    );
}
