using System;
using System.Collections.Generic;
using System.Text;

namespace BrightStars.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ? Notes { get; set; }
        public decimal Price { get; set; }  
        
        //public byte? Rating { get; set; }
        public override string ToString()
        {
            return 
        $"\nId\t: {Id}" +
        $"\nName\t: {Name}" +
        $"\nNotes\t: {Notes}" +
        $"\nPrice\t: {Price}";
        }
    }
}
