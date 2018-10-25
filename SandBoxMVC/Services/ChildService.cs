using SandBoxMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandBoxMVC.Services
{
    public class ChildService : IChildService
    {
        public void AddAmount(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<History> GetHistories()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Quest> GetQuests(int id)
        {
            throw new NotImplementedException();
        }

        public void Payment(int cardId)
        {
            throw new NotImplementedException();
        }
    }
}