using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HW2.Aclasses
{
    public class PCIx16 : PCI
    {
        public override int Speed { get; set; } = 16;

        public override void InputOutput()
        {
            Debug.WriteLine("sahrmanka zavedis");
        }
    }
}
