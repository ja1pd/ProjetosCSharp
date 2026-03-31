namespace Exercício_Avaliativo_2ª_Etapa___5_Pontos
{
    partial class Exercicio2
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lblMaiuscula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(13, 13);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(473, 24);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Digite algo para que o texto seja exibido em Maiúsculo:";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(17, 40);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(771, 193);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // lblMaiuscula
            // 
            this.lblMaiuscula.Location = new System.Drawing.Point(17, 236);
            this.lblMaiuscula.Name = "lblMaiuscula";
            this.lblMaiuscula.Size = new System.Drawing.Size(771, 205);
            this.lblMaiuscula.TabIndex = 2;
            // 
            // Exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMaiuscula);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblTexto);
            this.Name = "Exercicio2";
            this.Text = "Exercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label lblMaiuscula;
    }
}