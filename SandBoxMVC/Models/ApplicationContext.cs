using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SandBoxMVC.Models
{
    //Добавить ссылку на db
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    { 
        public DbSet<Child> Children { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Bonus> Bonus { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<History> Histories { get; set; }

        public ApplicationContext() : base("DefaultConnection")
        { }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
    }
}