using Patterns.BehaviouralPatterns.ChainOfResponsibility;
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
            //CallFacade();
            CallChainOfResponsibility();
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

        static void CallChainOfResponsibility()
        {
            var ali = new AliexpressHadler();
            var rozetka = new RozetkaHandler();
            var eldom = new EldomHadler();
            rozetka.SetNext(eldom).SetNext(ali);
            for(; ; )
            {
                Console.WriteLine("Press 1 if you want to buy a new computer");
                Console.WriteLine("Press 2 if you want to buy govno");
                Console.WriteLine("Press 3 if you want to buy kitayskoe govno");
                Console.WriteLine("Press q to quit");
                string s = Console.ReadLine();
                if (s == "q")
                {
                    break;
                }
                Console.WriteLine(Client.ClientCode(rozetka, s));
            }
        }
    }
}
