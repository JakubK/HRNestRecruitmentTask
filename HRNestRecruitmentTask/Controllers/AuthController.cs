using HRNestRecruitmentTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRNestRecruitmentTask.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel register)
        {
            if(ModelState.IsValid && register.Password == register.PasswordRepeat)
            {
                System.Diagnostics.Debug.WriteLine("Corret reigster");

                return RedirectToAction("Login");
            }

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}