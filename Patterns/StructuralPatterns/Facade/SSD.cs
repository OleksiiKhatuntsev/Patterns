using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.StructuralPatterns.Facade
{
    public class SSD
    {
        private string name;

        public SSD()
        {
            this.name = "SSD";
        }

        public SSD(string name)
        {
            this.name = name;
        }

        public void StartOS()
        {
            Console.WriteLine($"{this.ToString()}: Starting OS");
        }

        public void RecoverFiles()
        {
            Console.WriteLine($"{this.ToString()}: Recovering files");
        }

        public void CleanCache()
        {
            Console.WriteLine($"{this.ToString()}: Cleaning cache");
        }

        public void ShutDownOS()
        {
            Console.WriteLine($"{this.ToString()}: Shuting down OS");
        }

        public override string ToString()
        {
            return "SSD";
        }
    }
}
