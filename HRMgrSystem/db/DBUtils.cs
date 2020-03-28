using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using HRMgrSystem.vo;
using HRMgrSystem.utils;
using Dapper.Contrib.Extensions;


namespace HRMgrSystem.db
{
    public class DBUtils
    {

        public static MySqlConnection conn = null;

        public static MySqlConnection GetConnection()
        {
            if (conn != null)
                return conn;

            string mysqlConnectionStr = ConfigurationManager.ConnectionStrings["MsConnectionStr"].ToString();
            try
            {
                conn = new MySqlConnection(mysqlConnectionStr);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return conn;
        }

        /// <summary>
        /// CURD Test
        /// </summary>
        public static void Test()
        {
            
            using (IDbConnection conn = GetConnection())
            {
                // query 
                string sqlC = @"SELECT * FROM HR_CONTRACT";
                List<HRContract> cList = conn.Query<HRContract>(sqlC).ToList();
                Console.WriteLine(string.Format("result length:{0}", cList.Count));

                // Insert
                //var count2 = conn.Execute(@"insert HR_DEPT(id,name,header_id) values (@id, @name, @headerId)", new[] { new { id = 1112, name = "开发", headerId="23" }, });
                //// update
                //var count3 = conn.Execute(@"update HR_DEPT SET  name=@name WHERE id =@id", new { id = 1112, name = "开发xxx" });

                // delete
                conn.Execute(@"DELETE FROM HR_DEPT WHERE id = @id", new { id = 1112 });
            }

            // var dog = connection.Query<Dog>("select Age = @Age, Id = @Id", new { Age = (int?)null, Id = guid });
        }
    }
}
