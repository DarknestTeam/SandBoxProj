using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandBoxMVC.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime WorkDate { get; set; }
        public int IdSender { get; set; }
        public int IdRecepient { get; set; }
        public float CountMoney { get; set; }
        public DateTime DateOfPay { get; set; }
    }
}