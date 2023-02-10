using System;
using System.Globalization;
namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, uni1, uni2;
            double valor1, valor2, valortot;

            Console.WriteLine("Código do Produto: ");
            cod1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            uni1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor por unidade: ");
            valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Código do produto: ");
            cod2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            uni2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor por Unidade");
            valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valortot = valor1 * uni1 + valor2 * uni2;

            Console.WriteLine("Total a pagar: " + valortot.ToString("F2", CultureInfo.InvariantCulture));
            



        }
    }
}