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
            AnswerTextBox.Text = "50";
            question = QuestionList.RndQuestion();
            QuestionLabel.Text = question.Text;
            Player1.Text = currentPlayer.UserName;
            UpdateTable();
            currentPlayer.IsStartingPlayer = true;
            timer1.Start();
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
        int time = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            seconds.Text = time.ToString();
            if (time == 0)
            {
                timer1.Stop();
                FirstPlayerSubmitButtonClick(sender, e);

            }
        }
        public void UpdateTable()
        {
            int i = 0;
            Player1.Text = PlayerList.AllPlayers[i].Points.ToString();
            Player1Points.Text = PlayerList.AllPlayers[i].UserName;
            i++;
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                Player2.Text = PlayerList.AllPlayers[i].Points.ToString();
                Player2Points.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                Player2.Hide();
                Player2Points.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                Player3.Text = PlayerList.AllPlayers[i].Points.ToString();
                Player3Points.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                Player3.Hide();
                Player3Points.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                Player4.Text = PlayerList.AllPlayers[i].Points.ToString();
                Player4Points.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                Player4.Hide();
                Player4Points.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                Player5.Text = PlayerList.AllPlayers[i].Points.ToString();
                Player5Points.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                Player5.Hide();
                Player5Points.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                Player6.Text = PlayerList.AllPlayers[i].Points.ToString();
                Player6Points.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                Player6.Hide();
                Player6Points.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                Player7.Text = PlayerList.AllPlayers[i].Points.ToString();
                Player7Points.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                Player7.Hide();
                Player7Points.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                Player8.Text = PlayerList.AllPlayers[i].Points.ToString();
                Player8Points.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                Player8.Hide();
                Player8Points.Hide();
            }
        }
    }
}

