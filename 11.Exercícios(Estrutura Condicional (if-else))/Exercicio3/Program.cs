using System;
using System.Globalization;
namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor: ");
            int B = int.Parse(Console.ReadLine());

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("São Multiplos!");
            }
            else
            {
                Console.WriteLine("Não são Multiplos!");
            }
        }
    }
}