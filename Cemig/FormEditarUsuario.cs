using Cemig.Entidades;
using System.Data;
using System.Xml.Serialization;

namespace Cemig
{
    public partial class FormEditarUsuario : Form
    {
        private Usuario usuarioSelecionado;
        private List<Usuario> usuarios;
        private readonly string caminhoCompleto;

        public FormEditarUsuario(string usuarioLogadoCpfCnpj)
        {
            InitializeComponent();

            // Define o caminho do arquivo
            string pastaArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Arquivo");
            string nomeArquivo = "conta.xml";
            caminhoCompleto = Path.Combine(pastaArquivo, nomeArquivo);

            this.usuarioLogadoCpfCnpj = usuarioLogadoCpfCnpj;
            CarregarUsuarioLogado();
        }

        private string usuarioLogadoCpfCnpj;

        public List<Usuario> LerUsuariosDoArquivo()
        {
            List<Usuario> usuarios = new List<Usuario>();
            if (File.Exists(caminhoCompleto))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));
                using (FileStream fileStream = new FileStream(caminhoCompleto, FileMode.Open))
                {
                    usuarios = (List<Usuario>)serializer.Deserialize(fileStream);
                }
            }
            return usuarios;
        }

        private void CarregarUsuarioLogado()
        {
            usuarios = LerUsuariosDoArquivo();
            usuarioSelecionado = usuarios.FirstOrDefault(u => u.CpfCnpj == usuarioLogadoCpfCnpj);
            if (usuarioSelecionado != null)
            {
                ExibirDadosUsuario(usuarioSelecionado);
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }
        }

        public void SalvarUsuariosNoArquivo(List<Usuario> usuarios)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));
            using (FileStream fileStream = new FileStream(caminhoCompleto, FileMode.Create))
            {
                serializer.Serialize(fileStream, usuarios);
            }
        }

        private void SalvarDadosUsuario()
        {
            AtualizarUsuario(usuarioSelecionado);
            SalvarUsuariosNoArquivo(usuarios);
            MessageBox.Show("Dados do usuário atualizados com sucesso.");
        }

        public void ExibirDadosUsuario(Usuario usuario)
        {
            txtNome.Text = usuario.Nome;
            txtCpfCnpj.Text = usuario.CpfCnpj;
            maskCep.Text = usuario.Cep;
            txtEndereco.Text = usuario.Endereco;
            txtBairro.Text = usuario.Bairro;
            txtMunicipio.Text = usuario.Municipio;
            cmbSexo.SelectedItem = usuario.Sexo;
            txtNum.Text = usuario.Telefone;
            txtEstado.Text = usuario.Estado;
            txtAltSenha.Text = string.Empty;
            txtRepSenha.Text = string.Empty;
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            usuario.Nome = txtNome.Text;
            usuario.CpfCnpj = txtCpfCnpj.Text;
            usuario.Cep = maskCep.Text;
            usuario.Endereco = txtEndereco.Text;
            usuario.Bairro = txtBairro.Text;
            usuario.Municipio = txtMunicipio.Text;
            usuario.Sexo = cmbSexo.SelectedItem.ToString();
            usuario.Telefone = txtNum.Text;
            usuario.Estado = txtEstado.Text;

            // Verifica se a nova senha foi informada e se coincide com a confirmação da senha
            if (!string.IsNullOrWhiteSpace(txtAltSenha.Text))
            {
                if (txtAltSenha.Text == txtRepSenha.Text)
                {
                    usuario.Senha = txtAltSenha.Text;
                }
                else
                {
                    MessageBox.Show("A nova senha e a confirmação da senha não coincidem.");
                    return;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDadosUsuario();
        }

        // Handlers de eventos vazios podem ser removidos se não estiverem sendo usados
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void altSenha_Click(object sender, EventArgs e) { }
        private void maskCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void maskCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void maksCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void txtNum_TextChanged(object sender, EventArgs e) { }
        private void txtEstado_TextChanged(object sender, EventArgs e) { }
        private void txtRepSenha_TextChanged(object sender, EventArgs e) { }
        private void txtAltSenha_TextChanged(object sender, EventArgs e) { }
        private void txtMunicipio_TextChanged(object sender, EventArgs e) { }
        private void txtBairro_TextChanged(object sender, EventArgs e) { }
        private void txtEndereco_TextChanged(object sender, EventArgs e) { }
    }
}
