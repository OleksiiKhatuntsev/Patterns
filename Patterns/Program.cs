using Patterns.BehaviouralPatterns.Observer;
using Patterns.StructuralPatterns.Facade;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //CallObserver();
            CallFacade();
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

        static void CallFacade()
        {
            CPU cpu = new CPU("Core i5 CPU");
            MotherBoard motherBoard = new MotherBoard("ASUS ROG");
            SSD ssd = new SSD("Kingston SSD");

            Facade facade = new Facade(cpu, ssd, motherBoard);

            facade.StartPC();
            facade.ShutDownPC();
        }
    }
}
