using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生成绩管理系统
{
    /// <summary>
    /// 变量存储
    /// </summary>
    class Temp
    {
        public static string userTrueId = "";//查询到的Id
        public static string userTrueName = "";//查询到的姓名
        public static string userTrueKey = "";//查询到的密码    
        public static string connStr = "server=localhost;user id=root;password=qqmm7591251314;database=pkcile;charset=utf8";
        public static string sqlSelect = "";
        public static string sqlUpdate = "";
        public static string sqlInsert = "";
        public static string role="学生";//角色
        public static string usernameInput;//输入的学号
        public static string passwordInput;//输入的密码

    }
}
