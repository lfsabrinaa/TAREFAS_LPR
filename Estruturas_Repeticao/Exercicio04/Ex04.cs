using System;

class Exercicio04
{
    public static void Main()
    {
        Console.Write("digite um numero inteiro: ");
        
        string? input = Console.ReadLine();
        
        if (int.TryParse(input, out int numero))
        {
            int conta = numero * numero;
            int soma = 0;

            while (conta > 0)
            {
                soma += conta % 10;
                conta /= 10;
            }

            Console.WriteLine("a soma dos dígitos do quadrado é: " + soma);
        }
        else
        {
            Console.WriteLine("esse número não é inteiro");
        }
    }
}
