using System;
using System.Globalization;
namespace ExercicioDeFixacao2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double produto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu ultimo nome, idade, altura: ");
            string[] vet = Console.ReadLine().Split();
            string n = vet[0];
            int i = int.Parse(vet[1]);
            double a = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine(" ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine(n);
            Console.WriteLine(i);
            Console.WriteLine(a.ToString("F2"), CultureInfo.InvariantCulture);
            

        }
    }
}