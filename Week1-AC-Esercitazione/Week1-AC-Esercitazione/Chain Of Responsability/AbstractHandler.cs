﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AC_Esercitazione.Chain_Of_Responsability
{
    public abstract class AbstractHandler:IHandler
    {
        private IHandler _nextHandler;
        public virtual string Handle(int request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
    }
}
