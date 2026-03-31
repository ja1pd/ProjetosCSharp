namespace Exercício_Avaliativo_2ª_Etapa___5_Pontos
{
    partial class Exercicio3
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnAzul = new System.Windows.Forms.RadioButton();
            this.rbtnAmarelo = new System.Windows.Forms.RadioButton();
            this.rbtnVermelho = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione uma opção para trocar a cor de fundo:";
            // 
            // rbtnAzul
            // 
            this.rbtnAzul.AutoSize = true;
            this.rbtnAzul.Location = new System.Drawing.Point(16, 71);
            this.rbtnAzul.Name = "rbtnAzul";
            this.rbtnAzul.Size = new System.Drawing.Size(45, 17);
            this.rbtnAzul.TabIndex = 1;
            this.rbtnAzul.TabStop = true;
            this.rbtnAzul.Text = "Azul";
            this.rbtnAzul.UseVisualStyleBackColor = true;
            this.rbtnAzul.CheckedChanged += new System.EventHandler(this.rbtnAzul_CheckedChanged);
            // 
            // rbtnAmarelo
            // 
            this.rbtnAmarelo.AutoSize = true;
            this.rbtnAmarelo.Location = new System.Drawing.Point(179, 71);
            this.rbtnAmarelo.Name = "rbtnAmarelo";
            this.rbtnAmarelo.Size = new System.Drawing.Size(63, 17);
            this.rbtnAmarelo.TabIndex = 2;
            this.rbtnAmarelo.TabStop = true;
            this.rbtnAmarelo.Text = "Amarelo";
            this.rbtnAmarelo.UseVisualStyleBackColor = true;
            this.rbtnAmarelo.CheckedChanged += new System.EventHandler(this.rbtnAmarelo_CheckedChanged);
            // 
            // rbtnVermelho
            // 
            this.rbtnVermelho.AutoSize = true;
            this.rbtnVermelho.Location = new System.Drawing.Point(316, 71);
            this.rbtnVermelho.Name = "rbtnVermelho";
            this.rbtnVermelho.Size = new System.Drawing.Size(69, 17);
            this.rbtnVermelho.TabIndex = 3;
            this.rbtnVermelho.TabStop = true;
            this.rbtnVermelho.Text = "Vermelho";
            this.rbtnVermelho.UseVisualStyleBackColor = true;
            this.rbtnVermelho.CheckedChanged += new System.EventHandler(this.rbtnVermelho_CheckedChanged);
            // 
            // Exercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnVermelho);
            this.Controls.Add(this.rbtnAmarelo);
            this.Controls.Add(this.rbtnAzul);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio3";
            this.Text = "Exercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnAzul;
        private System.Windows.Forms.RadioButton rbtnAmarelo;
        private System.Windows.Forms.RadioButton rbtnVermelho;
    }
}