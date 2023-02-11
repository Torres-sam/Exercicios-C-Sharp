using System;
using System.Globalization;
namespace Exercicio2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else {
                Console.WriteLine("Ímpar");
            }
        }
    }
}