using System;
using System.Collections.Generic;
using System.Text;

namespace Gem.Models
{
    public class RefrigegeratedMultiTrailerTruck : MultiTrailerTruck
    {
        public RefrigegeratedMultiTrailerTruck(string color, string model, float width, float height, float length, float maxSpeed, string engine, float BoxVolume, byte numberOfTrailers) : base(color, model, width, height, length, maxSpeed, engine, BoxVolume, numberOfTrailers)
        {
        }

    }
}
