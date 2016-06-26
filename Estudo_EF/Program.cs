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
            PessoaFisica victor = new PessoaFisica()
            {
                Nome = "Victor",
                CPF = "123"

            };

            PessoaJuridica caelum = new PessoaJuridica()
            {
                Nome="Caelum",
                CNPJ="23456"
            };

            contexto.Usuarios.Add(victor);
            contexto.Usuarios.Add(caelum);

            contexto.SaveChanges();
            
            contexto.Dispose();
            

            Console.ReadKey();
        }
    }
}
