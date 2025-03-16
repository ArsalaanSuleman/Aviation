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
        public Dictionary<Passenger, string> SeatAssignments { get; set; }

        public CheckIn(List<Passenger> passengers, Luggage luggage, Flight flight)
        {
            Passengers = passengers;
            Luggage = luggage;
            Flight = flight;
            SeatAssignments = new Dictionary<Passenger, string>();
        }

        public void AssignSeats(List<string> availableSeats)
        {
            Console.WriteLine("\n✈️ Available seats: " + string.Join(", ", availableSeats));

            foreach (var passenger in Passengers)
            {
                Console.Write($"{passenger.Name}, choose a seat: ");
                string chosenSeat = Console.ReadLine().ToUpper();

                while (!availableSeats.Contains(chosenSeat))
                {
                    Console.WriteLine("❌ Seat not available. Choose another seat.");
                    chosenSeat = Console.ReadLine().ToUpper();
                }

                SeatAssignments[passenger] = chosenSeat;
                availableSeats.Remove(chosenSeat);
                Console.WriteLine($"{passenger.Name} has been assigned seat {chosenSeat}\n");
            }
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

        public void PrintBoardingPass()
        {
            Console.WriteLine("\n🎟️ --- BOARDING PASS --- 🎟️");
            Console.WriteLine($"Flight: {Flight.FlightNumber} to {Flight.Destination}");
            Console.WriteLine($"Departure: {Flight.Departure}");
            string seat = Passengers.Count > 0 && SeatAssignments.ContainsKey(Passengers[0]) ? SeatAssignments[Passengers[0]] : "Not Assigned";
            Console.WriteLine($"Seat: {seat}");
            Console.WriteLine($"Baggage: {Luggage.Pieces} pieces, Total weight: {Luggage.Weight}kg");
            Console.WriteLine("\nPassengers:");

            foreach (var passenger in Passengers)
            {
                Console.WriteLine($"- {passenger.Name}, Age: {passenger.Age}, Passport: {passenger.Passnumber}, Seat: {seat}");
            }

            Console.WriteLine("\n✅ Please arrive at the gate 30 minutes before departure.");
            Console.WriteLine("Have a great flight! ✈️");
        }
    }
}