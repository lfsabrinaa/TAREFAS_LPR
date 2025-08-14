using System;

class Exercicio03
{
    public static void Main()
    {

        Console.WriteLine("Escolha entre uma das categorias de personagens abaixo:");
        Console.WriteLine("1-Guerreira 2-Mago 3-Arqueira");
 
        if (int.TryParse(Console.ReadLine(), out int escolha))
        {
            if (escolha == 1)
            {
                Console.WriteLine("Suas habilidades especiais são: Ataque Pesado, Defesa Total");
            }
            else if (escolha == 2)
            {
                Console.WriteLine("Suas habilidades especiais são: Bola de Fogo, Escudo de Gelo");
            }
            else if (escolha == 3)
            {
                Console.WriteLine("Suas habilidades especiais são: Flecha Precisa, Disparo Triplo");
            }
            else
            {
                Console.WriteLine("Escolha um número válido.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}