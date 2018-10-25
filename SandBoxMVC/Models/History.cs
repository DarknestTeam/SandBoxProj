using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SandBoxMVC.Models
{
    public class History
    {   [Key]
        public int StatisticsId { get; set; }
        public int ParentId { get; set; }
        public int ChildId { get; set; }
        public int DepositId { get; set; }
        public float Amount { get; set; }
        public DateTime DateOfDeposit { get; set; }
    }
}