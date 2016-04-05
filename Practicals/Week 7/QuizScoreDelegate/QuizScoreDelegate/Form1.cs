using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizScoreDelegate
{
    public partial class Form1 : Form
    {
        //Declare a delegate type that returns an int, and accepts 2 ints as arguments.
        public delegate int ScoreDelegate(int correct, int incorrect);
        ScoreDelegate scoreComputer;

        public Form1()
        {
            InitializeComponent();

            //Default vals into text boxes
            txtCorrect.Text = "5";
            txtIncorrect.Text = "2";

            //Check something by default
            rdoAdult.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //determine which rdo clicked
            if (rdoAdult.Checked)
            {
                //bind delegate to adult score method
                scoreComputer = new ScoreDelegate(Scorer.adultScore);
            }
            else
            {
                scoreComputer = new ScoreDelegate(Scorer.childrenScore);
            }

            //parse text to ints
            int parseCorrect = Int32.Parse(txtCorrect.Text);
            int parseIncorrect = Int32.Parse(txtIncorrect.Text);
            int resultScore = scoreComputer(parseCorrect, parseIncorrect);

            //Run delegate method and output score
            lbResult.Text = "" + resultScore + " points.";
        }
    }
}
