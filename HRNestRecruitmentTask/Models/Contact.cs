﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRNestRecruitmentTask.Models
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Email { get; set; }
  

        public string Name { get; set; }
        public string Surname { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }
    }
}