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
    public partial class Form2 : Form
    {
        public Form2()//添加
        {
            InitializeComponent();//添加
            //添加
        }
        List<int> idTH = new List<int>();
        int createTeacher = 0;
        private void btnOK_Click(object sender, EventArgs e)
        {
            //part1:找到表中，id的最后一个数值
            MySqlConnection conn1 = new MySqlConnection(Temp.connStr);  //连接
            conn1.Open();
            string selectId = "select Id from user ";
            MySqlCommand cmd1 = new MySqlCommand(selectId,conn1);
            MySqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                idTH.Add(reader.GetInt32(0));
            }
            conn1.Close();
            int idFinal = idTH[idTH.Count - 1] + 1;//id的最后一个数值的下一位
            //part2:插入
            MySqlConnection conn = new MySqlConnection(Temp.connStr);
            conn.Open();
            try { Temp.role = comboBox1.SelectedItem.ToString(); }
            catch { Temp.role = comboBox1.Text; }//亦可输入角色
            Temp.sqlInsert = "insert into user (id,username,password,role) values('" + idFinal + "','" + txtName.Text + "','" + txtKey.Text + "','" + Temp.role + "')";//Sql语句
            if (createTeacher == 1)
            {
                if (txt.Text != "666")
                {
                    MessageBox.Show("教师认证错误");
                    return;
                }
            }
            MySqlCommand cmd = new MySqlCommand(Temp.sqlInsert,conn);//连接，导入
            //part3:判断条件
            if (txtKey2.Text != txtKey.Text && (txtKey2.Text != "" && txtKey.Text != ""))
            {
                MessageBox.Show("你的密码输入不一致");
                return;
            }
            if (txtKey2.Text == "" || txtKey.Text == ""||txtName.Text=="")
            {
                MessageBox.Show("请将信息输入完整");
            }
            else
            {
                cmd.ExecuteReader();//执行
                MessageBox.Show("恭喜" + Temp.role + "：" + txtName.Text + "\n" + "注册成功", "插入状态");
            }
            conn.Close();//关闭连接 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("教师");
            comboBox1.Items.Add("学生");
            comboBox1.SelectedIndex = 1;//初始选项为学生
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtKey.Text = "";
            this.txtKey2.Text = "";
            this.txtName.Text = "";

        }

        private void ifKey(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "教师")
                {
                    lbl.Visible = true;
                    txt.Visible = true;
                    createTeacher = 1;
                }
                else
                {
                    lbl.Visible = false;
                    txt.Visible = false;
                }
            }
            catch {

                lbl.Visible = false;
                txt.Visible = false;
            };
        }
    }
}
