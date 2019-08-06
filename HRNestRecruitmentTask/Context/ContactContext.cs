using HRNestRecruitmentTask.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HRNestRecruitmentTask.Context
{
    public class ContactContext : DbContext
    {
        public ContactContext() : base()
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}