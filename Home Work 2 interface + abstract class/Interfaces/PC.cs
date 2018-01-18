using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HW2.Interfaces
{
    class PC: CPU, GPU, PowerSupply, RAM, PowerButton
    {
        public int Mhz { get; set; } = 2000;
        public int Cores { get; set; } = 2;
        public int Threads { get; set; } = 4;
        public int Vram { get; set; } = 2048;
        public int Cooler { get; set; } = 2;
        public int HDMI { get; set; } = 2;
        public int Gb { get; set; } = 8;
        public int Timing { get; set; } = 777777;
        public int Watt { get; set; } = 1450;
        public int Efficiency { get; set; } = 90;

        public void Reset()
        {
            Debug.WriteLine("Restart PC");
        }
    }
}
