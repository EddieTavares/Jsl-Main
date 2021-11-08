using System;
using System.Collections.Generic;
using System.Text;

namespace Layer.Architecture.Domain.Entities
{
    public class Endereco : BaseEntity
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public int CEP { get; set; }
        public string Complemento { get; set; }
        public string Telefone { get; set; }

        public virtual ICollection<Motorista> Motorista { get; set; }

    }
}
