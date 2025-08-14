using System;

class Ex03VM
{
    public static void Main()
    {
        string[] cidades = { "Vitoria", "Belo Horizonte", "Rio de Janeiro", "Sao Paulo" };
        int[,] distancias =
        {
            { 0, 524, 521, 882 },
            { 524, 0, 434, 586 },
            { 521, 434, 0, 429 },
            { 882, 586, 429, 0 }
        };

        while (true)
        {
            Console.WriteLine("\nCidades:");

            for (int i = 0; i < cidades.Length; i++)
            {
                Console.WriteLine($"{i} - {cidades[i]}");
            }

            // Lê e valida a entrada para a cidade de origem.
            Console.Write("\nCidade de origem (numero) ");
            string? origemInput = Console.ReadLine();
            if (!int.TryParse(origemInput, out int origem))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                continue;
            }

            // Lê e valida a entrada para a cidade de destino.
            Console.Write("Cidade de destino (numero): ");
            string? destinoInput = Console.ReadLine();
            if (!int.TryParse(destinoInput, out int destino))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                continue;
            }
            
            // Verifica se os números estão dentro do intervalo válido
            if (origem < 0 || origem >= cidades.Length || destino < 0 || destino >= cidades.Length)
            {
                 Console.WriteLine("Número de cidade inválido. Por favor, escolha um número da lista.");
                 continue;
            }

            if (origem == destino)
            {
                Console.WriteLine("\norigem e destino iguais.");
                break;
            }

            Console.WriteLine($"\nA distância entre {cidades[origem]} e {cidades[destino]} é {distancias[origem, destino]} km.");
            System.Threading.Thread.Sleep(3000);
        }
    }
}
