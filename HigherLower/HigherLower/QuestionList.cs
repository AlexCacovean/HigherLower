using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLower
{
    class QuestionList
    {
        static List<Question> AllQuestions = new List<Question>();

        static public Question RndQuestion()
        {
            Random rnd = new Random();
            int randomNumber;
            randomNumber = rnd.Next() % AllQuestions.Count();
            return AllQuestions[randomNumber];
        }

        static public void InitializeQuestions()
        {
            AllQuestions.Add(new Question
            {
                Text = "What percentage of people have tried talking police officers out of ticketing or arresting them?",
                CorrectAnswer = 38
            });

            AllQuestions.Add(new Question
            {
                Text = "What percentage of people have woken up before 5 a.m. to attend Black Friday sales?",
                CorrectAnswer = 39
            });

            AllQuestions.Add(new Question
            {
                Text = "What percentage of people have peed in public pools?",
                CorrectAnswer = 66
            });

            AllQuestions.Add(new Question
            {
                Text = "What percentage of people take their Oreos apart before eating them?",
                CorrectAnswer = 46
            });

            AllQuestions.Add(new Question
            {
                Text = "What percentage of people believe there are aliens out there somewhere in the universe?",
                CorrectAnswer = 85
            });
        }
    }
}
