using PizzaOrderApp.BLL;
using PizzaOrderApp.DAL;
using PizzaOrderApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PizzaOrderApp.Controllers
{
    public class AccountController : Controller
    {


        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(string email, string password, string returnUrl)
        {
            //Validation logic
            //On success redirection Logic
            AccountManager theAccountmanger = new AccountManager();

            bool status = theAccountmanger.Validate(email, password);
            if (status)
            {
                // return RedirectToAction("Index","Home");
                FormsAuthentication.SetAuthCookie(email, false);
                return Redirect(returnUrl ?? Url.Action("Index", "pizza"));
            }
            else
                return View();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}
