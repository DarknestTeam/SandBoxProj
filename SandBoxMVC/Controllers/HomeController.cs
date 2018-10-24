using SandBoxMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SandBoxMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Index(Child model, string returnUrl)
        //{
        //    ApplicationUser user = await UserManager.FindAsync(model.ChildName, model.Password);
        //    if (user == null)
        //    {
        //        ModelState.AddModelError("", "Ты ввел неправильный логин или пароль");
        //    }
        //    ClaimsIdentity claim = await UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
        //    authenticationManager.SignOut();
        //    authenticationManager.SignIn(new AuthenticationProperties
        //    {
        //        IsPersistent = true
        //    }, claim);
        //    if (String.IsNullOrEmpty(returnUrl))
        //        return RedirectToAction("");
        //    return Redirect(returnUrl);
        //}
    }
}