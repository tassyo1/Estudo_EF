using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_EF.Entidades
{
    [Table("Categorias")]
    public class Categoria
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public virtual IList<Produto> Produtos { get; set; }
    }
}
