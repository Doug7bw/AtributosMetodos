using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            double area = Altura * Largura;

            return area;
        }

        public double Perimetro()
        {
            double perimetro = 2 * (Altura + Largura);

            return perimetro;
        }

        public double Diagonal()
        {
            double diagonal = Math.Pow(Altura, 2) + Math.Pow(Largura, 2);

            return diagonal;
        }
    }
}
