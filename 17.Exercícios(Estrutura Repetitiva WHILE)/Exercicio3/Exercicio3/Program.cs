using System;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma das opções a sua preferencia: ");
            Console.WriteLine(" ");
            Console.WriteLine("1.Álcool 2.Gasolina 3.Diesel 4.Fim");
            Console.WriteLine(" ");
            int op = int.Parse(Console.ReadLine());

            int A = 0, G = 0, D = 0;

            while ( op != 4)
            {
                if (op == 1)
                {
                    A++;
                }
                else if (op == 2)
                {
                    G++;
                }
                else if (op == 3)
                {
                    D++;
                }
                else {
                    Console.WriteLine("Codigo Invalido");
                    Console.WriteLine(" ");
                    Console.WriteLine("Digite novamente um codigo valido: ");
                }
                Console.WriteLine("Escolha uma das opções a sua preferencia: ");
                Console.WriteLine(" ");
                Console.WriteLine("1.Álcool 2.Gasolina 3.Diesel 4.Fim");
                Console.WriteLine(" ");
                op = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" ");
            Console.WriteLine("Obrigado");
            Console.WriteLine("Alcool: " + A);
            Console.WriteLine("Gasolina: " + G);
            Console.WriteLine("Dissel: " + D);

        }
    }
}