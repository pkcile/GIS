using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace 数据库作业老师学生成绩查询
{
    class Temp
    {
        public static string userTrueName = "";
        public static string userTruePassword = "";
        public static string userTrueID = "";
        public static string userTrueRole = "";
        public static string studentID = "";
        public static string studentName = "";


        public static MySqlConnection connect()
        {
            string connstr = "server=120.79.178.19;user id=root;password=lljcsw;database=mydatabase;charset=utf8";
            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();
            return conn;
        }
 
    }
}
