using SpecsGenerator.ComponentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecsGenerator
{
    class SpecPrinter
    {
        //Declare a lb and a factory
        private IMachineMaker mm;
        private ListBox lb;

        //Ctor
        public SpecPrinter(IMachineMaker mm, ListBox lb)
        {
            this.mm = mm;
            this.lb = lb;
        }

        //Print method
        public void print()
        {
            //Populate each component
            CPU outCPU = mm.makeCPU();
            GPU outGPU = mm.makeGPU();
            RAM outRAM = mm.makeRAM();

            //Calc total price
            double totalPrice = outCPU.Price + outGPU.Price + outRAM.Price;

            //clear lb
            lb.Items.Clear();
            lb.Items.Add("Price\tComponent");
            //Divider
            lb.Items.Add("---------------------------------");

            //add newly made pc
            lb.Items.Add(outCPU.ToString());
            lb.Items.Add(outGPU.ToString());
            lb.Items.Add(outRAM.ToString());

            //Divider
            lb.Items.Add("--------------------------------");
            //total price output
            lb.Items.Add("Total Cost: $" + totalPrice.ToString());
        }
    }
}
