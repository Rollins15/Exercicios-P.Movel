using System;
using System.Windows.Forms;

namespace Exercicio3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcularCubo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtLadoCubo.Text, out double lado))
                {
                    MessageBox.Show("Por favor, insira um valor válido para o lado do cubo.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLadoCubo.Focus();
                    return;
                }

                if (lado <= 0)
                {
                    MessageBox.Show("O lado do cubo deve ser maior que zero.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLadoCubo.Focus();
                    return;
                }

                                       // Criar objeto cubo usando construtor apropriado
                       GeometricShape cubo = new GeometricShape(lado);
                double volume = cubo.CalcularVolumeCubo();

                lblResultadoCubo.Text = $"Volume do Cubo: {volume:F2}";
                lblResultadoCubo.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular volume do cubo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultadoCubo.Text = "Erro no cálculo";
                lblResultadoCubo.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnCalcularCone_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtRaioCone.Text, out double raio))
                {
                    MessageBox.Show("Por favor, insira um valor válido para o raio do cone.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRaioCone.Focus();
                    return;
                }

                if (!double.TryParse(txtAlturaCone.Text, out double altura))
                {
                    MessageBox.Show("Por favor, insira um valor válido para a altura do cone.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAlturaCone.Focus();
                    return;
                }

                if (raio <= 0 || altura <= 0)
                {
                    MessageBox.Show("O raio e altura do cone devem ser maiores que zero.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                                       // Criar objeto cone usando construtor apropriado
                       GeometricShape cone = new GeometricShape(raio, altura);
                double volume = cone.CalcularVolumeCone();

                lblResultadoCone.Text = $"Volume do Cone: {volume:F2}";
                lblResultadoCone.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular volume do cone: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultadoCubo.Text = "Erro no cálculo";
                lblResultadoCubo.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnCalcularEsfera_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtRaioEsfera.Text, out double raio))
                {
                    MessageBox.Show("Por favor, insira um valor válido para o raio da esfera.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRaioEsfera.Focus();
                    return;
                }

                if (raio <= 0)
                {
                    MessageBox.Show("O raio da esfera deve ser maior que zero.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRaioEsfera.Focus();
                    return;
                }

                                                                               // Criar objeto esfera usando método estático
                        GeometricShape esfera = GeometricShape.CriarEsfera(raio);
                double volume = esfera.CalcularVolumeEsfera();

                lblResultadoEsfera.Text = $"Volume da Esfera: {volume:F2}";
                lblResultadoEsfera.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular volume da esfera: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultadoEsfera.Text = "Erro no cálculo";
                lblResultadoEsfera.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar todos os campos
            txtLadoCubo.Clear();
            txtRaioCone.Clear();
            txtAlturaCone.Clear();
            txtRaioEsfera.Clear();
            
            lblResultadoCubo.Text = "";
            lblResultadoCone.Text = "";
            lblResultadoEsfera.Text = "";
            
            txtLadoCubo.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Volta ao menu principal
            this.Close();
        }
    }
}
