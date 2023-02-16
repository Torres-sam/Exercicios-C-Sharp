using System;
using System.Globalization;
namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hora inicial: ");
            int hora_inicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Hora final: ");
            int hora_final = int.Parse(Console.ReadLine());

            int duracao;

            if (hora_inicial < hora_final)
            {
                duracao = hora_inicial - hora_final;
            }
            else 
            {
                duracao = 24 - hora_inicial + hora_final;
            }
            Console.WriteLine($"A duração do jogo foi de {duracao} hrs");
        }
    }
}
