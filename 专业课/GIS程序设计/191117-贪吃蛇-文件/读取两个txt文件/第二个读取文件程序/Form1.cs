using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 第二个读取文件程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> x = new List<string>();
        List<string> y = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            string str = filterprogress();//文件路径名
            string parts = filterkeep(str);  //读入文件内容
            string[] sum = parts.Split('@');//分成sum.Length个组
            for (int s = 1; s < sum.Length; s++)//分别求每部分的坐标
            {
                method(sum, s);//s传递索引值
            }
        }
        public string filterkeep(string str)//读入文件内容
        {
            StreamReader content = new StreamReader(str, Encoding.Default);
            string part = ""; string parts = "";
            while ((part = content.ReadLine()) != null)
            {
                parts = parts + part + ",";
            }
            content.Close();
            return parts;
        }
        public string filterprogress()//文件路径名
        {
            openFileDialog1.Title = "打开txt文档";
            openFileDialog1.Filter = "文本文件|*.txt";
            openFileDialog1.ShowDialog();
            string str = openFileDialog1.FileName;
            return str;
        }
        public void method(string[] sum, int s)//分别求每部分的坐标 
        {
            string[] sumpart1 = sum[s].Split(','); int k = 0;//分开

            for (int i = 0; i < sumpart1.Length; i++)//根据倍数关系分配关系
            {
                if (sumpart1[i] != "")
                {
                    k = k + 1;
                    {
                        {
                            if (k % 4 == 3)
                                x.Add(sumpart1[i]);
                            else
                                if (k % 4 == 0)
                                    y.Add(sumpart1[i]);


                        }
                  if (x.Count > 1 && y[y.Count - 1] == y[0] && x[x.Count - 1] == x[0])//结束标识！！！！
                  break;
                    }
                }
            }
          

            richTextBox1.Text += "第" + s + "组数据" + "\n";
            ifxy();  //判断x,y各点坐标都小于某一个值
            for (int m = 0; m < x.Count; m++)
            {
                richTextBox1.Text += "(" + x[m] + "," + y[m] + ")";
            }
            richTextBox1.Text += "\n\n";
            x.Clear();
            y.Clear();

        }
        public void ifxy()//判断x,y的值是否很大
        {
            int ifxy1 = 0;
            for (int s = 0; s < x.Count - 1; s++)
            {
                if (double.Parse(x[s]) > 300 || double.Parse(y[s]) > 300)
                    ifxy1 += 1;
                if (ifxy1 == 0)
                    paint();

            }
        }
        public void paint()//绘图
        {
            Graphics g = panel1.CreateGraphics();
            Pen pen1 = new Pen(Color.Red, 5);
            for (int m = 0; m < x.Count - 1; m++)
            {
                g.DrawLine(pen1, int.Parse(x[m]), int.Parse(y[m]), int.Parse(x[m + 1]), int.Parse(y[m + 1]));
            }
            g.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
