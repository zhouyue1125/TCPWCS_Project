using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;


namespace WebServiceForASRS.DAL
{
    public class DBHelper_Sqlserver : DBHelper
    {
        //static String mysqlStr = "Data Source= (DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.8.10)(PORT = 34455)))(CONNECT_DATA =(SERVICE_NAME = ASRS)));User Id=asrs2015; Password=1234567;";
        //static String mysqlStr = global::WebServiceForASRS.Properties.Settings.Default.JMCOracle;
        //static String mysqlStr = "Data Source= (DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = 192.28.124.142)(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = JMC11)));User Id=CYWMS; Password=cywms!;";
        static String mysqlStr = "Data Source=.;Initial Catalog=ASRS_VOLVO;Persist Security Info=True;User ID=sa;Password=abc123.com;";
             
        #region DBHelper 成员

        public DbConnection getConn()
        {
            SqlConnection mysql = new SqlConnection(mysqlStr);
            return mysql;
        }

        public DbCommand getSqlCommand(string sql, DbConnection mysql)
        {
            SqlCommand mySqlCommand = new SqlCommand(sql, mysql as SqlConnection);
            return mySqlCommand;
        }

        public T GetDataValue<T>(IDataReader dr, string columnName)
        {
            // NOTE: GetOrdinal() is used to automatically determine where the column
            //       is physically located in the database table. This allows the
            //       schema to be changed without affecting this piece of code.
            //       This of course sacrifices a little performance for maintainability.
            int i = dr.GetOrdinal(columnName);

            if (!dr.IsDBNull(i))
                return (T)dr.GetValue(i);
            else
                return default(T);
        }

        public void PrepareCommand(DbConnection conn, DbTransaction trans, DbCommand cmd, CommandType cmdType, string cmdText, DbParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = cmdType;
            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

        public DbDataReader ExecuteReader(string cmdText, params DbParameter[] cmdParms)
        {
            DbCommand cmd = new SqlCommand();

            SqlConnection conn = getConn() as SqlConnection;

            try
            {

                PrepareCommand(conn, null, cmd, CommandType.Text, cmdText, cmdParms);

                DbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                cmd.Parameters.Clear();

                return dr;

            }

            catch (Exception exc)
            {
                
                conn.Close();
                return null;
            }
        }

        public int ExecuteNonQuery(DbCommand cmd)
        {
            try
            {
                using (SqlConnection conn = getConn() as SqlConnection)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
                    int val = cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                    return val;
                }

            }
            catch (Exception ex)
            {
            
                return 0;
            }
        }

        public int ExecuteNonQuery(string strSQL, DbParameter[] paras, CommandType cmdType)
        {
            int i = 0;
            using (SqlConnection conn = getConn() as SqlConnection)
            {
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = cmdType;
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                conn.Open();
                i = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return i;
        }

        public int ExecuteNonQuery(string strSQL)
        {
            return ExecuteNonQuery(strSQL, null);
        }

        public int ExecuteNonQuery(string strSQL, DbParameter[] paras)
        {
            return ExecuteNonQuery(strSQL, paras, CommandType.Text);
        }

        public DataSet ExecuteDataSet(string cmdText)
        {
            DbCommand cmd = new SqlCommand();
            using (SqlConnection conn = getConn() as SqlConnection)
            {
                PrepareCommand(conn, null, cmd, CommandType.Text, cmdText, null);
                DbDataAdapter da = new SqlDataAdapter(cmd as SqlCommand);
                DataSet ds = new DataSet();
                da.Fill(ds);
                conn.Close();
                cmd.Parameters.Clear();
                return ds;
            }
        }

        public DataTable GetTable(string cmdText)
        {
            var ds = ExecuteDataSet(cmdText);
            var dt = ds.Tables[0];
            return dt;
        }

        public object ExcuteScalarSQL(string strSQL, DbParameter[] paras, CommandType cmdType)
        {
            return ExcuteScalarSQL(strSQL, paras, CommandType.Text);
        }

        public object ExcuteScalarSQL(string strSQL)
        {
            return ExcuteScalarSQL(strSQL, null);
        }

        public object ExcuteScalarSQL(string strSQL, DbParameter[] paras)
        {
            return ExcuteScalarSQL(strSQL, paras, CommandType.Text);
        }

        #endregion
    }
}