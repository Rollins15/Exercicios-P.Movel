using System;
using System.Windows.Forms;

namespace Exercicio3
{
    public partial class Form3 : Form
    {
        private Veiculo veiculo;

        public Form3()
        {
            InitializeComponent();
            veiculo = new Veiculo();
        }

        private void btnDefinirDestino_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDistancia.Text, out double distancia))
            {
                MessageBox.Show("Insira uma distância válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            veiculo.DefinirDestino(distancia);
            lblStatus.Text = $"Destino definido: {distancia} km";
        }

        private void btnDefinirVelocidade_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtVelocidade.Text, out double velocidade))
            {
                MessageBox.Show("Insira uma velocidade válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            veiculo.DefinirVelocidade(velocidade);
            lblStatus.Text = $"Velocidade definida: {velocidade} km/h";
        }

        private void btnIniciarViagem_Click(object sender, EventArgs e)
        {
            try
            {
                veiculo.IniciarViagem();
                lblStatus.Text = "Viagem iniciada - Motor ligado";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViajar_Click(object sender, EventArgs e)
        {
            try
            {
                veiculo.Viajar();
                lblStatus.Text = $"Distância percorrida: {veiculo.DistanciaPercorrida:F1} km";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            veiculo.Parar();
            lblStatus.Text = "Veículo parado - Motor desligado";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
