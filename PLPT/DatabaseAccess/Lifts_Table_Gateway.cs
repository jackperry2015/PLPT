using PLPT.Models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace PLPT.DatabaseAccess
{
    public class Lifts_Table_Gateway
    {
        // Obtaining Connectionstring from App.config file
        private readonly SqlConnection conn = 
            new SqlConnection(ConfigurationManager.
            ConnectionStrings["PLPT_Database"].ConnectionString);

        #region Stored Procedures
        // Adding new lifts row into lifts table
        public void InsertNewLifts(Lifts _lifts)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("Add_New_Lifts", conn)
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

        public DateTime FindEarliestLiftEntryForUser(string Username)
        {
            DateTime earliestLiftEntry;
            try
            {
                conn.Open();
                var cmd = new SqlCommand("Find_Earliest_Lifts_Entry", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@Username", Username));
                cmd.Parameters.Add("@retValueDate", System.Data.SqlDbType.DateTime).Direction =
                    System.Data.ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                earliestLiftEntry = (DateTime)cmd.Parameters["@retValueDate"].Value;
                conn.Close();
            }
            catch
            {
                return new DateTime();
            }

            return earliestLiftEntry;
        }

        public Lifts[] GetAllLiftsForAUser(string Username)
        {
            DataSet liftsDataset = new DataSet();
            try
            {
                conn.Open();

                var cmd = new SqlCommand("Get_All_Lifts", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                var da = new SqlDataAdapter();
                cmd.Parameters.Add(new SqlParameter("@Username", Username));
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(liftsDataset);
                conn.Close();
            }
            catch (Exception e)
            {
                return null;
            }

            var liftsDataTable = liftsDataset.Tables[0];

            return (from DataRow row in liftsDataTable.Rows select new Lifts
                (row["Username"].ToString(), Convert.ToDateTime(row["Date"]),
                Convert.ToInt32(row["Squat"]), Convert.ToInt32(row["Bench"]),
                Convert.ToInt32(row["Deadlift"]), Convert.ToInt32(row["Bodyweight"]),
                Convert.ToInt32(row["Total"]), Convert.ToInt32(row["Wilks"]))).ToArray();
        }
        #endregion
    }
}
