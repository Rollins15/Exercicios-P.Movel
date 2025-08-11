using System;
using System.Globalization;

internal class Program
{
    private static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.Clear();
            ImprimirMenu();

            int opcao = LerOpcaoMenu();

            if (opcao == 0)
            {
                Console.WriteLine("Saindo...");
                return;
            }

            double primeiroValor = LerNumero("Digite o primeiro valor: ");
            double segundoValor = LerNumero("Digite o segundo valor: ");

            switch (opcao)
            {
                case 1:
                    ExibirResultado(primeiroValor + segundoValor, "Soma");
                    break;
                case 2:
                    ExibirResultado(primeiroValor - segundoValor, "Subtração");
                    break;
                case 3:
                    ExibirResultado(primeiroValor * segundoValor, "Multiplicação");
                    break;
                case 4:
                    if (segundoValor == 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero.");
                    }
                    else
                    {
                        ExibirResultado(primeiroValor / segundoValor, "Divisão");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine();
            Console.Write("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }

    private static void ImprimirMenu()
    {
        Console.WriteLine("Calculadora");
        Console.WriteLine("====================");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("0 - Sair");
        Console.WriteLine();
    }

    private static int LerOpcaoMenu()
    {
        while (true)
        {
            Console.Write("Escolha uma opção: ");
            string? entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int opcao) && opcao is >= 0 and <= 4)
            {
                return opcao;
            }
            Console.WriteLine("Opção inválida. Tente novamente (0 a 4).");
        }
    }

    private static double LerNumero(string prompt)
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

    private static void ExibirResultado(double resultado, string operacao)
    {
        Console.WriteLine($"Resultado da {operacao}: {resultado}");
    }
}


