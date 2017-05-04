using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo.Models
{
    public class Despesa
    {
        public string NomeDespesa { get; set; }

        public int Quantidade { get; set; }

        public double Valor { get; set; }

        public string Categoria { get; set; }

        public bool Pago { get; set; }

        public Despesa ()
        {

        }
    }


}
