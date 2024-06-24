using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Cemig.Entidades
{
    [Serializable]
    [XmlInclude(typeof(Usuario))]
    [XmlRoot("Usuario")]
    public class Usuario
    {

        public void SalvarDadosNoArquivoXml()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Arquivo", "conta.xml");

            XDocument doc;
            XElement rootElement;

            if (File.Exists(filePath))
            {
                doc = XDocument.Load(filePath);
                rootElement = doc.Element("usuarios");
            }
            else
            {
                doc = new XDocument(new XElement("usuarios"));
                rootElement = doc.Root;
            }
        }


        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Estado { get; set; }
        public string Senha { get; set; }
        public List<Conta> Contas { get; set; }
        public List<string> Roles { get; set; }

        // Construtor padrão
        public Usuario()
        {
            Contas = new List<Conta>();
        }

        // Construtor que aceita parâmetros
        public Usuario(string nome, string cpfCnpj, string cep, string endereco, string bairro, string municipio, string sexo, string telefone, string estado, string senha, List<string> roles)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Arquivo", "conta.xml");

            XDocument doc;
            XElement rootElement;

            if (File.Exists(filePath))
            {
                doc = XDocument.Load(filePath);
                rootElement = doc.Element("usuarios");
            }
            else
            {
                doc = new XDocument(new XElement("usuarios"));
                rootElement = doc.Root;
            }

            XElement usuarioElement = new XElement("usuario",
                new XElement("nome", Nome),
                new XElement("cpfCnpj", CpfCnpj),
                new XElement("cep", Cep),
                new XElement("endereco", Endereco),
                new XElement("bairro", Bairro),
                new XElement("municipio", Municipio),
                new XElement("sexo", Sexo),
                new XElement("telefone", Telefone),
                new XElement("estado", Estado),
                new XElement("senha", Senha),
                new XElement("contas",
                    from conta in Contas
                    select new XElement("conta",
                        new XElement("numeroRegistro", conta.NumeroDeRegistro),
                        new XElement("cpf", conta.Indentificacao),
                        new XElement("valor", conta.Valor),
                        new XElement("leituraAtual", conta.LeituraAtual),
                        new XElement("leituraAnterior", conta.LeituraAnterior))));

            rootElement.Add(usuarioElement);
            doc.Save(filePath);
        }
    }
}
