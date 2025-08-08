using System;
class Program

{

    static void Main()

    {

        int personagem;
        int escolha;
        Console.WriteLine("Escolha entre uma das categorias de personagens abaixo:");
        Console.WriteLine("1-Guerreira 2-Mago 3-Arqueira");
        escolha = int.Parse(Console.ReadLine());

        if (escolha == 1) {
         Console.WriteLine("Suas habilidades especiais são: Ataque Pesado, Defesa Total");
        }
        else if (escolha == 2) {
         Console.WriteLine("Suas habilidades especiais são: Bola de Fogo, Escudo de Gelo");
        }
        else if (escolha == 3) {
         Console.WriteLine("Suas habilidades especiais são: Flecha Precisa, Disparo Triplo");
        }
        else {
         Console.WriteLine("Escolha um número válido.");
        }

    }

}
