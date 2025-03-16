using System;
using System.Collections.Generic;
using Aviation.Classes;

class Program
{
    static void Main()
    {

        Console.WriteLine("✈️ Welcome to Aviation Check-In System !\n");

        List<Flight> flights = new List<Flight>
        {
            new Flight("SK1234", DateTime.Now.AddHours(3), DateTime.Now.AddHours(6), "13A", "Paris", new List<string> { "12A", "12B", "12C", "13A", "13B" }),
            new Flight("DY5678", DateTime.Now.AddHours(3), DateTime.Now.AddHours(6), "12B","Rome", new List<string> { "14A", "14B", "14C", "15A", "15B" }),
            new Flight("BA9101", DateTime.Now.AddHours(3), DateTime.Now.AddHours(6), "15C","London", new List<string> { "16A", "16B", "16C", "17A", "17B" }),
            new Flight("SK1002", DateTime.Now.AddHours(3), DateTime.Now.AddHours(6), "10A","Belgium", new List<string> { "18A", "18B", "18C", "19A", "19B" }),
            new Flight("DY9003", DateTime.Now.AddHours(3), DateTime.Now.AddHours(6), "9A","New York", new List<string> { "20A", "20B", "20C", "21A", "21B" }),
            new Flight("BA8800", DateTime.Now.AddHours(3), DateTime.Now.AddHours(6), "5A","Oslo", new List<string> { "22A", "22B", "22C", "23A", "23B" })
        };

        List<string> availableSeats = new List<string> { };

        Console.WriteLine("Available flights:");
        for (int i = 0; i < flights.Count; i++)
        {
            Console.WriteLine($"{i + 1}. Flight {flights[i].FlightNumber} (Departs: {flights[i].Departure})");
        }

        int FlightChoice = GetValidInput("\nChoose a flight (1-6): ", 1, flights.Count);
        Flight selectedFlight = flights[FlightChoice - 1];

        Console.Clear();
        Console.WriteLine($"✈️ You selected flight {selectedFlight.FlightNumber} to {selectedFlight.Destination}\n");

        List<Passenger> passengers = new List<Passenger>();
        while (true)
        {
            Console.Write("Enter passenger name (or type 'Done' to finish):");
            string name = Console.ReadLine();
            if (name.ToLower() == "done") break;

            int age = GetValidInput("Enter age: ", 1, 120);

            int passNumber = GetValidInput("Enter passport number: ", 10000000, 99999999);

            passengers.Add(new Passenger(name, age, passNumber, selectedFlight.FlightNumber));
            Console.WriteLine($"Passenger {name} added!\n");

        }

        int luggageWeigth = GetValidInput("\n Enter luggage weight (kg): ", 1, 50);

        Luggage luggage = new Luggage(luggageWeigth, 1, 30);
        CheckIn checkIn = new CheckIn(passengers, luggage, selectedFlight);

        Console.Clear();
        checkIn.DisplayCheckInDetails();
        checkIn.CheckBaggage();
        checkIn.AssignSeats(selectedFlight.AvailableSeats);
        checkIn.PrintBoardingPass();

    }

    static int GetValidInput(string message, int min, int max)
    {
        int value;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
            {
                return value;
            }
            Console.WriteLine($" Invalid Input! Please enter a number between {min} and {max}.\n");
        }
    }
}