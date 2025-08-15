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
            ImprimirMenuPrincipal();

            int opcao = ConsoleUtils.LerOpcaoNoIntervalo("Escolha uma opção: ", 0, 3);

            if (opcao == 0)
            {
                Console.WriteLine("Saindo...");
                return;
            }

            if (opcao == 1)
            {
                Calculadora.Executar();
            }
            else if (opcao == 2)
            {
                SomaEMedia.Executar();
            }
            else if (opcao == 3)
            {
                DroneController.Executar();
            }
        }
    }

    private static void ImprimirMenuPrincipal()
    {
        Console.WriteLine("Menu Principal");
        Console.WriteLine("====================");
        Console.WriteLine("1 - Calculadora");
        Console.WriteLine("2 - Soma e média de N números");
        Console.WriteLine("3 - Controle de Drone");
        Console.WriteLine("0 - Sair");
        Console.WriteLine();
    }
}


