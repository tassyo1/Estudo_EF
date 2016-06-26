namespace Estudo_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InseriFKVendas : DbMigration
    {
        public override void Up()
        {
            AddForeignKey("dbo.Vendas", "ClienteID", "dbo.Usuarios");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendas", "ClienteID", "dbo.Usuarios");
        }
    }
}
