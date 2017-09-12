using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Funcionario
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public int NroRegist { get; set; }

        public double Salario { get; set; }

        public Funcionario(int reg)
        {
            this.NroRegist = reg;
        }

    }
}
