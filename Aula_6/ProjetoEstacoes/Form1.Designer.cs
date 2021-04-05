namespace ProjetoEstacoes
{
    partial class FrmCombo
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
            this.grpEstacoes = new System.Windows.Forms.GroupBox();
            this.cboEstacoes = new System.Windows.Forms.ComboBox();
            this.lblEstacoes = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblEscolhida = new System.Windows.Forms.Label();
            this.picEstacao = new System.Windows.Forms.PictureBox();
            this.grpEstacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEstacao)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEstacoes
            // 
            this.grpEstacoes.Controls.Add(this.picEstacao);
            this.grpEstacoes.Controls.Add(this.lblEscolhida);
            this.grpEstacoes.Controls.Add(this.lblMsg);
            this.grpEstacoes.Controls.Add(this.lblEstacoes);
            this.grpEstacoes.Controls.Add(this.cboEstacoes);
            this.grpEstacoes.Location = new System.Drawing.Point(12, 21);
            this.grpEstacoes.Name = "grpEstacoes";
            this.grpEstacoes.Size = new System.Drawing.Size(393, 390);
            this.grpEstacoes.TabIndex = 0;
            this.grpEstacoes.TabStop = false;
            this.grpEstacoes.Text = "Estações";
            // 
            // cboEstacoes
            // 
            this.cboEstacoes.FormattingEnabled = true;
            this.cboEstacoes.Items.AddRange(new object[] {
            "Inverno",
            "Outono",
            "Primavera",
            "Verão"});
            this.cboEstacoes.Location = new System.Drawing.Point(10, 63);
            this.cboEstacoes.Name = "cboEstacoes";
            this.cboEstacoes.Size = new System.Drawing.Size(222, 32);
            this.cboEstacoes.Sorted = true;
            this.cboEstacoes.TabIndex = 0;
            this.cboEstacoes.Text = "Qual a estação do ano ";
            this.cboEstacoes.SelectedIndexChanged += new System.EventHandler(this.cboEstacoes_SelectedIndexChanged);
            // 
            // lblEstacoes
            // 
            this.lblEstacoes.AutoSize = true;
            this.lblEstacoes.Location = new System.Drawing.Point(6, 36);
            this.lblEstacoes.Name = "lblEstacoes";
            this.lblEstacoes.Size = new System.Drawing.Size(159, 24);
            this.lblEstacoes.TabIndex = 1;
            this.lblEstacoes.Text = "Estações do Ano:";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(6, 112);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(170, 24);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "Estação Escolhida:";
            // 
            // lblEscolhida
            // 
            this.lblEscolhida.AutoSize = true;
            this.lblEscolhida.Location = new System.Drawing.Point(172, 112);
            this.lblEscolhida.Name = "lblEscolhida";
            this.lblEscolhida.Size = new System.Drawing.Size(16, 24);
            this.lblEscolhida.TabIndex = 3;
            this.lblEscolhida.Text = "-";
            // 
            // picEstacao
            // 
            this.picEstacao.Image = global::ProjetoEstacoes.Properties.Resources.estacoes;
            this.picEstacao.Location = new System.Drawing.Point(10, 157);
            this.picEstacao.Name = "picEstacao";
            this.picEstacao.Size = new System.Drawing.Size(362, 218);
            this.picEstacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEstacao.TabIndex = 4;
            this.picEstacao.TabStop = false;
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 423);
            this.Controls.Add(this.grpEstacoes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmCombo";
            this.Text = "Aprendendo ComboBox";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.grpEstacoes.ResumeLayout(false);
            this.grpEstacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEstacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEstacoes;
        private System.Windows.Forms.Label lblEstacoes;
        private System.Windows.Forms.ComboBox cboEstacoes;
        private System.Windows.Forms.Label lblEscolhida;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox picEstacao;
    }
}

