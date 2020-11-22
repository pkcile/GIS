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
    public partial class 登录页面 : Form
    {
        public 登录页面()
        {
            InitializeComponent();
        }
        string a = "";
        private void btnOK_Click(object sender, EventArgs e)
        {
            //连接数据库
            //执行：select判断，登录
            //string strsql = "select * from student where 学号 ='" + username + "' and password='" + password + "';";
            //MySqlCommand cmd = new MySqlCommand(strsql, myconn);
            //MySqlDataReader reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{

            //}
            //else
            //{
            //    MessageBox.Show("请输入正确的账号和密码");
            //    txtName.Text = "";
            //    txtKey.Text = "";
            //}
            ////关闭连接
            Database.connect().Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtKey.Text = "";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3(a);
            fm.Show();

        }
       
    }
}
