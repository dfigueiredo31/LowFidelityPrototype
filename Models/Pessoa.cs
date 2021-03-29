using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LowFidelityPrototype.Models
{
    public class Pessoa
    {
        public int ID { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public int Pontuacao { get; set; }
    }
}