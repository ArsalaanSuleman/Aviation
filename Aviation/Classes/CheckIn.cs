using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviation.Classes
{

    public class CheckIn
    {
        public List<Passenger> Passengers { get; set; }
        public Luggage Luggage { get; set; }
        public Flight Flight { get; set; }

        public CheckIn(List<Passenger> passengers, Luggage luggage, Flight flight)
        {
            Passengers = passengers;
            Luggage = luggage;
            Flight = flight;
        }

        public void DisplayCheckInDetails()
        {
            Console.WriteLine($"--- CHECK-IN DETAILS ---");
            Console.WriteLine($"Flight: {Flight.FlightNumber} to {Passengers[0].Destination}, Departure: {Flight.Departure}");
            Console.WriteLine($"Baggage: {Luggage.Pieces} pieces, Total weight: {Luggage.Weight}kg");

            Console.WriteLine("\nPassengers:");
            foreach (var passenger in Passengers)
            {
                Console.WriteLine($"- {passenger.Name}, Age: {passenger.Age}, Passport: {passenger.Passnumber}");

            }

        }
    }
}