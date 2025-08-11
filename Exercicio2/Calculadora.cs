using System;

internal static class Calculadora
{
    public static void Executar()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Calculadora");
            Console.WriteLine("====================");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("0 - Voltar");
            Console.WriteLine();

            int opcao = ConsoleUtils.LerOpcaoNoIntervalo("Escolha uma opção: ", 0, 4);
            if (opcao == 0)
            {
                return;
            }

            double primeiroValor = ConsoleUtils.LerNumero("Digite o primeiro valor: ");
            double segundoValor = ConsoleUtils.LerNumero("Digite o segundo valor: ");

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

    private static void ExibirResultado(double resultado, string operacao)
    {
        Console.WriteLine($"Resultado da {operacao}: {resultado}");
    }
}


