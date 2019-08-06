using HRNestRecruitmentTask.Context;
using HRNestRecruitmentTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRNestRecruitmentTask.Repository
{
    public class UserRepository : IRepository<User>
    {
        ContactContext context;
        public UserRepository(ContactContext ctx)
        {
            context = ctx;
        }

        public void Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void AddRange(IEnumerable<User> users)
        {
            context.Users.AddRange(users);
            context.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            return context.Users;
        }
    }
}