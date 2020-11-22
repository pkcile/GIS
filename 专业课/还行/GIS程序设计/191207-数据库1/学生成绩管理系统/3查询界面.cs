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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            lblName.Text = "姓名；"+Temp.userTrueName;
            lblId.Text = "ID："+Temp.userTrueId;
            lblRole.Text = "身份：" + Temp.role;
            groupBox1.Text = Temp.role+"之家";
            if (Temp.role == "教师")
            {
                this.pictureBox1.Image = imageList1.Images[1];
            }
            else
                this.pictureBox1.Image = imageList1.Images[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
 
            MySqlConnection conn = new MySqlConnection(Temp.connStr);   
            conn.Open();
            Temp.sqlUpdate = "update user set password='" + txtKey.Text + "' where username='" + Temp.userTrueName + "'";//Sql语句   
            //判断密码输入是否一致
            if (textBox2.Text != txtKey.Text && (textBox2.Text != "" && txtKey.Text != ""))
            {
                MessageBox.Show("你的密码输入不一致");
                return;
            }
             //判断设置密码和之前密码是否相同
            if (txtKey.Text == Temp.userTrueKey)
            {
                MessageBox.Show("设置密码和之前密码相同");
                return;
            }
            
            //判断密码输入是否完整
            if (txtKey.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("请填写完整");
            } 
            else
            {
                MySqlCommand cmd = new MySqlCommand(Temp.sqlUpdate, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("密码已修改");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//清除修改密码内容
        {
            txtKey.Text = "";
            textBox2.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void ShowButton(object sender, EventArgs e)//按钮的显示
        {
            if (txtKey.Text != "" || textBox2.Text != "")
            {
                this.btnOK.Visible = true;
                this.btnCancel.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //不同表个间的信息的交流
            MySqlConnection conn= new MySqlConnection(Temp.connStr);
            string sqlSelect = "select * from score where ID='"+Temp.userTrueId+"'";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sqlSelect,conn);
            MySqlDataReader reader=cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMath.Text = reader["math"].ToString();
                txtEnglish.Text = reader["english"].ToString();
                txtChinese.Text = reader["chinese"].ToString();

            }
            conn.Close();
            reader.Close();
        }
    }
}
