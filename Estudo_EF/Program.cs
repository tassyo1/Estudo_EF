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

            Categoria c = contexto.Categorias.Find(1);
            foreach (var produto in c.Produtos)
            {
                Console.WriteLine(produto.Nome);
            }
            

            contexto.Dispose();
            Console.WriteLine("Sucesso");

            Console.ReadKey();
        }
    }
}
