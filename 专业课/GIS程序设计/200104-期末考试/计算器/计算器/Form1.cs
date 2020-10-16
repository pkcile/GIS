using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string tempNumber = "";
        string part1 = "";
        string part2 = "";
        string special = "";
        string showEvery = "";
        double result = -1;
        int operatorStatus = 0;//用于delete中运算符判别
        private void btn0_Click(object sender, EventArgs e)
        {
            showNumber(0);
        }
        public void showNumber(int number)
        {
            operatorStatus = 0;//未使用状态
            tempNumber += number + "";
            showEvery += number + "";
            textBox1.Text = showEvery;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            showNumber(1);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            showNumber(2);

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            showNumber(3);

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            showNumber(4);

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            showNumber(5);

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            showNumber(6);

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            showNumber(7);

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            showNumber(8);

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            showNumber(9);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Openrator("+"); 
        }
        public void Openrator(string openrator)
        {
            operatorStatus = 1;//使用状态
            part1 = tempNumber;
            tempNumber = "";
            special = openrator;
            showEvery += openrator;
            textBox1.Text = showEvery;
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Openrator("-"); 
        }
     

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Openrator("*"); 
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Openrator("/"); 
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            tempNumber += ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tempNumber = "";
            part1 = "";
            part2 = "";
            special = "";
            showEvery = "";
            result = -1;
            textBox1.Text = showEvery;
            txtResult.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //tempNumber
            //如果通过基础算法来解决分割问题，而不是通过方法
            //char，每次看是否为空
            //逐个读取字符串中的字符   
           //()
            if (operatorStatus == 1)//如果最后一位字符为运算符
            {
                special = "";
                operatorStatus = 0;//使用状态
                if (showEvery != "")
                {
                    tempNumber = showEvery.Substring(0, showEvery.Length - 1); //temp寄存减一
                }
            }
            else
            {
                if (part2 != "")//如果第二部分不为空
                {
                    tempNumber=part2.Substring(0, part2.Length - 1);
               
                }
                else
                    if (tempNumber != "")
                    {
                        tempNumber=showEvery.Substring(0, showEvery.Length - 1); //temp寄存减一

                        part1 = tempNumber;
                    }         
            }   
            if(showEvery!="")
                showEvery = showEvery.Substring(0, showEvery.Length - 1);//字符显示减一
            textBox1.Text = showEvery;//显示
         
          
          

        }

        private void btnBaifen_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            operatorStatus = 0;//
            part2 = tempNumber;//存入第二部分的值
            tempNumber = "";
            txtResult.Text = "";
            switch (special)
            {
                case "+": result = Convert.ToDouble(part1) + Convert.ToDouble(part2); break;//part1出现问题
                case "-": result = Convert.ToDouble(part1) - Convert.ToDouble(part2); break;
                case "*": result = Convert.ToDouble(part1) * Convert.ToDouble(part2); break;
                case "/": result = Convert.ToDouble(part1) / Convert.ToDouble(part2); break;
            }

            txtResult.Text = result+"";
            //MessageBox.Show(""+result);

        }
    }
}
