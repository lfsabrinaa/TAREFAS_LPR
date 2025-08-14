using System;

class Exercicio01
{
    public static void Main()
    {
        Console.WriteLine("digite um número inteiro:");

        if (int.TryParse(Console.ReadLine(), out int ni))
        {
            int conta = ni % 2;
          
            if (conta == 0)
            {
               Console.WriteLine("O número fornecido é par.");
            }
            else
            {
               Console.WriteLine("O número fornecido é ímpar.");
            }
        }
        else
        {
           Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }
}