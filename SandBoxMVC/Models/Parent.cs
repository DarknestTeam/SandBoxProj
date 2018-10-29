using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SandBoxMVC.Models
{
    public class Parent
    {

        [Key]
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        public string IdMBank { get; set; }
        public float Bill { get; set; }
        public string Name { get; set; }
        public string Password {get;set;}
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public float SumRefill { get; set; }
       // public List<Child> Childs { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}