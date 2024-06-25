using Cemig.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Cemig
{
    public partial class FormLogin : Form
    {
        private readonly string caminhoCompleto;
        private readonly Usuario adminUsuario;
        

        public FormLogin()
        {
            InitializeComponent();
            CustomizeDesign();

            string pastaArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Arquivo");
            string nomeArquivo = "usuario.xml";
            caminhoCompleto = Path.Combine(pastaArquivo, nomeArquivo);

            adminUsuario = new Usuario
            {
                Nome = "Admin",
                CpfCnpj = "11122233344455",
                Senha = "1234",
                Roles = new List<string> { "Admin" }
            };
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

        private List<Usuario> LerUsuariosDoArquivo()
        {
            List<Usuario> usuarios = new List<Usuario>();
            if (File.Exists(caminhoCompleto))
            {
                try
                {
                    XmlSerializer listSerializer = new XmlSerializer(typeof(List<Usuario>), new XmlRootAttribute("usuarios"));
                    using (FileStream fileStream = new FileStream(caminhoCompleto, FileMode.Open))
                    {
                        usuarios = (List<Usuario>)listSerializer.Deserialize(fileStream);
                    }
                }
                catch (InvalidOperationException)
                {
                    XmlSerializer singleSerializer = new XmlSerializer(typeof(Usuario));
                    using (FileStream fileStream = new FileStream(caminhoCompleto, FileMode.Open))
                    {
                        Usuario usuario = (Usuario)singleSerializer.Deserialize(fileStream);
                        usuario.Roles = new List<string> { usuario.Tipo };
                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userType = cmbUserType.SelectedItem.ToString();

            List<Usuario> usuarios = LerUsuariosDoArquivo();
            usuarios.Add(adminUsuario); 

            Usuario usuarioLogado = usuarios.FirstOrDefault(u => u.CpfCnpj == username && u.Senha == password && u.Roles.Contains(userType));
            
            if (usuarioLogado != null)
            {
                MessageBox.Show($"Login como {userType} bem-sucedido!");

                if (userType == "Admin")
                {
                    FormHome formHome = new FormHome();
                    formHome.Show();
                }
                else
                {
                    FormHome formHome = new FormHome();
                    formHome.Show();
                }

                this.Hide();
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
