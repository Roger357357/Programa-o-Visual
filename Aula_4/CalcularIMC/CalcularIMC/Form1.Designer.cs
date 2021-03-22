namespace CalcularIMC
{
    partial class FrmCalculoIMC
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grpIndiceMassaCorporal = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.grpPesoIdeal = new System.Windows.Forms.GroupBox();
            this.lblPesoMaximo = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblPesoMinimo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.grpIndiceMassaCorporal.SuspendLayout();
            this.grpPesoIdeal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.ForeColor = System.Drawing.Color.Lime;
            this.lblPeso.Location = new System.Drawing.Point(39, 37);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(45, 20);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.ForeColor = System.Drawing.Color.Lime;
            this.lblAltura.Location = new System.Drawing.Point(39, 95);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 20);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(107, 34);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(113, 26);
            this.txtPeso.TabIndex = 2;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(107, 92);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(113, 26);
            this.txtAltura.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(78, 151);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(89, 33);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grpIndiceMassaCorporal
            // 
            this.grpIndiceMassaCorporal.Controls.Add(this.lblSituacao);
            this.grpIndiceMassaCorporal.Controls.Add(this.lblResultado);
            this.grpIndiceMassaCorporal.Location = new System.Drawing.Point(283, 18);
            this.grpIndiceMassaCorporal.Name = "grpIndiceMassaCorporal";
            this.grpIndiceMassaCorporal.Size = new System.Drawing.Size(329, 100);
            this.grpIndiceMassaCorporal.TabIndex = 5;
            this.grpIndiceMassaCorporal.TabStop = false;
            this.grpIndiceMassaCorporal.Text = "Índice de Massa Corporal";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.BackColor = System.Drawing.SystemColors.Control;
            this.lblSituacao.ForeColor = System.Drawing.Color.Lime;
            this.lblSituacao.Location = new System.Drawing.Point(149, 60);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(72, 20);
            this.lblSituacao.TabIndex = 1;
            this.lblSituacao.Text = "Situação";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Lime;
            this.lblResultado.Location = new System.Drawing.Point(24, 49);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(71, 33);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "IMC";
            // 
            // grpPesoIdeal
            // 
            this.grpPesoIdeal.Controls.Add(this.lblPesoMaximo);
            this.grpPesoIdeal.Controls.Add(this.lblMaximo);
            this.grpPesoIdeal.Controls.Add(this.lblPesoMinimo);
            this.grpPesoIdeal.Controls.Add(this.lblMinimo);
            this.grpPesoIdeal.Location = new System.Drawing.Point(283, 151);
            this.grpPesoIdeal.Name = "grpPesoIdeal";
            this.grpPesoIdeal.Size = new System.Drawing.Size(329, 135);
            this.grpPesoIdeal.TabIndex = 6;
            this.grpPesoIdeal.TabStop = false;
            this.grpPesoIdeal.Text = "Seu Peso Ideal";
            // 
            // lblPesoMaximo
            // 
            this.lblPesoMaximo.AutoSize = true;
            this.lblPesoMaximo.ForeColor = System.Drawing.Color.Lime;
            this.lblPesoMaximo.Location = new System.Drawing.Point(170, 82);
            this.lblPesoMaximo.Name = "lblPesoMaximo";
            this.lblPesoMaximo.Size = new System.Drawing.Size(51, 20);
            this.lblPesoMaximo.TabIndex = 5;
            this.lblPesoMaximo.Text = "label6";
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.ForeColor = System.Drawing.Color.Lime;
            this.lblMaximo.Location = new System.Drawing.Point(26, 82);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(63, 20);
            this.lblMaximo.TabIndex = 4;
            this.lblMaximo.Text = "Máximo";
            // 
            // lblPesoMinimo
            // 
            this.lblPesoMinimo.AutoSize = true;
            this.lblPesoMinimo.ForeColor = System.Drawing.Color.Lime;
            this.lblPesoMinimo.Location = new System.Drawing.Point(170, 38);
            this.lblPesoMinimo.Name = "lblPesoMinimo";
            this.lblPesoMinimo.Size = new System.Drawing.Size(51, 20);
            this.lblPesoMinimo.TabIndex = 3;
            this.lblPesoMinimo.Text = "label4";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.ForeColor = System.Drawing.Color.Lime;
            this.lblMinimo.Location = new System.Drawing.Point(26, 38);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(59, 20);
            this.lblMinimo.TabIndex = 2;
            this.lblMinimo.Text = "Mínimo";
            // 
            // FrmCalculoIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 320);
            this.Controls.Add(this.grpPesoIdeal);
            this.Controls.Add(this.grpIndiceMassaCorporal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCalculoIMC";
            this.Text = "Cálculo do IMC";
            this.grpIndiceMassaCorporal.ResumeLayout(false);
            this.grpIndiceMassaCorporal.PerformLayout();
            this.grpPesoIdeal.ResumeLayout(false);
            this.grpPesoIdeal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grpIndiceMassaCorporal;
        private System.Windows.Forms.GroupBox grpPesoIdeal;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPesoMaximo;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblPesoMinimo;
        private System.Windows.Forms.Label lblMinimo;
    }
}

