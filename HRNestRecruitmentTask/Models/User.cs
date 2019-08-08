using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRNestRecruitmentTask.Models
{
    public class User
    {
        [Key]
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}