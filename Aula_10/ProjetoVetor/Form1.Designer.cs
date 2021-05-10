namespace ProjetoVetor
{
    partial class FrmVetor
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
            this.lstInteiros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstInteiros
            // 
            this.lstInteiros.FormattingEnabled = true;
            this.lstInteiros.ItemHeight = 20;
            this.lstInteiros.Location = new System.Drawing.Point(28, 26);
            this.lstInteiros.Name = "lstInteiros";
            this.lstInteiros.Size = new System.Drawing.Size(120, 84);
            this.lstInteiros.TabIndex = 0;
            // 
            // FrmVetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 348);
            this.Controls.Add(this.lstInteiros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVetor";
            this.Text = "Vetor";
            this.Load += new System.EventHandler(this.FrmVetor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstInteiros;
    }
}

