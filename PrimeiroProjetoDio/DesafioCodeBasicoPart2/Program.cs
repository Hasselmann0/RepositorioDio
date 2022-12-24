using System.IO;
using System.Linq;


int quantidadeDeEntradas = int.Parse(Console.ReadLine());

string[] entrada = new string[2];

for (int contador = 0; contador < quantidadeDeEntradas; contador++)
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