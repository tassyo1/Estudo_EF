namespace Estudo_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropFKVendaUsuario : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vendas", "ClienteID", "dbo.Usuarios");
        }
        
        public override void Down()
        {
            
        }
    }
}
