using System;
using System.Globalization;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite os dados do funcionário: \n");

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioLiquido = funcionario.SalarioLiquido();

            Console.WriteLine($"\nFuncionário: {funcionario}\n");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(p);

            Console.WriteLine($"\nDados atualizados: {funcionario}");
        }
    }
}