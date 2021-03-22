namespace Aula_5
{
    partial class frmSwitch
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
            this.lblDia = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.picSemana = new System.Windows.Forms.PictureBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSemana)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(34, 38);
            this.lblDia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(47, 24);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Dia: ";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(93, 35);
            this.txtDia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(64, 29);
            this.txtDia.TabIndex = 1;
            this.txtDia.TextChanged += new System.EventHandler(this.txtDia_TextChanged);
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(277, 38);
            this.lblDiaSemana.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(16, 24);
            this.lblDiaSemana.TabIndex = 2;
            this.lblDiaSemana.Text = "-";
            // 
            // picSemana
            // 
            this.picSemana.Location = new System.Drawing.Point(12, 98);
            this.picSemana.Name = "picSemana";
            this.picSemana.Size = new System.Drawing.Size(563, 219);
            this.picSemana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSemana.TabIndex = 3;
            this.picSemana.TabStop = false;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(500, 33);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 34);
            this.btnSwitch.TabIndex = 4;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // frmSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 329);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.picSemana);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblDia);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmSwitch";
            this.Text = "Exemplos de Switch";
            ((System.ComponentModel.ISupportInitialize)(this.picSemana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.PictureBox picSemana;
        private System.Windows.Forms.Button btnSwitch;
    }
}

