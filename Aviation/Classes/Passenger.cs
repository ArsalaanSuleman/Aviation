using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviation.Classes
{

    public class Passenger
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public int Passnumber { get; set; }
        public string? Destination { get; set; }

        public Passenger(string name, int age, int passnumber, string destination)
        {
            Name = name;
            Age = age;
            Passnumber = passnumber;
            Destination = destination;
        }
    }
}