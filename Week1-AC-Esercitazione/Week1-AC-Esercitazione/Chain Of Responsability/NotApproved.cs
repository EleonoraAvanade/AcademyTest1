using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AC_Esercitazione.Chain_Of_Responsability
{
    public class NotApproved:AbstractHandler
    {
        public override string Handle(int request)
        {
            if (request > 25000)
            {
                return "Nessuno può fare una spesa con questo importo:" + request;
            }
            else return base.Handle(request);
        }
    }
}
