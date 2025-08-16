using System;
using System.Windows.Forms;

namespace Exercicio3
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            // Abre o Form1 (Exercício 1 - Soma de 5 números)
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            // Abre o Form2 (Exercício 2 - Cálculo de Volumes)
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            // Abre o Form3 (Exercício 3 - Veículo e Motor)
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Fecha a aplicação
            Application.Exit();
        }
    }
}
