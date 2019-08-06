using HRNestRecruitmentTask.Models;
using HRNestRecruitmentTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRNestRecruitmentTask.Services
{
    public class DatabaseSeeder : IDatabaseSeeder
    {
        IRepository _repository;

        public DatabaseSeeder(IRepository repository)
        {
            _repository = repository;
        }

        public void Seed()
        {
            if (_repository.GetContacts().Count() == 0)
            {
                _repository.AddContacts(new Contact[]
                {
                    new Contact { Email = "A", Name = "John", Surname = "Doe", BirthDate = DateTime.Now },
                    new Contact { Email = "B", Name = "Dohn", Surname = "Boe", BirthDate = DateTime.Now },
                    new Contact { Email = "C", Name = "Tohn", Surname = "Toe", BirthDate = DateTime.Now },
                    new Contact { Email = "D", Name = "Mohn", Surname = "Woe", BirthDate = DateTime.Now }
                });
            }
        }
    }
}