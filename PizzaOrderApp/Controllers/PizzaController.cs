using PizzaOrderApp.DAL;
using PizzaOrderApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PizzaOrderApp.Controllers
{
    public class PizzaController : Controller
    {
        PizzaDBContext PizzaEntities = new PizzaDBContext();

        // GET: Pizza
        public ActionResult Index()
        {
            List<PizzaModel> allpizza = PizzaEntities.Pizzas.ToList();
            ViewData["pizza"] = allpizza;
            return View();
        }


        public ActionResult Detail(int? id)        // ? is a Nullable syntax
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pizza = PizzaEntities.Pizzas.SingleOrDefault(p => p.Id == id);

            if (pizza == null)
            {
                return HttpNotFound();
            }
            this.ViewData["pizza"] = pizza;
            return View();
        }

        [Authorize]
        [HttpGet]
        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pizza = PizzaEntities.Pizzas.SingleOrDefault(p => p.Id == id);

            if (pizza == null)
            {
                return HttpNotFound();
            }

            return View(pizza);

        }

        [Authorize]
        [HttpPost]
        public ActionResult Update(PizzaModel pizza)
        {
            if (ModelState.IsValid)
            {
                PizzaEntities.Entry(pizza).State = System.Data.Entity.EntityState.Modified;
                PizzaEntities.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pizza);
        }
    }
}