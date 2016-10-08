using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MinhaLocadora.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public dynamic Get()
        {
            var dados = new
            {
                Nome = "Fabrica",
                DataAbertura = DateTime.Now.AddYears(-30),
                Pecas = new [] 
                {
                   new { Nome = "Peca 1" },
                   new { Nome = "Peca 2" },
                   new { Nome = "Peca 3" }
               }
            };
            return dados;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
