using Patterns.BehaviouralPatterns.Observer;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //CallObserver();
        }

        static void CallObserver()
        {
            Stock stock = new Stock();
            Broker Tom = new Broker("Tom", stock);
            Broker John = new Broker("John", stock);

            Tom.Subscribe();
            John.Subscribe();

            for (int i = 0; i < 20; i++)
            {
                stock.Market();
            }
        }
    }
}
