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
        public List<string> Roles { get; set; }

        // Construtor padrão
        public Usuario()
        {
        }

        // Construtor que aceita parâmetros
        public Usuario(string nome, string cpfCnpj, string cep, string endereco, string bairro, string municipio, string sexo, string telefone, string estado, string senha, List<string> roles)
        {
            Nome = nome;
            CpfCnpj = cpfCnpj;
            Cep = cep;
            Endereco = endereco;
            Bairro = bairro;
            Municipio = municipio;
            Sexo = sexo;
            Telefone = telefone;
            Estado = estado;
            Senha = senha;
            Roles = roles;
        }
    }
}
