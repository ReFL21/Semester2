using DuelSysClassLibrary.DAL;
using DuelSysClassLibrary.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.Classes
{
    public class DuelSysInc
    {
        MatchManager matchManager = new MatchManager(new DALMatch());
        PeopleManager peopleManager = new PeopleManager(new DALPeople());
        TournamentManager tournamentManager = new TournamentManager(new DALTournament());
        SportManager sportManager = new SportManager(new DALSport());

        public MatchManager MatchManager
        {
            get { return matchManager; }
            set { matchManager = value; }
        }
        public PeopleManager PeopleManager
        {
            get { return peopleManager; }
            set { peopleManager = value; }
        }
        public TournamentManager TournamentManager
        {
            get { return tournamentManager; }
            set { tournamentManager = value; }
        }

        public SportManager SportManager
        {
            get { return sportManager; }
            set { sportManager = value; }
        }


        public DuelSysInc()
        {}
    }
}
