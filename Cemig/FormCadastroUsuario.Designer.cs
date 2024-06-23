namespace Cemig
{
    partial class FormCadastroUsuario
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

        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            lblIdentificador = new Label();
            lblTipoConta = new Label();
            cmbTipoConta = new ComboBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            btnCadastrar = new Button();
            cpfBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(15, 15);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(15, 35);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.MaxLength = 70;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(302, 23);
            txtNome.TabIndex = 1;
            // 
            // lblIdentificador
            // 
            lblIdentificador.AutoSize = true;
            lblIdentificador.Location = new Point(15, 69);
            lblIdentificador.Margin = new Padding(4, 0, 4, 0);
            lblIdentificador.Name = "lblIdentificador";
            lblIdentificador.Size = new Size(63, 15);
            lblIdentificador.TabIndex = 2;
            lblIdentificador.Text = "CPF/CNPJ:";
            // 
            // lblTipoConta
            // 
            lblTipoConta.AutoSize = true;
            lblTipoConta.Location = new Point(15, 125);
            lblTipoConta.Margin = new Padding(4, 0, 4, 0);
            lblTipoConta.Name = "lblTipoConta";
            lblTipoConta.Size = new Size(81, 15);
            lblTipoConta.TabIndex = 4;
            lblTipoConta.Text = "Tipo de Conta";
            // 
            // cmbTipoConta
            // 
            cmbTipoConta.FormattingEnabled = true;
            cmbTipoConta.Items.AddRange(new object[] { "Pessoa Fisica", "Pessoa Juridica" });
            cmbTipoConta.Location = new Point(15, 144);
            cmbTipoConta.Margin = new Padding(4, 3, 4, 3);
            cmbTipoConta.Name = "cmbTipoConta";
            cmbTipoConta.Size = new Size(302, 23);
            cmbTipoConta.TabIndex = 5;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(15, 180);
            lblSenha.Margin = new Padding(4, 0, 4, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(15, 200);
            txtSenha.Margin = new Padding(4, 3, 4, 3);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(302, 23);
            txtSenha.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(15, 242);
            btnCadastrar.Margin = new Padding(4, 3, 4, 3);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(302, 27);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // cpfBox
            // 
            cpfBox.Location = new Point(15, 95);
            cpfBox.Mask = "000.000.000-00";
            cpfBox.Name = "cpfBox";
            cpfBox.Size = new Size(302, 23);
            cpfBox.TabIndex = 9;
            cpfBox.TextAlign = HorizontalAlignment.Center;
            cpfBox.MaskInputRejected += cpfBox_MaskInputRejected;
            // 
            // FormCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 301);
            Controls.Add(cpfBox);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(cmbTipoConta);
            Controls.Add(lblTipoConta);
            Controls.Add(lblIdentificador);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCadastroUsuario";
            Text = "Cadastro de Consumidor";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.ComboBox cmbTipoConta;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private MaskedTextBox cpfBox;
    }
}
