using System;

class Program
{
    static void Main()
    {
        Random NumAleatorio = new Random();
        int numero = NumAleatorio.Next(1, 100); 
        int chute = 0, tentativas = 0;

        do
        {
            Console.Write("digite um numero entre 1 e 100: ");
            chute = int.Parse(Console.ReadLine());
            tentativas = tentativas + 1;

            if (chute > numero)
            {
             Console.WriteLine("chutou alto!");
            }
            if (chute < numero)
            {
             Console.WriteLine("chutou baixo!");
            }
            if (chute == numero)
            {
             Console.WriteLine("parabens, voce acertou!");
             Console.WriteLine("tentativas: " + tentativas);
            }

        } while (chute != numero);
    }
}
