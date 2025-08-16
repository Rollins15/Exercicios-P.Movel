using System;

namespace Exercicio3
{
    public class Motor
    {
        public bool Ligado { get; private set; }

        public void Ligar()
        {
            Ligado = true;
        }

        public void Desligar()
        {
            Ligado = false;
        }
    }
}
