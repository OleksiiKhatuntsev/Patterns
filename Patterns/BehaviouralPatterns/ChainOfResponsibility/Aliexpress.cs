using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.BehaviouralPatterns.ChainOfResponsibility
{
    public class AliexpressHadler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request as string == "3")
            {
                return "You can buy it in Ali";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
