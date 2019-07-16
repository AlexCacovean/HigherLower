using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HigherLower
{
    public partial class FirstPlayerView : Form
    {
        Player currentPlayer = PlayerList.AllPlayers[0];

        Question question = new Question();
        public FirstPlayerView()
        {
            InitializeComponent();
            question = QuestionList.RndQuestion();
            QuestionLabel.Text=  question.Text;
            CurrentPlayerUserNameLabel.Text = currentPlayer.UserName;

            currentPlayer.IsStartingPlayer = true;
        }

        private void FirstPlayerSubmitButtonClick(object sender, EventArgs e)
        {
          
            string sAnswerProcent = AnswerTextBox.Text;

            if (question.IsProcentValid(sAnswerProcent))
            {
                question.FirstPlayerAnswer = Int32.Parse(sAnswerProcent);
                this.Close();
                OtherPlayerForm newfrm = new OtherPlayerForm(question);
                newfrm.Show();
            }
            else
            {
                MessageBox.Show("Answer is not a valid %");
            }
            
        }
    }
}
