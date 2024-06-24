using Cemig.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;

namespace Cemig
{
    public partial class FormCadastrodeConta : Form
    {
        public FormCadastrodeConta()
        {
            InitializeComponent();
            FormCadastroConta_Load();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormsConsultaConta formsConsultaConta = new FormsConsultaConta();
            formsConsultaConta.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastrodeConta_Load(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void nresgistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            string identificacao = txtCpfCnpj.Text;

            if (pessoaFis.Checked)
            {
                // Salvar dados sem validar CPF
                SalvarDados("Pessoa Física", identificacao);
            }
            else if (pessoaJur.Checked)
            {
                // Salvar dados sem validar CNPJ
                SalvarDados("Pessoa Jurídica", identificacao);
            }
        }

        private void SalvarDados(string tipoPessoa, string identificacao)
        {
            Conta conta = new Conta
            {
                Indentificacao = identificacao,
                NumeroDeRegistro = Convert.ToInt32(nresgistro.Text),
                Valor = Convert.ToDecimal(Valor.Text).ToString("F2")
            };

            // Criar o caminho completo para o arquivo XML desejado
            string pastaArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Arquivo");
            string nomeArquivo = "conta.xml";
            string caminhoCompleto = Path.Combine(pastaArquivo, nomeArquivo);

            // Criar a pasta se ela não existir
            Directory.CreateDirectory(pastaArquivo);

            // Salvar a conta como um arquivo XML
            XmlSerializer serializer = new XmlSerializer(typeof(Conta));
            using (StreamWriter streamWriter = new StreamWriter(caminhoCompleto))
            {
                serializer.Serialize(streamWriter, conta);
            }

            MessageBox.Show("Conta salva com sucesso!");
        }


        private void FormCadastroConta_Load()
        {
            string caminhoArquivo = "contas.txt";

            if (System.IO.File.Exists(caminhoArquivo))
            {
                string[] linhas = System.IO.File.ReadAllLines(caminhoArquivo);
                foreach (string linha in linhas)
                {
                    string[] dados = linha.Split('|');
                    Conta conta = new Conta
                    {
                        Indentificacao = dados[0],
                        NumeroDeRegistro = int.Parse(dados[1]),
                        Valor = (dados[2])
                    };

                }
            }
        }




        private void pessoaFis_CheckedChanged(object sender, EventArgs e)
        {
            if (pessoaFis.Checked)
            {
                txtCpfCnpj.Mask = "000.000.000-00";
                txtCpfCnpj.Clear();

            }

        }

        private void pessoaJur_CheckedChanged(object sender, EventArgs e)
        {
            if (pessoaJur.Checked)
            {
                txtCpfCnpj.Mask = "00.000.000/0000-00";
                txtCpfCnpj.Clear();
            }
        }

        private void txtCpfCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
