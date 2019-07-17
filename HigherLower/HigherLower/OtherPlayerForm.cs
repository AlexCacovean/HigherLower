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
    public partial class OtherPlayerForm : Form
    {
        Player player = new Player();
        Question question = new Question();
        int i;

        private void ReInitializePlayers()
        {
            foreach (Player p in PlayerList.AllPlayers)
            {
                p.IsStartingPlayer = false;
                p.HasAnsweredThisRound = false;
            }
            PlayerList.AllPlayersHaveAnsweredThisRound = false;
            i = 0;
        }
        public void ChangeTurn()
        {
            this.Close();
            ReInitializePlayers();
            FirstPlayerView nextRoundView = new FirstPlayerView();
            nextRoundView.Show();
        }

        public void GivePointsToCurrentPlayer()
        {
            int AnswerType =8;
            if (i <= 7)
            {
                AnswerType = question.CompareAnswers(PlayerList.AllPlayers[i].CurrentAnswer);
            }
            
            switch (AnswerType)
            {
                case 0:
                    PlayerList.AllPlayers[i].AddPoints(0);
                    break;
                case 1:
                    PlayerList.AllPlayers[i].AddPoints(200);
                    break;
                case 2:
                    PlayerList.AllPlayers[i].AddPoints(100);
                    break;
                case 3:
                    PlayerList.AllPlayers[i].AddPoints(100);
                    break;
                case 4:
                    PlayerList.AllPlayers[i].AddPoints(200);
                    break;
            }
        }

        public void ChangePlayer()
        {
            i = 0;
            foreach(Player p in PlayerList.AllPlayers)
            {
                
                if(p.HasAnsweredThisRound == false 
                    && p.IsStartingPlayer == false
                    && p.UserName != "NewUser")
                {
                    player = p;
                    i--;
                }
                i++;
            }
            if(i < PlayerList.NumberOfPlayers)
            {
                if(GetNextPlayersId(i) != -1)
                {
                    CurrentPlayerUserNameLabel.Text = PlayerList.AllPlayers[GetNextPlayersId(i)].UserName;
                }
                PlayerList.AllPlayers[i].HasAnsweredThisRound = true;
                //MessageBox.Show(PlayerList.AllPlayers[i].UserName + "  has answered yet");
            }
            else
            {
                UpdateTable();
                ChangeTurn();
            }
        }

        public int GetNextPlayersId(int i)
        {
            for(int j =i; j<PlayerList.NumberOfPlayers;j++)
            {
                if (PlayerList.AllPlayers[j].HasAnsweredThisRound == false
                    && PlayerList.AllPlayers[j].IsStartingPlayer == false
                    && PlayerList.AllPlayers[j].UserName != "NewUser")
                {
                    return j;
                }
            }
            return -1;
        }
        public void GetAnswerFromPlayer()
        {
            possibleAnswers answer = possibleAnswers.MuchHigher;
            player.CurrentAnswer = answer;
        }
        public OtherPlayerForm(Question q)
        {
            InitializeComponent();
            UpdateTable();
            CurrentPlayerUserNameLabel.Text = PlayerList.AllPlayers[GetNextPlayersId(0)].UserName;
            QuestionLabel.Text = q.Text;
            question = q;
            FirstPlayerAnswerLabel.Text = q.FirstPlayerAnswer.ToString();
            
        }

        //private void HigherLowerAnswerButtonClick()
        //{
        //    GetAnswerFromPlayer();
        //    ChangePlayer();
        //    UpdateTable();
        //    PlayerList.AllPlayers[i].CurrentAnswer = possibleAnswers.MuchHigher;
        //    GivePointsToCurrentPlayer();
        //}
     
        private void MuchHigherButton_Click(object sender, EventArgs e)
        {
            GetAnswerFromPlayer();
            ChangePlayer();
            if (i <= 7)
            {
                PlayerList.AllPlayers[i].CurrentAnswer = possibleAnswers.MuchHigher;
            }
            GivePointsToCurrentPlayer();
            //UpdateTable();
        }

        private void HigherButton_Click(object sender, EventArgs e)
        {
            GetAnswerFromPlayer();
            ChangePlayer();
            if (i <= 7) 
            {
                PlayerList.AllPlayers[i].CurrentAnswer = possibleAnswers.Higher;
            }
            GivePointsToCurrentPlayer();
            //UpdateTable();
        }

        private void LowerButton_Click(object sender, EventArgs e)
        {
            GetAnswerFromPlayer();
            ChangePlayer();
            if (i <= 7)
            {
                PlayerList.AllPlayers[i].CurrentAnswer = possibleAnswers.Lower;
            }
            GivePointsToCurrentPlayer();
            //UpdateTable();
        }

        private void MuchLowerButton_Click(object sender, EventArgs e)
        {
            GetAnswerFromPlayer();
            ChangePlayer();
            if (i <= 7)
            {
                PlayerList.AllPlayers[i].CurrentAnswer = possibleAnswers.MuchLower;
            }
            GivePointsToCurrentPlayer();
            //UpdateTable();
        }
        public void UpdateTable()
        {
            int i = 0;
            label1.Text = PlayerList.AllPlayers[i].Points.ToString();
            label2.Text = PlayerList.AllPlayers[i].UserName;
            i++;
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                label3.Text = PlayerList.AllPlayers[i].Points.ToString();
                label4.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                label3.Hide();
                label4.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                label5.Text = PlayerList.AllPlayers[i].Points.ToString();
                label6.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                label5.Hide();
                label6.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                label7.Text = PlayerList.AllPlayers[i].Points.ToString();
                label8.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                label7.Hide();
                label8.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                label9.Text = PlayerList.AllPlayers[i].Points.ToString();
                label10.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                label9.Hide();
                label10.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                label11.Text = PlayerList.AllPlayers[i].Points.ToString();
                label12.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                label11.Hide();
                label12.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                label13.Text = PlayerList.AllPlayers[i].Points.ToString();
                label14.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                label13.Hide();
                label14.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                label15.Text = PlayerList.AllPlayers[i].Points.ToString();
                label16.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                label15.Hide();
                label16.Hide();
            }
        }
    }
}
