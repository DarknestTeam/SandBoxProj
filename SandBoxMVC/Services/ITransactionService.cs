using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandBoxMVC.Services
{
    public interface ITransactionService<T> where T:class
    {
        void Tranfer(T post, T receiv);
    }
}