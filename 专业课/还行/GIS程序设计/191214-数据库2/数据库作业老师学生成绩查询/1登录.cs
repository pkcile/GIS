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

namespace 数据库作业老师学生成绩查询
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //执行sql语句
            string sqlstr = "select * from user where username='" + txtName.Text + "' and password ='" + txtKey.Text + "';";
            MySqlCommand cmd = new MySqlCommand(sqlstr, Temp.connect());
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Temp.userTrueName = reader["username"].ToString();
                Temp.userTruePassword= reader["password"].ToString();
                Temp.userTrueID = reader["id"].ToString();
                Temp.userTrueRole = reader["role"].ToString();
                Form2 fm = new Form2();
                fm.Show();
            }
            Temp.connect().Close();

        }
    }
}
