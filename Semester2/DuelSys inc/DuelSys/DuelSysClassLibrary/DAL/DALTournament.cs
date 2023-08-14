using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.DAL
{
   public class DALTournament:ITournament
    {

        public void AddTournament(Tournament tournament)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "INSERT INTO `tournament`(`StartingDate`, `EndDate`, `Description`, `SportID`, `City`, `Address`, `MInPlayers`, `MaxPlayers`, `StatusID`) VALUES (@StartingDate,@EndDate,@Description,@Sport,@City,@Address,@Minplayer,@MaxPlayer,@Status)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@StartingDate", tournament.Startdate);
                cmd.Parameters.AddWithValue("@EndDate", tournament.Enddate);
                cmd.Parameters.AddWithValue("@Description", tournament.Description);
                cmd.Parameters.AddWithValue("@Sport", tournament.Sport.ID);
                cmd.Parameters.AddWithValue("@City", tournament.City);
                cmd.Parameters.AddWithValue("@Address", tournament.Address);
                cmd.Parameters.AddWithValue("@Minplayer", tournament.Minplayers);
                cmd.Parameters.AddWithValue("@MaxPlayer", tournament.Maxplayers);
                cmd.Parameters.AddWithValue("@Status", 1);

                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception)
            {

                throw;
            }
        
        }

        public void DeleteTournament(Tournament tournament)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "DELETE FROM `tournament` WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", tournament.ID);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Tournament> GetAllTournament()
        {
            List<Tournament> tournaments = new List<Tournament>();
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "SELECT t.`ID`, `StartingDate`, `EndDate`, `Description`, ts.ID, ts.Name , `City`, `Address`, `MInPlayers`, `MaxPlayers`, `StatusID` FROM `tournament` AS t INNER JOIN typesport AS ts ON t.SportID = ts.ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    DateTime startingDate = Convert.ToDateTime(dataReader[1]);
                    DateTime endDate = Convert.ToDateTime(dataReader[2]);
                    string description = dataReader[3].ToString();
                    int sportid = Convert.ToInt32(dataReader[4]);
                    string sportname = dataReader[5].ToString();
                    Sports sports = new Sports(sportid, sportname, 5);
                    string city = dataReader[6].ToString();
                    string address = dataReader[7].ToString();
                    int MInPlayers = Convert.ToInt32(dataReader[8]);
                    int MaxPlayers = Convert.ToInt32(dataReader[9]);
                    int StatusID = Convert.ToInt32(dataReader[10]);
                    if (StatusID ==1)
                    {
                        Tournament tournament = new Tournament(id, description, startingDate, endDate, city, address, MInPlayers, MaxPlayers, sports,Status.Availible);
                        tournaments.Add(tournament);
                    }
                    else if (StatusID == 2)
                    {
                        Tournament tournament = new Tournament(id, description, startingDate, endDate, city, address, MInPlayers, MaxPlayers, sports, Status.NonApplicable);
                        tournaments.Add(tournament);
                    }
                    else if (StatusID == 3)
                    {
                        Tournament tournament = new Tournament(id, description, startingDate, endDate, city, address, MInPlayers, MaxPlayers, sports, Status.Finished);
                        tournaments.Add(tournament);
                    }
                    else if (StatusID == 4)
                    {
                        Tournament tournament = new Tournament(id, description, startingDate, endDate, city, address, MInPlayers, MaxPlayers, sports, Status.InProgress);
                        tournaments.Add(tournament);
                    }
                }
                return tournaments;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Tournament GetTournament(int id)
        {
            try
            {
                Tournament tournament;
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string sql = "SELECT * FROM `tournament` WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int tid = Convert.ToInt32(dataReader[0]);
                    DateTime startingDate = Convert.ToDateTime(dataReader[1]);
                    DateTime endDate = Convert.ToDateTime(dataReader[2]);
                    string description = dataReader[3].ToString();
                    int sportid = Convert.ToInt32(dataReader[4]);
                    
                    Sports sports = new Sports(sportid, "asdasd", 5);
                    string city = dataReader[5].ToString();
                    string address = dataReader[6].ToString();
                    int MInPlayers = Convert.ToInt32(dataReader[7]);
                    int MaxPlayers = Convert.ToInt32(dataReader[8]);
                    int StatusID = Convert.ToInt32(dataReader[9]);
                    if (StatusID == 1)
                    {
                       tournament = new Tournament(tid, description, startingDate, endDate, city, address, MInPlayers, MaxPlayers, sports, Status.Availible);
                        return tournament;
                    }
                    else if (StatusID == 2)
                    {
                       tournament = new Tournament(tid, description, startingDate, endDate, city, address, MInPlayers, MaxPlayers, sports, Status.NonApplicable);
                        return tournament;
                    }
                    else if (StatusID == 3)
                    {
                       tournament = new Tournament(tid, description, startingDate, endDate, city, address, MInPlayers, MaxPlayers, sports, Status.Finished);
                        return tournament;
                    }
                    else if (StatusID == 4)
                    {
                       tournament = new Tournament(id, description, startingDate, endDate, city, address, MInPlayers, MaxPlayers, sports, Status.InProgress);
                        return tournament;
                    }
                }
                conn.Close();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Player> GetPlayersForTournament(Tournament tournament)
        {
            try
            {
                List<Player> players = new List<Player>();
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string querry = "SELECT t.`ID`, `TournamentID`, `PlayerID`, p.Name FROM `tournamentplayers` AS t INNER JOIN player AS p On t.PlayerID = p.ID WHERE TournamentID = @id";
                MySqlCommand cmd = new MySqlCommand(querry, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", tournament.ID);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int tid = Convert.ToInt32(dataReader[1]);
                   
                    int pid = Convert.ToInt32(dataReader[2]);
                    string name = dataReader[3].ToString();
                    Player player = new Player(pid, name);
                    players.Add(player);
                    
                }
                return players;
            }
            catch (Exception)
            {

                throw;
            }
        
        }

        public void AddPoints(Tournament tournament, Player player)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string querry = "UPDATE `tournamentplayers` SET `Points`+ @points WHERE TournamentID = @Tid , PlayerID = @pid";
                MySqlCommand cmd = new MySqlCommand(querry, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Tid", tournament.ID);
                cmd.Parameters.AddWithValue("@pid", player.ID);
                cmd.Parameters.AddWithValue("@points", 1);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }
        
        }

        public void UpdateStatus(Tournament tournament, Status status)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string querry = "UPDATE `tournament` SET `StatusID`=@Status WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(querry, conn);
                conn.Open();
                if (status == Status.InProgress)
                {
                    cmd.Parameters.AddWithValue("@StatusID", 4);
                }
                else if (status == Status.NonApplicable)
                {
                    cmd.Parameters.AddWithValue("@StatusID", 2);
                }
                else if (status == Status.Finished)
                {
                    cmd.Parameters.AddWithValue("@StatusID", 3);
                }
                cmd.Parameters.AddWithValue("@id", tournament.ID);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        
        }

        public void UpdateTournament(DateTime startDate, DateTime endDate, string city, string address, int minplayers, int maxplayers, int id)
        {
            MySqlConnection conn = new MySqlConnection(Data.conn);
            string querry = "UPDATE `tournament` SET `StartingDate`=@startingdate,`EndDate`=@enddate,`City`=@city,`Address`=@address,`MInPlayers`=@minplayers,`MaxPlayers`=@maxplayers WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@startingdate", startDate);
            cmd.Parameters.AddWithValue("@enddate", endDate);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@minplayers", minplayers);
            cmd.Parameters.AddWithValue("@maxplayers", maxplayers);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}
