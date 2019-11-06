using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.BehaviouralPatterns.ChainOfResponsibility
{
    public class EldomHadler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request as string == "2")
            {
                return "You can buy it in eldom";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
