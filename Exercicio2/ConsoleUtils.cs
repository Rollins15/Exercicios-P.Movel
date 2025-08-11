using System;
using System.Globalization;

internal static class ConsoleUtils
{
    public static int LerOpcaoNoIntervalo(string prompt, int minimo, int maximo)
    {
        while (true)
        {
            Console.Write(prompt);
            string? entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int valor) && valor >= minimo && valor <= maximo)
            {
                return valor;
            }
            Console.WriteLine($"Opção inválida. Tente novamente ({minimo} a {maximo}).");
        }
    }

    public static double LerNumero(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? entrada = Console.ReadLine();
            if (double.TryParse(entrada, NumberStyles.Number, CultureInfo.CurrentCulture, out double valor))
            {
                return valor;
            }
            Console.WriteLine("Valor inválido. Digite um número válido.");
        }
    }
}


