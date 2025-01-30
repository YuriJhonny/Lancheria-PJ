namespace Lancheria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            label6 = new Label();
            numericUpDown2 = new NumericUpDown();
            label7 = new Label();
            numericUpDown3 = new NumericUpDown();
            button2 = new Button();
            numericUpDown4 = new NumericUpDown();
            label8 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(145, 9);
            label1.Name = "label1";
            label1.Size = new Size(494, 37);
            label1.TabIndex = 0;
            label1.Text = "Estoque para as lancherias Pato Donalds";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "LancheEscolha";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "X Bacon", "X Pato", "X Hamburguer" });
            comboBox1.Location = new Point(111, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Escolha o Lanche";
            // 
            // button1
            // 
            button1.Location = new Point(245, 60);
            button1.Name = "button1";
            button1.Size = new Size(70, 52);
            button1.TabIndex = 3;
            button1.Text = "Escolher";
            button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(112, 89);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 5;
            label2.Text = "Lanche:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 6;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(419, 58);
            label4.Name = "label4";
            label4.Size = new Size(318, 21);
            label4.TabIndex = 7;
            label4.Text = "Quantidade de Lanches Restantes para Fazer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 128);
            label5.Name = "label5";
            label5.Size = new Size(135, 21);
            label5.TabIndex = 9;
            label5.Text = "Produtos em Falta";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 161);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "X-Bacon";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(12, 186);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(62, 19);
            checkBox4.TabIndex = 13;
            checkBox4.Text = "X-Pato";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(12, 211);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(106, 19);
            checkBox7.TabIndex = 16;
            checkBox7.Text = "X-Hamburguer";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(124, 190);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(55, 19);
            checkBox11.TabIndex = 20;
            checkBox11.Text = "Fanta";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(124, 161);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(59, 19);
            checkBox12.TabIndex = 21;
            checkBox12.Text = "Limão";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point(124, 219);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(70, 19);
            checkBox13.TabIndex = 22;
            checkBox13.Text = "Guaraná";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point(12, 236);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(80, 19);
            checkBox14.TabIndex = 23;
            checkBox14.Text = "Coca Cola";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 168);
            label6.Name = "label6";
            label6.Size = new Size(134, 15);
            label6.TabIndex = 25;
            label6.Text = "Quantidade em Estoque";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(360, 191);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(101, 23);
            numericUpDown2.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(483, 169);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 27;
            label7.Text = "Pedir para Estoque";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(479, 191);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(109, 23);
            numericUpDown3.TabIndex = 28;
            // 
            // button2
            // 
            button2.Location = new Point(497, 219);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 29;
            button2.Text = "Pedir";
            button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(530, 89);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(109, 23);
            numericUpDown4.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(595, 168);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 31;
            label8.Text = "Tempo de Entrega";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(595, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 23);
            textBox1.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(245, 164);
            label9.Name = "label9";
            label9.Size = new Size(58, 21);
            label9.TabIndex = 33;
            label9.Text = "Outros";
            // 
            // comboBox2
            // 
            comboBox2.AccessibleName = "LancheEscolha";
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Bacon", "Hamburguer", "Pato", "Presunto", "Queijo", "Tomate", "Alface", "Picles", "Ovo" });
            comboBox2.Location = new Point(214, 190);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 34;
            comboBox2.Text = "Escolha o Produto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 280);
            Controls.Add(comboBox2);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(numericUpDown4);
            Controls.Add(button2);
            Controls.Add(numericUpDown3);
            Controls.Add(label7);
            Controls.Add(numericUpDown2);
            Controls.Add(label6);
            Controls.Add(checkBox14);
            Controls.Add(checkBox13);
            Controls.Add(checkBox12);
            Controls.Add(checkBox11);
            Controls.Add(checkBox7);
            Controls.Add(checkBox4);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox7;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private Label label6;
        private NumericUpDown numericUpDown2;
        private Label label7;
        private NumericUpDown numericUpDown3;
        private Button button2;
        private NumericUpDown numericUpDown4;
        private Label label8;
        private TextBox textBox1;
        private Label label9;
        private ComboBox comboBox2;
    }
}
