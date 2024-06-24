using Cemig.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Cemig
{
    public static class UtilitarioUsuario
    {
        public static Usuario CarregarUsuarioLogado(string usuarioLogadoCpfCnpj)
        {
            string pastaArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Arquivo");
            string nomeArquivo = "conta.xml";
            string caminhoCompleto = Path.Combine(pastaArquivo, nomeArquivo);

            List<Usuario> usuarios = LerUsuariosDoArquivo(caminhoCompleto);
            Usuario usuarioSelecionado = usuarios.FirstOrDefault(u => u.CpfCnpj == usuarioLogadoCpfCnpj);
            if (usuarioSelecionado == null)
            {
                MessageBox.Show("Usuário não encontrado.");
            }
            return usuarioSelecionado;
        }

        private static List<Usuario> LerUsuariosDoArquivo(string caminhoCompleto)
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
    }
}
