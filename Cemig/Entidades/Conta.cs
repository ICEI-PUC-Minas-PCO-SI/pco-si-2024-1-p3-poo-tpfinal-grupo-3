using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Cemig.Entidades
{
    [Serializable]
    [XmlInclude(typeof(Conta))]
    [XmlRoot("Conta")]

    public class Conta
    {
        // Atributos
        public  string  Indentificacao { get; set; }
        public  int NumeroDeRegistro { get; set; }
        public  string Valor { get; set; }

        // Construtor padrão
        public Conta() { }

        // Construtor com parâmetros
        public Conta(string cpf, string identificacao, int numeroDeRegistro, string valor)
        {
            Indentificacao = identificacao;
            NumeroDeRegistro = numeroDeRegistro;
            Valor = valor;
        }
    }
}
