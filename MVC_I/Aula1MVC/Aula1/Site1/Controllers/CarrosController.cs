using Site1.Models;
using Site1.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site1.Controllers
{
    public class CarrosController : Controller
    {
        Contexto Db = new Contexto();

        public ActionResult Index()
        {
            var dados = Db.Veiculos.Include("Marca").OrderBy(x => x.Id);

            return View(dados);
        }

        public ActionResult Criar(int? id) {
            var model = new Veiculo();

            if (id!=null)
            {
                model = Db.Veiculos.Find(id);
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Criar(Veiculo veiculo) {
            if (!ModelState.IsValid)
            {
                return View(veiculo);
            }

            if (veiculo.Id > 0)
            {
                Db.Entry(veiculo).State = EntityState.Modified;
                Db.Entry(veiculo.Marca).State = EntityState.Modified;
            }
            else
            {
                Db.Veiculos.Add(veiculo);
            }

            Db.SaveChanges();

            return View();
        }
     
        //-----------------------
        public ActionResult Novo(int? id)
        {
            var model = new VeiculoViewModel();

            if (id != null)
            {
                var veiculo = Db.Veiculos.Include(x => x.Marca).FirstOrDefault();
                model.Veiculo = veiculo;
                model.Marca = veiculo.Marca;
            }

            return View(model);
        }
    }
}