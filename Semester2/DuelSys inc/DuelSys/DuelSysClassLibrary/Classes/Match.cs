using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.Classes
{
   public class Match
    {
        private int id;
        private Player player1;
        private Player player2;
        private int scorePlayer1;
        private int scorePlayer2;
        private Tournament tournament;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        public int ScorePlayer1
        {
            get { return scorePlayer1; }
            set { scorePlayer1 = value; }
        }
        public int ScorePlayer2
        {
            get { return scorePlayer2; }
            set { scorePlayer2 = value; }
        }

        public Player Player1
        {
            get { return player1; }
            set { player1 = value; }
        }
        public Player Player2
        {
            get { return player2; }
            set { player2 = value; }
        }
        public Tournament Tournament
        {
            get { return tournament; }
            set { tournament = value; }
        }

        public Match(Tournament tournament,Player player1, Player player2)
        {
            this.tournament = tournament;
            this.player1 = player1;
            this.player2 = player2;
        }

        public Match( int id,Tournament tournament, Player player1, Player player2)
        {
            this.tournament = tournament;
            this.id = id;
            this.player1 = player1;
            this.player2 = player2;
        }
        public Match(int id,Tournament tournament, Player player1, Player player2, int scorePlayer1, int scorePlayer2)
        {
            this.tournament = tournament;
            this.id = id;
            this.player1 = player1;
            this.player2 = player2;
            this.scorePlayer1 = scorePlayer1;
            this.scorePlayer2 = scorePlayer2;
        }

        public Match()
        {
        }

        public override string ToString()
        {
            return $"{player1.Name} - {scorePlayer1} : {scorePlayer2} - {player2.Name}";
        }
    }
}
