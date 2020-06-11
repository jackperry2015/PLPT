using PLPT.Models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PLPT.DatabaseAccess
{
    public class Lifts_Table_Gateway
    {
        // Obtaining Connectionstring from App.config file
        private readonly SqlConnection conn = 
            new SqlConnection(ConfigurationManager.
            ConnectionStrings["PLPT_Database"].ConnectionString);

        // Adding new lifts row into lifts table
        public void InsertNewLifts(Lifts _lifts)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Add_New_Lifts", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@Username", _lifts.Username));
                cmd.Parameters.Add(new SqlParameter("@Date", _lifts.Date));
                cmd.Parameters.Add(new SqlParameter("@Squat", _lifts.Squat));
                cmd.Parameters.Add(new SqlParameter("@Bench", _lifts.Bench));
                cmd.Parameters.Add(new SqlParameter("@Deadlift", _lifts.Deadlift));
                cmd.Parameters.Add(new SqlParameter("@Bodyweight", _lifts.Bodyweight));
                cmd.Parameters.Add(new SqlParameter("@Total", _lifts.Total));
                cmd.Parameters.Add(new SqlParameter("@Wilks", _lifts.Wilks));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                return;
            }
        }
    }
}
