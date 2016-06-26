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
            PessoaFisica paulo = new PessoaFisica()
            {
                Nome = "Paulo",
                CPF = "123"
            };
            PessoaJuridica caelum = new PessoaJuridica()
            {
                Nome = "DevMedia",
                CNPJ = "5454"

            };
            contexto.Usuarios.Add(paulo);
            contexto.Usuarios.Add(caelum);
            contexto.SaveChanges();
            Console.WriteLine("Usuários Atualizados");
            contexto.Dispose();  
            

            Console.ReadKey();
        }
    }
}
