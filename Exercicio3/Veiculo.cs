using System;

namespace Exercicio3
{
    public class Veiculo
    {
        public Motor Motor { get; private set; }
        public double Velocidade { get; private set; }
        public double DistanciaDestino { get; private set; }
        public double DistanciaPercorrida { get; private set; }

        public Veiculo()
        {
            Motor = new Motor();
            Velocidade = 0;
            DistanciaDestino = 0;
            DistanciaPercorrida = 0;
        }

        public void DefinirDestino(double distancia)
        {
            DistanciaDestino = distancia;
            DistanciaPercorrida = 0;
        }

        public void DefinirVelocidade(double velocidade)
        {
            Velocidade = velocidade;
        }

        public void IniciarViagem()
        {
            if (DistanciaDestino <= 0)
                throw new InvalidOperationException("Destino não definido!");
            
            Motor.Ligar();
        }

        public void Viajar()
        {
            if (!Motor.Ligado)
                throw new InvalidOperationException("Motor não está ligado!");

            // Calcula a distância restante até o destino
            double distanciaRestante = DistanciaDestino - DistanciaPercorrida;
            
            if (distanciaRestante <= 0)
            {
                throw new InvalidOperationException("Já chegou ao destino!");
            }

            // Move o veículo conforme a velocidade
            if (Velocidade >= distanciaRestante)
            {
                // Chega exatamente ao destino
                DistanciaPercorrida = DistanciaDestino;
                Motor.Desligar(); // Motor desliga automaticamente
            }
            else
            {
                // Continua a viagem
                DistanciaPercorrida += Velocidade;
            }
        }

        public void Parar()
        {
            Motor.Desligar();
        }
    }
}
