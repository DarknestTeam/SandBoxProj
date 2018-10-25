
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using SandBoxMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SandBoxMVC.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;
        public HomeController()
        {
           
        }
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        private ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }   
        public ActionResult Index(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(Child model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await UserManager.FindAsync(model.ChildName, model.Password);
                if (user == null)
                {
                    ModelState.AddModelError("", "Ты ввел неправильный логин или пароль");
                }
                else
                {
                    ClaimsIdentity claim = await UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
                    AuthenticationManager.SignOut();
                    AuthenticationManager.SignIn(new AuthenticationProperties
                    {
                        IsPersistent = true
                    }, claim);
                    if (String.IsNullOrEmpty(returnUrl))
                        return RedirectToAction("");
                    return Redirect(returnUrl);
                }
                
            }
            ViewBag.returnUrl = returnUrl;
            return View(model);
        }
        public ActionResult Logout()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult  Account()
        {   
            ViewData["Money"] = CurrentBalanse(Membership.GetUser().ProviderUserKey.ToString());
            return View();
        }

        public  Child  GetChild (string id)
        {
            
            
                 var  child = db.Children.Find(id);
                if ( id != null && child != null)
                {
                    return child;
                }

                return (child =null);

        }
        public int CurrentBalanse(string  id) 
        {
            var  child =GetChild(id);
            if (child != null)
            {
                return child.Bill;
                
            }
            else
            { return 0; }

        }
        public void Replenish(string id, int  money)
        {
            var person = GetChild(id);
            if (person != null)
            {
                person.Bill += money;
                db.SaveChanges();
            }

        }

    }
}