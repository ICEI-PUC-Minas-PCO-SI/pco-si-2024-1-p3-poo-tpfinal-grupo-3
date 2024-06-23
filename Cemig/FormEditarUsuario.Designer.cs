namespace Cemig
{
    partial class FormEditarUsuario
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            altSenha = new Button();
            label11 = new Label();
            label12 = new Label();
            maksCpf = new MaskedTextBox();
            maskCnpj = new MaskedTextBox();
            maskCep = new MaskedTextBox();
            cmbSexo = new ComboBox();
            txtEndereco = new TextBox();
            txtBairro = new TextBox();
            txtMunicipio = new TextBox();
            txtAltSenha = new TextBox();
            txtRepSenha = new TextBox();
            txtNum = new TextBox();
            txtEstado = new TextBox();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.user;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(322, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 95);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 149);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 147);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 2;
            label1.Text = "Nome :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 188);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 2;
            label2.Text = "CPF :";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 231);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 2;
            label3.Text = "CNPJ :";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 270);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 2;
            label4.Text = "Sexo :";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 310);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 2;
            label5.Text = "CEP :";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 348);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 2;
            label6.Text = "Endereço :";
            label6.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 385);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 2;
            label7.Text = "Bairro :";
            label7.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 423);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 2;
            label8.Text = "Municipio :";
            label8.Click += label1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(470, 242);
            label9.Name = "label9";
            label9.Size = new Size(108, 21);
            label9.TabIndex = 2;
            label9.Text = "Repita Senha :";
            label9.Click += label1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(470, 188);
            label10.Name = "label10";
            label10.Size = new Size(101, 21);
            label10.TabIndex = 2;
            label10.Text = "Senha Nova :";
            label10.Click += label1_Click;
            // 
            // altSenha
            // 
            altSenha.BackColor = Color.White;
            altSenha.Location = new Point(599, 288);
            altSenha.Margin = new Padding(0);
            altSenha.Name = "altSenha";
            altSenha.Size = new Size(86, 34);
            altSenha.TabIndex = 3;
            altSenha.Text = "ALTERAR";
            altSenha.UseVisualStyleBackColor = false;
            altSenha.Click += altSenha_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(470, 348);
            label11.Name = "label11";
            label11.Size = new Size(75, 21);
            label11.TabIndex = 2;
            label11.Text = "Número :";
            label11.Click += label1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(470, 385);
            label12.Name = "label12";
            label12.Size = new Size(63, 21);
            label12.TabIndex = 2;
            label12.Text = "Estado :";
            label12.Click += label1_Click;
            // 
            // maksCpf
            // 
            maksCpf.Enabled = false;
            maksCpf.Location = new Point(99, 190);
            maksCpf.Mask = "000.000.000-00";
            maksCpf.Name = "maksCpf";
            maksCpf.Size = new Size(83, 23);
            maksCpf.TabIndex = 2;
            maksCpf.MaskInputRejected += maksCpf_MaskInputRejected;
            // 
            // maskCnpj
            // 
            maskCnpj.Enabled = false;
            maskCnpj.Location = new Point(99, 233);
            maskCnpj.Mask = "00.000.000/0000-00";
            maskCnpj.Name = "maskCnpj";
            maskCnpj.Size = new Size(100, 23);
            maskCnpj.TabIndex = 3;
            maskCnpj.MaskInputRejected += maskCnpj_MaskInputRejected;
            // 
            // maskCep
            // 
            maskCep.Location = new Point(99, 312);
            maskCep.Mask = "00000-000";
            maskCep.Name = "maskCep";
            maskCep.Size = new Size(127, 23);
            maskCep.TabIndex = 5;
            maskCep.TextAlign = HorizontalAlignment.Center;
            maskCep.MaskInputRejected += maskCep_MaskInputRejected;
            // 
            // cmbSexo
            // 
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.FlatStyle = FlatStyle.Flat;
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Feminino", "Masculino" });
            cmbSexo.Location = new Point(99, 272);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(121, 23);
            cmbSexo.TabIndex = 4;
            cmbSexo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(99, 346);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(127, 23);
            txtEndereco.TabIndex = 6;
            txtEndereco.TextChanged += txtEndereco_TextChanged;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(99, 383);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(127, 23);
            txtBairro.TabIndex = 8;
            txtBairro.TextChanged += txtBairro_TextChanged;
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(99, 423);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(122, 23);
            txtMunicipio.TabIndex = 10;
            txtMunicipio.TextChanged += txtMunicipio_TextChanged;
            // 
            // txtAltSenha
            // 
            txtAltSenha.Location = new Point(577, 190);
            txtAltSenha.Name = "txtAltSenha";
            txtAltSenha.Size = new Size(132, 23);
            txtAltSenha.TabIndex = 12;
            txtAltSenha.TextChanged += txtAltSenha_TextChanged;
            // 
            // txtRepSenha
            // 
            txtRepSenha.Location = new Point(577, 244);
            txtRepSenha.Name = "txtRepSenha";
            txtRepSenha.Size = new Size(132, 23);
            txtRepSenha.TabIndex = 13;
            txtRepSenha.TextChanged += txtRepSenha_TextChanged;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(578, 346);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(131, 23);
            txtNum.TabIndex = 7;
            txtNum.TextChanged += txtNum_TextChanged;
            // 
            // txtEstado
            // 
            txtEstado.CharacterCasing = CharacterCasing.Upper;
            txtEstado.Location = new Point(577, 387);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(131, 23);
            txtEstado.TabIndex = 9;
            txtEstado.TextChanged += txtEstado_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(312, 413);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 44);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FormEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo_POO;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 469);
            Controls.Add(btnSalvar);
            Controls.Add(txtEstado);
            Controls.Add(txtNum);
            Controls.Add(txtRepSenha);
            Controls.Add(txtAltSenha);
            Controls.Add(txtMunicipio);
            Controls.Add(txtBairro);
            Controls.Add(txtEndereco);
            Controls.Add(cmbSexo);
            Controls.Add(maskCep);
            Controls.Add(maskCnpj);
            Controls.Add(maksCpf);
            Controls.Add(altSenha);
            Controls.Add(label8);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "FormEditarUsuario";
            Text = "FormEditarUsuario";
            TransparencyKey = Color.Lime;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button altSenha;
        private Label label11;
        private Label label12;
        private MaskedTextBox maksCpf;
        private MaskedTextBox maskCnpj;
        private MaskedTextBox maskCep;
        private ComboBox cmbSexo;
        private TextBox txtEndereco;
        private TextBox txtBairro;
        private TextBox txtMunicipio;
        private TextBox txtAltSenha;
        private TextBox txtRepSenha;
        private TextBox txtNum;
        private TextBox txtEstado;
        private Button btnSalvar;
    }
}