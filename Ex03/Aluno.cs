using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        public double Media;

        public double MediaFinal()
        {
            double media = Nota1 + Nota2 + Nota3;

            return media;
        }
    }
}
