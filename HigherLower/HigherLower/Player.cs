using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLower
{
    enum possibleAnswers
    {
        MuchHigher,
        Higher,
        Lower,
        MuchLower
    }
    class Player
    {
        public string UserName;
        public int Points;
        public bool IsStartingPlayer;
        public bool HasAnsweredThisRound;
        public possibleAnswers CurrentAnswer { get; set; }
        
        public Player()
        {
            UserName = "NewUser";
            Points = 0;
            IsStartingPlayer = false;
        }
        public Player(string UserName)
        {
            this.UserName = UserName;
            Points = 0;
            IsStartingPlayer = false;
        }
        private void AddPoints(int newPoints)
        {
            if(newPoints > 0)
            {
                Points = Points + newPoints;
            }
        }

        //public void CalculatePoints()
        //{
        //    Question.Give
        //}

    }
}
