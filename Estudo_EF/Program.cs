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
            foreach (var u in contexto.Usuarios)
            {
                Console.WriteLine(u.ID + "-" + u.Nome);
            }
            
            contexto.Dispose();  
            

            Console.ReadKey();
        }
    }
}
