using HW2.Aclasses;
using HW2.Interfaces;

namespace Home_Work_2_interface___abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //PC pc = new PC();
            //pc.Reset();

            PCIx16 pci = new PCIx16();
            pci.InputOutput();
        }
    }
}
