namespace ProjetoListBox
{
    partial class frmListBox
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
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.lblAsteristico = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.txtPosicao = new System.Windows.Forms.TextBox();
            this.txtAsteristico = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight = 20;
            this.lstNumeros.Location = new System.Drawing.Point(22, 22);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(207, 364);
            this.lstNumeros.TabIndex = 0;
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(272, 22);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(101, 32);
            this.btnFor.TabIndex = 1;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(272, 72);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(101, 32);
            this.btnWhile.TabIndex = 2;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(272, 122);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(101, 32);
            this.btnDoWhile.TabIndex = 3;
            this.btnDoWhile.Text = "Do ... While";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(430, 45);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(48, 20);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.Text = "Placa";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(430, 84);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(76, 20);
            this.lblTamanho.TabIndex = 5;
            this.lblTamanho.Text = "Tamanho";
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.Location = new System.Drawing.Point(430, 122);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(65, 20);
            this.lblPosicao.TabIndex = 6;
            this.lblPosicao.Text = "Posição";
            // 
            // lblAsteristico
            // 
            this.lblAsteristico.AutoSize = true;
            this.lblAsteristico.Location = new System.Drawing.Point(430, 161);
            this.lblAsteristico.Name = "lblAsteristico";
            this.lblAsteristico.Size = new System.Drawing.Size(15, 20);
            this.lblAsteristico.TabIndex = 7;
            this.lblAsteristico.Text = "*";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(507, 42);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 26);
            this.txtPlaca.TabIndex = 8;
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(507, 78);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(100, 26);
            this.txtTamanho.TabIndex = 9;
            // 
            // txtPosicao
            // 
            this.txtPosicao.Location = new System.Drawing.Point(507, 119);
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.Size = new System.Drawing.Size(100, 26);
            this.txtPosicao.TabIndex = 10;
            // 
            // txtAsteristico
            // 
            this.txtAsteristico.Location = new System.Drawing.Point(507, 158);
            this.txtAsteristico.Name = "txtAsteristico";
            this.txtAsteristico.Size = new System.Drawing.Size(100, 26);
            this.txtAsteristico.TabIndex = 11;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(651, 36);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(75, 32);
            this.btnVerifica.TabIndex = 12;
            this.btnVerifica.Text = "Verifica";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 482);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtAsteristico);
            this.Controls.Add(this.txtPosicao);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblAsteristico);
            this.Controls.Add(this.lblPosicao);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.lstNumeros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListBox";
            this.Text = "Laços de Repetição com ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.Label lblAsteristico;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.TextBox txtPosicao;
        private System.Windows.Forms.TextBox txtAsteristico;
        private System.Windows.Forms.Button btnVerifica;
    }
}

