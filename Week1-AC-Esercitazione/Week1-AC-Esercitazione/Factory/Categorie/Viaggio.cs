using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AC_Esercitazione.Factory.Categorie
{
    public class Viaggio : IRimborso
    {
        public double Rimborso { get; set; }

        public double Calcola(int importo)
        {
            return importo+50;
        }
    }
}
