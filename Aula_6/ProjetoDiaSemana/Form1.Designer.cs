namespace ProjetoDiaSemana
{
    partial class FrmDiaSemana
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
            this.lblEscolher = new System.Windows.Forms.Label();
            this.cbmDiaSemana = new System.Windows.Forms.ComboBox();
            this.picDiaSemana = new System.Windows.Forms.PictureBox();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDiaSemana)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEscolher
            // 
            this.lblEscolher.AutoSize = true;
            this.lblEscolher.Location = new System.Drawing.Point(12, 27);
            this.lblEscolher.Name = "lblEscolher";
            this.lblEscolher.Size = new System.Drawing.Size(197, 20);
            this.lblEscolher.TabIndex = 0;
            this.lblEscolher.Text = "Escolha o Dia da Semana:";
            // 
            // cbmDiaSemana
            // 
            this.cbmDiaSemana.FormattingEnabled = true;
            this.cbmDiaSemana.Location = new System.Drawing.Point(16, 50);
            this.cbmDiaSemana.Name = "cbmDiaSemana";
            this.cbmDiaSemana.Size = new System.Drawing.Size(433, 28);
            this.cbmDiaSemana.TabIndex = 1;
            this.cbmDiaSemana.Text = "Dia da Semana";
            this.cbmDiaSemana.SelectedIndexChanged += new System.EventHandler(this.cbmDiaSemana_SelectedIndexChanged);
            // 
            // picDiaSemana
            // 
            this.picDiaSemana.Image = global::ProjetoDiaSemana.Properties.Resources.dia_semana;
            this.picDiaSemana.Location = new System.Drawing.Point(16, 147);
            this.picDiaSemana.Name = "picDiaSemana";
            this.picDiaSemana.Size = new System.Drawing.Size(429, 255);
            this.picDiaSemana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiaSemana.TabIndex = 2;
            this.picDiaSemana.TabStop = false;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(12, 106);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(119, 20);
            this.lblDiaSemana.TabIndex = 3;
            this.lblDiaSemana.Text = "Dia da Semana";
            // 
            // FrmDiaSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 414);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.picDiaSemana);
            this.Controls.Add(this.cbmDiaSemana);
            this.Controls.Add(this.lblEscolher);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDiaSemana";
            this.Text = "Utilizando ComboBox";
            this.Load += new System.EventHandler(this.FrmDiaSemana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDiaSemana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEscolher;
        private System.Windows.Forms.ComboBox cbmDiaSemana;
        private System.Windows.Forms.PictureBox picDiaSemana;
        private System.Windows.Forms.Label lblDiaSemana;
    }
}

