namespace Minha_Classe_em_CSharp
{
    partial class Form1
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.LabelNome = new System.Windows.Forms.Label();
            this.LabelIdade = new System.Windows.Forms.Label();
            this.LabelAltura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(66, 392);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(294, 29);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(76, 68);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(16, 13);
            this.LabelNome.TabIndex = 1;
            this.LabelNome.Text = "...";
            // 
            // LabelIdade
            // 
            this.LabelIdade.AutoSize = true;
            this.LabelIdade.Location = new System.Drawing.Point(76, 111);
            this.LabelIdade.Name = "LabelIdade";
            this.LabelIdade.Size = new System.Drawing.Size(16, 13);
            this.LabelIdade.TabIndex = 2;
            this.LabelIdade.Text = "...";
            // 
            // LabelAltura
            // 
            this.LabelAltura.AutoSize = true;
            this.LabelAltura.Location = new System.Drawing.Point(76, 163);
            this.LabelAltura.Name = "LabelAltura";
            this.LabelAltura.Size = new System.Drawing.Size(16, 13);
            this.LabelAltura.TabIndex = 3;
            this.LabelAltura.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 472);
            this.Controls.Add(this.LabelAltura);
            this.Controls.Add(this.LabelIdade);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.BtnOK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.Label LabelIdade;
        private System.Windows.Forms.Label LabelAltura;
    }
}

