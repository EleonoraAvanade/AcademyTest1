using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AC_Esercitazione
{
    public class Spesa
    {
        public DateTime data { get; set; }
        public string Categoria { get; set; }
        public string LivApprov { get; set; }
        public string Descrizione { get; set; }
        public int Importo { get; set; }
        public override string ToString()
        {
            string str = $"{data} - {Categoria} - {LivApprov} - {Descrizione} - {Importo} \n";
            return str;
        }
    }
}
