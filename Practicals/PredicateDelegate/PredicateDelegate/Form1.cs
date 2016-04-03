using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredicateDelegate
{
    public partial class Form1 : Form
    {
        //List of ints
        List<int> listOfNumbers;

        //Setup a random number gen
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
            //Instantiate list
            listOfNumbers = new List<int>();
        }

        //method to determine if a given number is odd
        private bool isOdd(int input)
        {
            bool isAnOddNumber = ((input % 2) == 1);
            return isAnOddNumber;
        }

        //method to determine if a given number is under 10
        private bool isLessThanTen(int input)
        {
            bool isLessThanTen;

            if (input < 10)
            {
                isLessThanTen = true;
            }
            else
            {
                isLessThanTen = false;

            }

            return isLessThanTen;
        }

        //Gen a random number
        private void genRandom()
        {
            lbRands.Items.Add(r.Next(100));
        }

        private void btnGenSet_Click(object sender, EventArgs e)
        {
            //clear lb before genning more numbers
            lbRands.Items.Clear();

            for (int i = 0; i < 25; i++)
            {
                genRandom();
            }
        }
    }
}
