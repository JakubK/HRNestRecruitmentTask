using HRNestRecruitmentTask.Models;
using HRNestRecruitmentTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRNestRecruitmentTask.Controllers
{
    [Authorize]
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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ContactForm form)
        {
            if(ModelState.IsValid)
            {
                var contact = new Contact();

                var emailRecord = _repository.GetAll().FirstOrDefault(x => x.Email == form.Email);

                if(emailRecord != null)
                {
                    ModelState.AddModelError("", "The email is already taken");
                    return View();
                }

                contact.Email = form.Email;
                contact.BirthDate = form.BirthDate;
                contact.Name = form.Name;
                contact.Surname = form.Surname;
                contact.PhoneNumber = form.PhoneNumber;

                _repository.Add(contact);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            _repository.Delete(_repository.Get(id));
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(_repository.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(Contact data)
        {
            if (ModelState.IsValid)
            {
                var record = _repository.Get(data.ID);

                var emailRecord = _repository.GetAll().FirstOrDefault(x => x.Email == data.Email);
                if(emailRecord != null && emailRecord.ID != record.ID)
                {
                    ModelState.AddModelError("", "The email is already taken");
                    return View();
                }

                if (record.ID == data.ID)
                {
                    _repository.Update(data);
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}