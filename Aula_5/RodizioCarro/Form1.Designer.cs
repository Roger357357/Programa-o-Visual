namespace RodizioCarro
{
    partial class frmRodizio
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
            this.grpPlaca = new System.Windows.Forms.GroupBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lblSemana = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.btnLicenciar = new System.Windows.Forms.Button();
            this.grpPlaca.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPlaca
            // 
            this.grpPlaca.Controls.Add(this.btnLicenciar);
            this.grpPlaca.Controls.Add(this.lblHorario);
            this.grpPlaca.Controls.Add(this.lblSemana);
            this.grpPlaca.Controls.Add(this.btnVerifica);
            this.grpPlaca.Controls.Add(this.txtPlaca);
            this.grpPlaca.Controls.Add(this.lblPlaca);
            this.grpPlaca.Location = new System.Drawing.Point(15, 15);
            this.grpPlaca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpPlaca.Name = "grpPlaca";
            this.grpPlaca.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpPlaca.Size = new System.Drawing.Size(409, 164);
            this.grpPlaca.TabIndex = 0;
            this.grpPlaca.TabStop = false;
            this.grpPlaca.Text = "Dados Veículos";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(24, 46);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(112, 20);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Final da Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(142, 43);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 26);
            this.txtPlaca.TabIndex = 1;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifica.Location = new System.Drawing.Point(299, 22);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(83, 30);
            this.btnVerifica.TabIndex = 2;
            this.btnVerifica.Text = "Rodízio";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemana.Location = new System.Drawing.Point(24, 96);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(51, 20);
            this.lblSemana.TabIndex = 3;
            this.lblSemana.Text = "label1";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(236, 96);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(146, 40);
            this.lblHorario.TabIndex = 4;
            this.lblHorario.Text = "Horário: 7h até 10h\r\n             17h até 20h\r\n";
            // 
            // btnLicenciar
            // 
            this.btnLicenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicenciar.Location = new System.Drawing.Point(299, 58);
            this.btnLicenciar.Name = "btnLicenciar";
            this.btnLicenciar.Size = new System.Drawing.Size(83, 30);
            this.btnLicenciar.TabIndex = 5;
            this.btnLicenciar.Text = "Licenciar";
            this.btnLicenciar.UseVisualStyleBackColor = true;
            this.btnLicenciar.Click += new System.EventHandler(this.btnLicenciar_Click);
            // 
            // frmRodizio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 194);
            this.Controls.Add(this.grpPlaca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmRodizio";
            this.Text = "Rodízio de Carro";
            this.grpPlaca.ResumeLayout(false);
            this.grpPlaca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlaca;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button btnLicenciar;
    }
}

