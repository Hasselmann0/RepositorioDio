using System;

class DIO
{

    static void Main(string[] args)
    {

        int numeros = int.Parse(Console.ReadLine());
        int produtoDosNumeros = 1, somaDosNumeros = 0;

        while (numeros > 0)
        {
            int resto = numeros % 10;

            // TODO: Crie as outras condições necessárias para a resolução do desafio:

            produtoDosNumeros *= resto;
            somaDosNumeros += resto;
            numeros /= 10;
        }

        Console.WriteLine(produtoDosNumeros - somaDosNumeros);

    }
}