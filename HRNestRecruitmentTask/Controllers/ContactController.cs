using HRNestRecruitmentTask.Models;
using HRNestRecruitmentTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRNestRecruitmentTask.Controllers
{
    public class ContactController : Controller
    {
        IRepository<Contact> _repository;
        public ContactController(IRepository<Contact> repo)
        {
            _repository = repo;
        }
        // GET: Contact
        public ActionResult Index()
        {
            return View(_repository.GetAll());
        }

        public ActionResult Delete(string email)
        {
            _repository.Delete(_repository.GetByEmail(email));
            return RedirectToAction("Index");
        }
    }
}