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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string ifuserID = "";
        private void btnOK_Click(object sender, EventArgs e)//成绩修改
        {
            //连接数据库  
            //执行：学生成绩修改
            string strsql = "update score set math=" + txtMath.Text + ",english=" + txtEnglish.Text + ",chinese=" + txtChinese.Text + " where userID='" + txtUserID.Text + "';";
            MySqlCommand cmd = new MySqlCommand(strsql,Database.connect());
            cmd.ExecuteNonQuery();
            //关闭连接
            Database.connect().Close();
            //显示
            txtSum.Text = (Convert.ToDouble(txtMath.Text) + Convert.ToDouble(txtEnglish.Text) + Convert.ToDouble(txtChinese.Text)) + "";
            MessageBox.Show("成绩修改成功，姓名：" + txtUserName.Text + "\n" + "数学" + txtMath.Text + "\n" + "英语" + txtEnglish.Text + "\n" + "语文" + txtChinese.Text + "\n" + "总分" + txtSum.Text + "\n", "成绩修改成功");
            
        }
        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            //连接数据库
            //执行：ID已知的情况下，成绩的查询
            string sql = "select * from score where userID='" + txtUserID.Text + "';";
            MySqlCommand cmd = new MySqlCommand(sql, Database.connect());
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMath.Text = reader["math"].ToString();
                txtEnglish.Text = reader["english"].ToString();
                txtChinese.Text = reader["chinese"].ToString();
                try
                {
                    txtSum.Text = Convert.ToDouble(txtMath.Text) + Convert.ToDouble(txtEnglish.Text) + Convert.ToDouble(txtChinese.Text) + "";
                }
                catch { };//三门成绩中有为null的字段
            }
            //关闭连接
            Database.connect().Close();
            //清除为txtUserName空时的显示
            if (txtUserName.Text == "")
            {
                txtMath.Text = "";
                txtEnglish.Text = "";
                txtChinese.Text = "";
                txtSum.Text = "";
                txtUserID.Text = "";
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            //每次换内容后清除
            txtMath.Text ="";
            txtEnglish.Text ="";
            txtChinese.Text = "";
            txtSum.Text = "";
            txtUserID.Text = "";
            //连接数据库
            //执行：ID的查询
            string sql = "select ID from user where username='"+txtUserName.Text+"';";
            MySqlCommand cmd = new MySqlCommand(sql,Database.connect());
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtUserID.Text = reader["ID"].ToString();
            }
            //关闭连接
            Database.connect().Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMath.Text = "";
            txtEnglish.Text = "";
            txtChinese.Text = "";
            txtSum.Text = "";
            txtUserID.Text = "";
            txtUserName.Text = "";
        }

        private void CreateUserID(object sender, EventArgs e)//查询userID是否存在,未完成
        {
            //连接数据库
            //执行：查询、插入
            string strsql1 = "SELECT COUNT(userID) FROM score WHERE userID='" + txtUserID.Text + "';";
            MySqlCommand cmd = new MySqlCommand(strsql1,Database.connect());
           ifuserID =(cmd.ExecuteScalar()).ToString();
            //关闭连接
           Database.connect().Close();
        }
    }
}
