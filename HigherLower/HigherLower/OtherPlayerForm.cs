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
        int ThisRoundNumber;

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
            if (ThisRoundNumber <= PlayerList.NumberOfPlayers)
            {
                FirstPlayerView nextRoundView = new FirstPlayerView(ThisRoundNumber + 1);
                nextRoundView.Show();
            }
            else
            {
                Leaderboard leaderboard = new Leaderboard();
                leaderboard.Show();
            }
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
        public OtherPlayerForm(Question q,int round)
        {
            //MessageBox.Show(round.ToString());
            ThisRoundNumber = round;
            InitializeComponent();
            UpdateTable();
            CurrentPlayerUserNameLabel.Text = PlayerList.AllPlayers[GetNextPlayersId(0)].UserName;
            QuestionLabel.Text = q.Text;
            question = q;
            Player1.Text = q.FirstPlayerAnswer.ToString();
            
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
