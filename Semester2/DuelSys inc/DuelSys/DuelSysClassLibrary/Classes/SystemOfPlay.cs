using DuelSysClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuelSysClassLibrary.Classes
{
    public class SystemOfPlay:ISystem
    {
        DuelSysInc duelSys = new DuelSysInc();
        public void CreateSchedule(Tournament tournament)
        {
            int number = 1;
            List<Match> matches = new List<Match>();
            Dictionary<int, Player> keys = new Dictionary<int, Player>();
            foreach (Player item in duelSys.TournamentManager.PlayersForTournament(tournament))
            {
                keys.Add(number,item);
                number++;
            }
            for (int i = 1; i <= keys.Count; i++)
            {
                Player player = keys[i];
                int myKey = keys.FirstOrDefault(x => x.Value == player).Key;
                foreach (var item in keys)
                {
                    if (myKey != item.Key)
                    {
                        if (myKey < item.Key)
                        {
                            Player player2 = item.Value;
                            duelSys.MatchManager.CreateMatch(new Match(tournament, player, player2));
                        }
                    }
   
                }
            }
        }
    }
}
