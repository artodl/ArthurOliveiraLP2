﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Gerente: Funcionario
    {
        public Gerente(int r, int s) : base(r)
        {
            Setor = r;
        }
        public int Setor { get; set; }
        public string Bonus { get; set; }
    }
}
