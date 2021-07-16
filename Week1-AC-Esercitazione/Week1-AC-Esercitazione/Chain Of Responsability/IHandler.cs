using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AC_Esercitazione.Chain_Of_Responsability
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler); //Metodo per settare l'anello successivo della catena
        string Handle(int request);
    }
}
