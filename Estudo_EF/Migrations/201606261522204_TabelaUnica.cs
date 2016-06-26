namespace Estudo_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaUnica : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "CPF", c => c.String());
            AddColumn("dbo.Usuarios", "CNPJ", c => c.String());
            AddColumn("dbo.Usuarios", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "Discriminator");
            DropColumn("dbo.Usuarios", "CNPJ");
            DropColumn("dbo.Usuarios", "CPF");
        }
    }
}
