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

            double consumo = 100; 
            double valorTotal = consumo * 0.5;
            double valorSemImpostos = valorTotal * 0.8;

            txtConsumption.Text = consumo.ToString("N2");
            txtTotalValue.Text = valorTotal.ToString("C2");
            txtValueWithoutTaxes.Text = valorSemImpostos.ToString("C2");
        }

        private void txtConsumption_TextChanged(object sender, EventArgs e)
        {

        }
    }
}