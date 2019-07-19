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
    public partial class Leaderboard : Form
    {

        Player[] finishPlayers = new Player[8];
        public Leaderboard()
        {
            InitializeComponent();
            
            finishPlayers = PlayerList.AllPlayers;

            UpdateTable();
        }

        public void SortPlayersByPoints()
        {
            Player aux = new Player();

            for(int i= 0;i<finishPlayers.Length;i++)
            {
                for (int j = i; j < finishPlayers.Length; j++)
                {
                    if(finishPlayers[i].Points < finishPlayers[j].Points)
                    {
                        aux = finishPlayers[i];
                        finishPlayers[i] = finishPlayers[j];
                        finishPlayers[j] = aux;
                    }
                }
            }
        }

        public void UpdateTable()
        {
            SortPlayersByPoints();
            int i = 0;
            FirstPlaceNameLabel.Text = PlayerList.AllPlayers[i].Points.ToString();
            label11.Text = PlayerList.AllPlayers[i].UserName;
            i++;
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                SecondPlaceNameLabel.Text = PlayerList.AllPlayers[i].Points.ToString();
                SecondPlacePointsLabel.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                SecondPlaceNameLabel.Hide();
                SecondPlacePointsLabel.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                ThirdPlaceNameLabel.Text = PlayerList.AllPlayers[i].Points.ToString();
                ThirdPlacePointsLabel.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                ThirdPlaceNameLabel.Hide();
                ThirdPlacePointsLabel.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                FourthPlaceNameLabel.Text = PlayerList.AllPlayers[i].Points.ToString();
                FourthPlacePointsLabel.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                FourthPlaceNameLabel.Hide();
                FourthPlacePointsLabel.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                FifthPlaceNameLabel.Text = PlayerList.AllPlayers[i].Points.ToString();
                FifthPlacePointsLabel.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                FifthPlaceNameLabel.Hide();
                FifthPlacePointsLabel.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                SixthPlaceNameLabel.Text = PlayerList.AllPlayers[i].Points.ToString();
                SixthPlacePointsLabel.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                SixthPlaceNameLabel.Hide();
                SixthPlacePointsLabel.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                SevenPlaceNameLabel.Text = PlayerList.AllPlayers[i].Points.ToString();
                SevenPlacePointsLabel.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                SevenPlaceNameLabel.Hide();
                SevenPlacePointsLabel.Hide();
            }
            if (PlayerList.AllPlayers[i].UserName != "NewUser")
            {
                EighthPlaceNameLabel.Text = PlayerList.AllPlayers[i].Points.ToString();
                EighthPlacePointsLabel.Text = PlayerList.AllPlayers[i].UserName;
                i++;
            }
            else
            {
                EighthPlaceNameLabel.Hide();
                EighthPlacePointsLabel.Hide();
            }
        }
    }
}
