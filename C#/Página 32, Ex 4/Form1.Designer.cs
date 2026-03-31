namespace Página_32__Ex_4
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
            txtNum = new TextBox();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNum
            // 
            txtNum.Location = new Point(38, 50);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(125, 27);
            txtNum.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(38, 83);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 29);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 50);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 2;
            label1.Text = "Positivo -> * 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 70);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 3;
            label2.Text = "Negativo -> * 3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(txtNum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
    }
}
