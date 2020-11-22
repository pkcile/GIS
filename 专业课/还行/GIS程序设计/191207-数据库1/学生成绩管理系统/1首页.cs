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

namespace 学生成绩管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtKey.Text = "";
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtKey.Text == "" || this.txtUser.Text == "")
            {
                MessageBox.Show("用户没有输入密码或账户");
                return;
            }
            else
            {
                //定义两个变量存入文本框输入的姓名和密码
                Temp.usernameInput = this.txtUser.Text.Trim();
                Temp.passwordInput = this.txtKey.Text.Trim();
                //建立连接
                MySqlConnection conn = new MySqlConnection(Temp.connStr);              
                conn.Open();
                //执行数据库操作
                Temp.sqlSelect = "select * from  user where username='" + Temp.usernameInput + "' and password='" + Temp.passwordInput + "'";//查询匹配账号和密码,Sql
                MySqlCommand cmd = new MySqlCommand(Temp.sqlSelect, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Temp.userTrueId = reader["ID"].ToString();//ID
                    Temp.userTrueName = reader["username"].ToString();//姓名
                    Temp.userTrueKey = reader["password"].ToString();//密码
                    Temp.role = reader["role"].ToString();//角色
                    Form3 fm3 = new Form3();//打开成绩查询界面
                    fm3.Show();
                }
                else
                {
                    MessageBox.Show("你输入的密码或账号错误");
                    txtUser.Text = "";
                    txtKey.Text = "";              
                }
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
        }
    }
}
