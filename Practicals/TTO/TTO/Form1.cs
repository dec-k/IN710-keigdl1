using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         public void TwoToOne()
             {
                const int columnCount = 4;
                const int rowCount = 2;

	            Char[] oneDimensional = new Char[columnCount * rowCount];
                Char[,] twoDimensional = new Char[columnCount, rowCount] 
                      { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' }, { 'g', 'h' } };

                // convert to one dimension
                for (int c = 0; c < columnCount; c++)
                    for (int r = 0; r < rowCount; r++)
                    {
                        //Code here
                        if (r == 0)
                        {
                            oneDimensional[r + c] = twoDimensional[r, c];
                        }
                        else
                        {
                            oneDimensional[c + 1] = twoDimensional[r, c];
                        }
                    }

                //printing one dimensional array
                for (int i = 0; i < columnCount * rowCount; i++)
                    listBox1.Items.Add(oneDimensional[i]);
            }

         private void button1_Click(object sender, EventArgs e)
         {
             TwoToOne();
         }

    }
}
