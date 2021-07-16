using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AC_Esercitazione.Chain_Of_Responsability
{
    public class CEOHandler:AbstractHandler
    {
        public override string Handle(int request)
        {
            if (request <= 25000)
            {
                return "I CEO posso fare una spesa con questo importo:" + request;
            }
            else return base.Handle(request);
        }
    }
}
