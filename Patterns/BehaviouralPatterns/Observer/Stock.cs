using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.BehaviouralPatterns.Observer
{
    public class Stock : IObservable
    {
        public StockInfo StockInfo;
        public event EventHandler eventHandler;

        public Stock()
        {
            StockInfo = new StockInfo { Euro = 30, USD = 20 };
        }

        public void Notify()
        {
            eventHandler(this, EventArgs.Empty);
        }

        public void Market()
        {
            Random r = new Random();
            StockInfo.USD = r.Next(20, 25);
            StockInfo.Euro = r.Next(30, 35);
            Notify();
        }
    }
}
