using DuelSysClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.Interfaces
{
   public interface IMatch
    {
        public List<Match> ViewMatches();
        public void AddScore(Match match, int scoreplayer1, int scoreplayer2);
        public void AddMatch(Match match);
        public List<Match> ViewmatchesByTournament(int id);

    }
}
