﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_EF.Entidades
{
    public class PessoaJuridica:Usuario
    {
        public string CNPJ { get; set; }
    }
}
