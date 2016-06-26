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
            ProdutoDAO produtoDAO = new ProdutoDAO();
            var resultado = produtoDAO.BuscaPorNomePrecoCategoria("", 50, "informática");

            foreach (var r in resultado)
            {
                Console.WriteLine(r.Nome);
            }
            
            contexto.Dispose();
            Console.WriteLine("Sucesso");

            Console.ReadKey();
        }
    }
}
