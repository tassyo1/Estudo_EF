using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudo_EF.Entidades;

namespace Estudo_EF.DAO
{
    class CategoriaDAO
    {
        private EntidadesContext contexto;
        public CategoriaDAO()
        {
            this.contexto = new EntidadesContext();
        }

        public Categoria buscaPorID(int id)
        {
            return this.contexto.Categorias.Find(id);
        }

        public void Adiciona(Categoria c)
        {
            this.contexto.Categorias.Add(c);
            this.contexto.SaveChanges();
        }

        public void Remover(Categoria c)
        {
            this.contexto.Categorias.Remove(c);
            this.contexto.SaveChanges();
        }


    }
}
