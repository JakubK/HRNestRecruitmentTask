using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRNestRecruitmentTask.Context;
using HRNestRecruitmentTask.Models;
using HRNestRecruitmentTask.Services;

namespace HRNestRecruitmentTask.Repository
{
    public class Repository : IRepository
    {
        ContactContext context;
        
        public Repository()
        {
           context = new ContactContext();
        }

        public void AddContact(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
        }

        public void AddContacts(IEnumerable<Contact> contacts)
        {
            context.Contacts.AddRange(contacts);
            context.SaveChanges();
        }

        public IEnumerable<Contact> GetContacts()
        {
           return context.Contacts;
        }
    }
}