using System;
using System.Globalization;
namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número do funcionario: ");
            int num_funci = int.Parse(Console.ReadLine());
            Console.WriteLine("Horas trabalhadas: ");
            int num_horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor por horas: ");
            double valor_trab = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = num_horas * valor_trab;

            Console.WriteLine("Número do funcionario: " + num_funci);
            Console.WriteLine("Salario do funcionario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}