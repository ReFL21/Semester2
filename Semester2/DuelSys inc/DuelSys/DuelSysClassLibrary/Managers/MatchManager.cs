using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.Managers
{
   public class MatchManager
    {
        public IMatch iMatch;
        public MatchManager(IMatch match)
        {
            this.iMatch = match;
        }

        public void CreateMatch(Match match)
        {
            iMatch.AddMatch(match);
        }

        public void AddScore(Match match, int score1, int score2)
        {
            iMatch.AddScore(match, score1, score2);
        }

        public List<Match> ViewAllmatches()
        {
            List<Match> matches = iMatch.ViewMatches();
            return matches;
        }

        public List<Match> ViewMatchesByTournament(int id)
        {
            List<Match> matches = iMatch.ViewmatchesByTournament(id);
           
            return matches;
        }


    }
}
