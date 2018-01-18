using System;
using System.Collections.Generic;
using System.Text;

namespace HW2.Aclasses
{
    public abstract class PCI
    {
        public abstract int Speed { get; set; }
        public abstract void InputOutput();
    }
}
