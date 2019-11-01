using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.StructuralPatterns.Facade
{
    public class Facade
    {
        private CPU CPU;
        private SSD SSD;
        private MotherBoard motherBoard;

        public Facade(CPU cpu, SSD ssd, MotherBoard motherBoard)
        {
            this.CPU = cpu;
            this.SSD = ssd;
            this.motherBoard = motherBoard;
        }

        public void StartPC()
        {
            CPU.StartCPU();
            motherBoard.StartBios();
            motherBoard.EnterBoot();
            SSD.StartOS();
            SSD.RecoverFiles();
        }

        public void ShutDownPC()
        {
            Console.WriteLine("System notification: SHUTING DOWN");
            SSD.CleanCache();
            SSD.ShutDownOS();
            CPU.ShutDownCPU();
        }
    }
}
