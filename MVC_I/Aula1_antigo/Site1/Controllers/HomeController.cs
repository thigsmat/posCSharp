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
            var carros = new List<Veiculo>();
            var marca = new Marca() { Nome = "VM", Pais = "Alemnha" };
            var marca1 = new Marca() { Nome = "Peugeout", Pais = "França" };
            var marca2 = new Marca() { Nome = "Honda", Pais = "Japão" };
            carros.Add(new Veiculo() { Ano = 2010, Marca = marca, Modelo = "Fusca0",  Preco = 90560.56M });
            carros.Add(new Veiculo() { Ano = 2011, Marca = marca1, Modelo = "206 Feline", Preco = 90570.56M });
            carros.Add(new Veiculo() { Ano = 2012, Marca = marca2, Modelo = "Civic", Preco = 90580.56M });
            carros.Add(new Veiculo() { Ano = 2013, Marca = marca, Modelo = "Saveiro", Preco = 90590.56M });
            carros.Add(new Veiculo() { Ano = 2014, Marca = marca, Modelo = "Gol",  Preco = 90600.56M });

           
            db.Veiculos.AddRange(carros);
            db.SaveChanges();

            // var dados = db.Veiculos.Include("Marca").Where(x => x.Ano > 2012).OrderBy(x => x.Id);
            var dados = db.Veiculos.Where(x => x.Ano > 2012).OrderBy(x => x.Id);
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