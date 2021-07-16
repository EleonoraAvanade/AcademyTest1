using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AC_Esercitazione.Chain_Of_Responsability
{
    public class OperationalManagerHandler:AbstractHandler
    {
        public override string Handle(int request)
        {
            if (request <= 1000)
            {
                return "Gli operationl Manager posso fare una spesa con questo importo:" + request;
            }
            else return base.Handle(request);
        }
    }
}
