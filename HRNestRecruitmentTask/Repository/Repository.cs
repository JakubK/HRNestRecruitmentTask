using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRNestRecruitmentTask.Context;
using HRNestRecruitmentTask.Models;

namespace HRNestRecruitmentTask.Repository
{
    public class Repository : IRepository
    {
        ContactContext context;
        
        public Repository()
        {
           context = new ContactContext();
        }

        public IEnumerable<Contact> GetContacts()
        {
           return context.Contacts;
        }
    }
}