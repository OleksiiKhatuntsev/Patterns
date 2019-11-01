using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.StructuralPatterns.Facade
{
    public class CPU
    {
        private string name;

        public CPU()
        {
            this.name = "CPU";
        }

        public CPU(string name)
        {
            this.name = name;
        }
        public void StartCPU()
        {
            Console.WriteLine($"{this.ToString()}: Starting CPU");
        }

        public void ShutDownCPU()
        {
            Console.WriteLine($"{this.ToString()}: Shuting down CPU");
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
