using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;


namespace DuelSysClassLibrary.DAL
{
   public class DALMatch:IMatch
    {
        public void AddMatch(Match match)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query= "INSERT INTO `matches`( `TournamentID`, `PlayerID1`, `PlayerID2`, `resultPlayer1`, `resultPlayer2`) VALUES(@Tournamnet,@Player1,@Player2,@resultPlayer1,@resultPlayer2)";
              //  string sql = "INSERT INTO `matches`(`TournamentID`, `PlayerID1`, `PlayerID2`, , `resultPlayer1`, `resultPlayer2`) VALUES (@Tournamnet, @Player1,@Player2, @resultPlayer1, @resultPlayer2)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Tournamnet", match.Tournament.ID);
                cmd.Parameters.AddWithValue("@Player1", match.Player1.ID);
                cmd.Parameters.AddWithValue("@Player2", match.Player2.ID);
                cmd.Parameters.AddWithValue("@resultPlayer1", 0);
                cmd.Parameters.AddWithValue("@resultPlayer2", 0);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddScore(Match match, int scoreplayer1, int scoreplayer2)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "UPDATE `matches` SET `resultPlayer1`=@result1,`resultPlayer2`=@result2 WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", match.ID);
                cmd.Parameters.AddWithValue("@result1", scoreplayer1);
                cmd.Parameters.AddWithValue("@result2", scoreplayer2);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Match> ViewMatches()
        {
            List<Match> matches = new List<Match>();
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "SELECT m.`ID`, `TournamentID`, `PlayerID1`, p.Name, `PlayerID2`,p2.Name,  `resultPlayer1`, `resultPlayer2` FROM `matches` AS m INNER JOIN player AS p ON m.PlayerID1 = p.ID INNER JOIN player AS p2 ON m.PlayerID2 = p2.ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    int tournamnentid = Convert.ToInt32(dataReader[1]);
                    Tournament tournament = new Tournament(tournamnentid);
                    int player1id = Convert.ToInt32(dataReader[2]);
                    string player1name = dataReader[3].ToString();
                    Player player1 = new Player(id, player1name);
                    int player2id = Convert.ToInt32(dataReader[4]);
                    string player2name = dataReader[5].ToString();
                    Player player2 = new Player(id, player2name);
                    int scoreplayer1 = Convert.ToInt32(dataReader[6]);
                    int scoreplayer2 = Convert.ToInt32(dataReader[7]);
                    Match match = new Match(id, tournament, player1, player2, scoreplayer1, scoreplayer2);
                    matches.Add(match);
                }
                conn.Close();
                return matches;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Match> ViewmatchesByTournament(int id)
        {
            List<Match> matches = new List<Match>();
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "SELECT m.`ID`, `TournamentID`, `PlayerID1`, p.Name, `PlayerID2`,p2.Name,  `resultPlayer1`, `resultPlayer2` FROM `matches` AS m INNER JOIN player AS p ON m.PlayerID1 = p.ID INNER JOIN player AS p2 ON m.PlayerID2 = p2.ID WHERE TournamentID = @tid";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@tid", id);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int mid = Convert.ToInt32(dataReader[0]);
                    int tournamnentid = Convert.ToInt32(dataReader[1]);
                    Tournament tournament = new Tournament(tournamnentid);
                    int player1id = Convert.ToInt32(dataReader[2]);
                    string player1name = dataReader[3].ToString();
                    Player player1 = new Player(id, player1name);
                    int player2id = Convert.ToInt32(dataReader[4]);
                    string player2name = dataReader[5].ToString();
                    Player player2 = new Player(id, player2name);
                    int scoreplayer1 = Convert.ToInt32(dataReader[6]);
                    int scoreplayer2 = Convert.ToInt32(dataReader[7]);
                    Match match = new Match(mid, tournament, player1, player2, scoreplayer1, scoreplayer2);
                    matches.Add(match);
                }
                conn.Close();
                return matches;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }

   



}
