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
            cmbUserType.Items.Add("Admin");
            cmbUserType.Items.Add("Usuario");
            cmbUserType.SelectedIndex = 0; 

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

        private void CustomizeDesign()
        {
            this.Text = "Login";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            CustomizeTextBox(txtUsername, "Usuário");
            CustomizeTextBox(txtPassword, "Senha");

            cmbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserType.Font = new Font("Arial", 12);
            cmbUserType.ForeColor = Color.Black;
            cmbUserType.Location = new Point(80, 160);
            cmbUserType.Width = 200;

            btnLogin.Font = new Font("Arial", 12);
            btnLogin.ForeColor = Color.White;
            btnLogin.BackColor = Color.FromArgb(0, 122, 204);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(80, 200);
            btnLogin.Width = 200;
            btnLogin.Height = 40;
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
