using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApi_III.Models;

namespace WebApi_III.Controllers
{
    public class FuncionarioController : ApiController
    {
        List<Funcionario> lista = new List<Funcionario>() {
            new Funcionario() {Id=1,Nome="Zé 1",DataCadastro=DateTime.Now },
            new Funcionario() {Id=2,Nome="Zé 2",DataCadastro=DateTime.Now },
            new Funcionario() {Id=3,Nome="Zé 3",DataCadastro=DateTime.Now },
            new Funcionario() {Id=4,Nome="Zé 4",DataCadastro=DateTime.Now },
            new Funcionario() {Id=5,Nome="Zé 5",DataCadastro=DateTime.Now }
        };
        
        public List<Funcionario> Get()
        {
            return lista;
        }

        public Funcionario Get(int id)
        {
            return lista.Find(x=>x.Id==id);
        }

        public Funcionario GetByName(string nome)
        {
            return lista.Find(x => x.Nome == nome);
        }

        public bool Post(Funcionario func)
        {
            lista.Add(func);
            return true;
        }
    
        public bool Put(Funcionario func)
        {
            lista.Add(func);
            return true;
        }

        public bool Delete(int id) {
            lista.Remove(lista.Find(x => x.Id == id));
            return true;
        }
    }
}