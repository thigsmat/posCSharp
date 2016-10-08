using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Site1.Models
{
    public class Contexto : DbContext
    {
        public Contexto(){
            //producao
            //Database.SetInitializer<Contexto>(null);
            
            //aula
            Database.SetInitializer<Contexto>(new DropCreateDatabaseIfModelChanges<Contexto>());

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
    }
}