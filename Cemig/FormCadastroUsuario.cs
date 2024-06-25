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
            string identificador = txtIdentificador.Text;
            if (!IsCpfCnpjValid(identificador))
            {
                MessageBox.Show("CPF/CNPJ inválido.");
                return;
            }

            if (cmbTipoConta.SelectedItem == null)
            {
                MessageBox.Show("Selecione um tipo de conta.");
                return;
            }


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
            return Regex.IsMatch(cpf, @"^\d{11}$");
        }

        private bool IsValidCnpj(string cnpj)
        {
            return Regex.IsMatch(cnpj, @"^\d{14}$");
        }
    }
}
