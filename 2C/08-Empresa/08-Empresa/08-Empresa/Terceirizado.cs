using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Terceirizado: Empregado
    {
        public Terceirizado(int n, string d, string g) : base(n, d)
        {
            EmprsMatriz = g;
        }
        public string EmprsMatriz { get; set; }  
    }
}
