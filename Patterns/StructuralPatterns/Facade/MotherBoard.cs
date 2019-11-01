using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.StructuralPatterns.Facade
{
    public class MotherBoard
    {
        private string name;

        public MotherBoard()
        {
            this.name = "MotherBoard";
        }

        public MotherBoard(string name)
        {
            this.name = name;
        }

        public void StartBios()
        {
            Console.WriteLine($"{this.ToString()}: Starting BIOS");
        }

        public void EnterBoot()
        {
            Console.WriteLine($"{this.ToString()}: Entering boot");
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
