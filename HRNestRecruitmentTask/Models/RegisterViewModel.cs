using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRNestRecruitmentTask.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "This field is required")]
        [EmailAddress(ErrorMessage ="The given string is not a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [RegularExpression("^(?=.*[A-Z].*[A-Z])(?=.*[!@#$&*])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8}$", ErrorMessage = "The password is not strong enough")]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Compare("Password", ErrorMessage = "Given passwords are not the same")]
        public string PasswordRepeat { get; set; }
    }
}