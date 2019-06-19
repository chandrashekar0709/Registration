//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationForm.EntityFramework
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Sp_GetUser_Result
    {
        
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage ="This Field is Required")]
        public string Username { get; set; }
        [Required(ErrorMessage ="This Field is Required ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}