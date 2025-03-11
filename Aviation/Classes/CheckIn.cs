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

        public void CheckBaggage()
        {
            if (Luggage.Weight > Luggage.MaximumLuggage)
            {
                Console.WriteLine("⚠️ WARNING: Overweight baggage! Additional fees may apply.");
                Console.Write("Would you like to pay the extra fee? (yes/no): " + "  ");
                string response = Console.ReadLine()?.ToLower();

                if (response == "yes")
                {
                    Console.WriteLine("✅ Extra fee paid. Your baggage is now accepted.");
                }
                else
                {
                    Console.WriteLine("❌ Check-in denied. Please reduce your baggage weight.");
                }
            }
            else
            {
                Console.WriteLine("✅ Baggage is within the weight limit.");

            }
        }

        public void DisplayCheckInDetails()
        {
            Console.WriteLine($"--- CHECK-IN DETAILS ---");
            Console.WriteLine($"Flight: {Flight.FlightNumber} to {Passengers[0].Destination}, Departure: {Flight.Departure}");
            Console.WriteLine($"Baggage: {Luggage.Pieces} pieces, Total weight: {Luggage.Weight}kg");
            Console.WriteLine($"Destination: {Flight.Destination}");

            Console.WriteLine("\nPassengers:");
            foreach (var passenger in Passengers)
            {
                Console.WriteLine($"- {passenger.Name}, Age: {passenger.Age}, Passport: {passenger.Passnumber}");

            }

        }
    }
}