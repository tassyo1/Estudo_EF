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
            var busca = from p in contexto.Produtos select p;
            if (!string.IsNullOrEmpty(nome))
            {
                busca = from p in busca where p.Nome == nome select p;
            }

            if (precoMinimo > 0)
            {
                busca = from p in busca where p.Preco > precoMinimo select p;
            }

            if (!string.IsNullOrEmpty(nomeCategoria))
            {
                busca = from p in busca where p.Categoria.Nome == nomeCategoria select p;
            }

            return busca.ToList(); 
        }
    }
}
