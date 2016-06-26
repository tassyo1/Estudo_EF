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
            Produto p1 =contexto.Produtos.Find(1);
            Produto p2 = contexto.Produtos.Find(2);

            Usuario cliente = contexto.Usuarios.Find(3);

            Venda venda = new Venda();
            venda.Cliente = cliente;
            venda.Produtos.Add(p1);
            venda.Produtos.Add(p2);

            contexto.Vendas.Add(venda);
            contexto.SaveChanges();

            Console.WriteLine("Venda adicionada");
            contexto.Dispose();
            

            Console.ReadKey();
        }
    }
}
