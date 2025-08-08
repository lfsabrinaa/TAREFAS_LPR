using System;

class Program
{
    static void Main()
    {
        int numero = int.Parse(Console.ReadLine());
        int conta = numero * numero;
        int soma = 0;
        Console.Write("digite um numero inteiro: ");

        while (conta > 0)
        {
            soma += conta % 10;
            conta /= 10;
        }

        Console.WriteLine("a soma dos dígitos do quadrado é: " + soma);
    }
}