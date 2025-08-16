using System;
using System.Windows.Forms;

namespace Exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método AddInts() que soma 5 inteiros lidos dos campos de texto
        /// e retorna o resultado e um indicador de sucesso
        /// </summary>
        /// <param name="numero1">Primeiro número inteiro</param>
        /// <param name="numero2">Segundo número inteiro</param>
        /// <param name="numero3">Terceiro número inteiro</param>
        /// <param name="numero4">Quarto número inteiro</param>
        /// <param name="numero5">Quinto número inteiro</param>
        /// <param name="soma">Parâmetro de saída para a soma</param>
        /// <param name="sucesso">Parâmetro de saída indicando se a operação foi bem-sucedida</param>
        private void AddInts(int numero1, int numero2, int numero3, int numero4, int numero5, out int soma, out bool sucesso)
        {
            try
            {
                // Realiza a soma dos 5 números
                soma = numero1 + numero2 + numero3 + numero4 + numero5;
                sucesso = true;
            }
            catch (OverflowException)
            {
                // Em caso de overflow na soma
                soma = 0;
                sucesso = false;
            }
            catch (Exception)
            {
                // Para qualquer outra exceção
                soma = 0;
                sucesso = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Lê os valores dos campos de texto
                if (!int.TryParse(txtNumero1.Text, out int num1))
                {
                    MessageBox.Show("Por favor, insira um número inteiro válido no campo Número 1.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero1.Focus();
                    return;
                }

                if (!int.TryParse(txtNumero2.Text, out int num2))
                {
                    MessageBox.Show("Por favor, insira um número inteiro válido no campo Número 2.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero2.Focus();
                    return;
                }

                if (!int.TryParse(txtNumero3.Text, out int num3))
                {
                    MessageBox.Show("Por favor, insira um número inteiro válido no campo Número 3.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero3.Focus();
                    return;
                }

                if (!int.TryParse(txtNumero4.Text, out int num4))
                {
                    MessageBox.Show("Por favor, insira um número inteiro válido no campo Número 4.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero4.Focus();
                    return;
                }

                if (!int.TryParse(txtNumero5.Text, out int num5))
                {
                    MessageBox.Show("Por favor, insira um número inteiro válido no campo Número 5.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero5.Focus();
                    return;
                }

                // Chama o método AddInts() com parâmetros de saída
                int resultado;
                bool operacaoSucesso;
                AddInts(num1, num2, num3, num4, num5, out resultado, out operacaoSucesso);

                // Exibe o resultado
                if (operacaoSucesso)
                {
                    lblResultado.Text = $"Resultado da Soma: {resultado}";
                    lblResultado.ForeColor = System.Drawing.Color.Green;
                    lblStatus.Text = "Status: Operação realizada com sucesso!";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblResultado.Text = "Erro na operação";
                    lblResultado.ForeColor = System.Drawing.Color.Red;
                    lblStatus.Text = "Status: Erro na operação de soma";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultado.Text = "Erro inesperado";
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "Status: Erro inesperado";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa todos os campos
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero3.Clear();
            txtNumero4.Clear();
            txtNumero5.Clear();
            lblResultado.Text = "";
            lblStatus.Text = "";
            
            // Foca no primeiro campo
            txtNumero1.Focus();
        }
    }
}
