namespace WindowsFormsCadastro
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
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblQnd = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbBoxQnd = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QndFazer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QndHaver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(634, 104);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(121, 22);
            this.txtBoxNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(582, 110);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblQnd
            // 
            this.lblQnd.AutoSize = true;
            this.lblQnd.Location = new System.Drawing.Point(549, 173);
            this.lblQnd.Name = "lblQnd";
            this.lblQnd.Size = new System.Drawing.Size(80, 16);
            this.lblQnd.TabIndex = 2;
            this.lblQnd.Text = "Quantidade:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(591, 140);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 16);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo:";
            // 
            // cmbBoxQnd
            // 
            this.cmbBoxQnd.FormattingEnabled = true;
            this.cmbBoxQnd.Items.AddRange(new object[] {
            "bebida",
            "comida"});
            this.cmbBoxQnd.Location = new System.Drawing.Point(634, 132);
            this.cmbBoxQnd.Name = "cmbBoxQnd";
            this.cmbBoxQnd.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxQnd.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(635, 167);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.QndFazer,
            this.QndHaver});
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(504, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.Width = 125;
            // 
            // QndFazer
            // 
            this.QndFazer.HeaderText = "Qnd a Fazer";
            this.QndFazer.MinimumWidth = 6;
            this.QndFazer.Name = "QndFazer";
            this.QndFazer.Width = 125;
            // 
            // QndHaver
            // 
            this.QndHaver.HeaderText = "Qnd em Estoque";
            this.QndHaver.MinimumWidth = 6;
            this.QndHaver.Name = "QndHaver";
            this.QndHaver.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cmbBoxQnd);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblQnd);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtBoxNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblQnd;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbBoxQnd;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn QndFazer;
        private System.Windows.Forms.DataGridViewTextBoxColumn QndHaver;
    }
}

