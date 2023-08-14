using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.DAL
{
    public class DALSport:ISport
    {
        public void AddSport(Sports sport)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string sql = "INSERT INTO `typesport`(`ID`, `Name`, `WiningPoints`) VALUES ([value-1],[value-2],[value-3])";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Tournamnet", sport.Name);
                cmd.Parameters.AddWithValue("@Player1", sport.WinningPoints);
                
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteSport(Sports sports)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string sql = "DELETE FROM `typesport` WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", sports.ID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Sports> ViewAllSports()
        {
            try
            {
                List<Sports> sports = new List<Sports>();
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string sql = "SELECT * FROM `typesport`";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    string name = dataReader[1].ToString();
                    int winningPoint = Convert.ToInt32(dataReader[2]);
                    Sports sport = new Sports(id, name, winningPoint);
                    sports.Add(sport);
                }
                conn.Close();
                return sports;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Sports GetSportsByID(int id)
        {
            try
            {
                Sports sports;
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string sql = "SELECT * FROM `typesport` WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int sid = Convert.ToInt32(dataReader[0]);
                    string name = dataReader[1].ToString();
                    int points = Convert.ToInt32(dataReader[2]);
                    sports = new Sports(sid, name, points);
                    return sports;
                }
                conn.Close();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateSport(string name, int winningP, int id)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string sql = "UPDATE `typesport` SET `Name`=@name,`WiningPoints`=@WinningP WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@WinningP", winningP);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }





    }
}
