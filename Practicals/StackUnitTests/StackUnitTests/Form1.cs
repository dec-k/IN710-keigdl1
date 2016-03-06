using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackUnitTests
{
    public partial class Form1 : Form
    {
        //Init a stack for testing
        Stack testStack = new Stack(5);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testStack.Push("TestItem");
            lbOutput.Items.Add("item added." + testStack.Iterator + "/" + testStack.Stack1.Length + " slots used.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            testStack.Pop();
            lbOutput.Items.Add("item removed." + testStack.Iterator + "/" + testStack.Stack1.Length + " slots used.");
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            testStack.Peek();
            lbOutput.Items.Add("Item #" + testStack.Iterator + " added last. " + testStack.Iterator + "/" + testStack.Stack1.Length + " slots used.");
        }
    }
}
