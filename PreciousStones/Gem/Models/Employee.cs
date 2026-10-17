using System;
using System.Collections.Generic;
using System.Text;

namespace Gem.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public string Position { get; set; }

        public decimal Salary { get; set; }

        public string Email { get; set; }

        public Employee(int Id, string FullName, string Address)
        {
            this.Id = Id;
            this.FullName = FullName;
            this.Address = Address;

        }
        public Employee(int Id, string FullName, string Address, string Position) : this(Id, FullName, Address)
        {
            this.Position = Position;
        }
        public Employee(int Id, string FullName, string Address, string Position, decimal Salary, string Email) : this(Id, FullName, Address, Position)
        { 
            this.Salary = Salary;
            this.Email = Email;
        }

    }
}
