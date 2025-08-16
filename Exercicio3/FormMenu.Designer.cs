namespace Exercicio3
{
    partial class FormMenu
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
            this.btnExercicio1 = new System.Windows.Forms.Button();
            this.btnExercicio2 = new System.Windows.Forms.Button();
            this.btnExercicio3 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(50, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(284, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menu Principal - Exercícios";
            // 
            // btnExercicio1
            // 
            this.btnExercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercicio1.Location = new System.Drawing.Point(80, 100);
            this.btnExercicio1.Name = "btnExercicio1";
            this.btnExercicio1.Size = new System.Drawing.Size(220, 50);
            this.btnExercicio1.TabIndex = 1;
            this.btnExercicio1.Text = "Exercício 1 - Soma de 5 Números";
            this.btnExercicio1.UseVisualStyleBackColor = true;
            this.btnExercicio1.Click += new System.EventHandler(this.btnExercicio1_Click);
            // 
            // btnExercicio2
            // 
            this.btnExercicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercicio2.Location = new System.Drawing.Point(80, 170);
            this.btnExercicio2.Name = "btnExercicio2";
            this.btnExercicio2.Size = new System.Drawing.Size(220, 50);
            this.btnExercicio2.TabIndex = 2;
            this.btnExercicio2.Text = "Exercício 2 - Cálculo de Volumes";
            this.btnExercicio2.UseVisualStyleBackColor = true;
            this.btnExercicio2.Click += new System.EventHandler(this.btnExercicio2_Click);
            // 
            // btnExercicio3
            // 
            this.btnExercicio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercicio3.Location = new System.Drawing.Point(80, 240);
            this.btnExercicio3.Name = "btnExercicio3";
            this.btnExercicio3.Size = new System.Drawing.Size(220, 50);
            this.btnExercicio3.TabIndex = 3;
            this.btnExercicio3.Text = "Exercício 3 - Veículo e Motor";
            this.btnExercicio3.UseVisualStyleBackColor = true;
            this.btnExercicio3.Click += new System.EventHandler(this.btnExercicio3_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(80, 310);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(220, 50);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 380);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExercicio3);
            this.Controls.Add(this.btnExercicio2);
            this.Controls.Add(this.btnExercicio1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal - Exercícios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnExercicio1;
        private System.Windows.Forms.Button btnExercicio2;
        private System.Windows.Forms.Button btnExercicio3;
        private System.Windows.Forms.Button btnSair;
    }
}
