using System.IO;
using System.Linq;
using System;


class Program
{
    static void Main(string[] args)
    {
        int quantidadeDeEntradas = int.Parse(Console.ReadLine());
        string[] entrada = new string[2];

        for (int i = 0; i < quantidadeDeEntradas; ++i)
        {
            entrada = Console.ReadLine().Split(" ");

            string primeiraEntrada = entrada[0];
            string segundaEntrada = entrada[1];
            if (segundaEntrada.Length > primeiraEntrada.Length)
                Console.WriteLine("nao encaixa");
            else if (primeiraEntrada.EndsWith(segundaEntrada))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");
        }
    }
}