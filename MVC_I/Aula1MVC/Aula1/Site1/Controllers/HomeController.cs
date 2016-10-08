using Site1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new Contexto();
            var carro = new Veiculo() {
                Ano = 2013,
                Marca = new Marca()
                {
                    Nome = "VW",
                    Pais = "Alemanha"
                },
                Modelo = "Fusca", 
                Preco = 90560.56M
            };

            db.Veiculos.Add(carro);
            db.SaveChanges();

            var dados = db.Veiculos.Include("Marca").
                Where(x => x.Ano > 2000).OrderBy(x=>x.Id);

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