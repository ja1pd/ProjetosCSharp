namespace Exercício_Avaliativo_2ª_Etapa___5_Pontos
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício1ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.desafioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividadesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atividadesToolStripMenuItem
            // 
            this.atividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercício1ToolStripMenuItem,
            this.exercício1ToolStripMenuItem1,
            this.exercício1ToolStripMenuItem2,
            this.exercício1ToolStripMenuItem3,
            this.desafioToolStripMenuItem});
            this.atividadesToolStripMenuItem.Name = "atividadesToolStripMenuItem";
            this.atividadesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.atividadesToolStripMenuItem.Text = "Atividades";
            // 
            // exercício1ToolStripMenuItem
            // 
            this.exercício1ToolStripMenuItem.Name = "exercício1ToolStripMenuItem";
            this.exercício1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercício1ToolStripMenuItem.Text = "Exercício 1";
            this.exercício1ToolStripMenuItem.Click += new System.EventHandler(this.exercício1ToolStripMenuItem_Click);
            // 
            // exercício1ToolStripMenuItem1
            // 
            this.exercício1ToolStripMenuItem1.Name = "exercício1ToolStripMenuItem1";
            this.exercício1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exercício1ToolStripMenuItem1.Text = "Exercício 2";
            this.exercício1ToolStripMenuItem1.Click += new System.EventHandler(this.exercício1ToolStripMenuItem1_Click);
            // 
            // exercício1ToolStripMenuItem2
            // 
            this.exercício1ToolStripMenuItem2.Name = "exercício1ToolStripMenuItem2";
            this.exercício1ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.exercício1ToolStripMenuItem2.Text = "Exercício 3";
            this.exercício1ToolStripMenuItem2.Click += new System.EventHandler(this.exercício1ToolStripMenuItem2_Click);
            // 
            // exercício1ToolStripMenuItem3
            // 
            this.exercício1ToolStripMenuItem3.Name = "exercício1ToolStripMenuItem3";
            this.exercício1ToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.exercício1ToolStripMenuItem3.Text = "Exercício 4";
            this.exercício1ToolStripMenuItem3.Click += new System.EventHandler(this.exercício1ToolStripMenuItem3_Click);
            // 
            // desafioToolStripMenuItem
            // 
            this.desafioToolStripMenuItem.Name = "desafioToolStripMenuItem";
            this.desafioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desafioToolStripMenuItem.Text = "Desafio";
            this.desafioToolStripMenuItem.Click += new System.EventHandler(this.desafioToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "2ª Etapa - Aluno: João Pedro Bastos Neves";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exercício1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exercício1ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem desafioToolStripMenuItem;
    }
}

