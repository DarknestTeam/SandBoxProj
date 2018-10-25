using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandBoxMVC.Models
{
    public class Quest
    {
        public int Id { get; set; }
        public int IdChild { get; set; }
        public string NameQuest { get; set; }
        public string Text { get; set; }
        public bool IsDone { get; set; }
        public int Rewand { get; set; }
        public int SaleProcent { get; set; }
    }
}