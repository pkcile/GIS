using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "简易计算器";
        }
        NumberCollect a = new NumberCollect();
        public void partly(string number)//寄存A+B=C中的A或B
        {
            a.part += number;
        }
        public void printly(string special)//显示A+B=C等形式
        {
            a.printf += special;
            this.textBox1.Text = a.printf;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            partly(a.number[0]);
            printly(a.number[0]);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            partly(a.number[1]);
            printly(a.number[1]);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            partly(a.number[2]);
            printly(a.number[2]);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            partly(a.number[3]);
            printly(a.number[3]);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            partly(a.number[4]);
            printly(a.number[4]);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            partly(a.number[5]);
            printly(a.number[5]);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            partly(a.number[6]);
            printly(a.number[6]);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            partly(a.number[7]);
            printly(a.number[7]);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            partly(a.number[8]);
            printly(a.number[8]);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            partly(a.number[9]);
            printly(a.number[9]);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            printly(a.FuHao1[0]);
            a.part1 = a.part;
            a.part = "";//清空
            a.FuHao = 1; 
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            printly(a.FuHao1[1]);
            a.part1 = a.part;
            a.part = "";
            a.FuHao = 2;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            printly(a.FuHao1[2]);
            a.part1 = a.part;
            a.part = "";
            a.FuHao = 3;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            printly(a.FuHao1[3]);
            a.part1 = a.part;
            a.part = "";
            a.FuHao = 4;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            a.part2 = a.part;
            if (a.part1 == "")//避免报错?
                a.part1 = "0";
            double partone = Convert.ToDouble(a.part1);
            if (a.part2 == "")//避免报错
                a.part2 = "0";
            double parttwo = Convert.ToDouble(a.part2);
            switch (a.FuHao)
            {
                case 1: a.result = partone + parttwo; break;
                case 2: a.result = partone - parttwo; break;
                case 3: a.result = partone * parttwo; break;
                case 4: a.result = partone / parttwo; break;
            }
            this.textBox1.Text = a.printf + "=" + a.result;
            a.part2 = "";
            a.part1 = "" + a.result;
            a.printf = "" + a.result;
            a.part = "" + a.result;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            a.part2 = "";
            a.part1 = "";
            a.printf = "";
            a.part = "";
            this.textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            printly(a.number[11]);//%
            double partone = 0.01 * Convert.ToDouble(a.part);
            a.part = Convert.ToString(partone);
            //a.part = 0.1 * a.part;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            partly(a.number[10]);
            printly(a.number[10]);
        }

    }
}
