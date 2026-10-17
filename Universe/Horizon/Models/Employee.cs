using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name ="Full Name")]
        [Required(ErrorMessage = "You have to provide a valid full name.")]
        [MinLength(12, ErrorMessage = "Full name mustn't be less than 12 characters.")]
        [MaxLength(50, ErrorMessage = "Full name mustn't exceed 50 characters.")]
        public string FullName { get; set; }
        
        [DisplayName("Job")]
        [Required(ErrorMessage = "You have to provide a valid position.")]
        [MinLength(3, ErrorMessage = "Position mustn't be less than 3 characters.")]
        [MaxLength(25, ErrorMessage = "Position mustn't exceed 25 characters.")]
        public string Position { get; set; }

        [Range(6000, 84000, ErrorMessage = "Salary must be between 7000 EGP and 84000 EGP.")]
        public decimal Salary { get; set; }

        [DisplayName("National Id")]
        [Required(ErrorMessage = "You have to provide a valid National Id.")]
        [MinLength(14, ErrorMessage = "National number mustn't be less than 14 characters.")]
        [MaxLength(14, ErrorMessage = "National number mustn't exceed 14 characters.")]
        public string NationalId { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [DisplayName("Phone")]
        public string PhoneNo { get; set; }
        
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
            
            ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }

        [NotMapped]
        [Compare(nameof(Email),ErrorMessage="Email and ConfirmEmail don't match ")]
        public string ConfirmEmail { get; set; }
        [Required(ErrorMessage = "You have to provide a valid country.")]
        [MinLength(3, ErrorMessage = "Country mustn't be less than 3 characters.")]
        [MaxLength(36, ErrorMessage = "Country mustn't exceed 36 characters.")]
        public string Country { get; set; }

        [DisplayName("Department")]
        [Range(1,int.MaxValue,ErrorMessage ="Choose a valid department!")]
        public int DepartmentId { get; set; }

        [ValidateNever]
        [DeleteBehavior(DeleteBehavior.NoAction)]

        public Department Department { get; set; }

        [DisplayName("Image")]
        [ValidateNever]
        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        [ValidateNever]

        public string? ImagePath { get; set; }

        public bool isActive { get; set; }
    }
}
