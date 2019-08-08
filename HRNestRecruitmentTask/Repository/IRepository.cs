﻿using HRNestRecruitmentTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRNestRecruitmentTask.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);

        void Delete(T entity);
        void Update(T data);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
    }
}