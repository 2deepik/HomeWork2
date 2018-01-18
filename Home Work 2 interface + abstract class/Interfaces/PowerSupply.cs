using System;
using System.Collections.Generic;
using System.Text;

namespace HW2.Interfaces
{
    interface PowerSupply
    {
        int Watt { get; set; }
        int Efficiency { get; set; }
    }
}
