using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace 学生查询he老师查询修改系统
{
    class Database
    {
        public static MySqlConnection connect()
        {
         //   string connstr = "server=120.79.178.19;user id=root;password=lljcsw;database=mydatabase;charset=utf8";
           string connstr = "server=localhost;user id=root;password=qqmm7591251314;database=pkcile;charset=utf8";
            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();
            return conn;
        }
    }
}
