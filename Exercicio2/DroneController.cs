using System;
using System.Globalization;

internal static class DroneController
{
    public static void Executar()
    {
        var drone = new Drone();

        while (true)
        {
            Console.Clear();
            ImprimirStatus(drone);
            ImprimirMenu();

            int opcao = ConsoleUtils.LerOpcaoNoIntervalo("Escolha: ", 0, 20);
            if (opcao == 0)
            {
                return;
            }

            try
            {
                switch (opcao)
                {
                    // Altura
                    case 1:
                        drone.SubirPasso();
                        break;
                    case 2:
                        drone.DescerPasso();
                        break;
                    case 3:
                    {
                        double h = ConsoleUtils.LerNumero($"Nova altura ({Drone.AlturaMinima}-{Drone.AlturaMaxima} m): ");
                        drone.DefinirAltura(h);
                        break;
                    }

                    // Direção
                    case 4:
                        drone.EsquerdaPasso();
                        break;
                    case 5:
                        drone.DireitaPasso();
                        break;
                    case 6:
                    {
                        int graus = ConsoleUtils.LerOpcaoNoIntervalo("Ângulo (0-360): ", 0, 360);
                        drone.DefinirDirecao(graus);
                        break;
                    }

                    // Velocidade
                    case 7:
                        drone.AumentarVelocidade();
                        break;
                    case 8:
                        drone.DiminuirVelocidade();
                        break;
                    case 9:
                        drone.Parar();
                        break;

                    // Aproximação
                    case 10:
                        drone.Parar();
                        drone.AproximarObjeto();
                        break;
                    case 11:
                        drone.AfastarObjeto();
                        break;

                    // Mão/Atividade
                    case 12:
                        EnsurePodeMexerBracos(drone);
                        drone.BracoEsquerdo.AtivarMao();
                        drone.BracoDireito.AtivarMao();
                        break;
                    case 13:
                        EnsurePodeMexerBracos(drone);
                        drone.BracoEsquerdo.RepousarMao();
                        drone.BracoDireito.RepousarMao();
                        break;

                    // Cotovelos
                    case 14:
                        EnsurePodeMexerBracos(drone);
                        drone.BracoEsquerdo.ContrairCotovelo();
                        drone.BracoDireito.ContrairCotovelo();
                        break;
                    case 15:
                        EnsurePodeMexerBracos(drone);
                        drone.BracoEsquerdo.RelaxarCotovelo();
                        drone.BracoDireito.RelaxarCotovelo();
                        break;

                    // Pulso
                    case 16:
                        EnsurePodeMexerBracos(drone);
                        drone.BracoEsquerdo.RotacionarPulsoNegativo();
                        drone.BracoDireito.RotacionarPulsoNegativo();
                        break;
                    case 17:
                        EnsurePodeMexerBracos(drone);
                        drone.BracoEsquerdo.RotacionarPulsoPositivo();
                        drone.BracoDireito.RotacionarPulsoPositivo();
                        break;
                    case 18:
                        EnsurePodeMexerBracos(drone);
                        int pulso = ConsoleUtils.LerOpcaoNoIntervalo("Pulso (0-360): ", 0, 360);
                        drone.BracoEsquerdo.DefinirPulso(pulso);
                        drone.BracoDireito.DefinirPulso(pulso);
                        break;

                    // Ferramentas
                    case 19:
                        EnsurePodeMexerBracos(drone);
                        drone.BracoEsquerdo.Pegar();
                        drone.BracoDireito.Pegar();
                        break;
                    case 20:
                        EnsurePodeMexerBracos(drone);
                        drone.BracoEsquerdo.Armazenar();
                        drone.BracoDireito.Armazenar();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                Console.Write("Pressione Enter...");
                Console.ReadLine();
            }
        }
    }

    private static void EnsurePodeMexerBracos(Drone drone)
    {
        if (drone.Proximidade != ProximityState.AproxObjecto)
            throw new InvalidOperationException("Braços só podem ser usados após 'aproximação de objeto'.");
        if (drone.Movimento == MovementState.EmMovimento)
            throw new InvalidOperationException("Para usar braços o drone deve estar 'Sem movimento'.");
    }

    private static void ImprimirStatus(Drone d)
    {
        Console.WriteLine("Status do Drone");
        Console.WriteLine("----------------");
        Console.WriteLine($"Altura: {d.AlturaAtual} m (min {Drone.AlturaMinima}, max {Drone.AlturaMaxima})");
        Console.WriteLine($"Direção: {d.DirecaoGraus}º");
        Console.WriteLine($"Velocidade: {d.VelocidadeAtual} m/s (min {Drone.VelocidadeMinima}, max {Drone.VelocidadeMaxima})");
        Console.WriteLine($"Movimento: {d.Movimento}");
        Console.WriteLine($"Proximidade: {(d.Proximidade == ProximityState.AproxObjecto ? "Próximo de objeto" : "Livre")}");
        Console.WriteLine();
        Console.WriteLine($"Braço Esq.: Cotovelo {d.BracoEsquerdo.Cotovelo}, Pulso {d.BracoEsquerdo.PulsoGraus}º, Mão {d.BracoEsquerdo.EstadoMao}");
        Console.WriteLine($"Braço Dir.: Cotovelo {d.BracoDireito.Cotovelo}, Pulso {d.BracoDireito.PulsoGraus}º, Mão {d.BracoDireito.EstadoMao}");
        Console.WriteLine();
    }

    private static void ImprimirMenu()
    {
        Console.WriteLine("Menu Drone");
        Console.WriteLine("==========");
        Console.WriteLine("1  - Subir 0,5 m");
        Console.WriteLine("2  - Descer 0,5 m");
        Console.WriteLine("3  - Definir altura específica");
        Console.WriteLine("4  - Girar 5º à esquerda");
        Console.WriteLine("5  - Girar 5º à direita");
        Console.WriteLine("6  - Definir direção (0-360º)");
        Console.WriteLine("7  - Aumentar velocidade em 0,5 m/s");
        Console.WriteLine("8  - Diminuir velocidade em 0,5 m/s");
        Console.WriteLine("9  - Parar (0 m/s)");
        Console.WriteLine("10 - Aproximar objeto (requer parado)");
        Console.WriteLine("11 - Afastar objeto");
        Console.WriteLine("12 - Ativar mãos (Em atividade)");
        Console.WriteLine("13 - Colocar mãos em repouso");
        Console.WriteLine("14 - Contrair cotovelos");
        Console.WriteLine("15 - Relaxar cotovelos");
        Console.WriteLine("16 - Rotação negativa do pulso (-5º)");
        Console.WriteLine("17 - Rotação positiva do pulso (+5º)");
        Console.WriteLine("18 - Definir ângulo do pulso (0-360º)");
        Console.WriteLine("19 - Ferramenta: Pegar (ambos)");
        Console.WriteLine("20 - Ferramenta: Armazenar (ambos)");
        Console.WriteLine("0  - Voltar");
        Console.WriteLine();
    }
}


