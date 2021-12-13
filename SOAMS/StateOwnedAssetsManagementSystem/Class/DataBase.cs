using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMPEsystem
{
    public class DataBase
    {
        /// <summary>
        /// 创建数据库连接
        /// </summary>
        /// <returns></returns>
        public static SqlConnection Connect()
        {

            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "DESKTOP-B5R3760",
                UserID = "sa",
                Password = "xz010912",
                InitialCatalog = "SOAMS"
            };

            SqlConnection sqlConnection = new SqlConnection(connectionStringBuilder.ToString());
            sqlConnection.Open();
            return sqlConnection;
        }
        /// <summary>
        /// 执行增删改语句
        /// </summary>
        /// <param name="statement"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static bool StatementExecute(string statement)
        {
            SqlConnection connection = DataBase.Connect();
            SqlCommand sqlCommand = new SqlCommand(statement, connection);
            int affectedRows = sqlCommand.ExecuteNonQuery();
            if (affectedRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 执行查询语句
        /// </summary>
        /// <param name="statement"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static SqlDataReader QueryExecute(string statement)
        {
            SqlConnection connection = DataBase.Connect();
            SqlCommand sqlCommand = new SqlCommand(statement, connection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }
    }
}
