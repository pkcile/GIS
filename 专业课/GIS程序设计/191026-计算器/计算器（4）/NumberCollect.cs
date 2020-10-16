using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器_4_
{
    class NumberCollect
    {
        public string[] number = new string[12] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", "%" };//按钮值
        public string printf = "", part = "", part1 = "", part2 = "";//假设在A+B=C中，分别代表，显示A+B=C、短暂寄存A或B、A的量、B的量
        public string[] FuHao1 = new string[4] { "+", "-", "*", "/" };//存储符号的类型
        public double result = 0;//单个结果
        public int FuHao;//寄存符号的标识
    }
}
