using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRNestRecruitmentTask.Context;
using HRNestRecruitmentTask.Models;
using HRNestRecruitmentTask.Services;

namespace HRNestRecruitmentTask.Repository
{
    public class ContactRepository : IRepository<Contact>
    {
        ContactContext context;
        
        public ContactRepository(ContactContext ctx)
        {
            context = ctx;
        }

        public void Add(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
        }

        public void AddRange(IEnumerable<Contact> contacts)
        {
            context.Contacts.AddRange(contacts);
            context.SaveChanges();
        }

        public IEnumerable<Contact> GetAll()
        {
            return context.Contacts;
        }

        public Contact GetByEmail(string email)
        {
            return context.Contacts.First(x => x.Email == email);
        }
    }
}