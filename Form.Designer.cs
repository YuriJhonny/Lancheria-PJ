using System;

namespace WindowsForms
{
    partial class Form1
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
            this.Localização = new System.Windows.Forms.ComboBox();
            this.Dias = new System.Windows.Forms.NumericUpDown();
            this.Loja = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loja)).BeginInit();
            this.SuspendLayout();
            // 
            // Localização
            // 
            this.Localização.FormattingEnabled = true;
            this.Localização.Items.AddRange(new object[] {
            "Caxias do Sul",
            "Flores da Cunha"});
            this.Localização.Location = new System.Drawing.Point(102, 186);
            this.Localização.Name = "Localização";
            this.Localização.Size = new System.Drawing.Size(121, 24);
            this.Localização.TabIndex = 0;
            this.Localização.Text = "Cidade";
            this.Localização.SelectedIndexChanged += new System.EventHandler(this.Localizacao_SelectedIndexChanged);
            // 
            // Dias
            // 
            this.Dias.Location = new System.Drawing.Point(304, 186);
            this.Dias.Name = "Dias";
            this.Dias.Size = new System.Drawing.Size(120, 22);
            this.Dias.TabIndex = 1;
            this.Dias.ValueChanged += new System.EventHandler(this.Dias_ValueChanged);
            // 
            // Loja
            // 
            this.Loja.Location = new System.Drawing.Point(304, 238);
            this.Loja.Name = "Loja";
            this.Loja.Size = new System.Drawing.Size(120, 22);
            this.Loja.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cidade";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(254, 188);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(35, 16);
            this.lblDias.TabIndex = 4;
            this.lblDias.Text = "Dias";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loja);
            this.Controls.Add(this.Dias);
            this.Controls.Add(this.Localização);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Dias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Dias_ValueChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ComboBox Localização;
        private System.Windows.Forms.NumericUpDown Dias;
        private System.Windows.Forms.NumericUpDown Loja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDias;
    }
}

