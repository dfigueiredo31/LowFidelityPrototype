using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LowFidelityPrototype.Models
{
    public class Hipotese
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public bool Correta { get; set; }
    }
}