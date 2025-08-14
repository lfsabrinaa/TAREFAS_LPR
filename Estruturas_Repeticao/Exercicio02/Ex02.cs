using System;

class Exercicio02
{
    public static void Main()
    {
        Random NumAleatorio = new Random();
        int numero = NumAleatorio.Next(1, 100);
        int chute = 0, tentativas = 0;

        do
        {
            Console.Write("digite um numero entre 1 e 100: ");
            string? input = Console.ReadLine();
            if (input != null && int.TryParse(input, out int resultadoChute))
            {
                chute = resultadoChute;
            }
            else
            {
                chute = -1; 
                Console.WriteLine("Entrada inválida.");
            }
            
            tentativas = tentativas + 1;

            if (chute > numero)
            {
                Console.WriteLine("chutou alto!");
            }
            else if (chute < numero && chute != -1)
            {
                Console.WriteLine("chutou baixo!");
            }
            else if (chute == numero)
            {
                Console.WriteLine("parabens, voce acertou!");
                Console.WriteLine("tentativas: " + tentativas);
            }

        } while (chute != numero);
    }
}
