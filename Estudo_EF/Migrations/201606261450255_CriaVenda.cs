namespace Estudo_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriaVenda : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClienteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuarios", t => t.ClienteID, cascadeDelete: true)
                .Index(t => t.ClienteID);
            
            CreateTable(
                "dbo.Venda_Produtos",
                c => new
                    {
                        VendaID = c.Int(nullable: false),
                        ProdutoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.VendaID, t.ProdutoID })
                .ForeignKey("dbo.Vendas", t => t.VendaID, cascadeDelete: true)
                .ForeignKey("dbo.Produtos", t => t.ProdutoID, cascadeDelete: true)
                .Index(t => t.VendaID)
                .Index(t => t.ProdutoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venda_Produtos", "ProdutoID", "dbo.Produtos");
            DropForeignKey("dbo.Venda_Produtos", "VendaID", "dbo.Vendas");
            DropForeignKey("dbo.Vendas", "ClienteID", "dbo.Usuarios");
            DropIndex("dbo.Venda_Produtos", new[] { "ProdutoID" });
            DropIndex("dbo.Venda_Produtos", new[] { "VendaID" });
            DropIndex("dbo.Vendas", new[] { "ClienteID" });
            DropTable("dbo.Venda_Produtos");
            DropTable("dbo.Vendas");
        }
    }
}
