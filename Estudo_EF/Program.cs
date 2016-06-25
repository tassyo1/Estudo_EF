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
            Categoria c = new Categoria()
            {
                Nome = "informática"
            };

            Produto p = new Produto()
            {
                Nome = "computador",
                Categoria = c,
                Preco = 1000
            };
            contexto.Categorias.Add(c);
            contexto.Produtos.Add(p);
            contexto.SaveChanges();

            contexto.Dispose();
            Console.WriteLine("Sucesso");

            Console.ReadKey();
        }
    }
}
