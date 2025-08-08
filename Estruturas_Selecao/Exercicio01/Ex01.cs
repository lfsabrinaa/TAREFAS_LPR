using System;
class Program
{
    static void Main()

    {

        int ni;
        float conta;

        Console.WriteLine("digite um número inteiro:");

        ni = int.Parse(Console.ReadLine());
        conta = ni % 2;
         
        if (conta == 0) {
         Console.WriteLine("O número fornecido é par.");
        }
        else {
         Console.WriteLine("O número fornecido é impar.");
        }

    }

}
