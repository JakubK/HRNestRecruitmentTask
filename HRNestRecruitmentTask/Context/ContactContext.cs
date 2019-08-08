using HRNestRecruitmentTask.Models;
using System.Data.Entity;

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