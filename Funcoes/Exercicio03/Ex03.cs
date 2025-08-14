using System;

class Exercicio
{
    static string heroi01Nome = string.Empty, heroi02Nome = string.Empty, heroi03Nome = string.Empty, heroi04Nome = string.Empty, heroi05Nome = string.Empty;
    static string heroi01Poder = string.Empty, heroi02Poder = string.Empty, heroi03Poder = string.Empty, heroi04Poder = string.Empty, heroi05Poder = string.Empty;
    static int heroi01Pts, heroi02Pts, heroi03Pts, heroi04Pts, heroi05Pts;
    static int HeroisCadastrados = 0;
    static string equipe01Nome = string.Empty, equipe02Nome = string.Empty, equipe03Nome = string.Empty;
    static int equipe01Pts, equipe02Pts, equipe03Pts;
    static int HeroisEquipe = 0;
    static bool heroi01Selecionado = false;
    static bool heroi02Selecionado = false;
    static bool heroi03Selecionado = false;
    static bool heroi04Selecionado = false;
    static bool heroi05Selecionado = false;
    

    public static void cadastrarHeroi()
    {
        if (HeroisCadastrados >= 5)
        {
        Console.WriteLine("Limite de herois atingido.");
        return;
        }

        Console.WriteLine("\nCadastro Heroi");
        if (HeroisCadastrados == 0)
        {
        Console.Write("Digite o nome do heroi: "); heroi01Nome = Console.ReadLine() ?? string.Empty;
        Console.Write("Digite o poder: "); heroi01Poder = Console.ReadLine() ?? string.Empty;
        Console.Write("Digite a pontuacao: "); 
        int.TryParse(Console.ReadLine(), out heroi01Pts);
        }
        else if (HeroisCadastrados == 1)
        {
        Console.Write("Digite o nome do heroi: "); heroi02Nome = Console.ReadLine() ?? string.Empty;
        Console.Write("Digite o poder: "); heroi02Poder = Console.ReadLine() ?? string.Empty;
        Console.Write("Digite a pontuacao: "); 
        int.TryParse(Console.ReadLine(), out heroi02Pts);
        }
        else if (HeroisCadastrados == 2)
        {
        Console.Write("Digite o nome do heroi: "); heroi03Nome = Console.ReadLine() ?? string.Empty;
        Console.Write("Digite o poder: "); heroi03Poder = Console.ReadLine() ?? string.Empty;
        Console.Write("Digite a pontuacao: "); 
        int.TryParse(Console.ReadLine(), out heroi03Pts);
        }
        else if (HeroisCadastrados == 3)
        {
        Console.Write("Digite o nome do heroi: "); heroi04Nome = Console.ReadLine() ?? string.Empty;
        Console.Write("Digite o poder: "); heroi04Poder = Console.ReadLine() ?? string.Empty;
        Console.Write("Digite a pontuacao: "); 
        int.TryParse(Console.ReadLine(), out heroi04Pts);
        }
        else if (HeroisCadastrados == 4)
        {
        Console.Write("Digite o nome do heroi: "); heroi05Nome = Console.ReadLine() ?? string.Empty;
        Console.Write("Digite o poder: "); heroi05Poder = Console.ReadLine() ?? string.Empty;
        Console.Write("Digite a pontuacao: "); 
        int.TryParse(Console.ReadLine(), out heroi05Pts);
        }
        HeroisCadastrados++;
        Console.WriteLine("Heroi cadastrado");
    }

