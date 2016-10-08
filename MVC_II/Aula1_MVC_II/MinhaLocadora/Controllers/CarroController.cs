using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using MinhaLocadora.Models;

namespace MinhaLocadora.Controllers
{
   // [RoutePrefix("api/carro/")]
    public class CarroController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/Carro
        [Route("api/carro/lista")]
        public IQueryable<CarroModel> GetCarros()
        {
            return db.Carros;
        }

        // GET: api/Carro/5
        [ResponseType(typeof(CarroModel))]
        [Route("api/carro/pesquisa/{id}")]
        public async Task<IHttpActionResult> GetCarroModel(int id)
        {
            CarroModel carroModel = await db.Carros.FindAsync(id);
            if (carroModel == null)
            {
                return NotFound();
            }

            return Ok(carroModel);
        }

        // PUT: api/Carro/5
        [ResponseType(typeof(void))]
        [Route("api/carro/alterar/{id}")]
        public async Task<IHttpActionResult> PutCarroModel(int id, CarroModel carroModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carroModel.Id)
            {
                return BadRequest();
            }

            db.Entry(carroModel).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarroModelExists(id))
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

        // POST: api/Carro
        [ResponseType(typeof(CarroModel))]
        [Route("api/carro/novo")]
        public async Task<IHttpActionResult> PostCarroModel(CarroModel carroModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Carros.Add(carroModel);
            await db.SaveChangesAsync();

            return Ok (carroModel);
        }

        // DELETE: api/Carro/5
        [ResponseType(typeof(CarroModel))]
        [Route("api/carro/excluir/{id}")]
        public async Task<IHttpActionResult> DeleteCarroModel(int id)
        {
            CarroModel carroModel = await db.Carros.FindAsync(id);
            if (carroModel == null)
            {
                return NotFound();
            }

            db.Carros.Remove(carroModel);
            await db.SaveChangesAsync();

            return Ok(carroModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarroModelExists(int id)
        {
            return db.Carros.Count(e => e.Id == id) > 0;
        }
    }
}