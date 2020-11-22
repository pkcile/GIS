using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace 学生查询he老师查询修改系统
{
    public partial class Form2 : Form
    {
        string username="",math="",english="",chinese="",Sum="";
        int userid=0;
        public Form2(string userID,string userName)
        {
            InitializeComponent();
            this.username = userName;
            this.userid = Convert.ToInt32(userID);
            this.Text = userName + "的成绩查询";
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            //连接数据库
            //执行：查找，学生成绩读取
            string strsql = "select * from score where userID = " + userid + ";";
            MySqlCommand cmd = new MySqlCommand(strsql, Database.connect());
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                math = reader["math"].ToString();
                english = reader["english"].ToString();
                chinese = reader["chinese"].ToString();
                Sum = (Convert.ToDouble(math) + Convert.ToDouble(english) + Convert.ToDouble(chinese)) + "";
            }
            //关闭连接
            Database.connect().Close();
            //显示
            txtMath.Text = math;
            txtEnglish.Text = english;
            txtChinese.Text = chinese;
            txtSum.Text = Sum;       
        }
    }
}
