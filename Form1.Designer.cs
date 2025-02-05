namespace Projeto_Pedir
{
    partial class frmFormsPedido
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
            this.clbPedidoRapido = new System.Windows.Forms.CheckedListBox();
            this.lbIngre = new System.Windows.Forms.Label();
            this.clbIngredientes = new System.Windows.Forms.CheckedListBox();
            this.clbBebidas = new System.Windows.Forms.CheckedListBox();
            this.lbPedido = new System.Windows.Forms.Label();
            this.lbBebidas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPedir
            // 
            this.btnPedir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPedir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedir.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedir.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPedir.Location = new System.Drawing.Point(805, 454);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(207, 124);
            this.btnPedir.TabIndex = 0;
            this.btnPedir.Text = "Pedir";
            this.btnPedir.UseVisualStyleBackColor = false;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // clbPedidoRapido
            // 
            this.clbPedidoRapido.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.clbPedidoRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbPedidoRapido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clbPedidoRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbPedidoRapido.FormattingEnabled = true;
            this.clbPedidoRapido.Items.AddRange(new object[] {
            "Hamburguer",
            "X Bacon",
            "X Pato"});
            this.clbPedidoRapido.Location = new System.Drawing.Point(352, 213);
            this.clbPedidoRapido.Name = "clbPedidoRapido";
            this.clbPedidoRapido.Size = new System.Drawing.Size(208, 386);
            this.clbPedidoRapido.TabIndex = 1;
            this.clbPedidoRapido.SelectedIndexChanged += new System.EventHandler(this.clbPedidoRapido_SelectedIndexChanged);
            // 
            // lbIngre
            // 
            this.lbIngre.AutoSize = true;
            this.lbIngre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbIngre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbIngre.Location = new System.Drawing.Point(124, 173);
            this.lbIngre.Name = "lbIngre";
            this.lbIngre.Size = new System.Drawing.Size(191, 37);
            this.lbIngre.TabIndex = 2;
            this.lbIngre.Text = "Ingredientes";
            // 
            // clbIngredientes
            // 
            this.clbIngredientes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.clbIngredientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbIngredientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clbIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbIngredientes.FormattingEnabled = true;
            this.clbIngredientes.Items.AddRange(new object[] {
            "Pão",
            "Carne",
            "Milho",
            "Ervilha",
            "Alface",
            "Tomate",
            "Ovo",
            "Bacon",
            "Óleo",
            "Tempero verde"});
            this.clbIngredientes.Location = new System.Drawing.Point(124, 213);
            this.clbIngredientes.Name = "clbIngredientes";
            this.clbIngredientes.Size = new System.Drawing.Size(208, 386);
            this.clbIngredientes.TabIndex = 3;
            this.clbIngredientes.SelectedIndexChanged += new System.EventHandler(this.clbIngredientes_SelectedIndexChanged);
            // 
            // clbBebidas
            // 
            this.clbBebidas.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.clbBebidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbBebidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clbBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbBebidas.FormattingEnabled = true;
            this.clbBebidas.Items.AddRange(new object[] {
            "Coca-Cola",
            "Sprit",
            "Guarana",
            "Pepsi",
            "Água"});
            this.clbBebidas.Location = new System.Drawing.Point(578, 213);
            this.clbBebidas.Name = "clbBebidas";
            this.clbBebidas.Size = new System.Drawing.Size(208, 386);
            this.clbBebidas.TabIndex = 4;
            this.clbBebidas.SelectedIndexChanged += new System.EventHandler(this.clbBebidas_SelectedIndexChanged);
            // 
            // lbPedido
            // 
            this.lbPedido.AutoSize = true;
            this.lbPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedido.Location = new System.Drawing.Point(345, 173);
            this.lbPedido.Name = "lbPedido";
            this.lbPedido.Size = new System.Drawing.Size(215, 37);
            this.lbPedido.TabIndex = 10;
            this.lbPedido.Text = "Pedido rapido";
            // 
            // lbBebidas
            // 
            this.lbBebidas.AutoSize = true;
            this.lbBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBebidas.Location = new System.Drawing.Point(587, 173);
            this.lbBebidas.Name = "lbBebidas";
            this.lbBebidas.Size = new System.Drawing.Size(132, 37);
            this.lbBebidas.TabIndex = 11;
            this.lbBebidas.Text = "Bebidas";
            // 
            // frmFormsPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 624);
            this.Controls.Add(this.lbBebidas);
            this.Controls.Add(this.lbPedido);
            this.Controls.Add(this.clbBebidas);
            this.Controls.Add(this.clbIngredientes);
            this.Controls.Add(this.lbIngre);
            this.Controls.Add(this.clbPedidoRapido);
            this.Controls.Add(this.btnPedir);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "frmFormsPedido";
            this.Text = "Forms - Pedido";
            this.Load += new System.EventHandler(this.frmFormsPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPedir;
        private System.Windows.Forms.CheckedListBox clbPedidoRapido;
        private System.Windows.Forms.Label lbIngre;
        private System.Windows.Forms.CheckedListBox clbIngredientes;
        private System.Windows.Forms.CheckedListBox clbBebidas;
        private System.Windows.Forms.Label lbPedido;
        private System.Windows.Forms.Label lbBebidas;
    }
}

