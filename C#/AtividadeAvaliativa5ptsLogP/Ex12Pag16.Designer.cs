namespace AtividadeAvaliativa5ptsLogP
{
    partial class Ex12Pag16
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
            txtQuestoes = new TextBox();
            txtAcertos = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtQuestoes
            // 
            txtQuestoes.Location = new Point(12, 12);
            txtQuestoes.Name = "txtQuestoes";
            txtQuestoes.Size = new Size(125, 27);
            txtQuestoes.TabIndex = 0;
            // 
            // txtAcertos
            // 
            txtAcertos.Location = new Point(12, 45);
            txtAcertos.Name = "txtAcertos";
            txtAcertos.Size = new Size(125, 27);
            txtAcertos.TabIndex = 1;
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
            // Ex12Pag16
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtAcertos);
            Controls.Add(txtQuestoes);
            Name = "Ex12Pag16";
            Text = "Ex12Pag16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuestoes;
        private TextBox txtAcertos;
        private Button btnCalcular;
    }
}