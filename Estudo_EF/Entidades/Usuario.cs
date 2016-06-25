﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_EF.Entidades
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
