namespace ProjetoIMC
{
    partial class frmCalculaImc
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.Altura = new System.Windows.Forms.Label();
            this.lblImc = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnVetor = new System.Windows.Forms.Button();
            this.lstVetores = new System.Windows.Forms.ListBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtImc = new System.Windows.Forms.TextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(39, 44);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(45, 20);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.Location = new System.Drawing.Point(39, 85);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(51, 20);
            this.Altura.TabIndex = 1;
            this.Altura.Text = "Altura";
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Location = new System.Drawing.Point(39, 137);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(38, 20);
            this.lblImc.TabIndex = 2;
            this.lblImc.Text = "IMC";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(43, 221);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(85, 30);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnVetor
            // 
            this.btnVetor.Location = new System.Drawing.Point(134, 221);
            this.btnVetor.Name = "btnVetor";
            this.btnVetor.Size = new System.Drawing.Size(86, 30);
            this.btnVetor.TabIndex = 4;
            this.btnVetor.Text = "Ver Vetor";
            this.btnVetor.UseVisualStyleBackColor = true;
            this.btnVetor.Click += new System.EventHandler(this.btnVetor_Click);
            // 
            // lstVetores
            // 
            this.lstVetores.FormattingEnabled = true;
            this.lstVetores.ItemHeight = 20;
            this.lstVetores.Location = new System.Drawing.Point(270, 41);
            this.lstVetores.Name = "lstVetores";
            this.lstVetores.Size = new System.Drawing.Size(249, 224);
            this.lstVetores.TabIndex = 5;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(107, 41);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(113, 26);
            this.txtPeso.TabIndex = 6;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(107, 82);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(113, 26);
            this.txtAltura.TabIndex = 7;
            // 
            // txtImc
            // 
            this.txtImc.Location = new System.Drawing.Point(107, 134);
            this.txtImc.Name = "txtImc";
            this.txtImc.ReadOnly = true;
            this.txtImc.Size = new System.Drawing.Size(113, 26);
            this.txtImc.TabIndex = 8;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(39, 176);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(14, 20);
            this.lblSituacao.TabIndex = 9;
            this.lblSituacao.Text = "-";
            // 
            // frmCalculaImc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 300);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.txtImc);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lstVetores);
            this.Controls.Add(this.btnVetor);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.lblPeso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCalculaImc";
            this.Text = "Calculadora de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label Altura;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnVetor;
        private System.Windows.Forms.ListBox lstVetores;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtImc;
        private System.Windows.Forms.Label lblSituacao;
    }
}

