using System;
using System.Collections.Generic;
using System.Linq;

class Ex01LD
{
    public static void Main()
    {
        List<string> nomes = new List<string>();

        Console.Write("quantos nomes quer adicionar a lista? ");
        int quantidade = 0;
        string? quantidadeInput = Console.ReadLine();
        if (!int.TryParse(quantidadeInput, out quantidade))
        {
            Console.WriteLine("Entrada inválida. A quantidade deve ser um número inteiro.");
            return;
        }

        Console.WriteLine("quais são os nomes? ");
        for (int i = 0; i < quantidade; i++)
        {
            string? nome = Console.ReadLine();
            if (!string.IsNullOrEmpty(nome))
            {
                nomes.Add(nome);
            }
        }

        var ordem = nomes.OrderBy(n => n.Length).ToList();

        Dictionary<int, Queue<string>> grupos = new Dictionary<int, Queue<string>>();
        foreach (var nome in ordem)
        {
            int tamanho = nome.Length;
            if (!grupos.ContainsKey(tamanho))
                grupos[tamanho] = new Queue<string>();

            grupos[tamanho].Enqueue(nome);
        }

        Console.WriteLine("\nlista de nomes:");
        bool existenome = true;
        while (existenome)
        {
            existenome = false;
            foreach (var tamanho in grupos.Keys.OrderBy(t => t))
            {
                if (grupos[tamanho].Count > 0)
                {
                    Console.Write(grupos[tamanho].Dequeue() + " ");
                    existenome = true;
                }
            }
        Console.WriteLine();
        }

    }
}
