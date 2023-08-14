using DuelSysClassLibrary;
using DuelSysClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuelSys
{
    public partial class Form1 : Form
    {

        DuelSysInc duelSys = new DuelSysInc();
        public Form1()
        {
            InitializeComponent();
        }
        public void LoadCombobox()
        { 
            cbSport.Items.Clear();
            foreach (Sports item in duelSys.SportManager.ViewAllSports())
            {
                cbSport.Items.Add(item.ToString());
            }
        }


        public void ReloadSportGrid()
        {
            SportGrid.DataSource = null;
            SportGrid.Rows.Clear();
            SportGrid.DataSource = duelSys.SportManager.ViewSports();
        }

        public void ReloadTGrid()
        {
            TournamentsGrid.DataSource = null;
            TournamentsGrid.Rows.Clear();
            TournamentsGrid.DataSource = duelSys.TournamentManager.ViewTournaments();

            UTournamentGrid.DataSource = null;
            UTournamentGrid.Rows.Clear();
            UTournamentGrid.DataSource = duelSys.TournamentManager.ViewTournaments();
        
        }

        public void ReloadStaffGrid()
        {
            StaffGrid.DataSource = null;
            StaffGrid.Rows.Clear();
            StaffGrid.DataSource = duelSys.PeopleManager.ViewStaff();

        }
        private void btnAddTournament_Click(object sender, EventArgs e)
        {
            try
            {
                if (staringdate.Value == endDate.Value && staringdate.Value > endDate.Value)
                {
                    MessageBox.Show("Please fix the dates!");
                }
                else
                {
                    int minplayers = Convert.ToInt32(tbMinPlayers.Text);
                    int maxplayers = Convert.ToInt32(tbMaxPlayers.Text);
                    if (minplayers <=-1 && maxplayers<=-1 && minplayers> maxplayers)
                    {
                        MessageBox.Show("Please fix your MIN and MAX amount of players");
                    }
                    else
                    {
                        foreach (Sports item in duelSys.SportManager.ViewAllSports())
                        {
                            if (cbSport.SelectedItem.ToString() == item.ToString())
                            {
                                duelSys.TournamentManager.CreateTournament(new Tournament(rtbDescription.Text,staringdate.Value,endDate.Value,tbCity.Text,tbAddress.Text, minplayers, maxplayers, item, Status.Availible ));
                                MessageBox.Show("The tournament is added to the system");
                            }
                        }
                    }                   

                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Please follow the correct format!");
            }
            catch (Exception)
            {

                throw ;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            ReloadTGrid();
            ReloadStaffGrid();
            ReloadSportGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (Tournament item in duelSys.TournamentManager.ViewAllTournaments())
            {
                if (item.ID == (int)TournamentsGrid.SelectedRows[0].Cells[0].Value)
                {
                    duelSys.TournamentManager.DeleteTournament(item);
                }
            }
        }

        private void cBocFinished_CheckedChanged(object sender, EventArgs e)
        {
            if (cBocFinished.Checked)
            {
                TournamentsGrid.DataSource = null;
                TournamentsGrid.Rows.Clear();
                TournamentsGrid.DataSource = duelSys.TournamentManager.ShowFilteredTournaments(Status.Finished);
            }
            else
            {
                ReloadTGrid();
            }
        }

        private void cBoxNonApplicable_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxNonApplicable.Checked)
            {
                TournamentsGrid.DataSource = null;
                TournamentsGrid.Rows.Clear();
                TournamentsGrid.DataSource = duelSys.TournamentManager.ShowFilteredTournaments(Status.NonApplicable);
            }
            else
            {
                ReloadTGrid();
            }
        }

        private void cBoxPending_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxPending.Checked)
            {
                TournamentsGrid.DataSource = null;
                TournamentsGrid.Rows.Clear();
                TournamentsGrid.DataSource = duelSys.TournamentManager.ShowFilteredTournaments(Status.InProgress);
            }
            else
            {
                ReloadTGrid();
            }
        }

        private void cBoxAvailible_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxAvailible.Checked)
            {
                TournamentsGrid.DataSource = null;
                TournamentsGrid.Rows.Clear();
                TournamentsGrid.DataSource = duelSys.TournamentManager.ShowFilteredTournaments(Status.Availible);
            }
            else
            {
                ReloadTGrid();
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            addStaff.Show();
            this.Hide();
        }

        private void btnUpdateTournamnet_Click(object sender, EventArgs e)
        {
            foreach (Tournament item in duelSys.TournamentManager.ViewAllTournaments())
            {
                if (item.ID == (int)UTournamentGrid.SelectedRows[0].Cells[0].Value)
                {
                    int minplayers = Convert.ToInt32(tbMinPlayers.Text);
                    int maxplayers = Convert.ToInt32(tbMaxPlayers.Text);
                    if (minplayers > maxplayers && UstartDate.Value > UendDate.Value)
                    {
                        MessageBox.Show("Please fix your dates/min and max players values!");
                    }
                    else
                    {
                        duelSys.TournamentManager.UpdateTournament(UstartDate.Value, UendDate.Value, tbUCity.Text, tbUaddress.Text, minplayers, maxplayers, item.ID);
                        MessageBox.Show("The Tournament is Updated!");
                    }
                   
                }
            }
        }

        private void TournamentsGrid_DoubleClick(object sender, EventArgs e)
        {
            foreach (Tournament item in duelSys.TournamentManager.ViewAllTournaments())
            {
                if (item.ID == (int)TournamentsGrid.SelectedRows[0].Cells[0].Value)
                {
                    Scheduling scheduling = new Scheduling();

                    scheduling.lblid.Text = item.ID.ToString();
                    scheduling.lblCity.Text = item.City;
                    scheduling.lblAddress.Text = item.Address;
                    scheduling.lblMaxPlayers.Text = item.Maxplayers.ToString();
                    scheduling.lblMinPlayers.Text = item.Minplayers.ToString();
                    scheduling.lblSport.Text = item.Sport.Name;
                    scheduling.lblStartdate.Text = item.Startdate.ToString();
                    scheduling.lblEnddate.Text = item.Enddate.ToString();
                    scheduling.ShowDialog();
                }
            }
        }

        private void UTournamentGrid_DoubleClick(object sender, EventArgs e)
        {
            foreach (Tournament item in duelSys.TournamentManager.ViewAllTournaments())
            {
                if (item.ID == (int)UTournamentGrid.SelectedRows[0].Cells[0].Value)
                {
                    tbUaddress.Text = item.Address;
                    tbUCity.Text = item.City;
                    tbUMaxplayer.Text = item.Maxplayers.ToString();
                    tbUMinplayers.Text = item.Minplayers.ToString();
                    UstartDate.Value = item.Startdate;
                    UendDate.Value = item.Enddate;
                }
            }
        }

        private void btnAddSport_Click(object sender, EventArgs e)
        {
            AddSports addSports = new AddSports();
            addSports.Show();
            this.Hide();
        }

        private void btnDeleteSport_Click(object sender, EventArgs e)
        {
            foreach (var item in duelSys.SportManager.ViewAllSports())
            {
                if (item.ID == (int)SportGrid.SelectedRows[0].Cells[0].Value)
                {
                    duelSys.SportManager.DeleteSport(item);
                    MessageBox.Show("The sport has been deleted!");
                }
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            foreach (var item in duelSys.PeopleManager.ViewStaffMembers())
            {
                if (item.ID == (int)SportGrid.SelectedRows[0].Cells[0].Value)
                {
                    duelSys.PeopleManager.DeleteStaff(item);
                    MessageBox.Show("The worker is deleted!");
                }
            }
        }

        private void btnUpdateSport_Click(object sender, EventArgs e)
        {
            foreach (var item in duelSys.SportManager.ViewAllSports())
            {
                if (item.ID == (int)SportGrid.SelectedRows[0].Cells[0].Value)
                {
                    int winningPoints = Convert.ToInt32(tbSWinningP.Text);
                    if (tbSName.Text != "" && winningPoints > 0)
                    {
                        duelSys.SportManager.UpdateSport(tbSName.Text,winningPoints,item.ID);
                        MessageBox.Show("The information is updated!");                    
                    } 
                }
            }
        }

    }
}
