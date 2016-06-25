namespace Estudo_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Contexto : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Produtoes", newName: "Produtos");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Produtos", newName: "Produtoes");
        }
    }
}
