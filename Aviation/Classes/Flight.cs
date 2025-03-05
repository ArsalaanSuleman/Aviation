using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviation.Classes
{
    public class Flight
    {
        public string? FlightNumber { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public string? Seat { get; set; }

        public Flight(string flightNumber, DateTime departure, DateTime arrival, string seat)
        {
            FlightNumber = flightNumber;
            Departure = departure;
            Arrival = arrival;
            Seat = seat;
        }
    }
}