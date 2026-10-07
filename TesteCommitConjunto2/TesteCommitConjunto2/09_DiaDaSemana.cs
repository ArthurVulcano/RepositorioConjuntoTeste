using System;

class DiaDaSemana
{
    static void Main()
    {
        Console.WriteLine("=== Conversor de Número para Dia da Semana ===\n");
        
        Console.Write("Informe um número de 1 a 7: ");
        int dia = int.Parse(Console.ReadLine());
        
        Console.WriteLine();
        
        switch (dia)
        {
            case 1:
                Console.WriteLine("Dia 1 = SEGUNDA-FEIRA");
                break;
            case 2:
                Console.WriteLine("Dia 2 = TERÇA-FEIRA");
                break;
            case 3:
                Console.WriteLine("Dia 3 = QUARTA-FEIRA");
                break;
            case 4:
                Console.WriteLine("Dia 4 = QUINTA-FEIRA");
                break;
            case 5:
                Console.WriteLine("Dia 5 = SEXTA-FEIRA");
                break;
            case 6:
                Console.WriteLine("Dia 6 = SÁBADO");
                break;
            case 7:
                Console.WriteLine("Dia 7 = DOMINGO");
                break;
            default:
                Console.WriteLine("Número inválido! Digite um número entre 1 e 7.");
                break;
        }
        
        Console.ReadKey();
    }
}
