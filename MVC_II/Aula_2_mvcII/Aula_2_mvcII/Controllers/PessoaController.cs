using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aula_2_mvcII.Models;

namespace Aula_2_mvcII.Controllers
{
    public class PessoaController : Controller
    {
        private Contexto db = new Contexto();

        public async Task<ActionResult> Index()
        {
            return View(await db.PessoaModels.ToListAsync());
        }

        public async Task<ActionResult> Cadastro(int? id)
        {
		    var pessoaModel = new PessoaModel();
            
            if (id.HasValue && id > 0) 
			{
				pessoaModel = await db.PessoaModels.FindAsync(id);
								if (pessoaModel == null)
				{
					return HttpNotFound();
				}
			}
            return View(pessoaModel);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Cadastro([Bind(Include = "Id,Nome")] PessoaModel pessoaModel)
        {
            if (ModelState.IsValid)
            {
                if (pessoaModel.Id > 0) 
				{
					db.Entry(pessoaModel).State = EntityState.Modified;
				}
				else
				{
					db.PessoaModels.Add(pessoaModel);
				}
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(pessoaModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            try
			{
							var pessoaModel = await db.PessoaModels.FindAsync(id);
							db.PessoaModels.Remove(pessoaModel);
							await db.SaveChangesAsync();
							return Json(new {excluiu = true});
			}
			catch (Exception ex)
			{
				return Json(new {excluiu = false, msg = ex.Message});
			}
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
