using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.BehaviouralPatterns.Observer
{
    public class Broker : IObserver
    {
        private Stock stock;

        public Broker(string name, Stock stock)
        {
            this.stock = stock;
            Name = name;
        }

        public string Name { get; set; }

        public void Subscribe()
        {
            stock.eventHandler += StartTrade;
        }

        public void UnSubscribe()
        {
            stock.eventHandler += StartTrade;
        }

        private void StartTrade(object sender, EventArgs e)
        {
            Console.WriteLine($"{Name} change USD price to {stock.StockInfo.USD} and Euro price to {stock.StockInfo.Euro}");
        }
    }
}
