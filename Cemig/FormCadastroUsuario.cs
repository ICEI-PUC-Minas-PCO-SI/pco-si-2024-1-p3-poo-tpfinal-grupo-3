using Cemig.Entidades;
using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Cemig
{
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validação de CPF/CNPJ
            string identificador = txtIdentificador.Text;
            if (!IsCpfCnpjValid(identificador))
            {
                MessageBox.Show("CPF/CNPJ inválido.");
                return;
            }

            // Validação de tipo de conta
            if (cmbTipoConta.SelectedItem == null)
            {
                MessageBox.Show("Selecione um tipo de conta.");
                return;
            }

            // Captura dos dados de entrada e salvamento no arquivo XML
            Usuario usuario = new Usuario
            {
                Nome = txtNome.Text,
                CpfCnpj = txtIdentificador.Text,
                Cep = txtCep.Text,
                Endereco = txtEndereco.Text,
                Bairro = txtBairro.Text,
                Municipio = txtMunicipio.Text,
                Sexo = txtSexo.Text,
                Telefone = txtTelefone.Text,
                Estado = txtEstado.Text,
                Senha = txtSenha.Text,
                Tipo = cmbTipoConta.SelectedItem.ToString()
            };

            string pastaArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Arquivo");
            string nomeArquivo = "usuario.xml";
            string caminhoCompleto = Path.Combine(pastaArquivo, nomeArquivo);

            // Criar a pasta se ela não existir
            Directory.CreateDirectory(pastaArquivo);


            // Salvar a conta como um arquivo XML
            XmlSerializer serializer = new XmlSerializer(typeof(Usuario), new XmlRootAttribute("Usuario"));
            using (StreamWriter streamWriter = new StreamWriter(caminhoCompleto))
            {

                serializer.Serialize(streamWriter, usuario);
            }

            MessageBox.Show("Usuario salva com sucesso!");


        }

        private bool IsCpfCnpjValid(string cpfCnpj)
        {
            if (cpfCnpj.Length == 11)
                return IsValidCpf(cpfCnpj);
            else if (cpfCnpj.Length == 14)
                return IsValidCnpj(cpfCnpj);
            return false;
        }

        private bool IsValidCpf(string cpf)
        {
            // Adicione a lógica de validação de CPF aqui
            return System.Text.RegularExpressions.Regex.IsMatch(cpf, @"^\d{11}$");
        }

        private bool IsValidCnpj(string cnpj)
        {
            // Adicione a lógica de validação de CNPJ aqui
            return System.Text.RegularExpressions.Regex.IsMatch(cnpj, @"^\d{14}$");
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdentificador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMunicipio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
