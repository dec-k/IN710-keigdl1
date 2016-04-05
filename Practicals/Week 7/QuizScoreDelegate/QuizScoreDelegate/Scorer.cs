using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizScoreDelegate
{
    public static class Scorer
    {
        //Score calc adults
        public static int adultScore(int correct, int incorrect)
        {
            //reset score calc
            int score = 0;
            score = ((correct * 10) - (incorrect * 1));
            return score;
        }

        //Score calc children
        public static int childrenScore(int correct, int incorrect)
        {
            //reset score calc
            int score = 0;
            score = ((correct * 15));
            return score;
        }
    }
}
