using System;
using System.Globalization;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r;
            r = new Retangulo();

            Console.WriteLine("Digite os valores do triângulo: \n");

            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nÁrea = {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro = {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}