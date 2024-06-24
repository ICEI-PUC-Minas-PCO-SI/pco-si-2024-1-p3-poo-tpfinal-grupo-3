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

namespace Cemig
{
    public partial class FormRegistroConsumo : Form
    {
        private Usuario usuarioAtual;

        public FormRegistroConsumo(string usuarioLogadoCpfCnpj)
        {
            InitializeComponent();
            usuarioAtual = UtilitarioUsuario.CarregarUsuarioLogado(usuarioLogadoCpfCnpj);
        }

        private void FormRegistroConsumo_Load(object sender, EventArgs e)
        {
            // Carregar as contas associadas ao usuário atual
            cbConta.Items.Clear();
            foreach (var conta in usuarioAtual.Contas)
            {
                cbConta.Items.Add(conta.NumeroDeRegistro);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbConta.SelectedItem == null || string.IsNullOrWhiteSpace(tbLeituraAtual.Text) || string.IsNullOrWhiteSpace(tbLeituraAnterior.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            int leituraAtual;
            int leituraAnterior;

            if (!int.TryParse(tbLeituraAtual.Text, out leituraAtual) || !int.TryParse(tbLeituraAnterior.Text, out leituraAnterior))
            {
                MessageBox.Show("Por favor, insira leituras válidas.");
                return;
            }

            var numeroRegistro = (int)cbConta.SelectedItem;
            var conta = usuarioAtual.Contas.Find(c => c.NumeroDeRegistro == numeroRegistro);

            if (conta != null)
            {
                conta.LeituraAtual = leituraAtual;
                conta.LeituraAnterior = leituraAnterior;
                conta.DataLeitura = DateTime.Now; // Adicionar a data de leitura
                usuarioAtual.SalvarDadosNoArquivoXml();
                MessageBox.Show("Leituras registradas com sucesso.");
            }
            else
            {
                MessageBox.Show("Conta não encontrada.");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbLeituraAtual_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLeituraAnterior_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
