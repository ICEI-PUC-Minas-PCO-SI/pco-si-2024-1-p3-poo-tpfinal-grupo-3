namespace Cemig
{
    partial class FormCadastrodeConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            nresgistro = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Valor = new TextBox();
            cpfBox = new TextBox();
            cnpjBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.checklist;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 53);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poor Richard", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 9);
            label1.Name = "label1";
            label1.Size = new Size(201, 31);
            label1.TabIndex = 2;
            label1.Text = "Cadastro de Conta";
            label1.Click += label1_Click;
            // 
            // nresgistro
            // 
            nresgistro.Location = new Point(364, 136);
            nresgistro.Name = "nresgistro";
            nresgistro.PlaceholderText = "XXXXXXXXXXXX";
            nresgistro.Size = new Size(125, 23);
            nresgistro.TabIndex = 5;
            nresgistro.TextChanged += nresgistro_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poor Richard", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(260, 137);
            label2.Name = "label2";
            label2.Size = new Size(94, 18);
            label2.TabIndex = 6;
            label2.Text = "Nº de Registro :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poor Richard", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(288, 186);
            label3.Name = "label3";
            label3.Size = new Size(46, 18);
            label3.TabIndex = 7;
            label3.Text = "Valor :";
            // 
            // Valor
            // 
            Valor.Location = new Point(364, 186);
            Valor.Name = "Valor";
            Valor.PlaceholderText = "Valor mês atual";
            Valor.Size = new Size(125, 23);
            Valor.TabIndex = 8;
            Valor.TextChanged += textBox2_TextChanged_1;
            // 
            // cpfBox
            // 
            cpfBox.Location = new Point(278, 74);
            cpfBox.Name = "cpfBox";
            cpfBox.PlaceholderText = "Digite seu CPF";
            cpfBox.Size = new Size(100, 23);
            cpfBox.TabIndex = 9;
            // 
            // cnpjBox
            // 
            cnpjBox.Location = new Point(458, 75);
            cnpjBox.Name = "cnpjBox";
            cnpjBox.PlaceholderText = "Digite seu CNPJ";
            cnpjBox.Size = new Size(100, 23);
            cnpjBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poor Richard", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(235, 75);
            label4.Name = "label4";
            label4.Size = new Size(37, 18);
            label4.TabIndex = 11;
            label4.Text = "CPF :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Poor Richard", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(394, 75);
            label5.Name = "label5";
            label5.Size = new Size(46, 18);
            label5.TabIndex = 12;
            label5.Text = "CNPJ :";
            // 
            // cadastrar
            // 
            cadastrar.BackColor = SystemColors.Control;
            cadastrar.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastrar.Location = new Point(323, 299);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(138, 44);
            cadastrar.TabIndex = 13;
            cadastrar.Text = "Cadastrar";
            cadastrar.UseVisualStyleBackColor = false;
            cadastrar.Click += cadastrar_Click;
            // 
            // FormCadastrodeConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo_POO;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(cadastrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cnpjBox);
            Controls.Add(cpfBox);
            Controls.Add(Valor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nresgistro);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormCadastrodeConta";
            Text = "FormCadastrodeConta";
            Load += FormCadastrodeConta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox nresgistro;
        private Label label2;
        private Label label3;
        private TextBox Valor;
        private TextBox cpfBox;
        private TextBox cnpjBox;
        private Label label4;
        private Label label5;
        private Button cadastrar;
    }
}