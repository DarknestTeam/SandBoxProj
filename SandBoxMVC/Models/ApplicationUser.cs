    using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandBoxMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
       public virtual Parent  Parent { get; set; }
       //public ApplicationUser() { }
    }
}