    public static void selecionarEquipe()
    {
        if (HeroisCadastrados == 0)
        {
        Console.WriteLine("Nenhum heroi cadastrado");
        return;
        }

        HeroisEquipe = 0;
        heroi01Selecionado = false;
        heroi02Selecionado = false;
        heroi03Selecionado = false;
        heroi04Selecionado = false;
        heroi05Selecionado = false;
        
        Console.WriteLine("\nSelecao de Equipe");
        Console.WriteLine("Herois disponiveis:");
        if (HeroisCadastrados > 0) Console.WriteLine($"1 - {heroi01Nome}");
        if (HeroisCadastrados > 1) Console.WriteLine($"2 - {heroi02Nome}");
        if (HeroisCadastrados > 2) Console.WriteLine($"3 - {heroi03Nome}");
        if (HeroisCadastrados > 3) Console.WriteLine($"4 - {heroi04Nome}");
        if (HeroisCadastrados > 4) Console.WriteLine($"5 - {heroi05Nome}");
        
        int heroiEscolhido;
        while (HeroisEquipe < 3)
        {
            Console.Write($"\nEscolha o {HeroisEquipe + 1}º heroi: ");
            if (!int.TryParse(Console.ReadLine(), out heroiEscolhido))
            {
            Console.WriteLine("Entrada invalida. Digite um numero.");
            continue;
            }

            if (heroiEscolhido == 1 && HeroisCadastrados > 0 && !heroi01Selecionado)
            {
            if(HeroisEquipe == 0) { equipe01Nome = heroi01Nome; equipe01Pts = heroi01Pts; }
            else if(HeroisEquipe == 1) { equipe02Nome = heroi01Nome; equipe02Pts = heroi01Pts; }
            else { equipe03Nome = heroi01Nome; equipe03Pts = heroi01Pts; }
            HeroisEquipe++;
            heroi01Selecionado = true;
            Console.WriteLine($"{heroi01Nome} adicionado a equipe.");
            }
            else if (heroiEscolhido == 2 && HeroisCadastrados > 1 && !heroi02Selecionado)
            {
            if(HeroisEquipe == 0) { equipe01Nome = heroi02Nome; equipe01Pts = heroi02Pts; }
            else if(HeroisEquipe == 1) { equipe02Nome = heroi02Nome; equipe02Pts = heroi02Pts; }
            else { equipe03Nome = heroi02Nome; equipe03Pts = heroi02Pts; }
            HeroisEquipe++;
            heroi02Selecionado = true;
            Console.WriteLine($"{heroi02Nome} adicionado a equipe.");
            }
            else if (heroiEscolhido == 3 && HeroisCadastrados > 2 && !heroi03Selecionado)
            {
            if(HeroisEquipe == 0) { equipe01Nome = heroi03Nome; equipe01Pts = heroi03Pts; }
            else if(HeroisEquipe == 1) { equipe02Nome = heroi03Nome; equipe02Pts = heroi03Pts; }
            else { equipe03Nome = heroi03Nome; equipe03Pts = heroi03Pts; }
            HeroisEquipe++;
            heroi03Selecionado = true;
            Console.WriteLine($"{heroi03Nome} adicionado a equipe.");
            }
            else if (heroiEscolhido == 4 && HeroisCadastrados > 3 && !heroi04Selecionado)
            {
            if(HeroisEquipe == 0) { equipe01Nome = heroi04Nome; equipe01Pts = heroi04Pts; }
            else if(HeroisEquipe == 1) { equipe02Nome = heroi04Nome; equipe02Pts = heroi04Pts; }
            else { equipe03Nome = heroi04Nome; equipe03Pts = heroi04Pts; }
            HeroisEquipe++;
            heroi04Selecionado = true;
            Console.WriteLine($"{heroi04Nome} adicionado a equipe.");
            }
            else if (heroiEscolhido == 5 && HeroisCadastrados > 4 && !heroi05Selecionado)
            {
            if(HeroisEquipe == 0) { equipe01Nome = heroi05Nome; equipe01Pts = heroi05Pts; }
            else if(HeroisEquipe == 1) { equipe02Nome = heroi05Nome; equipe02Pts = heroi05Pts; }
            else { equipe03Nome = heroi05Nome; equipe03Pts = heroi05Pts; }
            HeroisEquipe++;
            heroi05Selecionado = true;
            Console.WriteLine($"{heroi05Nome} adicionado a equipe.");
            }
            else
            {
            Console.WriteLine("Opção inválida, heroi ja selecionado ou heroi nao existe.");
            }
        }
        Console.WriteLine("\nEquipe de 3 herois formada com sucesso!");
    }

    public static int calcularPontuacaoTotal()
    {
        return equipe01Pts + equipe02Pts + equipe03Pts;
    }

    public static void exibirEquipe()
    {
        if (HeroisEquipe < 3)
        {
        Console.WriteLine("A equipe ainda nao foi selecionada.");
        return;
        }

        Console.WriteLine("\nEquipe Atual");
        if (!string.IsNullOrEmpty(equipe01Nome))
        {
        Console.WriteLine($"1 - Nome: {equipe01Nome}, Pontuacao: {equipe01Pts}");
        }
        if (!string.IsNullOrEmpty(equipe02Nome))
        {
        Console.WriteLine($"2 - Nome: {equipe02Nome}, Pontuacao: {equipe02Pts}");
        }
        if (!string.IsNullOrEmpty(equipe03Nome))
        {
        Console.WriteLine($"3 - Nome: {equipe03Nome}, Pontuacao: {equipe03Pts}");
        }
        int PtsTotal = calcularPontuacaoTotal();
        Console.WriteLine($"\nPontuacao total da equipe: {PtsTotal}");
    }

    public static void menuPrincipal()
    {
        string? opcao;
        do
        {
        Console.WriteLine("\nMENU");
        Console.WriteLine("1 - Cadastrar Heroi");
        Console.WriteLine("2 - Selecionar Equipe");
        Console.WriteLine("3 - Exibir Equipe");
        Console.WriteLine("4 - Sair");
        Console.Write("Escolha uma opcao: ");
        opcao = Console.ReadLine();
        
        switch (opcao)
        {
            case "1":
                cadastrarHeroi();
                break;
            case "2":
                selecionarEquipe();
                break;
            case "3":
                exibirEquipe();
                break;
            case "4":
                Console.WriteLine("Saindo do programa. Ate mais!");
                break;
            default:
                Console.WriteLine("Opcao invalida.");
                break;
            }
        } while (opcao != "4");
    }

    public static void Main()
    {
        menuPrincipal();
    }
}
