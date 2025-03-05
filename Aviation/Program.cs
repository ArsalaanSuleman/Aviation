using System;
using System.Collections.Generic;
using Aviation.Classes;

class Program
{
    static void Main()
    {
        List<Passenger> passengers = new List<Passenger>
        {
            new Passenger("John Doe", 32, 12345678, "New York"),
            new Passenger("Jane Smith", 28, 87654321, "New York"),
            new Passenger("Alice Johnson", 35, 11112222, "New York"),
            new Passenger("Bob Brown", 40, 22223333, "New York"),
            new Passenger("Charlie Davis", 22, 33334444, "New York"),
            new Passenger("David White", 30, 44445555, "New York"),
            new Passenger("Emma Black", 27, 55556666, "New York"),
            new Passenger("Frank Harris", 45, 66667777, "New York"),
            new Passenger("Grace Lee", 29, 77778888, "New York"),
            new Passenger("Henry Martin", 31, 88889999, "New York"),
            new Passenger("Isabella Clark", 24, 99990000, "New York"),
            new Passenger("Jack Wilson", 50, 10101010, "New York"),
            new Passenger("Karen Moore", 26, 12121212, "New York"),
            new Passenger("Leo Walker", 23, 13131313, "New York"),
            new Passenger("Mia Hall", 34, 14141414, "New York"),
            new Passenger("Nathan Young", 29, 15151515, "New York"),
            new Passenger("Olivia King", 33, 16161616, "New York"),
            new Passenger("Paul Scott", 37, 17171717, "New York"),
            new Passenger("Quincy Allen", 42, 18181818, "New York"),
            new Passenger("Rachel Turner", 25, 19191919, "New York"),
            new Passenger("Samuel Adams", 38, 20202020, "New York")
        };

        Console.Write("Enter luggage weight (kg): ");
        int luggageWeigth;
        while (!int.TryParse(Console.ReadLine(), out luggageWeigth))
        {
            Console.WriteLine("Invalid input! Please enter a valid number");
        }

        Luggage luggage = new Luggage(luggageWeigth, 1, 30);
        Flight flight = new Flight("SK1234", DateTime.Now.AddHours(3), DateTime.Now.AddHours(6), "12A");
        CheckIn checkIn = new CheckIn(passengers, luggage, flight);

        checkIn.DisplayCheckInDetails();
        checkIn.CheckBaggage();

    }
}