using Cemig.Entidades;
using System;
using System.Windows.Forms;

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
                Senha = txtSenha.Text
            };

            try
            {
                usuario.SalvarDadosNoArquivoXml();
                MessageBox.Show("Consumidor cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}");
            }
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
    }
}
