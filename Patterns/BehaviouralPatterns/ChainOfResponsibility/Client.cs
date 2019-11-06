using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.BehaviouralPatterns.ChainOfResponsibility
{
    public class Client
    {
        public static string ClientCode(AbstractHandler handler, string s)
        {
            var result = handler.Handle(s).ToString();
            return result;
        }
    }
}
