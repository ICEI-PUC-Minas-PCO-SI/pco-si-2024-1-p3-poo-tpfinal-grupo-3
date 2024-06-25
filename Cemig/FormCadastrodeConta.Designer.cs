namespace Cemig
{
    partial class FormCadastrodeConta
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            nresgistro = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Valor = new TextBox();
            cadastrar = new Button();
            pessoaFis = new RadioButton();
            pessoaJur = new RadioButton();
            label4 = new Label();
            txtCpfCnpj = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            maskConsumo = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.checklist;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(24, 28);
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
            label1.Font = new Font("Arial", 20.25F);
            label1.Location = new Point(300, 20);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 2;
            label1.Text = "Cadastro de Conta";
            label1.Click += label1_Click;
            // 
            // nresgistro
            // 
            nresgistro.Location = new Point(364, 136);
            nresgistro.Name = "nresgistro";
            nresgistro.PlaceholderText = "XXXXXXXXXXXX";
            nresgistro.Size = new Size(200, 23);
            nresgistro.TabIndex = 5;
            nresgistro.TextChanged += nresgistro_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(260, 137);
            label2.Name = "label2";
            label2.Size = new Size(106, 17);
            label2.TabIndex = 6;
            label2.Text = "Nº de Registro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(288, 186);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 7;
            label3.Text = "Valor:";
            // 
            // Valor
            // 
            Valor.Location = new Point(364, 186);
            Valor.Name = "Valor";
            Valor.PlaceholderText = "Valor mês atual";
            Valor.Size = new Size(200, 23);
            Valor.TabIndex = 8;
            Valor.TextChanged += textBox2_TextChanged_1;
            // 
            // cadastrar
            // 
            cadastrar.BackColor = Color.FromArgb(0, 122, 204);
            cadastrar.FlatStyle = FlatStyle.Flat;
            cadastrar.Font = new Font("Arial", 12F);
            cadastrar.ForeColor = Color.White;
            cadastrar.Location = new Point(364, 299);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(200, 40);
            cadastrar.TabIndex = 13;
            cadastrar.Text = "Cadastrar";
            cadastrar.UseVisualStyleBackColor = false;
            cadastrar.Click += cadastrar_Click;
            // 
            // pessoaFis
            // 
            pessoaFis.AutoSize = true;
            pessoaFis.BackColor = Color.Transparent;
            pessoaFis.Font = new Font("Arial", 11.25F);
            pessoaFis.Location = new Point(295, 53);
            pessoaFis.Name = "pessoaFis";
            pessoaFis.Size = new Size(119, 21);
            pessoaFis.TabIndex = 14;
            pessoaFis.TabStop = true;
            pessoaFis.Text = "Pessoa Fisica";
            pessoaFis.UseVisualStyleBackColor = false;
            pessoaFis.CheckedChanged += pessoaFis_CheckedChanged;
            // 
            // pessoaJur
            // 
            pessoaJur.AutoSize = true;
            pessoaJur.BackColor = Color.Transparent;
            pessoaJur.Font = new Font("Arial", 11.25F);
            pessoaJur.Location = new Point(407, 53);
            pessoaJur.Name = "pessoaJur";
            pessoaJur.Size = new Size(130, 21);
            pessoaJur.TabIndex = 15;
            pessoaJur.TabStop = true;
            pessoaJur.Text = "Pessoa Juridica";
            pessoaJur.UseVisualStyleBackColor = false;
            pessoaJur.CheckedChanged += pessoaJur_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 11.25F);
            label4.Location = new Point(238, 89);
            label4.Name = "label4";
            label4.Size = new Size(84, 17);
            label4.TabIndex = 17;
            label4.Text = "CPF/CNPJ:";
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(323, 84);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(241, 23);
            txtCpfCnpj.TabIndex = 18;
            txtCpfCnpj.MaskInputRejected += txtCpfCnpj_MaskInputRejected;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 9.75F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(107, 16);
            label5.TabIndex = 19;
            label5.Text = "Consultar Contas";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 11.25F);
            label6.Location = new Point(260, 231);
            label6.Name = "label6";
            label6.Size = new Size(76, 17);
            label6.TabIndex = 7;
            label6.Text = "Consumo:";
            // 
            // maskConsumo
            // 
            maskConsumo.Location = new Point(364, 231);
            maskConsumo.Mask = "0000";
            maskConsumo.Name = "maskConsumo";
            maskConsumo.Size = new Size(200, 23);
            maskConsumo.TabIndex = 20;
            maskConsumo.MaskInputRejected += maskConsumo_MaskInputRejected;
            // 
            // FormCadastrodeConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(maskConsumo);
            Controls.Add(label5);
            Controls.Add(txtCpfCnpj);
            Controls.Add(label4);
            Controls.Add(pessoaJur);
            Controls.Add(pessoaFis);
            Controls.Add(cadastrar);
            Controls.Add(Valor);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nresgistro);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormCadastrodeConta";
            Text = "Cadastro de Conta";
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
        private Button cadastrar;
        private RadioButton pessoaFis;
        private RadioButton pessoaJur;
        private Label label4;
        private MaskedTextBox txtCpfCnpj;
        private Label label5;
        private Label label6;
        private MaskedTextBox maskConsumo;
    }
}
