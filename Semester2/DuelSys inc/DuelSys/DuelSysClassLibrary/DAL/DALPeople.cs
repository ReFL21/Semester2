using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.DAL
{
    public class DALPeople : IPeople
    {
        public void AddPeople(People people)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string sql = "INSERT INTO `player`(`Name`, `Username`, `Password`, `Email`, PlayerType) VALUES (@Name,@Username,@Password,@Email, @PlayerType)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Name", people.Name);
                cmd.Parameters.AddWithValue("@Username", people.Username);
                cmd.Parameters.AddWithValue("@Password", people.Password);
                cmd.Parameters.AddWithValue("@Email", people.Email);
                if (people is Player)
                {
                    cmd.Parameters.AddWithValue("@PlayerType", 1);
                }
                else if (people is Staff)
                {
                    cmd.Parameters.AddWithValue("@PlayerType", 2);
                }

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public People GetPerson(int id)
        {
            try
            {
                People people;
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "SELECT * FROM `player` WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int Id = Convert.ToInt32(dataReader["ID"]);
                    string username = dataReader["Username"].ToString();
                    string name = dataReader["Name"].ToString();
                    string pass = dataReader["Password"].ToString();
                    string email = dataReader["Email"].ToString();
                    int typeUser = Convert.ToInt32(dataReader[5]);
                    if (typeUser == 2)
                    {
                        people = new Staff(Id, name, username, pass, email);
                        return people;
                    }
                    else if(typeUser == 1)
                    {
                        people = new Player(Id, name, username, pass, email);
                        return people;
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
        public int CheckUser(string user, string pass)
        {

            MySqlConnection conn = new MySqlConnection(Data.conn);
            string sql = "SELECT ID FROM player WHERE Username = @username AND Password = @password";
            try
            {
                int id;
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@username", MySqlDbType.String).Value = user;
                cmd.Parameters.Add("@password", MySqlDbType.String).Value = pass;

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32("ID");
                    return id;
                }

                return -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }


        public bool IsTaken(string username)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string SQL = "SELECT * FROM player WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                int effectedRows = cmd.ExecuteNonQuery();

                if (effectedRows != 0)
                {
                    return true;
                }
                conn.Close();
                return false;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<People> ViewAllPeople()
        {
            try
            {
                List<People> peoples = new List<People>();
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "SELECT * FROM `player`";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    string name = dataReader[1].ToString();
                    string username = dataReader[2].ToString();
                    string password = dataReader[3].ToString();
                    string email = dataReader[4].ToString();
                    int position = Convert.ToInt32(dataReader[5]);
                    if (position == 1)
                    {
                        Player people = new Player(id, name, username, password, email);
                        peoples.Add(people);
                    }
                    else if (position == 2)
                    {
                        Staff staff = new Staff(id, name, username, password, email);
                        peoples.Add(staff);
                    }

                }
                conn.Close();
                return peoples;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void RegisterForTournament(Player player, Tournament tournament)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string sql = "INSERT INTO `tournamentplayers`( `TournamentID`, `PlayerID`, `Points`) VALUES (@tid,@Pid,@Points)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@tid", tournament.ID);
                cmd.Parameters.AddWithValue("@Pid", player.ID);
                cmd.Parameters.AddWithValue("@Points", 0);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int RetrieveTournamentID(int id)
        {
            try
            {
                int tournamentid;
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "SELECT `TournamentID`, `PlayerID` FROM `tournamentplayers` WHERE PlayerID = @pid";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("pid", id);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tournamentid = Convert.ToInt32(dataReader[0]);
                    return tournamentid;
                }
                conn.Close();
                return -1;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void DeleteStaff(People people)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "DELETE FROM `player` WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", people.ID);
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
