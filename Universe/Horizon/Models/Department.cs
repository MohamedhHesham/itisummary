using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Horizon.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You have to provide a valid name.")]
        [MinLength(2, ErrorMessage = "Name mustn't be less than 2 characters.")]
        [MaxLength(10, ErrorMessage = "Name mustn't exceed 10 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You have to provide a valid description.")]
        [MinLength(6, ErrorMessage = "Description mustn't be less than 6 characters.")]
        [MaxLength(30, ErrorMessage = "Description mustn't exceed 30 characters.")]
        public string Description { get; set; }

        [ValidateNever]
        public List<Employee> Employees { get; set; }


    }
}
