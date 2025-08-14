using System;

class Ex04VM
{
    public static void Main()
    {
        int[,] A = new int[3, 3];
        int[,] B = new int[3, 3];
        int[,] C = new int[3, 3];
        
        Console.WriteLine("Digite os numeros da matriz A: ");
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"A[{i},{j}]: ");
                string? inputA = Console.ReadLine();
                if (int.TryParse(inputA, out int valorA))
                {
                    A[i, j] = valorA;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    // Reinicia a leitura para a mesma posição
                    j--; 
                }
            }
        }
        
        Console.WriteLine("Digite os numeros da matriz B: ");
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"B[{i},{j}]: ");
                string? inputB = Console.ReadLine();
                if (int.TryParse(inputB, out int valorB))
                {
                    B[i, j] = valorB;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    // Reinicia a leitura para a mesma posição
                    j--;
                }
            }
        }
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                C[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }
        
        Console.WriteLine("Resultado: ");
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(C[i, j] + "\t");
            }
            Console.WriteLine();
        }
        
    }
}
