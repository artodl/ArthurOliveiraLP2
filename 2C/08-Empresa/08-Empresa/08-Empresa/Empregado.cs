using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Empregado : Funcionario
    {
        public Empregado(int n, string d) : base(n)
        {
            dataEntrada = d;
        }

        private string dataEntrada;
        public string DataEntrada
        {
            get { return dataEntrada; }
        }
        public Gerente Gerente { get; set; }
    }

}