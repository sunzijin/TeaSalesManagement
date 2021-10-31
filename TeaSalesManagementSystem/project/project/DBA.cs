using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//使用命名空间
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace project
{
    class DBA
    {
        SqlConnection con;//建立连接
        SqlCommand com;
        SqlDataAdapter sda;
        public DBA()
        {
            con = null;
            com = null;
            init();
        }
        //初始化连接
        private void init()
        {
            con = new SqlConnection();
            con.ConnectionString = "server=.;database=Myteadatabase;User Id=sa;password=000000";
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

        }

        //非查询
        public int nonSelect(string sql)
        {
            com = new SqlCommand(sql, con);
            return com.ExecuteNonQuery();
        }
        //逐行查询
        public SqlDataReader selectOneRow(string sql)
        {
            com = new SqlCommand(sql, con);
            return com.ExecuteReader();
        }

        //全表查询 
        public DataTable selectTable(string sql)
        {
            sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];

        }

        //关闭连接
        public void close()
        {
            con.Close();
        }
    }
}
