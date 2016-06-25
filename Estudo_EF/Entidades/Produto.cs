﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_EF.Entidades
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public virtual Categoria Categoria { get; set; }
        public int? CategoriaID { get; set; }

    }
}
