using System;
using System.Globalization;
namespace Exercicio1 
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Negativo!");
            }
            else {
                Console.WriteLine("Positivo");
            }
        }
    }
}