using HRNestRecruitmentTask.Models;
using HRNestRecruitmentTask.Repository;
using System;
using System.Linq;

namespace HRNestRecruitmentTask.Services
{
    public class DatabaseSeeder : IDatabaseSeeder
    {
        IRepository<Contact> _repository;

        public DatabaseSeeder(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public void Seed()
        {
            if (_repository.GetAll().Count() == 0)
            {
                _repository.AddRange(new Contact[]
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