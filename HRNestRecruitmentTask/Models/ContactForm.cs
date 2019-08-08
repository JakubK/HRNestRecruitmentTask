using System;
using System.ComponentModel.DataAnnotations;

namespace HRNestRecruitmentTask.Models
{
    public class ContactForm
    {
        [EmailAddress]
        public string Email { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }
    }
}