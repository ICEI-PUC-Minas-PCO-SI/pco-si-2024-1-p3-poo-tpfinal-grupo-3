using Cemig.Entidades;
using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Cemig
{

    public partial class FormHome : Form
    {


        public FormHome()
        {
            InitializeComponent();
            // Define o caminho do arquivo

        }

        string usuarioLogadoCpfCnpj;

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            FormCadastrodeConta formCadastrodeConta = new FormCadastrodeConta();
            formCadastrodeConta.Show();
        }

        private void BtnRegisterConsumption_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            FormRegistroConsumo formRegistroConsumo = new FormRegistroConsumo(usuarioLogadoCpfCnpj);
            formRegistroConsumo.Show();
        }

        private void BtnConsultAccounts_Click(object sender, EventArgs e)
        {
            FormsConsultaConta formsConsultaConta = new FormsConsultaConta();
            formsConsultaConta.Show();
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            FormEditarUsuario formEditarUsuario = new FormEditarUsuario(usuarioLogadoCpfCnpj);
            formEditarUsuario.Show();
        }

        private void dataGridViewAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
