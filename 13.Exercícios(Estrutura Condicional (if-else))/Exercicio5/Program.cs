using System;
using System.Globalization;
namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------MENU------------");
            Console.WriteLine("[1] Cachorro Quente R$ 4.00\n\r" +
                "[2] X-Salada........R$ 4.50\n\r" +
                "[3] X-Bacon.........R$ 5.00\n\r" +
                "[4] Torrada Simples R$ 2.00\n\r" +
                "[5] Refrigerante....R$ 1.50\n\r" +
                "----------------------------");
            Console.WriteLine("Escolha uma opçao do Cardapio: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            int quant = int.Parse(Console.ReadLine());
            double pedido = 0.0;
            if (codigo == 1)
            {
                pedido = 4.0 * (double)quant;
            }
            else if (codigo == 2)
            {
                pedido = 4.5 * quant;
            }
            else if (codigo == 3)
            {
                pedido = 5.0 * quant;
            }
            else if (codigo == 4)
            {
                pedido = 2.0 * quant;
            }
            else if (codigo == 5)
            {
                pedido = 1.5 * quant;
            }
            else {
                Console.WriteLine("Código Invalido!!");
            }
            Console.WriteLine("Total a pagar: R$ " + pedido.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}