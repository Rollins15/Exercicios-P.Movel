using System;

internal enum MovementState { SemMovimento, EmMovimento }
internal enum ProximityState { Livre, AproxObjecto }
internal enum ElbowState { Repouso, Contraido }
internal enum HandState { Repouso, EmAtividade, Ocupado }

internal sealed class Drone
{
    // Configuração
    public const double AlturaMinima = 0.5; // m
    public const double AlturaMaxima = 25.0; // m
    public const double PassoAltura = 0.5; // m
    public const int PassoDirecao = 5; // graus
    public const double VelocidadeMinima = 0.0; // m/s
    public const double VelocidadeMaxima = 15.0; // m/s
    public const double PassoVelocidade = 0.5; // m/s

    // Estado de voo
    public double AlturaAtual { get; private set; } = 0.5;
    public int DirecaoGraus { get; private set; } = 0; // 0 = norte
    public double VelocidadeAtual { get; private set; } = 0.0;
    public MovementState Movimento => VelocidadeAtual > 0 ? MovementState.EmMovimento : MovementState.SemMovimento;
    public ProximityState Proximidade { get; private set; } = ProximityState.Livre;

    // Braços
    public Arm BracoEsquerdo { get; } = new Arm("Esquerdo");
    public Arm BracoDireito { get; } = new Arm("Direito");

    // Regras utilitárias
    private static int NormalizeAngle(int graus)
    {
        int mod = graus % 360;
        return mod < 0 ? mod + 360 : mod;
    }

    private void EnsureLivre()
    {
        if (Proximidade == ProximityState.AproxObjecto)
        {
            throw new InvalidOperationException("Operação bloqueada: drone em aproximação de objeto.");
        }
    }

    private void EnsureParado()
    {
        if (Movimento != MovementState.SemMovimento)
        {
            throw new InvalidOperationException("Operação requer drone parado (0 m/s).");
        }
    }

    // Altura
    public void DefinirAltura(double novaAltura)
    {
        EnsureLivre();
        if (novaAltura < AlturaMinima || novaAltura > AlturaMaxima)
            throw new ArgumentOutOfRangeException(nameof(novaAltura), $"Altura deve estar entre {AlturaMinima} e {AlturaMaxima} m.");
        AlturaAtual = novaAltura;
    }

    public void SubirPasso()
    {
        EnsureLivre();
        if (AlturaAtual + PassoAltura > AlturaMaxima)
            throw new InvalidOperationException("Altura máxima atingida.");
        AlturaAtual += PassoAltura;
    }

    public void DescerPasso()
    {
        EnsureLivre();
        if (AlturaAtual - PassoAltura < AlturaMinima)
            throw new InvalidOperationException("Altura mínima atingida.");
        AlturaAtual -= PassoAltura;
    }

    // Direção
    public void DefinirDirecao(int graus)
    {
        EnsureLivre();
        if (graus < 0 || graus > 360)
            throw new ArgumentOutOfRangeException(nameof(graus), "Ângulo deve ser entre 0º e 360º.");
        DirecaoGraus = NormalizeAngle(graus);
    }

    public void DireitaPasso()
    {
        EnsureLivre();
        DirecaoGraus = NormalizeAngle(DirecaoGraus + PassoDirecao);
    }

    public void EsquerdaPasso()
    {
        EnsureLivre();
        DirecaoGraus = NormalizeAngle(DirecaoGraus - PassoDirecao);
    }

    // Velocidade
    public void AumentarVelocidade()
    {
        EnsureLivre();
        if (VelocidadeAtual + PassoVelocidade > VelocidadeMaxima)
            throw new InvalidOperationException("Velocidade máxima atingida.");
        VelocidadeAtual += PassoVelocidade;
    }

    public void DiminuirVelocidade()
    {
        EnsureLivre();
        if (VelocidadeAtual - PassoVelocidade < VelocidadeMinima)
            throw new InvalidOperationException("Velocidade mínima atingida.");
        VelocidadeAtual -= PassoVelocidade;
    }

    public void Parar()
    {
        VelocidadeAtual = 0.0;
    }

