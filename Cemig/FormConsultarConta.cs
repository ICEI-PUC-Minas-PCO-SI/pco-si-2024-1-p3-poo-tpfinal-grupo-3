using System;
using System.Windows.Forms;

namespace Cemig
{
    public partial class FormsConsultaConta : Form
    {
        public FormsConsultaConta()
        {
            InitializeComponent();
        }

        private void BtnConsult_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber.Text;

            if (string.IsNullOrEmpty(accountNumber))
            {
                MessageBox.Show("Por favor, insira o número da conta.");
                return;
            }

            // Simulação de dados
            double consumo = 100; // Exemplo: 100 unidades de consumo
            double valorTotal = consumo * 0.5; // Supondo que 0.5 seja o preço por unidade de consumo
            double valorSemImpostos = valorTotal * 0.8; // Supondo que 20% sejam impostos

            // Preenchendo os campos com os dados da conta
            txtConsumption.Text = consumo.ToString("N2");
            txtTotalValue.Text = valorTotal.ToString("C2");
            txtValueWithoutTaxes.Text = valorSemImpostos.ToString("C2");
        }

        private void txtConsumption_TextChanged(object sender, EventArgs e)
        {

        }
    }
}