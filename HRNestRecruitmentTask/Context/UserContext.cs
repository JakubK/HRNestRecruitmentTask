using HRNestRecruitmentTask.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HRNestRecruitmentTask.Context
{
    public class UserContext : IdentityDbContext<ApplicationUser>
    {
        public UserContext() : base("xsxsxsxs")
        {
            Configuration.ProxyCreationEnabled = false;
        }

    }
}