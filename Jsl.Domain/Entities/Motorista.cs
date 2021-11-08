using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jsl.Domain.Entities
{
    public class Motorista : BaseEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public int CEP { get; set; }
        public string Complemento { get; set; }
        public string Telefone { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int Eixos { get; set; }
    }
}
