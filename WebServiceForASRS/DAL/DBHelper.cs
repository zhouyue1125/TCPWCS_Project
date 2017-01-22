using System;
using System.Data;
using System.Data.Common;

namespace WebServiceForASRS.DAL
{
    public  interface DBHelper
    {
           DbConnection getConn();

          DbCommand getSqlCommand(String sql, DbConnection mysql);

          T GetDataValue<T>(IDataReader dr, string columnName);

          void PrepareCommand(DbConnection conn, DbTransaction trans, DbCommand cmd, CommandType cmdType, string cmdText, DbParameter[] cmdParms);

          DbDataReader ExecuteReader(string cmdText, params DbParameter[] cmdParms);

          int ExecuteNonQuery(DbCommand cmd);

          int ExecuteNonQuery(string strSQL, DbParameter[] paras, CommandType cmdType);

          int ExecuteNonQuery(string strSQL);

          int ExecuteNonQuery(string strSQL, DbParameter[] paras);

          DataSet ExecuteDataSet(string cmdText);

          DataTable GetTable(string cmdText);

          object ExcuteScalarSQL(string strSQL, DbParameter[] paras, CommandType cmdType);

          object ExcuteScalarSQL(string strSQL);

          object ExcuteScalarSQL(string strSQL, DbParameter[] paras);

    }
}