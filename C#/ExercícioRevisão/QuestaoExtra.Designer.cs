namespace ExercícioRevisão
{
    partial class QuestaoExtra
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
            this.txtNum0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lstRodada = new System.Windows.Forms.ListBox();
            this.btnRepetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum0
            // 
            this.txtNum0.Location = new System.Drawing.Point(12, 32);
            this.txtNum0.Name = "txtNum0";
            this.txtNum0.Size = new System.Drawing.Size(100, 22);
            this.txtNum0.TabIndex = 0;
            this.txtNum0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum0.TextChanged += new System.EventHandler(this.txtNum0_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Posição 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Posição 1";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(118, 32);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Posição 2";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(224, 32);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 4;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // lstRodada
            // 
            this.lstRodada.FormattingEnabled = true;
            this.lstRodada.ItemHeight = 16;
            this.lstRodada.Location = new System.Drawing.Point(12, 61);
            this.lstRodada.Name = "lstRodada";
            this.lstRodada.Size = new System.Drawing.Size(418, 340);
            this.lstRodada.TabIndex = 6;
            // 
            // btnRepetir
            // 
            this.btnRepetir.Location = new System.Drawing.Point(330, 13);
            this.btnRepetir.Name = "btnRepetir";
            this.btnRepetir.Size = new System.Drawing.Size(100, 41);
            this.btnRepetir.TabIndex = 7;
            this.btnRepetir.Text = "Repetir";
            this.btnRepetir.UseVisualStyleBackColor = true;
            this.btnRepetir.Click += new System.EventHandler(this.btnRepetir_Click);
            // 
            // QuestaoExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRepetir);
            this.Controls.Add(this.lstRodada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum0);
            this.Name = "QuestaoExtra";
            this.Text = "QuestaoExtra";
            this.Load += new System.EventHandler(this.QuestaoExtra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.ListBox lstRodada;
        private System.Windows.Forms.Button btnRepetir;
    }
}