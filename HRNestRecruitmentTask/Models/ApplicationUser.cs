using Microsoft.AspNet.Identity.EntityFramework;

namespace HRNestRecruitmentTask.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Salt { get; set; }
    }
}