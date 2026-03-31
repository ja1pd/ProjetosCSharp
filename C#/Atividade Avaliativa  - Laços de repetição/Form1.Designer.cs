namespace Atividade_Avaliativa____Laços_de_repetição
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            atvToolStripMenuItem = new ToolStripMenuItem();
            ex8Pag61ToolStripMenuItem = new ToolStripMenuItem();
            valoresToolStripMenuItem = new ToolStripMenuItem();
            txtPesos = new TextBox();
            lblMenor75kg = new Label();
            lblEntre20e23 = new Label();
            txtIdade = new TextBox();
            lblMediaIdades = new Label();
            button1 = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { atvToolStripMenuItem, ex8Pag61ToolStripMenuItem, valoresToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(143, 76);
            // 
            // atvToolStripMenuItem
            // 
            atvToolStripMenuItem.Name = "atvToolStripMenuItem";
            atvToolStripMenuItem.Size = new Size(142, 24);
            atvToolStripMenuItem.Text = "Ex7Pag61";
            // 
            // ex8Pag61ToolStripMenuItem
            // 
            ex8Pag61ToolStripMenuItem.Name = "ex8Pag61ToolStripMenuItem";
            ex8Pag61ToolStripMenuItem.Size = new Size(142, 24);
            ex8Pag61ToolStripMenuItem.Text = "Ex8Pag61";
            // 
            // valoresToolStripMenuItem
            // 
            valoresToolStripMenuItem.Name = "valoresToolStripMenuItem";
            valoresToolStripMenuItem.Size = new Size(142, 24);
            valoresToolStripMenuItem.Text = "30Valores";
            // 
            // txtPesos
            // 
            txtPesos.Location = new Point(12, 12);
            txtPesos.Multiline = true;
            txtPesos.Name = "txtPesos";
            txtPesos.Size = new Size(776, 102);
            txtPesos.TabIndex = 1;
            // 
            // lblMenor75kg
            // 
            lblMenor75kg.AutoSize = true;
            lblMenor75kg.Location = new Point(12, 245);
            lblMenor75kg.Name = "lblMenor75kg";
            lblMenor75kg.Size = new Size(50, 20);
            lblMenor75kg.TabIndex = 2;
            lblMenor75kg.Text = "label1";
            // 
            // lblEntre20e23
            // 
            lblEntre20e23.AutoSize = true;
            lblEntre20e23.Location = new Point(12, 225);
            lblEntre20e23.Name = "lblEntre20e23";
            lblEntre20e23.Size = new Size(50, 20);
            lblEntre20e23.TabIndex = 3;
            lblEntre20e23.Text = "label1";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(12, 120);
            txtIdade.Multiline = true;
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(776, 102);
            txtIdade.TabIndex = 4;
            // 
            // lblMediaIdades
            // 
            lblMediaIdades.AutoSize = true;
            lblMediaIdades.Location = new Point(12, 265);
            lblMediaIdades.Name = "lblMediaIdades";
            lblMediaIdades.Size = new Size(50, 20);
            lblMediaIdades.TabIndex = 5;
            lblMediaIdades.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 288);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblMediaIdades);
            Controls.Add(txtIdade);
            Controls.Add(lblEntre20e23);
            Controls.Add(lblMenor75kg);
            Controls.Add(txtPesos);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem atvToolStripMenuItem;
        private ToolStripMenuItem ex8Pag61ToolStripMenuItem;
        private ToolStripMenuItem valoresToolStripMenuItem;
        private TextBox txtPesos;
        private Label lblMenor75kg;
        private Label lblEntre20e23;
        private TextBox txtIdade;
        private Label lblMediaIdades;
        private Button button1;
    }
}
