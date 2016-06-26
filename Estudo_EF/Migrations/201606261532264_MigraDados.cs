namespace Estudo_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigraDados : DbMigration
    {
        public override void Up()
        {
            Sql("update Usuarios set Discriminator = 'PessoaFisica' where Discriminator=''");
        }
        
        public override void Down()
        {
        }
    }
}
