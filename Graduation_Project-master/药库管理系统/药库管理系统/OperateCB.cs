using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace 药库管理系统
{
    class OperateCB
    {
        private string connectionString = "Server=(local);database=Login;Integrated security=true";
        private SqlConnection conn = null;
        #region  打开数据库连接
        private void Open()
        {
            if (conn == null)
            {
                conn = new SqlConnection(connectionString);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        #endregion
        #region  关闭连接
        public void Close()
        {
            if (conn != null && conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
        #endregion
        #region  释放数据库连接资源
        public void Dispose()
        {
            if (conn != null)
            {
                conn.Dispose();
                conn = null;
            }
        }
        #endregion
        #region  执行SqlCommand命令
        public int ExecuteSql(string sqlstring)
        {
            this.Open();
            SqlCommand com = new SqlCommand(sqlstring, conn);
            int n = com.ExecuteNonQuery();
            this.Close();
            this.Dispose();
            return n;
        }
        #endregion
        #region  创建DataSet对象
        public DataSet GetDataSet(string sqlstring, string tableName)
        {
            this.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlstring, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, tableName);
            this.Close();
            this.Dispose();
            return ds;
        }
        #endregion
        #region 创建SqlDataReader对象
        public SqlDataReader GetDataReader(string sqlstring)
        {
            this.Open();
            SqlCommand com = new SqlCommand(sqlstring, conn);
            SqlDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
        #endregion

    }
}
