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
    public partial class Form3 : Form
    {
        string username = "";
        public Form3(string username)
        {
            this.username = username;  
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form4 fm = new Form4();
            fm.Show();
        }  
        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = username + "老师";
            //连接数据库
            //执行：查询，成绩绑定显示
            string strsql = "select * from score";
            DataSet myds = new DataSet();
            MySqlDataAdapter myda = new MySqlDataAdapter(strsql, Database.connect());
            myda.Fill(myds, "成绩表");
        
            dataGridView1.GridColor = Color.Black;
            DataTable mydt=myds.Tables["成绩表"];
            DataColumn mycoll = mydt.Columns.Add("姓名",Type.GetType("System.String"));
            dataGridView1.DataSource = myds.Tables["成绩表"];
            // 关闭连接
            Database.connect().Close();

        }
    }

}
