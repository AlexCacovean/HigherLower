using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            string textFilePath = @"C:\Users\Alex\Documents\HigherLower\Questions.txt";
            ReadQuestionsFromFile(textFilePath);
        }
        static private void ReadQuestionsFromFile(string fileName)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName);
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string name = line.Split('*')[0];
                    int answer = Convert.ToInt32(line[1]);
                    QuestionList.AllQuestions.Add(new Question {
                        Text = name,
                        CorrectAnswer = answer
                    });
                }
                sr.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
