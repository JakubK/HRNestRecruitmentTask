using HRNestRecruitmentTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRNestRecruitmentTask.Repository
{
    public interface IRepository
    {
        IEnumerable<Contact> GetContacts();
    }
}
