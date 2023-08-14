using DuelSysClassLibrary;
using DuelSysClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DuelSys
{
    public partial class Scheduling : Form
    {
        DuelSysInc duelSys = new DuelSysInc();
        public Scheduling()
        {
            InitializeComponent();
        }

        private void btnCreateSchedule_Click(object sender, EventArgs e)
        {
            if (lbMatches.Items.Count == 0)
            {
                int id = Convert.ToInt32(lblid.Text);
                Tournament tournament = duelSys.TournamentManager.GetTournament(id);
                List<Player> players = duelSys.TournamentManager.PlayersForTournament(tournament);
                if (players != null && players.Count >= tournament.Minplayers)
                {
                    tournament.CreateSchedule(tournament);
                    duelSys.TournamentManager.UpdateStatus(tournament, Status.InProgress);
                }
                else
                {
                    duelSys.TournamentManager.UpdateStatus(tournament, Status.NonApplicable);
                }
            }
            else
            {
                MessageBox.Show("The Matches are already created!");
            }
            
        }

        private void Scheduling_Load(object sender, EventArgs e)
        {
            int tournamnetid = Convert.ToInt32(lblid.Text);
            lbMatches.Items.Clear();
            List<Match> matches = duelSys.MatchManager.ViewMatchesByTournament(tournamnetid);
            foreach (Match item in matches)
            {
                lbMatches.Items.Add(item.ToString());
            }

        }

        private void btnAddResults_Click(object sender, EventArgs e)
        {
            Match match = new Match();
            Tournament tournament = duelSys.TournamentManager.GetTournament(Convert.ToInt32(lblid.Text));
            Sports sports = duelSys.SportManager.GetSportByID(tournament.Sport.ID);
            foreach (Match item in duelSys.MatchManager.ViewMatchesByTournament(tournament.ID))
            {
                if (item.ToString() == lbMatches.SelectedItem.ToString())
                {
                    match = item;
                }
            }
            
            int scoreplayer1 = Convert.ToInt32(tbscoreplayer1.Text);
            int scoreplayer2 = Convert.ToInt32(tbscoreplayer2.Text);
            if (scoreplayer1> sports.WinningPoints || scoreplayer2> sports.WinningPoints)
            {
                MessageBox.Show("Please fix the points!");
            }
            else if (scoreplayer1 > sports.WinningPoints && scoreplayer2 > sports.WinningPoints)
            {
                MessageBox.Show("Please fix the points!");
            }
            else
            {
                int difference = scoreplayer1 - scoreplayer2;
                if (difference <= -2)
                {
                    duelSys.MatchManager.AddScore(match, scoreplayer1, scoreplayer2);
                    duelSys.TournamentManager.AddPoints(tournament, match.Player2);
                    MessageBox.Show("Congratulations Player2");
                }
                else if (difference >= 2)
                {
                    duelSys.MatchManager.AddScore(match, scoreplayer1, scoreplayer2);
                    duelSys.TournamentManager.AddPoints(tournament, match.Player1);
                    MessageBox.Show("Congratulations Player1");
                }
                else if (difference == -1 )
                {
                    if (scoreplayer2 == sports.WinningPoints)
                    {
                        duelSys.MatchManager.AddScore(match, scoreplayer1, scoreplayer2);
                        duelSys.TournamentManager.AddPoints(tournament, match.Player2);
                        MessageBox.Show("Congratulations Player2");
                    }
                    else
                    {
                        MessageBox.Show("Please fix the points! There is on option the score to be bigger that the max points!");
                    }
                }
                else if (difference == 1)
                {
                    if (scoreplayer1 == sports.WinningPoints)
                    {
                        duelSys.MatchManager.AddScore(match, scoreplayer1, scoreplayer2);
                        duelSys.TournamentManager.AddPoints(tournament, match.Player1);
                        MessageBox.Show("Congratulations Player1");
                    }
                    else
                    {
                        MessageBox.Show("Please fix the points! There is on option the score to be bigger that the max points!");
                    }
                }
            }
            
        }
    }
}
