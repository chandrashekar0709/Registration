using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please Enter Name e.g. John")]
        [StringLength(30, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Name e.g. Doe")]
        [StringLength(30, MinimumLength = 3)]
        public string LastName { get; set; }

        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [DisplayName(" Username")]
        public string Username { get; set; }

        [Required]
        [DisplayName(" Password")]
        public string Password { get; set; }

        [Required]
        [DisplayName(" ReTypePassword")]
        public string ReTypePassword { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [StringLength(35)]
        public string City { get; set; }

        public string Address { get; set; }

        
    }
}