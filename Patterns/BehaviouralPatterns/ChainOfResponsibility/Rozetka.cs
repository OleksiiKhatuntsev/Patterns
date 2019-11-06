using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.BehaviouralPatterns.ChainOfResponsibility
{
    public class RozetkaHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request as string == "1")
            {
                return "You can buy it in rozetka";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
