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
            lbOutput.Items.Add("item added.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(testStack.Pop());
            lbOutput.Items.Add("item removed.");
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            testStack.Peek();
        }
    }
}
