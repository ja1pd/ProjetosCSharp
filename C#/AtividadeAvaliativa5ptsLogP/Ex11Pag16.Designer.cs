namespace AtividadeAvaliativa5ptsLogP
{
    partial class Form1
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
            txtCelsius = new TextBox();
            btnConverter = new Button();
            SuspendLayout();
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(12, 12);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(125, 27);
            txtCelsius.TabIndex = 0;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(12, 45);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(125, 29);
            btnConverter.TabIndex = 1;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConverter);
            Controls.Add(txtCelsius);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCelsius;
        private Button btnConverter;
    }
}