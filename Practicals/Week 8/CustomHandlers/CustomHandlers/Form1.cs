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
            cOb1 = new CustomObserver(r.Next(100),button1);
            cOb2 = new CustomObserver(r.Next(100), button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am the button1_click handler. Boring!");
        }
    }
}
