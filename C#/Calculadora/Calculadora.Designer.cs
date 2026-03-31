namespace Calculadora
{
    partial class Calculadora
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            cmbEscolha = new ComboBox();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(12, 24);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 27);
            txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(12, 68);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 27);
            txtNum2.TabIndex = 1;
            // 
            // cmbEscolha
            // 
            cmbEscolha.FormattingEnabled = true;
            cmbEscolha.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cmbEscolha.Location = new Point(12, 207);
            cmbEscolha.Name = "cmbEscolha";
            cmbEscolha.Size = new Size(151, 28);
            cmbEscolha.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 244);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 1);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 4;
            label1.Text = "Digite um número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 5;
            label2.Text = "Digite um número:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 6;
            label3.Text = "Escolha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 118);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 7;
            label4.Text = "1 - Adição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 158);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 8;
            label5.Text = "3 - Multiplicação";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 138);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 9;
            label6.Text = "2 - Subtração";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 178);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 10;
            label7.Text = "4 - Divisão";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(30, 276);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(17, 20);
            lblResultado.TabIndex = 11;
            lblResultado.Text = "0";
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(cmbEscolha);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "Calculadora";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private ComboBox cmbEscolha;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblResultado;
    }
}
