using SandBoxMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandBoxMVC.Services
{
    public interface IParentService
    {
        void AddChild(Child child);
        void UpdateAccount();
        IEnumerable<History> GetHistories();
    }
}