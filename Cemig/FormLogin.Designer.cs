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
            SuspendLayout();
  
            txtUsername.Location = new Point(200, 107);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Digite seu usuário";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 0;

            txtPassword.Location = new Point(200, 147);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Digite sua senha";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
      
            cmbUserType.Location = new Point(200, 187);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(200, 23);
            cmbUserType.TabIndex = 2;
         
            btnLogin.Font = new Font("Microsoft Sans Serif", 20F);
            btnLogin.Location = new Point(200, 227);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 46);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "ENTRAR";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
       
            ClientSize = new Size(614, 409);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(cmbUserType);
            Controls.Add(btnLogin);
            Name = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Button btnLogin;
    }
}
