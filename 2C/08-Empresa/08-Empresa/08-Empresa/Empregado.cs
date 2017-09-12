using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Empregado: Funcionario
    {
        public string Gerente { get; set; }
        public string Entrada { get; set; }

        public Empregado() { }

        public Empregado (int r, string n, double sal, string set)
        {
            NroRegist = r;
            Nome = n;
            Salario = sal;
            Gerente = set;
        }
    }
}
