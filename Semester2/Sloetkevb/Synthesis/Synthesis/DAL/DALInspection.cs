using MySql.Data.MySqlClient;
using Synthesis.Classes;
using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisAssignment.DAL
{
    class DALInspection : IInspection
    {
        public void AddInspection(Inspection inspection)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@Note", inspection.Note);
                cmd.Parameters.AddWithValue("@RentID", inspection.Rent.ID);
                conn.Open();
                cmd.ExecuteReader();
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Inspection> ViewAllInspections()
        {
            try
            {
                List<Inspection> inspections = new List<Inspection>();
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    string note = dataReader[2].ToString();
                    DateTime date = Convert.ToDateTime(dataReader[1]);
                    int rentID = Convert.ToInt32(dataReader[3]);
                    Location locaiton = new Location("asdasd","sadfaf","sdfdsf");
                    Customer customer = new Customer("asdasd","asdad", "adasd", "asdasd","asdas","asdad",4561628);
                    Rent rent = new Rent(rentID,DateTime.Now, DateTime.Now, DateTime.Now,customer, "asdadad",(RentalStatus)1,locaiton);
               //     Inspection inspection = new Inspection(id,date,rent,,note);
               //     inspections.Add(inspection);
                }
                conn.Close();
                return inspections;
            }
            catch (Exception)
            {

                throw;
            }

        }




    }
}
