namespace Estudo_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriaCategoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Produtos", "CategoriaID", c => c.Int());
            CreateIndex("dbo.Produtos", "CategoriaID");
            AddForeignKey("dbo.Produtos", "CategoriaID", "dbo.Categorias", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtos", "CategoriaID", "dbo.Categorias");
            DropIndex("dbo.Produtos", new[] { "CategoriaID" });
            DropColumn("dbo.Produtos", "CategoriaID");
            DropTable("dbo.Categorias");
        }
    }
}
