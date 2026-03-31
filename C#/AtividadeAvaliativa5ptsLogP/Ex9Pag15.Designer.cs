namespace AtividadeAvaliativa5ptsLogP
{
    partial class Ex9Pag15
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
            txtNascimento = new TextBox();
            txtAtual = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtNascimento
            // 
            txtNascimento.Location = new Point(12, 12);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(125, 27);
            txtNascimento.TabIndex = 0;
            // 
            // txtAtual
            // 
            txtAtual.Location = new Point(12, 45);
            txtAtual.Name = "txtAtual";
            txtAtual.Size = new Size(125, 27);
            txtAtual.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 78);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 29);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Ex9Pag15
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtAtual);
            Controls.Add(txtNascimento);
            Name = "Ex9Pag15";
            Text = "Ex9Pag15";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNascimento;
        private TextBox txtAtual;
        private Button btnCalcular;
    }
}