using System;
using System.Collections.Generic;
using System.Text;

namespace Gem.Models
{
    public partial class Customer
    {
        public string Email { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + ", Name: " 
                + Name + ", Email: " + Email 
                + ", Address: " + Address;
        }
    }
}
