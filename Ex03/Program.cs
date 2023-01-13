using System;
using System.Globalization;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.Media = aluno.MediaFinal();

            if(aluno.Media >= 60.00)
            {
                Console.WriteLine($"Nota final = {aluno.Media.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aprovado.");
            }
            else
            {
                Console.WriteLine($"Nota final = {aluno.Media.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Reprovado.");
                Console.WriteLine($"Faltaram {60 - aluno.Media} pontos.");
            }
        }
    }
}