using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandBoxMVC.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public int IdMBank { get; set; }
        public float Bill { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public float SumRefill { get; set; }
        public List<Child> Childs { get; set; }
    }
}