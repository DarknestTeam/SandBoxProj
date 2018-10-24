using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandBoxMVC.Models
{
    //Добавить ссылку на db
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("") { }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
    }
}