namespace ProjetoAbacaxi
{
    partial class frmAbacaxi
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
            this.cmbFrutas = new System.Windows.Forms.ComboBox();
            this.cmbPrecos = new System.Windows.Forms.ComboBox();
            this.lstSelecionados = new System.Windows.Forms.ListBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFrutas
            // 
            this.cmbFrutas.FormattingEnabled = true;
            this.cmbFrutas.Location = new System.Drawing.Point(104, 82);
            this.cmbFrutas.Name = "cmbFrutas";
            this.cmbFrutas.Size = new System.Drawing.Size(154, 28);
            this.cmbFrutas.TabIndex = 0;
            this.cmbFrutas.SelectedIndexChanged += new System.EventHandler(this.cmbFrutas_SelectedIndexChanged);
            // 
            // cmbPrecos
            // 
            this.cmbPrecos.FormattingEnabled = true;
            this.cmbPrecos.Location = new System.Drawing.Point(104, 138);
            this.cmbPrecos.Name = "cmbPrecos";
            this.cmbPrecos.Size = new System.Drawing.Size(154, 28);
            this.cmbPrecos.TabIndex = 1;
            // 
            // lstSelecionados
            // 
            this.lstSelecionados.FormattingEnabled = true;
            this.lstSelecionados.ItemHeight = 20;
            this.lstSelecionados.Location = new System.Drawing.Point(316, 33);
            this.lstSelecionados.Name = "lstSelecionados";
            this.lstSelecionados.Size = new System.Drawing.Size(256, 284);
            this.lstSelecionados.TabIndex = 2;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(101, 194);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(18, 20);
            this.lblMensagem.TabIndex = 3;
            this.lblMensagem.Text = "0";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Location = new System.Drawing.Point(27, 85);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(73, 20);
            this.lblProdutos.TabIndex = 4;
            this.lblProdutos.Text = "Produtos";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(27, 141);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(50, 20);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "Preço";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(27, 33);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 20);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(125, 30);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(133, 26);
            this.txtQuantidade.TabIndex = 7;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(27, 194);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 20);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total R$ ";
            // 
            // frmAbacaxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 390);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lstSelecionados);
            this.Controls.Add(this.cmbPrecos);
            this.Controls.Add(this.cmbFrutas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAbacaxi";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.frmAbacaxi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFrutas;
        private System.Windows.Forms.ComboBox cmbPrecos;
        private System.Windows.Forms.ListBox lstSelecionados;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblTotal;
    }
}

