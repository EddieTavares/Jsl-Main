using System;
using System.Collections.Generic;
using System.Text;

namespace Layer.Architecture.Domain.Entities
{
    public class Caminhao : BaseEntity
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public Int16 Eixos { get; set; }
    }
}
