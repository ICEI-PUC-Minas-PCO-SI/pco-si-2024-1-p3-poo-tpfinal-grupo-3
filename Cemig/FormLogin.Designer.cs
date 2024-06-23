namespace Cemig
{
    partial class FormLogin
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cmbUserType = new ComboBox();
            btnLogin = new Button();
            lblCadastrar = new Label();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(80, 80);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(80, 120);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // cmbUserType
            // 
            cmbUserType.Location = new Point(80, 160);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(200, 23);
            cmbUserType.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 122, 204);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 12F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(80, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblCadastrar
            // 
            lblCadastrar.AutoSize = true;
            lblCadastrar.Location = new Point(80, 260);
            lblCadastrar.Name = "lblCadastrar";
            lblCadastrar.Size = new Size(118, 15);
            lblCadastrar.TabIndex = 4;
            lblCadastrar.Text = "Não tem uma conta?";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(0, 122, 204);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Arial", 10F);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(197, 252);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(80, 30);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormLogin
            // 
            ClientSize = new Size(360, 320);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(cmbUserType);
            Controls.Add(btnLogin);
            Controls.Add(lblCadastrar);
            Controls.Add(btnCadastrar);
            Name = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cmbUserType;
        private Button btnLogin;
        private Label lblCadastrar;
        private Button btnCadastrar;
    }
}
