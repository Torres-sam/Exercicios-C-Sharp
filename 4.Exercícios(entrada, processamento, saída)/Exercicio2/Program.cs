using System;
using System.Globalization;
namespace Exercicio2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para o raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159 * Math.Pow(raio, 2.0);
            Console.WriteLine("O valor da area é :" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}