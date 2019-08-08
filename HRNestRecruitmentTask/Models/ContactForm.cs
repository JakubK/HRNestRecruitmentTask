using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRNestRecruitmentTask.Models
{
    public class ContactForm
    {
        public string Email { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }
    }
}