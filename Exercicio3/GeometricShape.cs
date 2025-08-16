using System;

namespace Exercicio3
{
    /// <summary>
    /// Classe GeometricShape para calcular volumes de diferentes formas geométricas
    /// </summary>
    public class GeometricShape
    {
        // Membros de dados
        public double Comprimento { get; set; }
        public double Largura { get; set; }
        public double Altura { get; set; }
        public double Raio { get; set; }

        // Construtor padrão
        public GeometricShape()
        {
            Comprimento = 0;
            Largura = 0;
            Altura = 0;
            Raio = 0;
        }

        // Construtor para cubo
        public GeometricShape(double lado)
        {
            Comprimento = lado;
            Largura = lado;
            Altura = lado;
            Raio = 0;
        }

        // Construtor para cone
        public GeometricShape(double raio, double altura)
        {
            Comprimento = 0;
            Largura = 0;
            Altura = altura;
            Raio = raio;
        }

        // Construtor completo
        public GeometricShape(double comprimento, double largura, double altura, double raio)
        {
            Comprimento = comprimento;
            Largura = largura;
            Altura = altura;
            Raio = raio;
        }

        // Métodos estáticos para criar formas específicas
        /// <summary>
        /// Cria uma esfera com o raio especificado
        /// </summary>
        /// <param name="raio">Raio da esfera</param>
        /// <returns>Nova instância de GeometricShape configurada para esfera</returns>
        public static GeometricShape CriarEsfera(double raio)
        {
            if (raio <= 0)
                throw new ArgumentException("O raio da esfera deve ser maior que zero.");
            
            return new GeometricShape
            {
                Raio = raio,
                Comprimento = 0,
                Largura = 0,
                Altura = 0
            };
        }

        /// <summary>
        /// Calcula o volume de um cubo
        /// </summary>
        /// <returns>Volume do cubo (lado³)</returns>
        public double CalcularVolumeCubo()
        {
            if (Comprimento <= 0 || Largura <= 0 || Altura <= 0)
                throw new ArgumentException("As dimensões do cubo devem ser maiores que zero.");
            
            return Comprimento * Largura * Altura;
        }

        /// <summary>
        /// Calcula o volume de um cone
        /// </summary>
        /// <returns>Volume do cone (π * raio² * altura / 3)</returns>
        public double CalcularVolumeCone()
        {
            if (Raio <= 0 || Altura <= 0)
                throw new ArgumentException("O raio e altura do cone devem ser maiores que zero.");
            
            return Math.PI * Math.Pow(Raio, 2) * Altura / 3.0;
        }

        /// <summary>
        /// Calcula o volume de uma esfera
        /// </summary>
        /// <returns>Volume da esfera (4/3 * π * raio³)</returns>
        public double CalcularVolumeEsfera()
        {
            if (Raio <= 0)
                throw new ArgumentException("O raio da esfera deve ser maior que zero.");
            
            return 4.0 / 3.0 * Math.PI * Math.Pow(Raio, 3);
        }

        /// <summary>
        /// Retorna uma representação em string da forma
        /// </summary>
        /// <returns>String com as dimensões da forma</returns>
        public override string ToString()
        {
            return $"GeometricShape [Comprimento: {Comprimento}, Largura: {Largura}, Altura: {Altura}, Raio: {Raio}]";
        }
    }
}
