using Estudo_EF.DAO;
using Estudo_EF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_EF
{
    class Program
    {
        static void Main(string[] args)
        {

            EntidadesContext contexto = new EntidadesContext();

            decimal precoMinimo = 200;

            var busca = from c in contexto.Categorias
                        select new ProdutosPorCategoria { Categoria = c, NumeroDeProdutos= c.Produtos.Count };

            IList<ProdutosPorCategoria> resultado = busca.ToList();
            foreach (var r in resultado)
            {
                Console.WriteLine(r.Categoria.Nome+" - "+r.NumeroDeProdutos);
            }
            contexto.Dispose();
            Console.WriteLine("Sucesso");

            Console.ReadKey();
        }
    }
}
