using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 贪吃蛇_12_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //***********键盘事件添加内容**********
            this.KeyPreview = true;//激活KeyPress，窗体比控件优先获得键盘事件的激活权
         
        }
        const int rectangle = 32, line = 8, rectangleAll = 40,rectangleNumber=9;
        Keys onkey; //存入键盘
       
        List<int> x = new List<int>();//蛇体
        List<int> y = new List<int>();//蛇体
        List<int> x0 = new List<int>();//只需存一个值，食物
        List<int> y0 = new List<int>();//只需存一个值，食物
        int score = 0,biaoshi=0;//上、下、左、右对应标识：1、2、3、4
        bool remove = true; int removebiaoshi = 0;//蛇运动开关
        private int speed = 1000;//蛇的速度
        private void btnBegin_Click(object sender, EventArgs e)//初始化
        {
            //初始化
            x.Clear(); y.Clear(); x0.Clear(); y0.Clear(); biaoshi = 3; remove = true;//开始向左移动
            timer3.Enabled = true; timer3.Interval = 1000; speed = 1000;//自动执行打开，速度设置
            timer2.Enabled = true;//食物出现，（timer1负责食物消失）
            score = 0;//分数初始化
            lblCondition.Text = "状态"; lblScore.Text = "分数"; this.lblSpeed.Text = speed + "毫秒/单位";
            //画框布局
            Graphics g = panel1.CreateGraphics();
            Pen pen1 = new Pen(Color.Gray, 8); //框子颜色：灰      
            SolidBrush brush1 = new SolidBrush(Color.Red);//蛇的颜色：红
            SolidBrush brush2 = new SolidBrush(Color.Black);//初始化方块的颜色：黑
            g.FillRectangle(brush2,0,0,600,600);//全局变黑
            for (int i = 0; i <= rectangleNumber; i++)
            {
                //画横线,比如：线宽8px，块宽32px ，一个单位40px     
                g.DrawLine(pen1, 0, line/2 + rectangleAll * i, line + rectangleAll * rectangleNumber, line/2 + rectangleAll * i);
                //画竖线
                g.DrawLine(pen1, line/2 + rectangleAll * i, 0, line/2 + rectangleAll * i, line + rectangleAll * rectangleNumber);
            }
            x.Add(line + 5 * rectangleAll); y.Add(line + 2 * rectangleAll);
            x.Add(line + 6 * rectangleAll); y.Add(line + 2 * rectangleAll);
            x.Add(line + 7 * rectangleAll); y.Add(line + 2 * rectangleAll);
            for(int i=0;i<x.Count;i++)//起始三个红色方块
            {
                g.FillRectangle(brush1,x[i],y[i],rectangle,rectangle);
            }
        }
        private int  borderJudge()//死亡处理
        {
            //边界判断
            int coincide = 0;//死亡标识符
            for (int i = 0; i < x.Count; i++)
            {

                //如果蛇头撞到身子      
                for (int k = 1; k < x.Count; k++)
                {
                    if (x[0] == x[k] && y[0] == y[k])
                        coincide += 1;
                }
                //如果蛇头撞到边界
                if (x[0] < line || x[0] > 9 * rectangleAll || y[0] < line || y[0] > 9 * rectangleAll)
                    coincide += 1;  
            }
            if (coincide > 0)
            {
                remove = false;
                timer1.Enabled = false;//食物显示关闭
                timer2.Enabled = false;//清除食物，可开，可关
                timer3.Enabled = false;//移动关闭
                this.lblCondition.Text = "你已经死亡";
                this.lblScore.Text = "" + score;
                //死亡后的措施
                //1.分数、状态
                //打印游戏结束
                Graphics g = panel1.CreateGraphics();
                SolidBrush brush1 = new SolidBrush(Color.Blue);//画出的图形颜色：蓝色
                SolidBrush brush2 = new SolidBrush(Color.Black);//初始化画布的颜色：黑色
                g.FillRectangle(brush2, 0, 0, 600, 600);//初始化范围：x轴方向0px-600px,y轴方向0px-600px
                for (int i = 0; i < 9; i++)
                {
                    //2字
                    g.FillRectangle(brush1, 20+10 * i, 100, 8, 8);
                    g.FillRectangle(brush1, 20+10 * i, 190, 8, 8);
                    g.FillRectangle(brush1, 100-10*i, 110+10*i, 8, 8);   
                    //0字
                    g.FillRectangle(brush1, 120+10*i, 100, 8, 8);
                    g.FillRectangle(brush1, 120+10*i, 190, 8, 8);
                    g.FillRectangle(brush1, 120, 100+10*i, 8, 8);
                    g.FillRectangle(brush1, 200, 100+10*i, 8, 8);
                    //2字
                    g.FillRectangle(brush1, 220 + 10 * i, 100, 8, 8);
                    g.FillRectangle(brush1, 220 + 10 * i, 190, 8, 8);
                    g.FillRectangle(brush1, 300 - 10 * i, 110 + 10 * i, 8, 8);
                    //0字
                    g.FillRectangle(brush1, 320 + 10 * i, 100, 8, 8);
                    g.FillRectangle(brush1, 320 + 10 * i, 190, 8, 8);
                    g.FillRectangle(brush1, 320, 100 + 10 * i, 8, 8);
                    g.FillRectangle(brush1, 400, 100 + 10 * i, 8, 8);
                }
                    return 0;//不画出移动一单位的蛇的图像的标识，即不显示
            }
            else
                return 1;//画出移动一单位的蛇的图像的标识，即显示

        }
        private void up()//上
        {
            if (remove == true && x.Count > 0)
            {
                //清除
                Graphics g = panel1.CreateGraphics();
                SolidBrush brush1 = new SolidBrush(Color.Red);//蛇身颜色
                SolidBrush brush2 = new SolidBrush(Color.Black);//初始化方块颜色
                for (int i = 0; i < x.Count; i++)
                {
                    g.FillRectangle(brush2, x[i], y[i], rectangle, rectangle);
                }
                //逻辑
                biaoshi = 1;//向上标识
                //判段添加的代码与
                int xLast = x[x.Count - 1], yLast = y[x.Count - 1];//将蛇最后一个点存到两个变量中
                for (int i = x.Count - 1; i >= 1; i--)//x[0]、y[0]后的变换
                {
                    x[i] = x[i - 1];
                    y[i] = y[i - 1];
                }
                x[0] = x[0] + 0;
                y[0] = y[0] - rectangleAll;
                if (x0.Count == 1)
                {
                    if (x0[0] == x[0] && y0[0] == y[0])//若蛇头与随机的食物相等则添加
                    {
                        x.Add(xLast);
                        y.Add(yLast);
                        //score+=
                        switch (speed)//分数设定，根据速度设定
                        {
                            case 200: score += 5; break;
                            case 600: score += 4; break;
                            case 1000: score += 3; break;
                            case 1400: score += 2; break;
                            case 1800: score += 1; break;
                            case 2200: score += 0; break;
                        }
                    }
                }
                //边界判断
                borderJudge();
                if (borderJudge() == 1)
                {
                    for (int i = 0; i < x.Count; i++)
                    {
                        g.FillRectangle(brush1, x[i], y[i], rectangle, rectangle);
                    }
                }

            }
            else//移动能进行后的操作
            {
                if (remove == false)
                {
                }
                else//进入页面直接点上、下、左或右键才会触发
                {
                    Graphics g = panel1.CreateGraphics();
                    SolidBrush brush2 = new SolidBrush(Color.Black);//初始化颜色
                    g.FillRectangle(brush2, 0, 0, 600, 600);//初始化范围
                    SolidBrush brushBlue = new SolidBrush(Color.Blue);
                    for (int i = 0; i < 12; i++)
                    {

                        g.FillRectangle(brushBlue, 130 + i * 10, 235, 6, 6);//横线1
                        g.FillRectangle(brushBlue, 165, 95 + i * 12, 6, 6);//竖线1
                        g.FillRectangle(brushBlue, 165 + i * 6, 95 + 12 * 6, 4, 6);//横线1    
                    }
                }
            }
            
        
        }
        private void down()//下
        {
            if (remove == true && x.Count > 0)//满足移动条件&满足有初始方块
            {
                //清除
                Graphics g = panel1.CreateGraphics();
                SolidBrush brush1 = new SolidBrush(Color.Red);
                SolidBrush brush2 = new SolidBrush(Color.Black);
                for (int i = 0; i < x.Count; i++)
                {
                    g.FillRectangle(brush2, x[i], y[i], rectangle, rectangle);
                }
                //逻辑
                biaoshi = 2;//向下标识
                //判段添加的代码与
                int xLast = x[x.Count - 1], yLast = y[x.Count - 1];//将蛇最后一个点存到两个变量中
                for (int i = x.Count - 1; i >= 1; i--)//x[0]、y[0]后的变换
                {
                    x[i] = x[i - 1];
                    y[i] = y[i - 1];
                }
                x[0] = x[0] + 0;
                y[0] = y[0] + rectangleAll;
                if (x0.Count == 1)
                {
                    if (x0[0] == x[0] && y0[0] == y[0])//若蛇头与随机的食物相等则添加
                    {
                        x.Add(xLast);
                        y.Add(yLast);
                        switch (speed)//分数设定，根据速度设定
                        {
                            case 200: score += 5; break;
                            case 600: score += 4; break;
                            case 1000: score += 3; break;
                            case 1400: score += 2; break;
                            case 1800: score += 1; break;
                            case 2200: score += 0; break;
                        }
                    }
                }
                //边界判断
                borderJudge();

                if (borderJudge() == 1)
                {
                    for (int i = 0; i < x.Count; i++)
                    {
                        g.FillRectangle(brush1, x[i], y[i], rectangle, rectangle);
                    }
                }
            }

            else
            {
                if (remove == false)
                { }
                else//进入页面直接点上、下、左或右键才会触发
                {
                    Graphics g = panel1.CreateGraphics();
                    SolidBrush brush2 = new SolidBrush(Color.Black);//初始化颜色
                    g.FillRectangle(brush2, 0, 0, 600, 600);//初始化范围
                    SolidBrush brushBlue = new SolidBrush(Color.Blue);
                    for (int i = 0; i < 12; i++)
                    {

                        g.FillRectangle(brushBlue, 120 + i * 10, 105, 6, 6);//横线1
                        g.FillRectangle(brushBlue, 165, 115 + i * 12, 6, 6);//竖线1

                    }
                    for (int i = 0; i < 7; i++)
                    {
                        g.FillRectangle(brushBlue, 165 + 8 * i, 140 + 8 * i, 6, 6);//竖线1

                    }
                }
            }


        }
        private void left()//左
        {
            if (remove == true && x.Count > 0)
            {
                //清除
                Graphics g = panel1.CreateGraphics();
                SolidBrush brush1 = new SolidBrush(Color.Red);
                SolidBrush brush2 = new SolidBrush(Color.Black);
                for (int i = 0; i < x.Count; i++)
                {
                    g.FillRectangle(brush2, x[i], y[i], rectangle, rectangle);
                }
                //逻辑
                biaoshi = 3;//向左标识
                //判段添加的代码与
                int xLast = x[x.Count - 1], yLast = y[x.Count - 1];//将蛇最后一个点存到两个变量中
                for (int i = x.Count - 1; i >= 1; i--)//x[0]、y[0]后的变换
                {
                    x[i] = x[i - 1];
                    y[i] = y[i - 1];
                }
                x[0] = x[0] - rectangleAll;
                y[0] = y[0] + 0;
                if (x0.Count == 1)
                {
                    if (x0[0] == x[0] && y0[0] == y[0])//若蛇头与随机的食物相等则添加
                    {
                        x.Add(xLast);
                        y.Add(yLast);
                        switch (speed)//分数设定，根据速度设定
                        {
                            case 200: score += 5; break;
                            case 600: score += 4; break;
                            case 1000: score += 3; break;
                            case 1400: score += 2; break;
                            case 1800: score += 1; break;
                            case 2200: score += 0; break;
                        }
                    }
                }
                //边界判断
                borderJudge();
                if (borderJudge() == 1)
                {
                    for (int i = 0; i < x.Count; i++)
                    {
                        g.FillRectangle(brush1, x[i], y[i], rectangle, rectangle);
                    }
                }
            }
            else
            {
                if (remove== false)
                { }
                else//进入页面直接点上、下、左或右键才会触发
                {
                    Graphics g = panel1.CreateGraphics();
                    SolidBrush brush2 = new SolidBrush(Color.Black);//初始化颜色
                    g.FillRectangle(brush2, 0, 0, 600, 600);//初始化范围
                    SolidBrush brushBlue = new SolidBrush(Color.Blue);
                    for (int i = 0; i < 12; i++)
                    {
                        g.FillRectangle(brushBlue, 120 + i * 12, 140, 8, 8);//横线1
                        g.FillRectangle(brushBlue, 160 + i * 8, 180, 6, 6);//横线2
                        g.FillRectangle(brushBlue, 155 + i * 9, 230, 6, 6);//横线3
                        g.FillRectangle(brushBlue, 200, 180 + i * 5, 6, 2);//竖直线
                        g.FillRectangle(brushBlue, 190 - i * 6, 90 + i * 12, 8, 6);//斜线

                    }
                }
            }
          
        }
        private void right()//右
        {
            if (remove == true && x.Count > 0)
            {
                //清除
                Graphics g = panel1.CreateGraphics();
                SolidBrush brush1 = new SolidBrush(Color.Red);
                SolidBrush brush2 = new SolidBrush(Color.Black);
                for (int i = 0; i < x.Count; i++)
                {
                    g.FillRectangle(brush2, x[i], y[i], rectangle, rectangle);
                }
                //逻辑
                biaoshi = 4;//向右标识
                //判段添加的代码与
                int xLast = x[x.Count - 1], yLast = y[x.Count - 1];//将蛇最后一个点存到两个变量中
                for (int i = x.Count - 1; i >= 1; i--)//x[0]、y[0]后的变换
                {
                    x[i] = x[i - 1];
                    y[i] = y[i - 1];
                }
                x[0] = x[0] + rectangleAll;
                y[0] = y[0] + 0;
                if (x0.Count == 1)
                {
                    if (x0[0] == x[0] && y0[0] == y[0])//若蛇头与随机的食物相等则添加
                    {
                        x.Add(xLast);
                        y.Add(yLast);
                        switch (speed)//分数设定，根据速度设定
                        {
                            case 200: score += 5; break;
                            case 600: score += 4; break;
                            case 1000: score += 3; break;
                            case 1400: score += 2; break;
                            case 1800: score += 1; break;
                            case 2200: score += 0; break;
                        }
                    }
                }
                //边界判断
                borderJudge();

                //界面显示
                if (borderJudge() == 1)
                {
                    for (int i = 0; i < x.Count; i++)
                    {
                        g.FillRectangle(brush1, x[i], y[i], rectangle, rectangle);
                    }
                }

            }
            else
            {
                if (remove == false)
                { }
                else//进入页面直接点上、下、左或右键才会触发
                {
                    Graphics g = panel1.CreateGraphics();
                    SolidBrush brush2 = new SolidBrush(Color.Black);//初始化颜色
                    g.FillRectangle(brush2, 0, 0, 600, 600);//初始化范围
                    SolidBrush brushBlue = new SolidBrush(Color.Blue);
                    for (int i = 0; i < 12; i++)
                    {
                        g.FillRectangle(brushBlue, 120 + i * 12, 140, 8, 8);//横线1
                        g.FillRectangle(brushBlue, 155 + i * 8, 180, 6, 6);//横线2
                        g.FillRectangle(brushBlue, 155 + i * 8, 235, 6, 6);//横线3
                        g.FillRectangle(brushBlue, 155, 180 + i * 5, 6, 4);//竖线1
                        g.FillRectangle(brushBlue, 245, 180 + i * 5, 6, 4);//竖线2
                        g.FillRectangle(brushBlue, 190 - i * 6, 90 + i * 12, 8, 6);//斜线

                    }
                }
            }
         
          
        }
        private void randomClear()//食物消除
        {
            //图像覆盖
            if (x0.Count == 1)
            {
                int k = 0;//图像清除标识
                for (int i = 0; i <= x.Count - 1; i++)//如果要消失的点和蛇任意一个点相等，标识
                {
                    if (x[i] == x0[0] && y[i] == y0[0])
                        k++;
                }
                if (k == 0)
                {
                    Graphics g = panel1.CreateGraphics();
                    SolidBrush brush2 = new SolidBrush(Color.Black);
                    if (x0.Count > 0)
                        g.FillRectangle(brush2, x0[0], y0[0], rectangle, rectangle);
                }

                //删除
                x0.Clear();
                y0.Clear();    
            }
        }
        private void randomAppear()//出现食物
        {
            timer1.Enabled = false;//清除功能关闭
            Graphics g = panel1.CreateGraphics();
            SolidBrush brush1 = new SolidBrush(Color.Blue);
            Random random = new Random();
            int x1 = 0, y1 = 0;
            for (int i = 0; ; i++)//不与蛇本身重复
            {
                int s = 0;
                x1 = random.Next(2, 4) * rectangleAll + line;
                y1 = random.Next(2, 4) * rectangleAll + line;
                for (int k = 0; k < x.Count; k++)
                {
                    if (x1 == x[k] && y1 == y[k])
                    {
                        s = s + 1;
                    }
                }
                if (s == 0)
                    break;
            }
            g.FillRectangle(brush1, x1, y1, rectangle, rectangle);
            y0.Add(y1); x0.Add(x1);//存入随机数值
            timer1.Enabled = true;//清除功能打开，重新开始计时
        }
        private void btnDown_Click(object sender, EventArgs e)//向下按钮
        {
            down();
        }
        private void btnRight_Click(object sender, EventArgs e)//向右按钮
        {
            right();
            this.lblSpeed.Text = speed + "毫秒/单位";
        }

        private void btnUp_Click(object sender, EventArgs e)//向上按钮
        {
            up();
            this.lblSpeed.Text = speed + "毫秒/单位";
        }

        private void btnLeft_Click(object sender, EventArgs e)//向左按钮
        {
            left();

        }
   
        private void 食物呈现时间_Tick(object sender, EventArgs e)
        {
            //timer1：食物呈现时间:t=食物消失时的时间 - 食物刚出现时的时间
                randomClear();
            
                    
                
           
        }

        private void 第一次出现与第二次间隔时间_Tick(object sender, EventArgs e)
        {
            //timer2:t=第二次开始出现的时间 - 第一次开始出现的时间；
            randomAppear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblSpeed.Text = speed + "毫秒/单位";
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //让蛇能够自主的动
            switch (biaoshi)
            {
                case 1: up(); break;
                case 2: down(); break;
                case 3: left(); break;
                case 4: right(); break;
            }
        }

        private void btnSlow_Click(object sender, EventArgs e)
        {
            if (speed <=2200)
                speed += 400;
            this.timer3.Interval = speed;
            this.lblSpeed.Text = speed + "毫秒/单位";
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            if (speed >200)
                speed -= 400;
            this.timer3.Interval = speed;
            this.lblSpeed.Text = speed + "毫秒/单位";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            removebiaoshi++;
            if (removebiaoshi % 2 == 0)
            {
                remove = true;
                timer2.Enabled = true;//能出现食物
            }
            else
            {
                remove = false;
                timer2.Enabled = false;//不能出现食物
            }
        }

        private void SnakeDong(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                onkey = e.KeyCode;

            }
            switch (onkey)
            {
                case Keys.Up:
                    up();
                    this.lblSpeed.Text = speed + "毫秒/单位"; break;
                case Keys.Down:
                    down();
                    this.lblSpeed.Text = speed + "毫秒/单位"; break;
                case Keys.Left:
                    left();
                    this.lblSpeed.Text = speed + "毫秒/单位"; break;
                case Keys.Right:
                    right();
                    this.lblSpeed.Text = speed + "毫秒/单位"; break;

            }
        }
          //***********键盘事件，所需要的***********
          //覆盖默认的系统键处理方式，遇到方向键，则直接返回，系统不处理，这样键值就会被传递到窗体，触发KeyDown事件
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down ||
                keyData == Keys.Left || keyData == Keys.Right)
                return false;
            else
                return base.ProcessDialogKey(keyData);
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       

    }
}
