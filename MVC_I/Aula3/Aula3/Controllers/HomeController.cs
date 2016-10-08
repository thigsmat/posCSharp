using Aula3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Aula3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            decimal? valor = 89;
            valor.ToMoeda();

            var db = new Contexto();
         //   var dados = db.Products.Include("Categories").ToList();
            // var sup = db.Suppliers.ToList();
            // var cat = db.Categories.ToList();
            var dados = db.Products.Include(x => x.Categories).ToList();
            return View(dados);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}