using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp.Model
{
    public class Contexto : DbContext
    {
        public Contexto() : base("name=Contexto")
        {
        }

        public DbSet<CidadesVisitadas> CidadesVisitadas { get; set; }
        public DbSet<OpiniaoCidades> OpiniaoCidades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}