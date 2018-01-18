using System;
using System.Collections.Generic;
using System.Text;

namespace HW2.Interfaces
{
    interface GPU
    {
        int Vram { get; set; }
        int Cooler { get; set; }
        int HDMI { get; set; }
    }
}
