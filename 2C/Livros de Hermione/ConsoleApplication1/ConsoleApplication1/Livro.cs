using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Livro
    {
        public string título;
        public int qtdPag, DiasDevol;
        
        double TempoLeituraHoras(int pph)
        {
            return qtdPag / pph;
        }
    }
}
