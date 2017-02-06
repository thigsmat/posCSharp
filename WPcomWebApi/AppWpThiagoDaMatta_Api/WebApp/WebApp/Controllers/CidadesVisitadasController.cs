using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApp.Model;

namespace WebApp.Controllers
{
    public class CidadesVisitadasController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/cidade
        [Route("api/cidade/lista")]
        public IQueryable<CidadesVisitadas> GetCidades()
        {
            return db.CidadesVisitadas;
        }

        // GET: api/cidade/5
        [ResponseType(typeof(CidadesVisitadas))]
        [Route("api/cidade/pesquisa/{id}")]
        public async Task<IHttpActionResult> GetCidadesVisitadas(int id)
        {
            CidadesVisitadas CidadesVisitadas = await db.CidadesVisitadas.FindAsync(id);
            if (CidadesVisitadas == null)
            {
                return NotFound();
            }

            return Ok(CidadesVisitadas);
        }

        // PUT: api/cidade/5
        [ResponseType(typeof(void))]
        [Route("api/cidade/alterar/{id}")]
        public async Task<IHttpActionResult> PutCidadesVisitadas(int id, CidadesVisitadas CidadesVisitadas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != CidadesVisitadas.Id)
            {
                return BadRequest();
            }

            db.Entry(CidadesVisitadas).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CidadesVisitadasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/cidade
        [ResponseType(typeof(CidadesVisitadas))]
        [Route("api/cidade/novo")]
        public async Task<IHttpActionResult> PostCidadesVisitadas(CidadesVisitadas CidadesVisitadas)
        {
            CidadesVisitadas.Id = 0;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CidadesVisitadas.Add(CidadesVisitadas);
            await db.SaveChangesAsync();

            return Ok(CidadesVisitadas);
        }

        // DELETE: api/cidade/5
        [ResponseType(typeof(CidadesVisitadas))]
        [Route("api/cidade/excluir/{id}")]
        public async Task<IHttpActionResult> DeleteCidadesVisitadas(int id)
        {
            CidadesVisitadas CidadesVisitadas = await db.CidadesVisitadas.FindAsync(id);
            if (CidadesVisitadas == null)
            {
                return NotFound();
            }

            db.CidadesVisitadas.Remove(CidadesVisitadas);
            await db.SaveChangesAsync();

            return Ok(CidadesVisitadas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CidadesVisitadasExists(int id)
        {
            return db.CidadesVisitadas.Count(e => e.Id == id) > 0;
        }
    }

}
