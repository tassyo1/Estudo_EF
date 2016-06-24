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
            /* Usuario usuario = new Usuario() { Nome = "Neuber", Senha = "654" };

             UsuarioDAO dao = new UsuarioDAO();
             dao.Adiciona(usuario);*/

            UsuarioDAO dao = new UsuarioDAO();
            foreach (var usuario in dao.ListaUsuario())
            {
                Console.WriteLine(usuario.Nome);
            }

            Console.ReadKey();
        }
    }
}
