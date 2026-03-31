namespace AtividadeAvaliativa5ptsLogP
{
    partial class Ex25Pag42
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
            txtAno = new TextBox();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // txtAno
            // 
            txtAno.Location = new Point(12, 12);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(125, 27);
            txtAno.TabIndex = 0;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(12, 45);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(125, 29);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // Ex25Pag42
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerificar);
            Controls.Add(txtAno);
            Name = "Ex25Pag42";
            Text = "Ex25Pag42";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAno;
        private Button btnVerificar;
    }
}