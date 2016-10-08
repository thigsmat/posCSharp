using Site1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site1.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(int? id, int? page)
        {
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

            Db.Veiculos.Add(carro);
            Db.SaveChanges();

            var dados = Db.Veiculos.Include("Marca").
                Where(x => x.Ano > 2000).OrderBy(x=>x.Id);

            return View(dados);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            var dados = Usuarios.OrderBy(x => x);

            return View(dados);
        }
    }
}