using System;

class Ex01structs
{
    struct Produto
    {
        public string nome;
        public int codigo;
        public float preco;
        public int quantidade;
    }

    public static void Main()
    {
        Produto[] produtos = new Produto[3];
        float vestoque = 0;

        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"\nProduto {i + 1}:");

            Console.Write("Nome: ");
            string? nomeInput = Console.ReadLine();
            produtos[i].nome = nomeInput ?? string.Empty;

            Console.Write("Codigo: ");
            string? codigoInput = Console.ReadLine();
            if (int.TryParse(codigoInput, out int codigo))
            {
                produtos[i].codigo = codigo;
            }

            Console.Write("Preco: ");
            string? precoInput = Console.ReadLine();
            if (float.TryParse(precoInput, out float preco))
            {
                produtos[i].preco = preco;
            }

            Console.Write("Quantidade: ");
            string? quantidadeInput = Console.ReadLine();
            if (int.TryParse(quantidadeInput, out int quantidade))
            {
                produtos[i].quantidade = quantidade;
            }

            vestoque += produtos[i].preco * produtos[i].quantidade;
        }

        Console.WriteLine($"\nValor total em estoque: R$ {vestoque:F2}");
    }
}
