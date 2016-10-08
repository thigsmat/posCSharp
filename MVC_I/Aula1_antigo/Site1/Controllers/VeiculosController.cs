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
        //
        // GET: /Veiculos/
        public ActionResult Index()
        {
            //var dados = Db.Veiculos.Where(x => x.Ano > 2012).OrderBy(x => x.Id);
            return View(Db.Veiculos);
        }

        public ActionResult Criar(int? id)
        {
            var model = new Veiculo();

            if (id != null)
            {
                model = Db.Veiculos.Find(id);
            }

            CarregarCombos();
            return View(model);
        }

        private void CarregarCombos()
        {
            ViewBag.Marcas = new SelectList(Db.Marcas, "Id", "Nome");
        }

        [HttpPost]
        public ActionResult Criar(Veiculo model)
        {
            if (!ModelState.IsValid)
            {
                CarregarCombos();
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

        public ActionResult Editar(Veiculo model)
        {
            CarregarCombos();

            return View(model);
        }

        public ActionResult Excluir(int id)
        {
            var veiculo = Db.Veiculos.Find(id);
            if (veiculo == null)
                return HttpNotFound();

            Db.Veiculos.Remove(veiculo);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}