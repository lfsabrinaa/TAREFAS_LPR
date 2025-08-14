using System;

struct Heroi
{
    public string nome;
    public string poder;
    public int pontuacao;
}

class ex03struct
{
    static Heroi[] herois = new Heroi[5];
    static int totalherois = 0;

    static Heroi[] equipe = new Heroi[3];
    static int totalequipe = 0;

    static void cadastrarheroi()
    {
        if (totalherois >= 5)
        {
            Console.WriteLine("você já cadastrou o número máximo de heróis");
            return;
        }

        Heroi novoheroi;
        
        Console.Write("\ndigite o nome do herói: ");
        string? nomeInput = Console.ReadLine();
        novoheroi.nome = nomeInput ?? string.Empty;
        
        Console.Write("digite o poder do herói: ");
        string? poderInput = Console.ReadLine();
        novoheroi.poder = poderInput ?? string.Empty;
        
        Console.Write("digite a pontuação do herói: ");
        string? pontuacaoInput = Console.ReadLine();
        if (int.TryParse(pontuacaoInput, out int pontuacao))
        {
            novoheroi.pontuacao = pontuacao;
        }
        else
        {
            Console.WriteLine("Pontuação inválida, herói não cadastrado.");
            return;
        }

        herois[totalherois] = novoheroi;
        totalherois++;

        Console.WriteLine("herói cadastrado com sucesso!");
    }

    static void selecionarequipe()
    {
        if (totalherois == 0)
        {
            Console.WriteLine("nenhum herói cadastrado.");
            return;
        }

        totalequipe = 0;
        Console.WriteLine("\nseleção de equipe");
        for (int i = 0; i < totalherois; i++)
        {
            Console.WriteLine($"{i + 1} - {herois[i].nome} ({herois[i].poder}) - pontos: {herois[i].pontuacao}");
        }

        while (totalequipe < 3)
        {
            Console.Write($"escolha o {totalequipe + 1}º herói (número): ");
            if (int.TryParse(Console.ReadLine(), out int escolha) &&
                escolha >= 1 && escolha <= totalherois)
            {
                bool jaselecionado = false;
                for (int j = 0; j < totalequipe; j++)
                {
                    if (equipe[j].nome == herois[escolha - 1].nome)
                    {
                        jaselecionado = true;
                        break;
                    }
                }

                if (!jaselecionado)
                {
                    equipe[totalequipe] = herois[escolha - 1];
                    totalequipe++;
                    Console.WriteLine($"{herois[escolha - 1].nome} adicionado à equipe.");
                }
                else
                {
                    Console.WriteLine("esse herói já foi selecionado.");
                }
            }
            else
            {
                Console.WriteLine("opção inválida.");
            }
        }

        Console.WriteLine("\nequipe formada com sucesso!");
    }

    static int calcularpontuacaototal()
    {
        int total = 0;
        for (int i = 0; i < totalequipe; i++)
        {
            total += equipe[i].pontuacao;
        }
        return total;
    }

    static void exibirequipe()
    {
        if (totalequipe < 3)
        {
            Console.WriteLine("a equipe ainda não foi selecionada.");
            return;
        }

        Console.WriteLine("\nequipe atual:");
        for (int i = 0; i < totalequipe; i++)
        {
            Console.WriteLine($"{i + 1} - {equipe[i].nome} ({equipe[i].poder}) - pontos: {equipe[i].pontuacao}");
        }
        Console.WriteLine($"pontuação total da equipe: {calcularpontuacaototal()}");
    }

    static void menuprincipal()
    {
        string? opcao;
        do
        {
            Console.WriteLine("\nmenu");
            Console.WriteLine("1 - cadastrar herói");
            Console.WriteLine("2 - selecionar equipe");
            Console.WriteLine("3 - exibir equipe");
            Console.WriteLine("4 - sair");
            Console.Write("escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    cadastrarheroi();
                    break;
                case "2":
                    selecionarequipe();
                    break;
                case "3":
                    exibirequipe();
                    break;
                case "4":
                    Console.WriteLine("saindo...");
                    break;
                default:
                    Console.WriteLine("opção inválida.");
                    break;
            }
        } while (opcao != "4");
    }

    public static void Main()
    {
        menuprincipal();
    }
}
