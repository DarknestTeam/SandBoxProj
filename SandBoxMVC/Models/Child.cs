using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SandBoxMVC.Models
{
    public class Child
    {
        //public int ChildId { get; set; }
        public int ChildId { get; set; }
        [Required]
        [Display(Name = "Твой логин")]
        public string ChildName { get; set; }
        [Required]
        [Display(Name = "Твой пароль")]
        public string Password { get; set; }
        
        public int Bill { get; set; }
    }
}