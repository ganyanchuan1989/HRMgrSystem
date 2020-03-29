using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace HRMgrSystem.db
{
    public class BaseDao 
    {
        protected MySqlConnection conn = DBUtils.GetConnection();

        public MySqlConnection getConn()
        {
            return conn;
        }
    }
}
