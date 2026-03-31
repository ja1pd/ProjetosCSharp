namespace AtividadeAvaliativa5ptsLogP
{
    partial class Ex10Pag16
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
            txtRaio = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtRaio
            // 
            txtRaio.Location = new Point(12, 12);
            txtRaio.Name = "txtRaio";
            txtRaio.Size = new Size(125, 27);
            txtRaio.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 45);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 29);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Ex10Pag16
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtRaio);
            Name = "Ex10Pag16";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRaio;
        private Button btnCalcular;
    }
}