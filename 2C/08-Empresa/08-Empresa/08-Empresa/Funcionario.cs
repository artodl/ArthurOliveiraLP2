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

        private int nroRegist;
        public int NroRegist
        {
            get { return nroRegist; }
        }

        private double salario;
        public double Salario
        {
            get { return salario; }
        }

        public Funcionario(int reg)
        {
            this.nroRegist = reg;
        }

    }
}
