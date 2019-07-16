using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLower
{
    public class Question
    {
        public string Text { get; set; }
        public int CorrectAnswer { get; set; }
        public int FirstPlayerAnswer { get; set; }

        public bool IsProcentValid(string s)
        {
            if(s == "")
            {
                return false;
            }
            foreach(char c in s)
            {
                if (c < '0' || c > '9') 
                {
                    return false;
                }
            }
            int Procent = Int32.Parse(s);

            if(Procent<0|| Procent>100)
            {
                return false;
            }

            return true;
        }
        int CompareAnswers(possibleAnswers PlayerAnswer)
        {
            if(FirstPlayerAnswer + 15 < CorrectAnswer&&
                PlayerAnswer == possibleAnswers.MuchHigher)
            {
                return 1;
            }
            else if (FirstPlayerAnswer < CorrectAnswer &&
                PlayerAnswer == possibleAnswers.Higher)
            {
                return 2;
            }

            if (FirstPlayerAnswer - 15 > CorrectAnswer &&
                PlayerAnswer == possibleAnswers.MuchLower)
            {
                return 4;
            }
            else if (FirstPlayerAnswer > CorrectAnswer &&
                PlayerAnswer == possibleAnswers.Lower)
            {
                return 3;
            }

            return 0;
        }

    }
}
