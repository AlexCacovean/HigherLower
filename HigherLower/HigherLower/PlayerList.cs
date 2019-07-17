using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLower
{
   
    class PlayerList
    {
        
        static public Player[] AllPlayers = new Player[8];
        static public int NumberOfPlayers;
        static public int CurrentPlayingPlayer;
        static public bool AllPlayersHaveAnsweredThisRound;
        static public void AddPlayerInVector(Player p)
        {
            
            NumberOfPlayers = 0;
            foreach(Player player in PlayerList.AllPlayers)
            {
                if(player.UserName == "NewUser")
                {
                    player.UserName = p.UserName;
                    break;
                }
                else
                {
                    NumberOfPlayers++;
                }
            }
            NumberOfPlayers++;
        }

        static public bool DoesPlayerExist(string newPlayerName)
        {
            foreach(Player p in PlayerList.AllPlayers)
            {
                if (p.UserName == newPlayerName)
                    return true;
            }
            return false;
        }
        static public bool AreEnoughPlayers()
        {
            if(NumberOfPlayers >=2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool IsGameFull()
        {
            if (NumberOfPlayers == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public void SelectNextPlayer()
        {
            if (CurrentPlayingPlayer == NumberOfPlayers)
            {
                CurrentPlayingPlayer = 0;
            }
            else
            {
                CurrentPlayingPlayer++;
            }
        }
        static public void InitializePlayers()
        {
            for (int i = 0; i < 8; i++)
            {
                PlayerList.AllPlayers[i] = new Player();
            }
        }

        static public bool TestIfAllPlayersHaveAnswered()
        {
            foreach(Player p in PlayerList.AllPlayers)
            {
                if (p.UserName != "NewUser" &&
                    p.HasAnsweredThisRound == false)
                    return false;
            }

            return true;
        }
    }
}
