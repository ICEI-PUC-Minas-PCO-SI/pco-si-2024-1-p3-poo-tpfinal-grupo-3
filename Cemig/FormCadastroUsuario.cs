using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

            // Aqui você pode adicionar a lógica para salvar o consumidor

            MessageBox.Show("Consumidor cadastrado com sucesso!");
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
            return Regex.IsMatch(cpf, @"^\d{11}$");
        }

        private bool IsValidCnpj(string cnpj)
        {
            // Adicione a lógica de validação de CNPJ aqui
            return Regex.IsMatch(cnpj, @"^\d{14}$");
        }

        private void cpfBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
