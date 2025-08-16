namespace Exercicio3
{
    partial class Form1
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
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblNumero3 = new System.Windows.Forms.Label();
            this.lblNumero4 = new System.Windows.Forms.Label();
            this.lblNumero5 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero3 = new System.Windows.Forms.TextBox();
            this.txtNumero4 = new System.Windows.Forms.TextBox();
            this.txtNumero5 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(276, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Soma de 5 Números Inteiros";
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(13, 50);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(53, 13);
            this.lblNumero1.TabIndex = 1;
            this.lblNumero1.Text = "Número 1:";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(13, 80);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(53, 13);
            this.lblNumero2.TabIndex = 2;
            this.lblNumero2.Text = "Número 2:";
            // 
            // lblNumero3
            // 
            this.lblNumero3.AutoSize = true;
            this.lblNumero3.Location = new System.Drawing.Point(13, 110);
            this.lblNumero3.Name = "lblNumero3";
            this.lblNumero3.Size = new System.Drawing.Size(53, 13);
            this.lblNumero3.TabIndex = 3;
            this.lblNumero3.Text = "Número 3:";
            // 
            // lblNumero4
            // 
            this.lblNumero4.AutoSize = true;
            this.lblNumero4.Location = new System.Drawing.Point(13, 140);
            this.lblNumero4.Name = "lblNumero4";
            this.lblNumero4.Size = new System.Drawing.Size(53, 13);
            this.lblNumero4.TabIndex = 4;
            this.lblNumero4.Text = "Número 4:";
            // 
            // lblNumero5
            // 
            this.lblNumero5.AutoSize = true;
            this.lblNumero5.Location = new System.Drawing.Point(13, 170);
            this.lblNumero5.Name = "lblNumero5";
            this.lblNumero5.Size = new System.Drawing.Size(53, 13);
            this.lblNumero5.TabIndex = 5;
            this.lblNumero5.Text = "Número 5:";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(80, 47);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 6;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(80, 77);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 7;
            // 
            // txtNumero3
            // 
            this.txtNumero3.Location = new System.Drawing.Point(80, 107);
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(100, 20);
            this.txtNumero3.TabIndex = 8;
            // 
            // txtNumero4
            // 
            this.txtNumero4.Location = new System.Drawing.Point(80, 137);
            this.txtNumero4.Name = "txtNumero4";
            this.txtNumero4.Size = new System.Drawing.Size(100, 20);
            this.txtNumero4.TabIndex = 9;
            // 
            // txtNumero5
            // 
            this.txtNumero5.Location = new System.Drawing.Point(80, 167);
            this.txtNumero5.Name = "txtNumero5";
            this.txtNumero5.Size = new System.Drawing.Size(100, 20);
            this.txtNumero5.TabIndex = 10;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 210);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(105, 210);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(13, 250);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 16);
            this.lblResultado.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(13, 280);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 320);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumero5);
            this.Controls.Add(this.txtNumero4);
            this.Controls.Add(this.txtNumero3);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblNumero5);
            this.Controls.Add(this.lblNumero4);
            this.Controls.Add(this.lblNumero3);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Exercício 1 - Soma de 5 Números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblNumero3;
        private System.Windows.Forms.Label lblNumero4;
        private System.Windows.Forms.Label lblNumero5;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero3;
        private System.Windows.Forms.TextBox txtNumero4;
        private System.Windows.Forms.TextBox txtNumero5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblStatus;
    }
}
