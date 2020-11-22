using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace 贪吃蛇
{
    public partial class Form1 : Form
    {
        List<int> x = new List<int>();//定义一个x、y的数组
        List<int> y = new List<int>();
        int biaoshi=0;//自动走那个方向
        List<int> addx = new List<int>();//定义食物的x、y的 坐标
        List<int> addy = new List<int>();
        bool food = false;//判断是否有食物的出现
        private double grades = 0;//记录成绩
        private int speed = 1000;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)//开始
        {
            begin();//画布布局,初始化
            x.Clear(); y.Clear(); addx.Clear(); addy.Clear();  
             x.Add(8+40*3); x.Add(8+40*4); x.Add(8+40*5);
             y.Add(8+40*2); y.Add(8+40*2); y.Add(8+40*2);
             label2.Text = "label2"; label4.Text = "label4";
             grades = 0;
             display();//用循环遍历起始块数
             biaoshi = 1;//表示上下内容
             timer1.Enabled = true;
             timer2.Enabled = true;
           
        } 
        public void up()//上移
        {
            clear(x.Count);//清除红块
            biaoshi = 2;//标识方向
            if (addmethod())//判断是否需要添加
                add();
            remove();//移动
            y[0] = y[0] - 40;//移动
            borderifandpaint();//判断边界及绘制
        }
        public void down()//下移
        {
            clear(x.Count);
            biaoshi = 3;
            if (addmethod())
                add();
            remove();
            y[0] = y[0] + 40;
            borderifandpaint();
        }
        public void left()//左移
        {
            clear(x.Count);
            biaoshi = 4;
            if (addmethod())
                add();
            remove();
            x[0] = x[0] - 40;
            borderifandpaint();
        }
        public void right()//右移
        {
            clear(x.Count);
            biaoshi = 5;
            if (addmethod())
                add();
            remove();
            x[0] = x[0] + 40;
            borderifandpaint();
        }
        public void begin()//画布布局，
        {
            Graphics g = panel1.CreateGraphics();
            Pen pen1 = new Pen(Color.Gray, 8);
            for (int i = 0; i <= 9; i++)
            {
                //画横线, 线宽8，块宽32      
                g.DrawLine(pen1, 0, 4 + 40 * i, 8+40*9, 4 + 40 * i);
                //画竖线
                g.DrawLine(pen1, 4 + 40 * i, 0, 4 + 40 * i, 8+40*9);
            }
           
        }
        public void display()//用循环遍历块数
        {
            for (int i = 0; i < x.Count; i++)
            {
                paintsnake(x[i], y[i],1);
            }
        }
        public void paintsnake(int x, int y,int color)//颜色转换
        {
            Graphics g = panel1.CreateGraphics();
            switch (color)
            {
                case 1: SolidBrush brushRed = new SolidBrush(Color.Red); g.FillRectangle(brushRed, x, y, 32, 32); break;
                case 2: SolidBrush brushBlack = new SolidBrush(Color.Black); g.FillRectangle(brushBlack, x, y, 32, 32); break;
                case 3: SolidBrush brushGreen = new SolidBrush(Color.Green); g.FillRectangle(brushGreen, x, y, 32, 32); break;
               
            }
            
           
        }
        public void clear(int number)//清除变黑
        {
            for (int i = 0; i < number; i++)
            {
                paintsnake(x[i], y[i],2);
            }
        }
        public void clearfood(int number)//清除变黑
        {
            for (int i = 0; i < number; i++)
            {
                paintsnake(addx[i], addy[i], 2);
            }
        }
        public void borderifandpaint()//动态走动效果消失与否判断，及画出显示
        {
            begin();
            bool border = bordermethod(x.Count);
            if (border)
                display();
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                label2.Text = "" + grades;
                label4.Text = "你已阵亡";
                if(addx.Count>=1)
                paintsnake(addx[addx.Count - 1], addy[addx.Count - 1],2);//涂黑

            } 
        }
        public void remove()//移动
        {
             for (int i = x.Count - 1; i > 0; i--)
            {
                x[i] = x[i - 1];
                y[i] = y[i - 1];
            }
        }
        public bool bordermethod(int n)//矩形边界判断
        {
            bool border1 = false;
            int border11 = 0;
            for (int i = 1; i < x.Count; i++)
            {
                if (x[0] < 8 || x[0] > 8+40*8 || y[0] < 8 || y[0] > 8+40*8 || (x[0] == x[i] && y[0] == y[i]))
                    border11 += 1;  
            }
            if (border11 == 0)
                border1 = true;
            return border1;
        }
        public bool addmethod()//蛇是否添加判断
        { 
            bool addif=false;
            //int a = x[0]; int b = addx[0];
            if (food == true&&addx.Count>=1&&addy.Count>=1)
            {
                if (x[0] == addx[addx.Count - 1] && y[0] == addy[addx.Count - 1])
                    addif = true;
            }
            return addif;
        }
        public void add()//为蛇添加蛇尾巴
        {      
            x.Add(addx[0]); y.Add(addy[0]);
            switch (speed)//分数设定，根据速度设定
            {
                case 200: grades += 5; break;
                case 600: grades += 4; break;
                case 1000: grades += 3; break;
                case 1400: grades += 2; break;
                case 1800: grades += 1; break;
            }
            
        }
        public bool randomfood()//食物随机出现
        {
            clearfood(addx.Count);
            Random random = new Random();
            random.Next(0,9);
            addx.Add(8 + random.Next(0, 9) * 40);
            addy.Add(8 + random.Next(0, 9) * 40);
            paintsnake(addx[addx.Count-1],addy[addx.Count-1],3);   
            return true;

        }
     
        private void btnUp_Click(object sender, EventArgs e)
        {
            up();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            down();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            left();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            right();
        }

    
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (biaoshi)
            {
                case 1: left(); break;
                case 2: up(); break;
                case 3: down(); break;
                case 4: left(); break;
                case 5: right(); break;      
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            food = randomfood();
          //  控制多长时间才出现一个格子
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(speed>200)
            speed-=400;
            this.timer1.Interval =400 ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(speed<1800)
            speed+=400;
            this.timer1.Interval = speed; 
        }

    }
}

//1.如何通过键盘的键位来控制方向
//2.如何使用类，方法多后需要一个文件夹来包起来
//3.咬到身体除第三节的其他部分怎么处理

