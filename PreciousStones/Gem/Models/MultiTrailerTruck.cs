using System;
using System.Collections.Generic;
using System.Text;

namespace Gem.Models
{
    public class MultiTrailerTruck : Truck
    {
        public byte NumberOfTrailers { get; set; }
        public MultiTrailerTruck(string color, string model, float width, float height, float length, float maxSpeed, string engine, float BoxVolume, byte numberOfTrailers) : base(color, model, width, height, length, maxSpeed, engine, BoxVolume)
        {
            this.NumberOfTrailers = numberOfTrailers;
            
        }
        public override string ShowSpecifications(string type)
        {
            return $"{base.ShowSpecifications(type)},{NumberOfTrailers}";

        }
    }
}
