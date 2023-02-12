using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());
            int tentativa = 1;
            while (senha != 2002 && tentativa < 3)
            {
                tentativa++;
                Console.Write("Senha Invalida ");
                Console.WriteLine("Tentativa (" + tentativa + ")");
                Console.WriteLine("Digite a senha novamente: ");
                senha = int.Parse(Console.ReadLine());

            }

            if (senha == 2002)
            {
                Console.WriteLine("Acesso Permitido");
            }
            else
            {
                Console.WriteLine("Senha Bloqueada, Tente novamente mais tarde");
            }
        }
    }
}