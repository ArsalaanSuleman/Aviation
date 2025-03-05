using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviation.Classes
{
    public class Luggage
    {
        public int Weight { get; set; }
        public int Pieces { get; set; }
        public int MaximumLuggage { get; set; }

        public Luggage(int weight, int pieces, int maximumLuggage)
        {
            Weight = weight;
            Pieces = pieces;
            MaximumLuggage = maximumLuggage;
        }
    }
}