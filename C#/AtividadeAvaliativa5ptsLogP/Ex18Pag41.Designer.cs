namespace AtividadeAvaliativa5ptsLogP
{
    partial class Ex18Pag41
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
            txtLadoa = new TextBox();
            txtLadob = new TextBox();
            txtLadoc = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtLadoa
            // 
            txtLadoa.Location = new Point(12, 12);
            txtLadoa.Name = "txtLadoa";
            txtLadoa.Size = new Size(125, 27);
            txtLadoa.TabIndex = 0;
            // 
            // txtLadob
            // 
            txtLadob.Location = new Point(12, 45);
            txtLadob.Name = "txtLadob";
            txtLadob.Size = new Size(125, 27);
            txtLadob.TabIndex = 1;
            // 
            // txtLadoc
            // 
            txtLadoc.Location = new Point(12, 78);
            txtLadoc.Name = "txtLadoc";
            txtLadoc.Size = new Size(125, 27);
            txtLadoc.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 111);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 29);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Ex18Pag41
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtLadoc);
            Controls.Add(txtLadob);
            Controls.Add(txtLadoa);
            Name = "Ex18Pag41";
            Text = "Ex18Pag41";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLadoa;
        private TextBox txtLadob;
        private TextBox txtLadoc;
        private Button btnCalcular;
    }
}