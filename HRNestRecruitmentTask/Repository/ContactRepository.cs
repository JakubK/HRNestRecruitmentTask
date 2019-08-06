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
        
        public ContactRepository()
        {
           context = new ContactContext();
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
    }
}