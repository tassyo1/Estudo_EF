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
            contexto.Database.CreateIfNotExists();

            Usuario usuario = new Usuario() { Nome = "Tássyo", Senha = "123" };
            contexto.Usuarios.Add(usuario);

            contexto.SaveChanges();
            contexto.Dispose();
        }
    }
}
