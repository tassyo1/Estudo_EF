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

            var busca = from p in contexto.Produtos select p;

            foreach (var p in busca)
            {
                Console.WriteLine(p.Nome);
            }
            contexto.Dispose();
            Console.WriteLine("Sucesso");

            Console.ReadKey();
        }
    }
}
