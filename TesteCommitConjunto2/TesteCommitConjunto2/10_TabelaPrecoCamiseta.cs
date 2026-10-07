using System;

class TabelaPrecoCamiseta
{
    static void Main()
    {
        Console.WriteLine("=== Tabela de Preço de Camiseta ===\n");
        Console.WriteLine("Tamanhos disponíveis:");
        Console.WriteLine("P - Pequeno");
        Console.WriteLine("M - Médio");
        Console.WriteLine("G - Grande");
        Console.Write("\nEscolha um tamanho (P, M ou G): ");
        
        string tamanho = Console.ReadLine().ToUpper();
        
        Console.WriteLine();
        
        switch (tamanho)
        {
            case "P":
                Console.WriteLine("Tamanho: Pequeno (P)");
                Console.WriteLine("Preço: R$ 29,90");
                break;
            case "M":
                Console.WriteLine("Tamanho: Médio (M)");
                Console.WriteLine("Preço: R$ 34,90");
                break;
            case "G":
                Console.WriteLine("Tamanho: Grande (G)");
                Console.WriteLine("Preço: R$ 39,90");
                break;
            default:
                Console.WriteLine("Tamanho inválido! Escolha P, M ou G.");
                break;
        }
        
        Console.ReadKey();
    }
}
