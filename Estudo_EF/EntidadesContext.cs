using Estudo_EF.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_EF
{
    class EntidadesContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           EntityTypeConfiguration<Categoria> configuracao = modelBuilder.Entity<Categoria>();
            configuracao.HasMany(categoria => categoria.Produtos) //referente a lista de produtos no Model de Categoria
                .WithOptional(produto => produto.Categoria); // referente ao objeto categoria dentro do Model de Produto
        }

    }
}
