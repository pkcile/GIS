using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学习成绩计算器
{
    public partial class Form1 : Form
    {
        string[] name = new string[8] { "刘备", "孙权", "诸葛亮", "关羽", "张飞", "吕布", "曹操", "周瑜" };
        int[] result = new int[8] { 85, 75, 98, 80, 65, 70, 99, 90 };
        //********************第一个任务********************
        public Form1()
        {
            InitializeComponent();
        }

        public void btnInset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                this.lblPrin.Text += "\n\n" + name[i] + "   " + result[i].ToString() + "\n";
            }//********************第一个任务********************打印

        }

        private void btnM_Click(object sender, EventArgs e)
        {
            //********************第二个任务********************显示最大和最小者的名字
            int[] resultcopy = new int[8];
            int[] resultcopy1 = new int[8];
            int max = 0, min = 0;//将其两个初值设为0；
            for (int i = 0; i < 8; i++)//复制两份result数组
            {
                resultcopy[i] = result[i];
                resultcopy1[i] = result[i];
            }
            for (int i = 0, k = 0; i + 1 < 8; i++, k++)//求出最大值和最小值的索引值
            {
                if (resultcopy[0] < resultcopy[i])//求最大值索引值
                {
                    int t;
                    t = resultcopy[0];
                    resultcopy[0] = resultcopy[i];
                    resultcopy[i] = t;
                    max = i;
                }
                if (resultcopy1[0] > resultcopy1[i])//求最小值索引值
                {
                    int t;
                    t = resultcopy1[0];
                    resultcopy1[0] = resultcopy1[i];
                    resultcopy1[i] = t;
                    min = i;
                }
            }
            this.lblM.Text += "\n\n" + name[max] + "     " + name[min] + "\n " + result[max] + "       " + result[min];    //整数可以不转字符型，因为其中存在字符型的     
        }


        private void txtInt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "学习成绩计算器";//左上方标题
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //*********************第四个任务*******************排序  
            //复制result数组，避免其影响第一个按钮的显示结果
            int[] result2 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                result2[i] = result[i];
            }
            int[] s1 = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };//模拟序列编号

            for (int i = 0; i < 8; i++)
            {
                for (int k = i + 1; k < 8; k++)
                {
                    if (result2[i] < result2[k])
                    {
                        int t, temp;
                        //排序
                        t = result2[i];
                        result2[i] = result2[k];
                        result2[k] = t;
                        //85, 75, 98, 80, 65, 70, 99, 90
                        //调换索引值
                        //理想索引值排序：6 2 7 0 3 1 5 4
                        temp = s1[i];
                        s1[i] = s1[k];
                        s1[k] = temp;

                    }
                }
            }
            for (int m = 0; m < 8; m++)
            {
                this.lblJudge.Text += "\n\n" + name[s1[m]] + "   " + result2[m].ToString() + "\n";
            }
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            //**********************第三个任务*******************求平均值和标准差 
            double average = 0, standard;
            double sum = 0;
            for (int i = 0; i < 8; i++)//求平均数
            {
                average += (double)result[i] / result.Length;
            }
            for (int i = 0; i < 8; i++)//求方差
            {
                sum += Math.Pow((average - result[0]), 2);
            }
            standard = Math.Sqrt((sum) / result.Length);//标准差
            this.lblA.Text += "\n\n" + "标准差：" + standard.ToString() + "\n" + "平均值：" + average.ToString();
        }

        private void lblR_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);//退出窗体   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.lblPrin.Text = "名字   成绩   ";
            this.lblM.Text = "最大者   最小者";
            this.lblA.Text = "平均分  标准差";
            this.lblJudge.Text = "成绩由高到低排序 ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
