using System;
using System.Globalization;
namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, diferenca;

            Console.WriteLine("Digite um valor: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor: ");
            d = int.Parse(Console.ReadLine());

            diferenca = a * b - c * d;

            Console.WriteLine("A diferença foi: " + diferenca);
        }
    }
}
