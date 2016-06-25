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

            var busca = from p in contexto.Produtos
                        where p.Categoria.Nome =="roupas" && p.Preco > 50
                        orderby p.Nome select p;
            IList<Produto> lista = busca.ToList();
            foreach (var p in lista)
            {
                Console.WriteLine(p.Nome);
            }
            contexto.Dispose();
            Console.WriteLine("Sucesso");

            Console.ReadKey();
        }
    }
}
