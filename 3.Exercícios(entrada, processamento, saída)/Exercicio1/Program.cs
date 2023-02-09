using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine($"A soma entre os valores {n1} e {n2} é: {soma}");
        }
    }
}