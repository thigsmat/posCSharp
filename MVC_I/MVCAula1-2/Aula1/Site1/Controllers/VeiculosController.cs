using Site1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site1.Controllers
{
    public class VeiculosController : Controller
    {
        Contexto Db = new Contexto();

        public ActionResult Index()
        {
            var dados = Db.Veiculos.Include("Marca").OrderBy(x => x.Id);

            return View(dados);
        }

        public ActionResult Criar(int? id)
        {
            var model = new Veiculo();

            if (id != null)
            {
                model = Db.Veiculos.Find(id);
            }

            CarregaCombos();
            return View(model);
        }

        [HttpPost]
        public ActionResult Criar(Veiculo model)
        {
            if (!ModelState.IsValid)
            {
                CarregaCombos();
                return View(model);
            }

            if (model.Id > 0)
            {
                Db.Entry(model).State = EntityState.Modified;
            }
            else
            {
                Db.Veiculos.Add(model);
            }
            Db.SaveChanges();

            return RedirectToAction("Index");
        }

        private void CarregaCombos()
        {
            ViewBag.Marcas = new SelectList(Db.Marcas, "Id", "Nome");
        }

        public ActionResult Excluir(int id)
        {
            var veiculo = Db.Veiculos.Find(id);

            if (veiculo == null)
            {
                return HttpNotFound();
            }

            Db.Veiculos.Remove(veiculo);
            Db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}