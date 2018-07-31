using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BFCommonSystem.DAL
{
    /// <summary>
    /// User的数据访问层
    /// 
    /// </summary>
    public class UserService
    {
        //根据用户名查询用户信息
        public static DataTable GetUserInfoByUserName(string userName)
        {
            //建立与数据库的连接
            //1，连接字符串
            string connString = @"   ";
            //2，根据连接字符串，创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //ADO.NET代码
                //建立与数据库的连接
                string sql = string.Format(@"执行的sql语句");
               
                //3,打开连接
                conn.Open();
                //4,执行sql语句取数据
                SqlCommand cmd = new SqlCommand(sql, conn);
                //5,取数据到内存仓库
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                //建立一个临时仓库
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                //返回取到的数据
                return ds.Tables[0];

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
