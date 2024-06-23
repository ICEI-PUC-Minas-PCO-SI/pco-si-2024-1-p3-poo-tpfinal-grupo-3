using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cemig
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Adiciona itens à ComboBox
            cmbUserType.Items.Add("Admin");
            cmbUserType.Items.Add("Usuario");
            cmbUserType.SelectedIndex = 0; // Seleciona o primeiro item por padrão

            // Simula placeholder nos TextBoxes
            txtUsername.GotFocus += RemovePlaceholder;
            txtUsername.LostFocus += SetPlaceholder;
            txtPassword.GotFocus += RemovePlaceholder;
            txtPassword.LostFocus += SetPlaceholder;

            SetPlaceholder(txtUsername, EventArgs.Empty);
            SetPlaceholder(txtPassword, EventArgs.Empty);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userType = cmbUserType.SelectedItem.ToString();

            // Lógica de validação do login
            if (username == "admin" && password == "admin" && userType == "Admin")
            {
                MessageBox.Show("Login como Admin bem-sucedido!");
            }
            else if (username == "usuario" && password == "usuario" && userType == "Usuario")
            {
                MessageBox.Show("Login como Usuario bem-sucedido!");
            }
            else
            {
                MessageBox.Show("Credenciais de login inválidas. Tente novamente.");
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                if (textBox == txtPassword)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = Color.Gray;
                if (textBox == txtPassword)
                {
                    textBox.UseSystemPasswordChar = false;
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario formCadastro = new FormCadastroUsuario();
            formCadastro.Show();
        }

        private void CustomizeDesign()
        {
            this.Text = "Login";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Customize TextBox
            CustomizeTextBox(txtUsername, "Usuário");
            CustomizeTextBox(txtPassword, "Senha");

            // Customize ComboBox
            cmbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserType.Font = new Font("Arial", 12);
            cmbUserType.ForeColor = Color.Black;
            cmbUserType.Location = new Point(80, 160);
            cmbUserType.Width = 200;

            // Customize Button
            btnLogin.Font = new Font("Arial", 12);
            btnLogin.ForeColor = Color.White;
            btnLogin.BackColor = Color.FromArgb(0, 122, 204);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(80, 200);
            btnLogin.Width = 200;
            btnLogin.Height = 40;

            // Customize Label and Button for Register
            Label lblCadastrar = new Label();
            lblCadastrar.Text = "Não tem uma conta?";
            lblCadastrar.Location = new Point(80, 260);
            lblCadastrar.Font = new Font("Arial", 10);
            lblCadastrar.AutoSize = true;

            Button btnCadastrar = new Button();
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Font = new Font("Arial", 10);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.BackColor = Color.FromArgb(0, 122, 204);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(200, 255);
            btnCadastrar.Width = 80;
            btnCadastrar.Height = 30;
            btnCadastrar.Click += new EventHandler(btnCadastrar_Click);

            // Add Controls to Form
            this.Controls.Add(txtUsername);
            this.Controls.Add(txtPassword);
            this.Controls.Add(cmbUserType);
            this.Controls.Add(btnLogin);
            this.Controls.Add(lblCadastrar);
            this.Controls.Add(btnCadastrar);
        }

        private void CustomizeTextBox(TextBox textBox, string placeholder)
        {
            textBox.Font = new Font("Arial", 12);
            textBox.ForeColor = Color.Gray;
            textBox.Location = new Point(80, textBox == txtUsername ? 80 : 120);
            textBox.Width = 200;
            textBox.Text = placeholder;
            textBox.Tag = placeholder;
        }
    }
}
