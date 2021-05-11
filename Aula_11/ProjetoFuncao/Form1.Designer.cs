namespace ProjetoFuncao
{
    partial class frmFuncao
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
            this.lblvalorA = new System.Windows.Forms.Label();
            this.lblvalorB = new System.Windows.Forms.Label();
            this.lblMaior = new System.Windows.Forms.Label();
            this.txtvalorA = new System.Windows.Forms.TextBox();
            this.txtvalorB = new System.Windows.Forms.TextBox();
            this.txtMaior = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblReajuste = new System.Windows.Forms.Label();
            this.lblNovoSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtReajuste = new System.Windows.Forms.TextBox();
            this.txtNovoSalario = new System.Windows.Forms.TextBox();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.btnCalcularIMC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblvalorA
            // 
            this.lblvalorA.AutoSize = true;
            this.lblvalorA.Location = new System.Drawing.Point(23, 43);
            this.lblvalorA.Name = "lblvalorA";
            this.lblvalorA.Size = new System.Drawing.Size(20, 20);
            this.lblvalorA.TabIndex = 0;
            this.lblvalorA.Text = "A";
            // 
            // lblvalorB
            // 
            this.lblvalorB.AutoSize = true;
            this.lblvalorB.Location = new System.Drawing.Point(23, 84);
            this.lblvalorB.Name = "lblvalorB";
            this.lblvalorB.Size = new System.Drawing.Size(20, 20);
            this.lblvalorB.TabIndex = 1;
            this.lblvalorB.Text = "B";
            // 
            // lblMaior
            // 
            this.lblMaior.AutoSize = true;
            this.lblMaior.Location = new System.Drawing.Point(23, 123);
            this.lblMaior.Name = "lblMaior";
            this.lblMaior.Size = new System.Drawing.Size(48, 20);
            this.lblMaior.TabIndex = 2;
            this.lblMaior.Text = "Maior";
            // 
            // txtvalorA
            // 
            this.txtvalorA.Location = new System.Drawing.Point(80, 40);
            this.txtvalorA.Name = "txtvalorA";
            this.txtvalorA.Size = new System.Drawing.Size(132, 26);
            this.txtvalorA.TabIndex = 3;
            // 
            // txtvalorB
            // 
            this.txtvalorB.Location = new System.Drawing.Point(80, 81);
            this.txtvalorB.Name = "txtvalorB";
            this.txtvalorB.Size = new System.Drawing.Size(132, 26);
            this.txtvalorB.TabIndex = 4;
            // 
            // txtMaior
            // 
            this.txtMaior.Location = new System.Drawing.Point(80, 120);
            this.txtMaior.Name = "txtMaior";
            this.txtMaior.Size = new System.Drawing.Size(132, 26);
            this.txtMaior.TabIndex = 5;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(27, 163);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(75, 28);
            this.btnVerifica.TabIndex = 6;
            this.btnVerifica.Text = "Verificar";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(137, 163);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 28);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(273, 43);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(58, 20);
            this.lblSalario.TabIndex = 8;
            this.lblSalario.Text = "Salário";
            // 
            // lblReajuste
            // 
            this.lblReajuste.AutoSize = true;
            this.lblReajuste.Location = new System.Drawing.Point(273, 84);
            this.lblReajuste.Name = "lblReajuste";
            this.lblReajuste.Size = new System.Drawing.Size(73, 20);
            this.lblReajuste.TabIndex = 9;
            this.lblReajuste.Text = "Reajuste";
            // 
            // lblNovoSalario
            // 
            this.lblNovoSalario.AutoSize = true;
            this.lblNovoSalario.Location = new System.Drawing.Point(273, 123);
            this.lblNovoSalario.Name = "lblNovoSalario";
            this.lblNovoSalario.Size = new System.Drawing.Size(98, 20);
            this.lblNovoSalario.TabIndex = 10;
            this.lblNovoSalario.Text = "Novo Salário";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(380, 40);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 26);
            this.txtSalario.TabIndex = 11;
            // 
            // txtReajuste
            // 
            this.txtReajuste.Location = new System.Drawing.Point(380, 81);
            this.txtReajuste.Name = "txtReajuste";
            this.txtReajuste.Size = new System.Drawing.Size(100, 26);
            this.txtReajuste.TabIndex = 12;
            // 
            // txtNovoSalario
            // 
            this.txtNovoSalario.Location = new System.Drawing.Point(380, 120);
            this.txtNovoSalario.Name = "txtNovoSalario";
            this.txtNovoSalario.Size = new System.Drawing.Size(100, 26);
            this.txtNovoSalario.TabIndex = 13;
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Location = new System.Drawing.Point(342, 163);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(75, 28);
            this.btnCalcularSalario.TabIndex = 14;
            this.btnCalcularSalario.Text = "Calcular";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(23, 224);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(45, 20);
            this.lblPeso.TabIndex = 15;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(23, 256);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 20);
            this.lblAltura.TabIndex = 16;
            this.lblAltura.Text = "Altura";
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Location = new System.Drawing.Point(23, 290);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(38, 20);
            this.lblIMC.TabIndex = 17;
            this.lblIMC.Text = "IMC";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(23, 327);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(72, 20);
            this.lblSituacao.TabIndex = 18;
            this.lblSituacao.Text = "Situação";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(92, 221);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 26);
            this.txtPeso.TabIndex = 19;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(92, 253);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 26);
            this.txtAltura.TabIndex = 20;
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(92, 287);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(100, 26);
            this.txtIMC.TabIndex = 21;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(101, 324);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.ReadOnly = true;
            this.txtSituacao.Size = new System.Drawing.Size(230, 26);
            this.txtSituacao.TabIndex = 22;
            // 
            // btnCalcularIMC
            // 
            this.btnCalcularIMC.Location = new System.Drawing.Point(211, 219);
            this.btnCalcularIMC.Name = "btnCalcularIMC";
            this.btnCalcularIMC.Size = new System.Drawing.Size(120, 28);
            this.btnCalcularIMC.TabIndex = 23;
            this.btnCalcularIMC.Text = "Calcular IMC";
            this.btnCalcularIMC.UseVisualStyleBackColor = true;
            this.btnCalcularIMC.Click += new System.EventHandler(this.btnCalcularIMC_Click);
            // 
            // frmFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 381);
            this.Controls.Add(this.btnCalcularIMC);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.txtNovoSalario);
            this.Controls.Add(this.txtReajuste);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblNovoSalario);
            this.Controls.Add(this.lblReajuste);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtMaior);
            this.Controls.Add(this.txtvalorB);
            this.Controls.Add(this.txtvalorA);
            this.Controls.Add(this.lblMaior);
            this.Controls.Add(this.lblvalorB);
            this.Controls.Add(this.lblvalorA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFuncao";
            this.Text = "Exemplo de Função";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvalorA;
        private System.Windows.Forms.Label lblvalorB;
        private System.Windows.Forms.Label lblMaior;
        private System.Windows.Forms.TextBox txtvalorA;
        private System.Windows.Forms.TextBox txtvalorB;
        private System.Windows.Forms.TextBox txtMaior;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblReajuste;
        private System.Windows.Forms.Label lblNovoSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtReajuste;
        private System.Windows.Forms.TextBox txtNovoSalario;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Button btnCalcularIMC;
    }
}