    // Aproximação
    public void AproximarObjeto()
    {
        EnsureParado();
        if (Proximidade == ProximityState.AproxObjecto)
            throw new InvalidOperationException("Já está próximo de um objeto.");
        Proximidade = ProximityState.AproxObjecto;
    }

    public void AfastarObjeto()
    {
        if (Proximidade == ProximityState.Livre)
            throw new InvalidOperationException("Drone já está livre de objeto.");
        // Ao afastar, braços voltam ao repouso e liberam ocupação
        BracoEsquerdo.ResetarParaLivre();
        BracoDireito.ResetarParaLivre();
        Proximidade = ProximityState.Livre;
    }
}

internal sealed class Arm
{
    public string Nome { get; }
    public ElbowState Cotovelo { get; private set; } = ElbowState.Repouso;
    public int PulsoGraus { get; private set; } = 0; // 0..360
    public HandState EstadoMao { get; private set; } = HandState.Repouso; // Repouso/EmAtividade/Ocupado

    public Arm(string nome)
    {
        Nome = nome;
    }

    public void AtivarMao()
    {
        if (EstadoMao == HandState.Ocupado)
            throw new InvalidOperationException("Mão ocupada. Não pode mudar para Em atividade.");
        EstadoMao = HandState.EmAtividade;
    }

    public void RepousarMao()
    {
        if (EstadoMao == HandState.Ocupado)
            throw new InvalidOperationException("Mão ocupada. Não pode ir para Repouso.");
        EstadoMao = HandState.Repouso;
    }

    public void ContrairCotovelo()
    {
        Cotovelo = ElbowState.Contraido;
    }

    public void RelaxarCotovelo()
    {
        Cotovelo = ElbowState.Repouso;
    }

    public void RotacionarPulsoPositivo()
    {
        PulsoGraus = NormalizeAngle(PulsoGraus + 5);
    }

    public void RotacionarPulsoNegativo()
    {
        PulsoGraus = NormalizeAngle(PulsoGraus - 5);
    }

    public void DefinirPulso(int graus)
    {
        if (graus < 0 || graus > 360)
            throw new ArgumentOutOfRangeException(nameof(graus), "Ângulo deve ser entre 0º e 360º.");
        PulsoGraus = NormalizeAngle(graus);
    }

    // Ferramentas
    public void Pegar()
    {
        if (Cotovelo != ElbowState.Contraido)
            throw new InvalidOperationException("Para 'Pegar' o cotovelo deve estar contraído.");
        if (EstadoMao == HandState.Ocupado)
            throw new InvalidOperationException("Mão já está ocupada.");
        EstadoMao = HandState.Ocupado;
    }

    public void Armazenar()
    {
        if (Cotovelo != ElbowState.Repouso)
            throw new InvalidOperationException("Para 'Armazenar' o cotovelo deve estar em repouso.");
        EstadoMao = HandState.Repouso;
    }

    public void Bater()
    {
        if (Cotovelo != ElbowState.Contraido)
            throw new InvalidOperationException("Para 'Bater' o cotovelo deve estar contraído.");
        if (EstadoMao == HandState.Ocupado)
            throw new InvalidOperationException("Mão ocupada.");
        // ação instantânea, não muda estado persistente
    }

    public void Cortar()
    {
        if (Cotovelo != ElbowState.Contraido)
            throw new InvalidOperationException("Para 'Cortar' o cotovelo deve estar contraído.");
        if (EstadoMao == HandState.Ocupado)
            throw new InvalidOperationException("Mão ocupada.");
        // ação instantânea
    }

    public void Coletar()
    {
        if (Cotovelo != ElbowState.Repouso)
            throw new InvalidOperationException("Para 'Coletar' o cotovelo deve estar em repouso.");
        if (EstadoMao == HandState.Ocupado)
            throw new InvalidOperationException("Mão ocupada.");
        EstadoMao = HandState.Ocupado;
    }

    public void ResetarParaLivre()
    {
        // Ao se afastar do objeto: mão repousa, cotovelo repousa
        EstadoMao = HandState.Repouso;
        Cotovelo = ElbowState.Repouso;
    }

    private static int NormalizeAngle(int graus)
    {
        int mod = graus % 360;
        return mod < 0 ? mod + 360 : mod;
    }
}


