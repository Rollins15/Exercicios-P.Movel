namespace Exercicio3
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.btnDefinirDestino = new System.Windows.Forms.Button();
            this.lblVelocidade = new System.Windows.Forms.Label();
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.btnDefinirVelocidade = new System.Windows.Forms.Button();
            this.btnIniciarViagem = new System.Windows.Forms.Button();
            this.btnViajar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(320, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Exercício 3 - Veículo e Motor";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(16, 50);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(58, 13);
            this.lblDistancia.TabIndex = 1;
            this.lblDistancia.Text = "Distância:";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(80, 47);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 2;
            // 
            // btnDefinirDestino
            // 
            this.btnDefinirDestino.Location = new System.Drawing.Point(190, 45);
            this.btnDefinirDestino.Name = "btnDefinirDestino";
            this.btnDefinirDestino.Size = new System.Drawing.Size(100, 23);
            this.btnDefinirDestino.TabIndex = 3;
            this.btnDefinirDestino.Text = "Definir Destino";
            this.btnDefinirDestino.UseVisualStyleBackColor = true;
            this.btnDefinirDestino.Click += new System.EventHandler(this.btnDefinirDestino_Click);
            // 
            // lblVelocidade
            // 
            this.lblVelocidade.AutoSize = true;
            this.lblVelocidade.Location = new System.Drawing.Point(16, 90);
            this.lblVelocidade.Name = "lblVelocidade";
            this.lblVelocidade.Size = new System.Drawing.Size(64, 13);
            this.lblVelocidade.TabIndex = 4;
            this.lblVelocidade.Text = "Velocidade:";
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(80, 87);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidade.TabIndex = 5;
            // 
            // btnDefinirVelocidade
            // 
            this.btnDefinirVelocidade.Location = new System.Drawing.Point(190, 85);
            this.btnDefinirVelocidade.Name = "btnDefinirVelocidade";
            this.btnDefinirVelocidade.Size = new System.Drawing.Size(100, 23);
            this.btnDefinirVelocidade.TabIndex = 6;
            this.btnDefinirVelocidade.Text = "Definir Velocidade";
            this.btnDefinirVelocidade.UseVisualStyleBackColor = true;
            this.btnDefinirVelocidade.Click += new System.EventHandler(this.btnDefinirVelocidade_Click);
            // 
            // btnIniciarViagem
            // 
            this.btnIniciarViagem.Location = new System.Drawing.Point(16, 130);
            this.btnIniciarViagem.Name = "btnIniciarViagem";
            this.btnIniciarViagem.Size = new System.Drawing.Size(100, 23);
            this.btnIniciarViagem.TabIndex = 7;
            this.btnIniciarViagem.Text = "Iniciar Viagem";
            this.btnIniciarViagem.UseVisualStyleBackColor = true;
            this.btnIniciarViagem.Click += new System.EventHandler(this.btnIniciarViagem_Click);
            // 
            // btnViajar
            // 
            this.btnViajar.Location = new System.Drawing.Point(130, 130);
            this.btnViajar.Name = "btnViajar";
            this.btnViajar.Size = new System.Drawing.Size(100, 23);
            this.btnViajar.TabIndex = 8;
            this.btnViajar.Text = "Viajar";
            this.btnViajar.UseVisualStyleBackColor = true;
            this.btnViajar.Click += new System.EventHandler(this.btnViajar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(244, 130);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(100, 23);
            this.btnParar.TabIndex = 9;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(244, 170);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 23);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar ao Menu";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(16, 175);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 210);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnViajar);
            this.Controls.Add(this.btnIniciarViagem);
            this.Controls.Add(this.btnDefinirVelocidade);
            this.Controls.Add(this.txtVelocidade);
            this.Controls.Add(this.lblVelocidade);
            this.Controls.Add(this.btnDefinirDestino);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form3";
            this.Text = "Exercício 3 - Veículo e Motor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Button btnDefinirDestino;
        private System.Windows.Forms.Label lblVelocidade;
        private System.Windows.Forms.TextBox txtVelocidade;
        private System.Windows.Forms.Button btnDefinirVelocidade;
        private System.Windows.Forms.Button btnIniciarViagem;
        private System.Windows.Forms.Button btnViajar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblStatus;
    }
}
