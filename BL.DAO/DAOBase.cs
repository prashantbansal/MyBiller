using System;
using System.Data;
using System.Data.SqlClient;

namespace BL.DAO
{
    internal class DAOBase
    {
        internal static SqlDataReader GetDataReader(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] cmdParameters)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open();
                PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParameters);
                SqlDataReader rdr = cmd.ExecuteReader();
                cmd.Parameters.Clear();
                return rdr;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                throw ex;
            }
        }

        internal static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] cmdParameters)
        {
            cmd.Connection = conn;

            int connectionTimeout = 0;
            //Check for Connection Timeout Property
            if (conn.ConnectionString.IndexOf("TIMEOUT", 0, StringComparison.OrdinalIgnoreCase) > 0)
            {
                //Split connection string 
                string[] connectionItems = conn.ConnectionString.Split(';');

                //Loop to connection timeout property in array
                for (int i = 0; i < connectionItems.Length; i++)
                {
                    //Look for connection timeout property
                    if (connectionItems[i].IndexOf("TIMEOUT", 0, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        //Split connection timeout property
                        var connectionTimeoutArr = connectionItems[i].Split('=');
                        //Read timeout
                        connectionTimeout = Convert.ToInt32(connectionTimeoutArr[1].Trim());
                        //break the loop
                        i = connectionItems.Length;
                    }
                }
            }

            //Set commandtimeout if connection timeout is set.
            if (connectionTimeout > 0)
                cmd.CommandTimeout = connectionTimeout;

            cmd.CommandText = cmdText;


            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;

            if (cmdParameters != null)
            {
                foreach (SqlParameter parm in cmdParameters)
                    cmd.Parameters.Add(parm);
            }
        }

       
    }
}
