using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LowFidelityPrototype.Models
{
    public class Pergunta
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public int Pontuacao { get; set; }
        public IEnumerable<Hipotese> ListaHipoteses { get; set; }
    }
}