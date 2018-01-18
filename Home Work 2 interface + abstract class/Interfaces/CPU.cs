using System;
using System.Collections.Generic;
using System.Text;

namespace HW2.Interfaces
{
    interface CPU
    {
        int Mhz { get; set; }
        int Cores { get; set; }
        int Threads { get; set; }
    }
}
