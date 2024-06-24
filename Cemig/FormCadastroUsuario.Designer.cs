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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtIdentificador = new TextBox();
            txtCep = new TextBox();
            txtEndereco = new TextBox();
            txtBairro = new TextBox();
            txtMunicipio = new TextBox();
            txtSexo = new TextBox();
            txtTelefone = new TextBox();
            txtEstado = new TextBox();
            txtSenha = new TextBox();
            cmbTipoConta = new ComboBox();
            btnCadastrar = new Button();
            lblNome = new Label();
            lblIdentificador = new Label();
            lblCep = new Label();
            lblEndereco = new Label();
            lblBairro = new Label();
            lblMunicipio = new Label();
            lblSexo = new Label();
            lblTelefone = new Label();
            lblEstado = new Label();
            lblSenha = new Label();
            lblTipoConta = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(140, 35);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(174, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtIdentificador
            // 
            txtIdentificador.Location = new Point(140, 69);
            txtIdentificador.Margin = new Padding(4, 3, 4, 3);
            txtIdentificador.Name = "txtIdentificador";
            txtIdentificador.Size = new Size(174, 23);
            txtIdentificador.TabIndex = 1;
            txtIdentificador.TextChanged += txtIdentificador_TextChanged;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(140, 104);
            txtCep.Margin = new Padding(4, 3, 4, 3);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(174, 23);
            txtCep.TabIndex = 2;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(140, 138);
            txtEndereco.Margin = new Padding(4, 3, 4, 3);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(174, 23);
            txtEndereco.TabIndex = 3;
            txtEndereco.TextChanged += txtEndereco_TextChanged;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(140, 173);
            txtBairro.Margin = new Padding(4, 3, 4, 3);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(174, 23);
            txtBairro.TabIndex = 4;
            txtBairro.TextChanged += txtBairro_TextChanged;
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(140, 208);
            txtMunicipio.Margin = new Padding(4, 3, 4, 3);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(174, 23);
            txtMunicipio.TabIndex = 5;
            txtMunicipio.TextChanged += txtMunicipio_TextChanged;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(140, 242);
            txtSexo.Margin = new Padding(4, 3, 4, 3);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(174, 23);
            txtSexo.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(140, 277);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(174, 23);
            txtTelefone.TabIndex = 7;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(140, 312);
            txtEstado.Margin = new Padding(4, 3, 4, 3);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(174, 23);
            txtEstado.TabIndex = 8;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(140, 346);
            txtSenha.Margin = new Padding(4, 3, 4, 3);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(174, 23);
            txtSenha.TabIndex = 9;
            // 
            // cmbTipoConta
            // 
            cmbTipoConta.FormattingEnabled = true;
            cmbTipoConta.Items.AddRange(new object[] { "Usuario ", "Admin" });
            cmbTipoConta.Location = new Point(140, 381);
            cmbTipoConta.Margin = new Padding(4, 3, 4, 3);
            cmbTipoConta.Name = "cmbTipoConta";
            cmbTipoConta.Size = new Size(174, 23);
            cmbTipoConta.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(140, 415);
            btnCadastrar.Margin = new Padding(4, 3, 4, 3);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(175, 27);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(18, 38);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 12;
            lblNome.Text = "Nome:";
            // 
            // lblIdentificador
            // 
            lblIdentificador.AutoSize = true;
            lblIdentificador.Location = new Point(18, 73);
            lblIdentificador.Margin = new Padding(4, 0, 4, 0);
            lblIdentificador.Name = "lblIdentificador";
            lblIdentificador.Size = new Size(63, 15);
            lblIdentificador.TabIndex = 13;
            lblIdentificador.Text = "CPF/CNPJ:";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(18, 107);
            lblCep.Margin = new Padding(4, 0, 4, 0);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(31, 15);
            lblCep.TabIndex = 14;
            lblCep.Text = "CEP:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(18, 142);
            lblEndereco.Margin = new Padding(4, 0, 4, 0);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(59, 15);
            lblEndereco.TabIndex = 15;
            lblEndereco.Text = "Endereço:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(18, 177);
            lblBairro.Margin = new Padding(4, 0, 4, 0);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 16;
            lblBairro.Text = "Bairro:";
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Location = new Point(18, 211);
            lblMunicipio.Margin = new Padding(4, 0, 4, 0);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(64, 15);
            lblMunicipio.TabIndex = 17;
            lblMunicipio.Text = "Município:";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(18, 246);
            lblSexo.Margin = new Padding(4, 0, 4, 0);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(35, 15);
            lblSexo.TabIndex = 18;
            lblSexo.Text = "Sexo:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(18, 280);
            lblTelefone.Margin = new Padding(4, 0, 4, 0);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 19;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(18, 315);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 20;
            lblEstado.Text = "Estado:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(18, 350);
            lblSenha.Margin = new Padding(4, 0, 4, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 21;
            lblSenha.Text = "Senha:";
            // 
            // lblTipoConta
            // 
            lblTipoConta.AutoSize = true;
            lblTipoConta.Location = new Point(18, 384);
            lblTipoConta.Margin = new Padding(4, 0, 4, 0);
            lblTipoConta.Name = "lblTipoConta";
            lblTipoConta.Size = new Size(84, 15);
            lblTipoConta.TabIndex = 22;
            lblTipoConta.Text = "Tipo de Conta:";
            // 
            // FormCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 462);
            Controls.Add(txtNome);
            Controls.Add(txtIdentificador);
            Controls.Add(txtCep);
            Controls.Add(txtEndereco);
            Controls.Add(txtBairro);
            Controls.Add(txtMunicipio);
            Controls.Add(txtSexo);
            Controls.Add(txtTelefone);
            Controls.Add(txtEstado);
            Controls.Add(txtSenha);
            Controls.Add(cmbTipoConta);
            Controls.Add(btnCadastrar);
            Controls.Add(lblNome);
            Controls.Add(lblIdentificador);
            Controls.Add(lblCep);
            Controls.Add(lblEndereco);
            Controls.Add(lblBairro);
            Controls.Add(lblMunicipio);
            Controls.Add(lblSexo);
            Controls.Add(lblTelefone);
            Controls.Add(lblEstado);
            Controls.Add(lblSenha);
            Controls.Add(lblTipoConta);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCadastroUsuario";
            Text = "Cadastro de Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox cmbTipoConta;
        private System.Windows.Forms.Button btnCadastrar;

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblTipoConta;
    }
}
