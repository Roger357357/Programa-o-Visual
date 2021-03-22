namespace Aula2
{
    partial class frmFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormulario));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.BtnMensagem = new System.Windows.Forms.Button();
            this.txtCopiaNome = new System.Windows.Forms.TextBox();
            this.txtCopiaEndereco = new System.Windows.Forms.TextBox();
            this.txtCopiaCidade = new System.Windows.Forms.TextBox();
            this.txtCopiaIdade = new System.Windows.Forms.TextBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Yellow;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(129, 32);
            this.lblNome.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(127, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Seu Nome:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Yellow;
            this.lblEndereco.ForeColor = System.Drawing.Color.White;
            this.lblEndereco.Location = new System.Drawing.Point(137, 71);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(119, 25);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Yellow;
            this.lblCidade.ForeColor = System.Drawing.Color.White;
            this.lblCidade.Location = new System.Drawing.Point(163, 109);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(93, 25);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.BackColor = System.Drawing.Color.Yellow;
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(179, 147);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(77, 25);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "Idade:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtEndereco.ForeColor = System.Drawing.Color.White;
            this.txtEndereco.Location = new System.Drawing.Point(266, 68);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(260, 31);
            this.txtEndereco.TabIndex = 2;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtCidade.ForeColor = System.Drawing.Color.White;
            this.txtCidade.Location = new System.Drawing.Point(266, 106);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(260, 31);
            this.txtCidade.TabIndex = 3;
            this.txtCidade.Text = "São Paulo";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(266, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 31);
            this.txtNome.TabIndex = 1;
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtIdade.ForeColor = System.Drawing.Color.White;
            this.txtIdade.Location = new System.Drawing.Point(266, 144);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(87, 31);
            this.txtIdade.TabIndex = 4;
            // 
            // BtnMensagem
            // 
            this.BtnMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMensagem.Location = new System.Drawing.Point(371, 141);
            this.BtnMensagem.Name = "BtnMensagem";
            this.BtnMensagem.Size = new System.Drawing.Size(155, 39);
            this.BtnMensagem.TabIndex = 5;
            this.BtnMensagem.Text = "Mensagem";
            this.BtnMensagem.UseVisualStyleBackColor = true;
            this.BtnMensagem.Click += new System.EventHandler(this.BtnMensagem_Click);
            // 
            // txtCopiaNome
            // 
            this.txtCopiaNome.Location = new System.Drawing.Point(235, 205);
            this.txtCopiaNome.Name = "txtCopiaNome";
            this.txtCopiaNome.Size = new System.Drawing.Size(260, 31);
            this.txtCopiaNome.TabIndex = 6;
            // 
            // txtCopiaEndereco
            // 
            this.txtCopiaEndereco.Location = new System.Drawing.Point(235, 242);
            this.txtCopiaEndereco.Name = "txtCopiaEndereco";
            this.txtCopiaEndereco.Size = new System.Drawing.Size(260, 31);
            this.txtCopiaEndereco.TabIndex = 7;
            // 
            // txtCopiaCidade
            // 
            this.txtCopiaCidade.Location = new System.Drawing.Point(235, 279);
            this.txtCopiaCidade.Name = "txtCopiaCidade";
            this.txtCopiaCidade.Size = new System.Drawing.Size(260, 31);
            this.txtCopiaCidade.TabIndex = 8;
            // 
            // txtCopiaIdade
            // 
            this.txtCopiaIdade.Location = new System.Drawing.Point(235, 316);
            this.txtCopiaIdade.Name = "txtCopiaIdade";
            this.txtCopiaIdade.Size = new System.Drawing.Size(260, 31);
            this.txtCopiaIdade.TabIndex = 9;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.Location = new System.Drawing.Point(543, 144);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(93, 36);
            this.btnCopiar.TabIndex = 10;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(543, 186);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(93, 35);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 405);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.txtCopiaIdade);
            this.Controls.Add(this.txtCopiaCidade);
            this.Controls.Add(this.txtCopiaEndereco);
            this.Controls.Add(this.txtCopiaNome);
            this.Controls.Add(this.BtnMensagem);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula de Formulário";
            this.Load += new System.EventHandler(this.frmFormulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button BtnMensagem;
        private System.Windows.Forms.TextBox txtCopiaNome;
        private System.Windows.Forms.TextBox txtCopiaEndereco;
        private System.Windows.Forms.TextBox txtCopiaCidade;
        private System.Windows.Forms.TextBox txtCopiaIdade;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

