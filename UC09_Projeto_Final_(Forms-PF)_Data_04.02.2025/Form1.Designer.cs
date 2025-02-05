namespace UC09_Projeto_Final__Forms_PF__Data_04._02._2025
{
    partial class frmFormsPf
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
            this.btnPedir = new System.Windows.Forms.Button();
            this.lvDados = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnPedir
            // 
            this.btnPedir.Location = new System.Drawing.Point(12, 353);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(304, 40);
            this.btnPedir.TabIndex = 1;
            this.btnPedir.Text = "Pedir";
            this.btnPedir.UseVisualStyleBackColor = true;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // lvDados
            // 
            this.lvDados.HideSelection = false;
            this.lvDados.Location = new System.Drawing.Point(12, 12);
            this.lvDados.Name = "lvDados";
            this.lvDados.Size = new System.Drawing.Size(776, 335);
            this.lvDados.TabIndex = 2;
            this.lvDados.UseCompatibleStateImageBehavior = false;
            // 
            // frmFormsPf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.lvDados);
            this.Controls.Add(this.btnPedir);
            this.Name = "frmFormsPf";
            this.Text = "Forms - Pf";
            this.Load += new System.EventHandler(this.frmFormsPf_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPedir;
        private System.Windows.Forms.ListView lvDados;
    }
}

