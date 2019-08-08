using HRNestRecruitmentTask.Models;
using HRNestRecruitmentTask.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HRNestRecruitmentTask.Context
{
    public class ContactContext : DbContext
    {
        public ContactContext() : base("ContactContex")
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}