namespace Exercicio3
{
    partial class Form2
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
            this.gbCubo = new System.Windows.Forms.GroupBox();
            this.lblLadoCubo = new System.Windows.Forms.Label();
            this.txtLadoCubo = new System.Windows.Forms.TextBox();
            this.btnCalcularCubo = new System.Windows.Forms.Button();
            this.lblResultadoCubo = new System.Windows.Forms.Label();
            this.gbCone = new System.Windows.Forms.GroupBox();
            this.lblRaioCone = new System.Windows.Forms.Label();
            this.txtRaioCone = new System.Windows.Forms.TextBox();
            this.lblAlturaCone = new System.Windows.Forms.Label();
            this.txtAlturaCone = new System.Windows.Forms.TextBox();
            this.btnCalcularCone = new System.Windows.Forms.Button();
            this.lblResultadoCone = new System.Windows.Forms.Label();
            this.gbEsfera = new System.Windows.Forms.GroupBox();
            this.lblRaioEsfera = new System.Windows.Forms.Label();
            this.txtRaioEsfera = new System.Windows.Forms.TextBox();
            this.btnCalcularEsfera = new System.Windows.Forms.Button();
            this.lblResultadoEsfera = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gbCubo.SuspendLayout();
            this.gbCone.SuspendLayout();
            this.gbEsfera.SuspendLayout();
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
            this.lblTitulo.Text = "Cálculo de Volumes - Exercício 2";
            // 
            // gbCubo
            // 
            this.gbCubo.Controls.Add(this.lblResultadoCubo);
            this.gbCubo.Controls.Add(this.btnCalcularCubo);
            this.gbCubo.Controls.Add(this.txtLadoCubo);
            this.gbCubo.Controls.Add(this.lblLadoCubo);
            this.gbCubo.Location = new System.Drawing.Point(16, 45);
            this.gbCubo.Name = "gbCubo";
            this.gbCubo.Size = new System.Drawing.Size(300, 100);
            this.gbCubo.TabIndex = 1;
            this.gbCubo.TabStop = false;
            this.gbCubo.Text = "Cubo";
            // 
            // lblLadoCubo
            // 
            this.lblLadoCubo.AutoSize = true;
            this.lblLadoCubo.Location = new System.Drawing.Point(6, 25);
            this.lblLadoCubo.Name = "lblLadoCubo";
            this.lblLadoCubo.Size = new System.Drawing.Size(37, 13);
            this.lblLadoCubo.TabIndex = 0;
            this.lblLadoCubo.Text = "Lado:";
            // 
            // txtLadoCubo
            // 
            this.txtLadoCubo.Location = new System.Drawing.Point(49, 22);
            this.txtLadoCubo.Name = "txtLadoCubo";
            this.txtLadoCubo.Size = new System.Drawing.Size(100, 20);
            this.txtLadoCubo.TabIndex = 1;
            // 
            // btnCalcularCubo
            // 
            this.btnCalcularCubo.Location = new System.Drawing.Point(155, 20);
            this.btnCalcularCubo.Name = "btnCalcularCubo";
            this.btnCalcularCubo.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularCubo.TabIndex = 2;
            this.btnCalcularCubo.Text = "Calcular";
            this.btnCalcularCubo.UseVisualStyleBackColor = true;
            this.btnCalcularCubo.Click += new System.EventHandler(this.btnCalcularCubo_Click);
            // 
            // lblResultadoCubo
            // 
            this.lblResultadoCubo.AutoSize = true;
            this.lblResultadoCubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCubo.Location = new System.Drawing.Point(6, 60);
            this.lblResultadoCubo.Name = "lblResultadoCubo";
            this.lblResultadoCubo.Size = new System.Drawing.Size(0, 15);
            this.lblResultadoCubo.TabIndex = 3;
            // 
            // gbCone
            // 
            this.gbCone.Controls.Add(this.lblResultadoCone);
            this.gbCone.Controls.Add(this.btnCalcularCone);
            this.gbCone.Controls.Add(this.txtAlturaCone);
            this.gbCone.Controls.Add(this.lblAlturaCone);
            this.gbCone.Controls.Add(this.txtRaioCone);
            this.gbCone.Controls.Add(this.lblRaioCone);
            this.gbCone.Location = new System.Drawing.Point(16, 155);
            this.gbCone.Name = "gbCone";
            this.gbCone.Size = new System.Drawing.Size(300, 120);
            this.gbCone.TabIndex = 2;
            this.gbCone.TabStop = false;
            this.gbCone.Text = "Cone";
            // 
            // lblRaioCone
            // 
            this.lblRaioCone.AutoSize = true;
            this.lblRaioCone.Location = new System.Drawing.Point(6, 25);
            this.lblRaioCone.Name = "lblRaioCone";
            this.lblRaioCone.Size = new System.Drawing.Size(38, 13);
            this.lblRaioCone.TabIndex = 0;
            this.lblRaioCone.Text = "Raio:";
            // 
            // txtRaioCone
            // 
            this.txtRaioCone.Location = new System.Drawing.Point(49, 22);
            this.txtRaioCone.Name = "txtRaioCone";
            this.txtRaioCone.Size = new System.Drawing.Size(100, 20);
            this.txtRaioCone.TabIndex = 1;
            // 
            // lblAlturaCone
            // 
            this.lblAlturaCone.AutoSize = true;
            this.lblAlturaCone.Location = new System.Drawing.Point(6, 55);
            this.lblAlturaCone.Name = "lblAlturaCone";
            this.lblAlturaCone.Size = new System.Drawing.Size(43, 13);
            this.lblAlturaCone.TabIndex = 2;
            this.lblAlturaCone.Text = "Altura:";
            // 
            // txtAlturaCone
            // 
            this.txtAlturaCone.Location = new System.Drawing.Point(49, 52);
            this.txtAlturaCone.Name = "txtAlturaCone";
            this.txtAlturaCone.Size = new System.Drawing.Size(100, 20);
            this.txtAlturaCone.TabIndex = 3;
            // 
            // btnCalcularCone
            // 
            this.btnCalcularCone.Location = new System.Drawing.Point(155, 52);
            this.btnCalcularCone.Name = "btnCalcularCone";
            this.btnCalcularCone.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularCone.TabIndex = 4;
            this.btnCalcularCone.Text = "Calcular";
            this.btnCalcularCone.UseVisualStyleBackColor = true;
            this.btnCalcularCone.Click += new System.EventHandler(this.btnCalcularCone_Click);
            // 
            // lblResultadoCone
            // 
            this.lblResultadoCone.AutoSize = true;
            this.lblResultadoCone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCone.Location = new System.Drawing.Point(6, 90);
            this.lblResultadoCone.Name = "lblResultadoCone";
            this.lblResultadoCone.Size = new System.Drawing.Size(0, 15);
            this.lblResultadoCone.TabIndex = 5;
            // 
            // gbEsfera
            // 
            this.gbEsfera.Controls.Add(this.lblResultadoEsfera);
            this.gbEsfera.Controls.Add(this.btnCalcularEsfera);
            this.gbEsfera.Controls.Add(this.txtRaioEsfera);
            this.gbEsfera.Controls.Add(this.lblRaioEsfera);
            this.gbEsfera.Location = new System.Drawing.Point(16, 285);
            this.gbEsfera.Name = "gbEsfera";
            this.gbEsfera.Size = new System.Drawing.Size(300, 100);
            this.gbEsfera.TabIndex = 3;
            this.gbEsfera.TabStop = false;
            this.gbEsfera.Text = "Esfera";
            // 
            // lblRaioEsfera
            // 
            this.lblRaioEsfera.AutoSize = true;
            this.lblRaioEsfera.Location = new System.Drawing.Point(6, 25);
            this.lblRaioEsfera.Name = "lblRaioEsfera";
            this.lblRaioEsfera.Size = new System.Drawing.Size(38, 13);
            this.lblRaioEsfera.TabIndex = 0;
            this.lblRaioEsfera.Text = "Raio:";
            // 
            // txtRaioEsfera
            // 
            this.txtRaioEsfera.Location = new System.Drawing.Point(49, 22);
            this.txtRaioEsfera.Name = "txtRaioEsfera";
            this.txtRaioEsfera.Size = new System.Drawing.Size(100, 20);
            this.txtRaioEsfera.TabIndex = 1;
            // 
            // btnCalcularEsfera
            // 
            this.btnCalcularEsfera.Location = new System.Drawing.Point(155, 20);
            this.btnCalcularEsfera.Name = "btnCalcularEsfera";
            this.btnCalcularEsfera.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularEsfera.TabIndex = 2;
            this.btnCalcularEsfera.Text = "Calcular";
            this.btnCalcularEsfera.UseVisualStyleBackColor = true;
            this.btnCalcularEsfera.Click += new System.EventHandler(this.btnCalcularEsfera_Click);
            // 
            // lblResultadoEsfera
            // 
            this.lblResultadoEsfera.AutoSize = true;
            this.lblResultadoEsfera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoEsfera.Location = new System.Drawing.Point(6, 60);
            this.lblResultadoEsfera.Name = "lblResultadoEsfera";
            this.lblResultadoEsfera.Size = new System.Drawing.Size(0, 15);
            this.lblResultadoEsfera.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(16, 400);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(200, 400);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar ao Menu";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 440);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbEsfera);
            this.Controls.Add(this.gbCone);
            this.Controls.Add(this.gbCubo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form2";
            this.Text = "Exercício 2 - Cálculo de Volumes";
            this.gbCubo.ResumeLayout(false);
            this.gbCubo.PerformLayout();
            this.gbCone.ResumeLayout(false);
            this.gbCone.PerformLayout();
            this.gbEsfera.ResumeLayout(false);
            this.gbEsfera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbCubo;
        private System.Windows.Forms.Label lblLadoCubo;
        private System.Windows.Forms.TextBox txtLadoCubo;
        private System.Windows.Forms.Button btnCalcularCubo;
        private System.Windows.Forms.Label lblResultadoCubo;
        private System.Windows.Forms.GroupBox gbCone;
        private System.Windows.Forms.Label lblRaioCone;
        private System.Windows.Forms.TextBox txtRaioCone;
        private System.Windows.Forms.Label lblAlturaCone;
        private System.Windows.Forms.TextBox txtAlturaCone;
        private System.Windows.Forms.Button btnCalcularCone;
        private System.Windows.Forms.Label lblResultadoEsfera;
        private System.Windows.Forms.GroupBox gbEsfera;
        private System.Windows.Forms.Label lblRaioEsfera;
        private System.Windows.Forms.TextBox txtRaioEsfera;
        private System.Windows.Forms.Button btnCalcularEsfera;
        private System.Windows.Forms.Label lblResultadoCone;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}
