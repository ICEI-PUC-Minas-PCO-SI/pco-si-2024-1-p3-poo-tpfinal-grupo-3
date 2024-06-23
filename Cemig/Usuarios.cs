using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace SeuProjeto
{
    public class Usuario
    {
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
        public List<string> Contas { get; set; }

        public Usuario()
        {
            Contas = new List<string>();
        }

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
                new XElement("contas", new XElement("conta", string.Join(",", Contas))));

            rootElement.Add(usuarioElement);
            doc.Save(filePath);
        }
    }
}
