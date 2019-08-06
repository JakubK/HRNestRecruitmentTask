﻿using HRNestRecruitmentTask.Models;
using HRNestRecruitmentTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRNestRecruitmentTask.Controllers
{
    public class AuthController : Controller
    {
        IRepository<User> _repository;
        public AuthController(IRepository<User> repo)
        {
            _repository = repo;
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel register)
        {
            if(ModelState.IsValid && register.Password == register.PasswordRepeat)
            {
                if (_repository.GetAll().First(x => x.Email == register.Email) == null)
                {
                    _repository.Add(new User
                    {
                        Email = register.Email,
                        Password = register.Password
                    });

                    return RedirectToAction("Login");
                }
                else
                {
                    //Email taken
                    ModelState.AddModelError("", "The email that you passed is already taken");
                }
            }

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}