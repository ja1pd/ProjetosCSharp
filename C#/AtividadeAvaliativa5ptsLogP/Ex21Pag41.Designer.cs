namespace AtividadeAvaliativa5ptsLogP
{
    partial class Ex21Pag41
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
            txtMulEsc = new TextBox();
            txtHomEsc = new TextBox();
            txtMulAna = new TextBox();
            txtHomAna = new TextBox();
            btnCalcular = new Button();
            lblAna = new Label();
            lblEsc = new Label();
            SuspendLayout();
            // 
            // txtMulEsc
            // 
            txtMulEsc.Location = new Point(12, 12);
            txtMulEsc.Name = "txtMulEsc";
            txtMulEsc.Size = new Size(125, 27);
            txtMulEsc.TabIndex = 0;
            // 
            // txtHomEsc
            // 
            txtHomEsc.Location = new Point(12, 68);
            txtHomEsc.Name = "txtHomEsc";
            txtHomEsc.Size = new Size(125, 27);
            txtHomEsc.TabIndex = 1;
            // 
            // txtMulAna
            // 
            txtMulAna.Location = new Point(279, 12);
            txtMulAna.Name = "txtMulAna";
            txtMulAna.Size = new Size(125, 27);
            txtMulAna.TabIndex = 2;
            // 
            // txtHomAna
            // 
            txtHomAna.Location = new Point(279, 68);
            txtHomAna.Name = "txtHomAna";
            txtHomAna.Size = new Size(125, 27);
            txtHomAna.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(143, 12);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(130, 83);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblAna
            // 
            lblAna.AutoSize = true;
            lblAna.Location = new Point(279, 42);
            lblAna.Name = "lblAna";
            lblAna.Size = new Size(145, 20);
            lblAna.TabIndex = 5;
            lblAna.Text = "Analista de Sistemas";
            // 
            // lblEsc
            // 
            lblEsc.AutoSize = true;
            lblEsc.Location = new Point(12, 45);
            lblEsc.Name = "lblEsc";
            lblEsc.Size = new Size(78, 20);
            lblEsc.TabIndex = 6;
            lblEsc.Text = "Escrituário";
            // 
            // Ex21Pag41
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEsc);
            Controls.Add(lblAna);
            Controls.Add(btnCalcular);
            Controls.Add(txtHomAna);
            Controls.Add(txtMulAna);
            Controls.Add(txtHomEsc);
            Controls.Add(txtMulEsc);
            Name = "Ex21Pag41";
            Text = "Ex21Pag41";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMulEsc;
        private TextBox txtHomEsc;
        private TextBox txtMulAna;
        private TextBox txtHomAna;
        private Button btnCalcular;
        private Label lblAna;
        private Label lblEsc;
    }
}