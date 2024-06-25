using System;
using System.Windows.Forms;
using System.Xml;

namespace Cemig
{
    public partial class FormsConsultaConta : Form
    {

        private const double ImpostoCPF = 0.3; // 30% de imposto para CPF
        private const double ImpostoCNPJ = 0.18; // 18% de imposto para CNPJ
        public FormsConsultaConta()
        {
            InitializeComponent();
            CarregarDadosConta();
        }

        private void CarregarDadosConta()
        {
            try
            {
                string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Arquivo", "conta.xml");
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(caminhoArquivo);

                // Navegue pelo XML para obter as informações da conta
                XmlNode contaNode = xmlDoc.SelectSingleNode("/contas/conta");
                if (contaNode != null)
                {
                    // Obtenha os valores dos elementos do XML
                    string identificacao = contaNode.SelectSingleNode("Identificacao").InnerText;
                    string numeroRegistro = contaNode.SelectSingleNode("NumeroDeRegistro").InnerText;
                    string valor = contaNode.SelectSingleNode("Valor").InnerText;
                    string consumo = contaNode.SelectSingleNode("Consumo").InnerText;

                    // Preencha os campos do formulário com os valores obtidos
                    txtAccountNumber.Text = identificacao;
                    txtAccountNumber.Text = numeroRegistro;
                    txtTotalValue.Text = valor;
                    txtConsumption.Text = consumo;
                }
                else
                {
                    MessageBox.Show("Nenhuma conta encontrada no arquivo XML.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o arquivo XML: " + ex.Message);
            }
        }

        private double CalcularValorComDesconto(string numeroIdentificacao, double valorTotal)
        {
            try
            {
                string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Arquivo", "conta.xml");
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(caminhoArquivo);

                // Verifique se o número de identificação (CPF ou CNPJ) existe no arquivo XML
                string xpathQuery = $"/contas/conta[Identificacao='{numeroIdentificacao}']";
                XmlNode contaNode = xmlDoc.SelectSingleNode(xpathQuery);
                if (contaNode != null)
                {
                    // Verifique se é CPF ou CNPJ
                    bool isCPF = numeroIdentificacao.Length == 11; // Supõe-se que CPF tenha 11 dígitos

                    // Calcular o valor com desconto de acordo com o tipo de identificação
                    double imposto = isCPF ? ImpostoCPF : ImpostoCNPJ;
                    double valorComDesconto = valorTotal * (1 - imposto);

                    return valorComDesconto;
                }
                else
                {
                    MessageBox.Show("Número de identificação não encontrado no arquivo XML.");
                    return valorTotal; // Retornar o valor total sem desconto
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular o valor com desconto: " + ex.Message);
                return valorTotal; // Retornar o valor total sem desconto em caso de erro
            }
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

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}