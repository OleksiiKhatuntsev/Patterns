using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.BehaviouralPatterns.ChainOfResponsibility
{
    public class AbstractHandler : IHandler
    {
        private IHandler nextHandler;

        public virtual object Handle(object request)
        {
            if(this.nextHandler != null)
            {
                return this.nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            this.nextHandler = handler;
            return handler;
        }
    }
}
