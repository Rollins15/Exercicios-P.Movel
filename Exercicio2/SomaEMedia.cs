using System;

internal static class SomaEMedia
{
    public static void Executar()
    {
        Console.Clear();
        Console.WriteLine("Soma e média de N números");
        Console.WriteLine("====================");

        int quantidade = ConsoleUtils.LerOpcaoNoIntervalo("Informe a quantidade de números (3 a 10): ", 3, 10);

        double soma = 0.0;
        for (int indice = 1; indice <= quantidade; indice++)
        {
            double valor = ConsoleUtils.LerNumero($"Digite o {indice}º número: ");
            soma += valor;
        }

        double media = soma / quantidade;

        Console.WriteLine();
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Média: {media}");
        Console.WriteLine();
        Console.Write("Pressione Enter para voltar ao menu principal...");
        Console.ReadLine();
    }
}


