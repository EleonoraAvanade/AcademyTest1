using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1_AC_Esercitazione.Factory.Categorie;

namespace Week1_AC_Esercitazione.Factory
{
    public class RimborsoFactory
    {
        public IRimborso GetRimborso(string categoria)
        {
            IRimborso rim = null;
            switch (categoria)
            {
                case "Viaggio":
                    rim = new Viaggio();
                    break;
                case "Alloggio":
                    rim = new Alloggio();
                    break;
                case "Vitto":
                    rim = new Vitto();
                    break;
                case "Altro":
                    rim = new Altro();
                    break;
                default:
                    return null;
                    break;
            }
            return rim;
        }
    }
}
