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
    public class OpinioesCidadeController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/cidade
        [Route("api/opiniao/listaPorCidade/{idCidade}")]
        public IQueryable<OpiniaoCidades> GetOpinioesPorCidades(int idCidade)
        {
            return db.OpiniaoCidades.Where(x=>x.IdCidade==idCidade);
        }

        // GET: api/cidade/5
        [ResponseType(typeof(OpiniaoCidades))]
        [Route("api/opiniao/pesquisa/{id}")]
        public async Task<IHttpActionResult> GetOpiniaoCidades(int id)
        {
            OpiniaoCidades OpiniaoCidades = await db.OpiniaoCidades.FindAsync(id);
            if (OpiniaoCidades == null)
            {
                return NotFound();
            }

            return Ok(OpiniaoCidades);
        }

        // PUT: api/cidade/5
        [ResponseType(typeof(void))]
        [Route("api/opiniao/alterar/{id}")]
        public async Task<IHttpActionResult> PutOpiniaoCidades(int id, OpiniaoCidades OpiniaoCidades)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != OpiniaoCidades.Id)
            {
                return BadRequest();
            }

            db.Entry(OpiniaoCidades).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OpiniaoCidadesExists(id))
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
        [ResponseType(typeof(OpiniaoCidades))]
        [Route("api/opiniao/novo")]
        public async Task<IHttpActionResult> PostOpiniaoCidades(OpiniaoCidades OpiniaoCidades)
        {
            OpiniaoCidades.Id = 0;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OpiniaoCidades.Add(OpiniaoCidades);
            await db.SaveChangesAsync();

            return Ok(OpiniaoCidades);
        }

        // DELETE: api/cidade/5
        [ResponseType(typeof(OpiniaoCidades))]
        [Route("api/opiniao/excluir/{id}")]
        public async Task<IHttpActionResult> DeleteOpiniaoCidades(int id)
        {
            OpiniaoCidades OpiniaoCidades = await db.OpiniaoCidades.FindAsync(id);
            if (OpiniaoCidades == null)
            {
                return NotFound();
            }

            db.OpiniaoCidades.Remove(OpiniaoCidades);
            await db.SaveChangesAsync();

            return Ok(OpiniaoCidades);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OpiniaoCidadesExists(int id)
        {
            return db.CidadesVisitadas.Count(e => e.Id == id) > 0;
        }
    }

}
