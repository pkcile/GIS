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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMath.Text = "";
            txtEnglish.Text = "";
            txtChinese.Text = "";
            if (Temp.userTrueRole == "教师")
            {
                //查询学生的ID
                string strsql = "select * from user where username='" + txtName.Text + "';";
                MySqlCommand cmd = new MySqlCommand(strsql, Temp.connect());
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Temp.studentID = reader["ID"].ToString();
                    Temp.studentName = reader["username"].ToString();
                }
                //查询学生的成绩
                string strsql2 = "select * from score where userID='" + Temp.studentID + "';";
                MySqlCommand cmd2 = new MySqlCommand(strsql2, Temp.connect());
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    txtMath.Text = reader2["math"].ToString();
                    txtEnglish.Text = reader2["english"].ToString();
                    txtChinese.Text = reader2["chinese"].ToString();
                }
                if (txtMath.Text == "" || txtEnglish.Text == "" || txtChinese.Text == "")//成绩查询结果判断
                {
                    MessageBox.Show(Temp.studentName + "userID:" + Temp.studentID + "\n" + "成绩未录入完整或空等情况");
                }
                Temp.studentName = "";
                Temp.studentID = "";
                Temp.connect().Close();
            }
            else
            {
                //查询学生成绩
                string strsql2 = "select * from score where userID='" + Temp.userTrueID + "';";
                MySqlCommand cmd2 = new MySqlCommand(strsql2, Temp.connect());
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    txtMath.Text = reader2["math"].ToString();
                    txtEnglish.Text = reader2["english"].ToString();
                    txtChinese.Text = reader2["chinese"].ToString();
                }
                if (txtMath.Text == "" || txtEnglish.Text == "" || txtChinese.Text == "")
                {
                    MessageBox.Show(Temp.userTrueName + "userID:" + Temp.userTrueID + "\n" + "成绩未录入完整或空等情况");
                }
                Temp.connect().Close();
            }
        }

       

        private void txtName_TextChanged_1(object sender, EventArgs e)
       {

        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            if (Temp.userTrueRole == "教师")
            {
                txtName.Visible = true;
                lblName.Visible = true;
            }
        }
    }
}
