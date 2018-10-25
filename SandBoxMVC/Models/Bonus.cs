using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandBoxMVC.Models
{
    public class Bonus
    {
        public int Id { get; set; }
        public string Url { get; set; }//ссылка на получение приза(Токена)
    }
}