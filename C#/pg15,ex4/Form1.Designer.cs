namespace pg15_ex4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLado = new TextBox();
            btnCalcular = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtLado
            // 
            txtLado.Location = new Point(41, 60);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(504, 27);
            txtLado.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(41, 93);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(504, 29);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Clique aqui para calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 37);
            label1.Name = "label1";
            label1.Size = new Size(504, 20);
            label1.TabIndex = 2;
            label1.Text = "Insira o valor do lado do quadrado para ser calculada a área do quadrado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(txtLado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLado;
        private Button btnCalcular;
        private Label label1;
    }
}
