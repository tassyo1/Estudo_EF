using Estudo_EF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_EF.DAO
{
    public class UsuarioDAO
    {
        private EntidadesContext contexto;
        public UsuarioDAO()
        {
            this.contexto = new EntidadesContext();
        }
        public void Adiciona( Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }

        public Usuario buscaPorId(int id)
        {
            return contexto.Usuarios.Find(id);
        }

        public void Remove(Usuario u)
        {
            contexto.Usuarios.Remove(u);
            contexto.SaveChanges();
        }

        public IList<Usuario> ListaUsuario()
        {
            IList<Usuario> lista = new List<Usuario>();
           foreach(var usuario in contexto.Usuarios)
            {
                lista.Add(usuario);
            }
            return lista;
        }
    }
}
