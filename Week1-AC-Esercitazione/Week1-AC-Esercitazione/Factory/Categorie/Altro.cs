using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AC_Esercitazione.Factory.Categorie
{
    public class Altro : IRimborso
    {
        public double Rimborso { get; set; }

        public double Calcola(int importo)
        {
            return importo / 100 * 10;
        }
    }
}
