namespace Estudo_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UmaTabelaPorClasse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PessoaFisica",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        CPF = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuarios", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.PessoaJuridica",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        CNPJ = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuarios", t => t.ID)
                .Index(t => t.ID);
            
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PessoaJuridica", "ID", "dbo.Usuarios");
            DropForeignKey("dbo.PessoaFisica", "ID", "dbo.Usuarios");
            DropIndex("dbo.PessoaJuridica", new[] { "ID" });
            DropIndex("dbo.PessoaFisica", new[] { "ID" });
            DropTable("dbo.PessoaJuridica");
            DropTable("dbo.PessoaFisica");
        }
    }
}
