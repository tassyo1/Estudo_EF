using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudo_EF.Entidades;
namespace Estudo_EF.DAO
{
    class ProdutoDAO
    {
        private EntidadesContext contexto;
        public ProdutoDAO()
        {
            this.contexto = new EntidadesContext();
        }

        public void Adiciona(Produto p)
        {
            this.contexto.Produtos.Add(p);
            this.contexto.SaveChanges();
        }

        public void Remove(Produto p)
        {
            this.contexto.Produtos.Remove(p);
            this.contexto.SaveChanges();
        }

        public Produto BuscaPorId(int id)
        {
            return this.contexto.Produtos.Find(id);
        }

        public IList<Produto> listaTodos()
        {
            IList<Produto> lista = new List<Produto>();
            foreach (var p in this.contexto.Produtos)
            {
                lista.Add(p);
            }
            return lista;
        }
        public IList<Produto> BuscaPorNomePrecoCategoria(string nome, decimal precoMinimo,
            string nomeCategoria)
        {
            /*var busca = from p in contexto.Produtos
                        where p.Nome == nome && p.Preco > precoMinimo
                        && p.Categoria.Nome == nomeCategoria
                        select p; */
            var busca = contexto.Produtos.AsQueryable() ;
            if (!string.IsNullOrEmpty(nome))
            {
                busca = busca.Where(p => p.Nome == nome) ;
            }

            if (precoMinimo > 0)
            {
                busca = busca.Where(p => p.Preco > precoMinimo);
            }

            if (!string.IsNullOrEmpty(nomeCategoria))
            {
                busca = busca.Where(p => p.Categoria.Nome == nomeCategoria);
            }

            return busca.ToList(); 
        }
    }
}
