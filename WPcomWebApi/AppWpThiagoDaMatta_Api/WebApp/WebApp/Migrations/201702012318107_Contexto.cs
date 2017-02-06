namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Contexto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CidadesVisitadas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OpiniaoCidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdCidade = c.Int(nullable: false),
                        Opiniao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OpiniaoCidades");
            DropTable("dbo.CidadesVisitadas");
        }
    }
}
