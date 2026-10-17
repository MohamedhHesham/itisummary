using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Gem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return Id + "," + Name + "," + Price;
        }
    }
}
