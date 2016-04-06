using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomHandlers
{
    public partial class Form1 : Form
    {
        //Declare custom observers
        CustomObserver cOb1;
        CustomObserver cOb2;

        //Declare a rand
        Random r;

        public Form1()
        {
            InitializeComponent();
            //Instantiate rand
            r = new Random();

            //Instantiate custom observers
            cOb1 = new CustomObserver(r.Next(100), btnTriggerHandlers);
            cOb2 = new CustomObserver(r.Next(100), btnTriggerHandlers);

            //Explanation for my own benefit:
            /*Found this practical easier than part 1, which I struggled with. Basically, when you call the constructor
             * for a new customObserver like this, it's constructor has code that binds one of THAT classes methods to a System-defined event
             * in this case it is a '.Click' event. Then obviously when that criteria is met, the event will pop and execute its code.
             * If you're a lecturer or other person readingt this block, it might seem obvious! But I just wanted to write something concrete.
             * */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am the button1_click handler. Boring!");
        }
    }
}
