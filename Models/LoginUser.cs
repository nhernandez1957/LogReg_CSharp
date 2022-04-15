using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogReg.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string LogEmail {get;set;}

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        [DataType(DataType.Password)]
        public string LogPassword {get;set;}
    }
}