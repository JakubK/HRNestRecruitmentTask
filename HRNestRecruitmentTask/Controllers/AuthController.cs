using HRNestRecruitmentTask.Helpers;
using HRNestRecruitmentTask.Models;
using HRNestRecruitmentTask.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using HRNestRecruitmentTask.Context;

namespace HRNestRecruitmentTask.Controllers
{
    public class AuthController : Controller
    {
        UserManager<ApplicationUser> UserManager { get; set; }
        public AuthController(UserContext ctx)
        {
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(ctx));
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
                var u = new ApplicationUser() { UserName = register.Email };
                u.Email = register.Email;
                u.UserName = register.Email;
                var result = UserManager.Create(u, register.Password);
                if (result.Succeeded)
                {
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
            AuthenticationManager.SignOut();
            return View();
        }

        public ActionResult Logout()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel login)
        {
            if(ModelState.IsValid)
            {
                var user = UserManager.Find(login.Email, login.Password);
                if(user != null)
                {
                    //Successful login
                    SignIn(user, false);
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Credentials provided by you are invalid");
            }

            return View();
        }

        private void SignIn(ApplicationUser user, bool isPersistent)
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
            var identity = UserManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
            AuthenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = isPersistent }, identity);
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
    }
}