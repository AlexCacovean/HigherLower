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
        int i;
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
                if(GetNextPlayersName(i) != -1)
                {
                    CurrentPlayerUserNameLabel.Text = PlayerList.AllPlayers[GetNextPlayersName(i)].UserName;
                }
                PlayerList.AllPlayers[i].HasAnsweredThisRound = true;
                MessageBox.Show(PlayerList.AllPlayers[i].UserName + "  has answered yet");
            }
            else
            {
                MessageBox.Show("AllPlayersHaveAnswered");
            }
        }

        public int GetNextPlayersName(int i)
        {
            for(int j =i+1; j<PlayerList.NumberOfPlayers;j++)
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
            CurrentPlayerUserNameLabel.Text = PlayerList.AllPlayers[GetNextPlayersName(0)].UserName;
            QuestionLabel.Text = q.Text;
            FirstPlayerAnswerLabel.Text = q.FirstPlayerAnswer.ToString();
            
        }
     
        private void MuchHigherButton_Click(object sender, EventArgs e)
        {
            GetAnswerFromPlayer();
            ChangePlayer();
        }

        private void HigherButton_Click(object sender, EventArgs e)
        {
            GetAnswerFromPlayer();
            ChangePlayer();
        }

        private void LowerButton_Click(object sender, EventArgs e)
        {
            GetAnswerFromPlayer();
            ChangePlayer();
        }

        private void MuchLowerButton_Click(object sender, EventArgs e)
        {
            GetAnswerFromPlayer();
            ChangePlayer();
        }

    }
}
