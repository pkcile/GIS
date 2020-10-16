using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 俄罗斯方块12_14
{
    public partial class kuang : Form
    {

        public kuang()
        {
            InitializeComponent();
        }
        List<int> x = new List<int>();//下落方块
        List<int> y = new List<int>();
        int widethTangle = 30, wideth = 6, widethAll = 36;//方块宽度、边框宽度、一个单位
        const int LWnumber = 8;
        int[,] xy = new int[LWnumber, LWnumber];//方块个数
        int number = -1;//随机方块种类
        int  game = 1;//游戏结束判断标识
        int score = 0;//分数
        private void btnBegin_Click(object sender, EventArgs e)//起始界面
        {
            
            //画框
            Graphics g = panel1.CreateGraphics();
            Pen pen1 = new Pen(Color.Gray, wideth);
            SolidBrush brush1 = new SolidBrush(Color.Red);
            for (int i = 0; i <= LWnumber; i++)
            {
                g.DrawLine(pen1, 0, wideth / 2 + i * widethAll, LWnumber * widethAll + wideth, wideth / 2 + i * widethAll);//横线
                g.DrawLine(pen1, wideth / 2 + i * widethAll, 0, wideth / 2 + i * widethAll, LWnumber * widethAll + wideth);//竖线
            }
            //界面清除
            cleanGezi();
            //逻辑清除，逻辑归零
            x.Clear(); y.Clear();
            for (int k = 0; k < LWnumber; k++)
            {
                for (int m = 0; m < LWnumber; m++)
                 {
                    xy[k, m] = 0;
                }
            }
            score = 0;//分数归零
            game = 1;
            randomAdd();//随机方格
            timerSpeed.Enabled = true;
            //界面显示,界面归零
            displayAll();
            lblScore.Text = "分数";
            lblCondition.Text = "状态";

        }
        
        public SolidBrush colorKinds()//颜色
        {
            Graphics g = panel1.CreateGraphics();
            SolidBrush brush1 = new SolidBrush(Color.Purple);
            SolidBrush brush2 = new SolidBrush(Color.Green);
            SolidBrush brush3 = new SolidBrush(Color.Blue);
            if (number == 0)
                return brush1;
            else
                if (number == 1)
                    return brush2;
                else
                    return brush3;
        }

        public void randomAdd()//随机下落格子类型
        {
            Random random1 = new Random();
            number =random1.Next(0, 3);//随机抽取3种类型的下落物，0，1，2
            switch (number)
            {
                case 0:
                    {

                        x.Add(wideth + widethAll * 2); y.Add(wideth);
                        x.Add(wideth + widethAll * 3); y.Add(wideth);
                        if (xy[0,2] == 1 || xy[0, 3]==1)//注意不是（2，0）（3，0），第一个xy[m,n],m为y轴方向，n为x轴方向
                        {
                            x.Clear(); y.Clear();
                            game = 0;
                            lblScore.Text = ""+score;
                            lblCondition.Text = "游戏结束";
                        }

                    }
                    break;
                case 1:
                    {

                        x.Add(wideth + widethAll * 2); y.Add(wideth);
                        x.Add(wideth + widethAll * 2); y.Add(wideth + widethAll);
                        if (xy[0, 2] == 1 || xy[1, 2] == 1)
                        {
                            x.Clear(); y.Clear();
                            game = 0;
                            lblScore.Text = "" + score;
                            lblCondition.Text = "游戏结束";
                        }

                    }
                    break;
                case 2:
                    {
                        x.Add(wideth + widethAll * 2); y.Add(wideth);
                        x.Add(wideth + widethAll * 3); y.Add(wideth);
                        x.Add(wideth + widethAll * 2); y.Add(wideth + widethAll * 1);
                        if (xy[0, 2] == 1 || xy[0, 3] == 1||xy[1,2]==1)
                        {
                            x.Clear(); y.Clear();
                            game = 0;
                            lblScore.Text = "" + score;
                            lblCondition.Text = "游戏结束";
                        }
                    }
                    break;

            }

        }
        public void cleanGezi()//清除图像
        {
            Graphics g = panel1.CreateGraphics();
            //Pen pen2 = new Pen(Color.Black, wideth);
            SolidBrush brush2 = new SolidBrush(Color.Black);
            //清除下落格子
            for (int i = 0; i < x.Count; i++)
            {
                g.FillRectangle(brush2, x[i], y[i], widethTangle, widethTangle);
            }
            //清除已固定格子
            for (int k = 0; k < LWnumber; k++)//清除格子值为1部分
            {
                for (int n = 0; n < LWnumber; n++)
                {
                    if (xy[k, n] == 1)
                    {
                        g.FillRectangle(brush2, n * widethAll + wideth, k * widethAll + wideth, widethTangle, widethTangle);
                    }
                }
            }
            ////清除边框
            //   for (int i = 0; i <= LWnumber; i++)
            //   {
            //       g.DrawLine(pen2, 0, wideth / 2 + i * widethAll, LWnumber * widethAll + wideth, wideth / 2 + i * widethAll);//横线
            //       g.DrawLine(pen2, wideth / 2 + i * widethAll, 0, wideth / 2 + i * widethAll, LWnumber * widethAll + wideth);//竖线
            //   }
        }
        public void displayAll()//显示全部要素
        {
            Graphics g = panel1.CreateGraphics();
            //Pen pen1 = new Pen(Color.Gray, wideth);
            SolidBrush brush1 = new SolidBrush(Color.Red);
            SolidBrush brush3 = colorKinds();
            for (int k = 0; k < LWnumber; k++)//格子值为1部分
            {
                for (int n = 0; n < LWnumber; n++)
                {
                    if (xy[k, n] == 1)
                    {
                        g.FillRectangle(brush1, n * widethAll + wideth, k * widethAll + wideth, widethTangle, widethTangle);
                    }
                }
            }
            for (int i = 0; i < x.Count; i++)//下落部分
            {
                g.FillRectangle(brush3, x[i], y[i], widethTangle, widethTangle);
            }      
            //for (int i = 0; i <= LWnumber; i++)
            //{
            //    g.DrawLine(pen1, 0, wideth / 2 + i * widethAll, LWnumber * widethAll + wideth, wideth / 2 + i * widethAll);//横线
            //    g.DrawLine(pen1, wideth / 2 + i * widethAll, 0, wideth / 2 + i * widethAll, LWnumber * widethAll + wideth);//竖线
            //}
        }
        public void up()//单种下落格子位置变换
        {
            if (game == 1)
            {
                cleanGezi();
                //转换逻辑         
                switch (number)
                {
                    case 0:
                        {
                            int s = 0;
                            if (x[0] == x[1] && y[0] == y[1] + widethAll)//竖直，要减
                                s = 1;
                            else
                                if (x[0] == x[1] - widethAll && y[0] == y[1])//横的，要加
                                    s = -1;
                            switchPosition(s, 0, 0);
                        }
                        break;
                    case 1:
                        {
                            int s = 0;
                            if (x[0] == x[1] + widethAll && y[0] == y[1])//横的，要减
                                s = 1;
                            else
                                if (x[0] == x[1] && y[0] == y[1] - widethAll)//竖直，要加
                                    s = -1;
                            switchPosition(s, 0, 0);
                        }
                        break;
                    case 2:
                        {
                            int s = 0;
                            if (x[0] == x[1] && y[0] == y[1] + widethAll)//竖直，要减
                                s = 1;
                            else
                                if (x[0] == x[1] - widethAll && y[0] == y[1])//横的，要加
                                    s = -1;
                            switchPosition(s, 0, 0);

                        }
                        break;
                }

                //显现
                displayAll();
            }
        }
        public void down()//下移
        {
            if (game == 1)
            {
                cleanGezi();
                //移动逻辑
                int m = 0;
                for ( int i = 0; i < x.Count; i++)//1预测格子边界和重合问题
                {

                    if ((y[i] + widethAll) > (LWnumber - 1) * widethAll + wideth)//1.1如果超出下边界，标识加1
                    {
                        m = 1;
                    }
                    else
                        if (xy[(y[i] - wideth) / widethAll + 1, (x[i] - wideth) / widethAll] == 1)//1.2在未超下边界的基础上，若下一个格子值为1，标识加1
                        {
                            m = 1;
                        }
                }
                if (m == 0)//预测下落方块没有越界或重合，则执行该下落动作
                {
                
                    for (int i = 0; i < x.Count; i++)
                    {
                        y[i] = y[i] + widethAll;
                    }
                }
                else//预测下落方块将越界或重合
                {

                    for (int i = 0; i < x.Count; i++)
                    {
                        xy[(y[i] - wideth) / widethAll, (x[i] - wideth) / widethAll] = 1;
                    }
                    clearColumn();  //遍历，消除一行或多行，下移
                    x.Clear(); y.Clear();//旧下落格子删除
                    score += 20;
                    //结束与否取决于新格子是否能够下落

                    randomAdd();//新下落格子生成          
                   
                }
                //显现
                displayAll();
            }
        }
        public void left()//左移
        {
            if (game == 1)
            {
                cleanGezi();
                //逻辑部分
                int m = 0;
                for (int i = 0; i < x.Count; i++)
                {
                    if (x[i] - widethAll < wideth)//如果超出边界，标识加1
                    {
                        m++;
                    }
                    else
                        if (xy[((y[i] - wideth) / widethAll), ((x[i] - wideth) / widethAll) - 1] == 1)//如果代表值为1，标识加1
                        {
                            m++;
                        }
                }
                if (m == 0)
                {
                    for (int i = 0; i < x.Count; i++)
                    {
                        x[i] = x[i] - widethAll;
                    }
                }
                //显现
                displayAll();
            }
        }
        public void right()//右移
        {
            if (game == 1)
            {
                cleanGezi();
                //逻辑部分
                int m = 0;
                for (int i = 0; i < x.Count; i++)
                {
                    if (x[i] == (LWnumber - 1) * widethAll + wideth)//如果超出边界，标识加1
                    {
                        m++;
                    }
                    else
                        if (xy[((y[i] - wideth) / widethAll), ((x[i] - wideth) / widethAll) + 1] == 1)//如果代表值为1，标识加1
                        {
                            m++;
                        }
                }
                if (m == 0)
                {
                    for (int i = 0; i < x.Count; i++)
                    {
                        x[i] = x[i] + widethAll;
                    }
                }
                //显现
                displayAll();
            }
        }
        public void clearColumn()//逻辑上清除若干排格子
        {
            for (int i = LWnumber - 1; i >= 0; i--)//再让循环走LWnumber次，能连续消除LWnumber行
            {
                for (int k = LWnumber - 1; k >= 0; k--)//(LWnumber-1)代表LWnumber
                {
                    int biaoshi = 0;
                    //**********消除方法1**********
                    for (int s = LWnumber - 1; s >= 0; s--)
                    {
                        if (xy[k, s] == 0)
                        {
                            biaoshi = biaoshi + 1;
                        }
                    }
                    if (biaoshi == 0)
                    {
                        for (int n = 0; n < LWnumber; n++)//相同的一行归0
                        {
                            xy[k, n] = 0;
                        }
                        for (int c = k; c > 0; c--)//限定在该行之上的行列
                        {

                            for (int n = 0; n < LWnumber; n++)//上行数值移到下行
                            {
                                xy[c, n] = xy[c - 1, n];
                            }
                            for (int n = 0; n < LWnumber; n++)//最上行值归为0
                            {
                                xy[0, n] = 0;
                            }
                        }
                    }
                    else
                    {
                        biaoshi = 0;
                    }
                }
                //**********消除方法2**********
                //if (xy[k, 0] == 1 && xy[k, 1] == 1 && xy[k, 2] == 1 && xy[k, 3] == 1 && xy[k, 4] == 1 && xy[k, 5] == 1)
                //{
                //    for (int n = 0; n < LWnumber; n++)//相同的一行归0
                //    {
                //        xy[k, n] = 0;
                //    }
                //    for (int c = k; c > 0; c--)//操作限定再该行之上的行列
                //    {

                //        for (int n = 0; n < LWnumber; n++)//上行数值移到下行
                //        {
                //            xy[c, n] = xy[c - 1, n];
                //        }
                //        for (int n = 0; n < LWnumber; n++)//最上行值归为0
                //        {
                //            xy[0, n] = 0;
                //        }
                //    }
                //}
            }
        }
        public void switchPosition(int ZF, int count1, int count2)//单种下落格子转换和边界判断
        {
            int s = 0;
            if (ZF == 1)
            {
                if (y[count2] - widethAll < wideth || x[count1] - widethAll < wideth)//若小于左上边界
                {
                    s++;
                }
                else
                    if (xy[(y[count2] - widethAll - wideth) / widethAll, (x[count1] - widethAll - wideth) / widethAll] == 1)//判断其是否在值为1的格子上
                    {
                        s++;
                    }
            }
            else
                if (ZF == -1)
                {
                    if (y[count2] + widethAll > (LWnumber - 1) * widethAll + wideth || x[count1] + widethAll > (LWnumber - 1) * widethAll + wideth)//若大于右上边界
                    {
                        s++;
                    }
                    else
                        if (xy[(y[count2] + widethAll - wideth) / widethAll, (x[count1] + widethAll - wideth) / widethAll] == 1)//判断其是否在值为1的格子上
                        {
                            s++;
                        }
                }

            if (s == 0)
            {
                x[count1] = x[count1] - ZF * widethAll;
                y[count2] = y[count2] - ZF * widethAll;

            }
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            down();
        }

        private void btnLeft1_Click(object sender, EventArgs e)
        {
            left();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            right();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            up();
        }

        private void timerSpeed_Tick(object sender, EventArgs e)//计时器
        {
            down();
        }
        private void kuangDisplay()//框体的清除
        {
            Graphics g = panel1.CreateGraphics();
            Pen pen1 = new Pen(Color.Gray, wideth);
            for (int i = 0; i <= LWnumber; i++)
            {
                g.DrawLine(pen1, 0, wideth / 2 + i * widethAll, LWnumber * widethAll + wideth, wideth / 2 + i * widethAll);//横线
                g.DrawLine(pen1, wideth / 2 + i * widethAll, 0, wideth / 2 + i * widethAll, LWnumber * widethAll + wideth);//竖线
            }
        }
        private void kuangClear()//框体的显示
        {
            Graphics g = panel1.CreateGraphics();
            Pen pen1 = new Pen(Color.Black, wideth);
            for (int i = 0; i <= LWnumber; i++)
            {
                g.DrawLine(pen1, 0, wideth / 2 + i * widethAll, LWnumber * widethAll + wideth, wideth / 2 + i * widethAll);//横线
                g.DrawLine(pen1, wideth / 2 + i * widethAll, 0, wideth / 2 + i * widethAll, LWnumber * widethAll + wideth);//竖线
            }
        }

        private void btnQuicker_Click(object sender, EventArgs e)//下落速度变快
        {
            if (timerSpeed.Interval > 200)
            {
                timerSpeed.Interval -= 100;
            }
            this.lblConditon1.Text = "Speed";
            this.lblSpeed.Text = timerSpeed.Interval+"ms/Sq";
        }

        private void btnSlower_Click(object sender, EventArgs e)//下落速度变慢
        {
            if (timerSpeed.Interval < 2000)
            {
                timerSpeed.Interval += 100;
            }
            this.lblConditon1.Text = "Speed";
            this.lblSpeed.Text = timerSpeed.Interval + "ms/Sq";

        }

        private void btnLonger_Click(object sender, EventArgs e)//单位像素变大
        {
          //  game = 0;
            //清除
            cleanGezi();
            kuangClear();
            //逻辑  
            if (wideth < 9)  //只需要判断边框大小或方块大小要满足的条件即可
            {
                int longWideth = 1, longWidethTangle = 5, longWidethAll = 6;
                for (int i = 0; i < x.Count; i++)
                {
                    x[i] = (x[i] - wideth) / widethAll * (widethAll + longWidethAll) + wideth + longWideth;
                    y[i] = (y[i] - wideth) / widethAll * (widethAll + longWidethAll) + wideth + longWideth;
                }
                wideth += longWideth;
                widethTangle += longWidethTangle;
                widethAll = wideth + widethTangle;
             //不能修改方框的横纵方块个数，二维数组定义个数需要用到常量
                this.lblCondition2.Text = "Size";//一个完整单元像素大小显示
                this.lblSize.Text = widethAll + "px/Sq";
            }
           // 显现
            displayAll(); 
            kuangDisplay();
        //widethTangle = 40, wideth = 6, widethAll = 46;
        }

        private void btnSmaller_Click(object sender, EventArgs e)//单位像素变小
        {
            //清除
            cleanGezi();
            kuangClear();
            //逻辑
            
            //    return;//只需要判断边框大小或方块大小要满足的条件即可
            if (wideth > 4 )
            {
                int smallWideth = -1, smallWidethTangle = -5, smallWidethAll = -6;
                for (int i = 0; i < x.Count; i++)
                {
                    x[i] = (x[i] - wideth) / widethAll * (widethAll + smallWidethAll) + wideth + smallWideth;
                    y[i] = (y[i] - wideth) / widethAll * (widethAll + smallWidethAll) + wideth + smallWideth;
                }
                wideth += smallWideth;
                widethTangle += smallWidethTangle;
                widethAll = wideth + widethTangle;
                this.lblCondition2.Text = "Size";//一个完整单元像素大小显示
                this.lblSize.Text = widethAll + "px/Sq";
            }
            //显现
            displayAll();
            kuangDisplay();
        }

        private void btnControl_Click(object sender, EventArgs e)//暂停-继续控制
        {
            if (timerSpeed.Enabled == false)
            {
                timerSpeed.Enabled = true;
                game = 1;
            }
            else
            {
                timerSpeed.Enabled = false;
                game = 0;
            }
        }


    } 
}
