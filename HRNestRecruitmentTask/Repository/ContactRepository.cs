using System.Collections.Generic;
using System.Linq;
using HRNestRecruitmentTask.Context;
using HRNestRecruitmentTask.Models;

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

        public void Delete(Contact entity)
        {
            context.Contacts.Remove(entity);
            context.SaveChanges();
        }

        public Contact Get(int id)
        {
            return context.Contacts.First(x => x.ID == id);
        }

        public IEnumerable<Contact> GetAll()
        {
            return context.Contacts;
        }

        public void Update(Contact data)
        {
            var record = Get(data.ID);
            if(record != null)
            {
                record.Email = data.Email;
                record.BirthDate = data.BirthDate;
                record.Name = data.Name;
                record.Surname = data.Surname;
                record.PhoneNumber = data.PhoneNumber;
                context.SaveChanges();
            }
        }
    }
}