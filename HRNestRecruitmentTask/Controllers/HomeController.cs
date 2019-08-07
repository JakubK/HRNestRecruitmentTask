using HRNestRecruitmentTask.Context;
using HRNestRecruitmentTask.Models;
using HRNestRecruitmentTask.Repository;
using HRNestRecruitmentTask.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRNestRecruitmentTask.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Contact> _repository;
        public HomeController(IRepository<Contact> repository, IDatabaseSeeder seeder)
        {
            _repository = repository;
            seeder.Seed();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View(_repository.GetAll());
        }

        public ActionResult Details(string email)
        {
            return View(_repository.GetByEmail(email));
        }
    }
}