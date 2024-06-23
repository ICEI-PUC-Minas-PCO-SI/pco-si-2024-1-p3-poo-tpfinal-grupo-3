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

           
            // Criar um objeto de conta com os dados do formulário
            Conta conta = new Conta();
            conta.Cpf = cpfBox.Text;
            conta.Cnpj = cnpjBox.Text;
            conta.NumeroDeRegistro = Convert.ToInt32(nresgistro.Text);
            conta.Valor = Convert.ToDecimal(Valor.Text);

            
            // Criar o caminho completo para o arquivo XML desejado
            string pastaArquivo = "Arquivo";
            string nomeArquivo = "conta.xml";
            string caminhoCompleto = Path.Combine(pastaArquivo, nomeArquivo);

            // Criar a pasta se ela não existir
            Directory.CreateDirectory(pastaArquivo);

           
            // Salvar a conta como um arquivo XML
            XmlSerializer serializer = new XmlSerializer(typeof(Conta), new XmlRootAttribute("Conta"));
            using (StreamWriter streamWriter = new StreamWriter(caminhoCompleto))
            {
                MessageBox.Show("SALVANDO" );
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
                    string[] dados = linha.Split(',');
                    Conta conta = new Conta
                    {
                        Cpf = dados[0],
                        Cnpj = dados[1],
                        NumeroDeRegistro = int.Parse(dados[2]),
                        Valor = decimal.Parse(dados[3])
                    };

                }
            }
        }

       
    }
}
