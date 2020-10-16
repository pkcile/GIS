using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 星座查询
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//确定按钮！

        {
            Text = "查询成功……";
            string str = textinput.Text;
            
                //textoutput.Text = "狮子座是黄道宫上的第五个星座，主宰星为太阳。阳光灿烂，充满活力，感觉有用不完的能量；表现欲强烈，举手投足之间充满了闪耀的魅力，很容易成为众人瞩目的焦点，你身上散发出来的热力很容易感染周围的人，让大家跟着你一起舞动生活。你对权力地位的追求非常执着，以捍卫你的领导地位，而这也是你不断向前的动力泉源。这往往让你站得比别人高，获得也比别人多，但人生大起大落；自尊心很强，当追求无望时会变得沉沦、怠惰。245";


            switch (str)
            {
                //case "水瓶座": textoutput.Text = "hahah\n\n\nhahahah\n"; break;
                //case "双鱼座": textoutput.Text = ""; break;
                //case "白羊座": textoutput.Text = ""; break;
                //case "金牛座": textoutput.Text = ""; break;
                //case "双子座": textoutput.Text = ""; break;
                //case "巨蟹座": textoutput.Text = ""; break;
                //case "狮子座": textoutput.Text = ""; break;
                //case "处女座": textoutput.Text = ""; break;
                //case "天秤座": textoutput.Text = ""; break;
                //case "天蝎座": textoutput.Text = ""; break;
                //case "射手座": textoutput.Text = ""; break;
               //case "肉做的": textBox2.Text = "哈哈哈"; break;
                case "水瓶座": { richTextBox.Text = "水瓶座(Aquarius)\n水瓶座的人很聪明，他们最大的特点是创新，追求独一无二的生活，个人主义色彩很浓重的星座。\n他们对人友善又注重隐私。水瓶座绝对算得上是“友谊之星”，他喜欢结交每一类朋友，但是却很难与他们交心，那需要很长的时间。\n他们对自己的家人就显得冷淡和疏远很多了。\n"; pictureBox5.Image = imageList1.Images[0]; this.label6.Text = "1月20日-2月18日"; this.label7.Text = "风向\n"; this.textBox1.Text = "用另一角度去想\n"; }; break;  //清空剪贴板

                case "双鱼座": { richTextBox.Text = "双鱼座(Pisces)\n双鱼座是十二宫最后一个星座，他集合了所有星座的优缺点于一身，同时受水象星座的情绪化影响，使他们原来复杂的性格又添加了更复杂的一笔。双鱼座的人最大的优点是有一颗善良的心，他们愿意帮助别人，甚至是牺牲自己。\n关键词：潜意识\n象征：鱼\n"; pictureBox5.Image = imageList1.Images[1]; this.label6.Text = "2月19日-3月20日"; this.label7.Text = "水向\n"; this.textBox1.Text = "Make love no war!"; }; break;
                case "白羊座": { richTextBox.Text = "白羊座(Aries)\n白羊座的人热情冲动、爱冒险、慷慨，天不怕地不怕。而且一旦下定决心，不到黄河心不死，排除万难也要达到目的。大部分属于白羊座的人的脾气都很差，不过只是炮仗颈，绝对不会放在心上的。\n关键词：自己\n象征：公羊\n四象性：火向\n"; pictureBox5.Image = imageList1.Images[2]; this.label6.Text = "3月21日-4月19日"; this.label7.Text = "我最大\n"; this.textBox1.Text = ""; this.label6.Text = ""; this.label7.Text = ""; this.textBox1.Text = "我最大\n"; }; break;
                case "金牛座": { richTextBox.Text = "金牛座(Taurus)\n金牛座是很保守的星座，喜欢稳定，不爱变动。在性格上则比较慢热，对工作、生活、环境都需要比较长的适应期。金牛座又往往是财富的象征，他们在投资理财方面常常有很独到的见解。金牛座的男人往往有大男人的倾向，而金牛女生则喜欢打扮自己，谁让金牛的守护神是维纳斯呢？\n关键词：金钱\n象征：公牛\n"; pictureBox5.Image = imageList1.Images[3]; this.label6.Text = "4月20日-5月20日"; this.label7.Text = "土向\n"; this.textBox1.Text = "有钱我最大\n"; }; break;
                case "双子座": { richTextBox.Text = "双子座(Gemini)\n双子座的人往往喜好新鲜事物，他们有着小聪明，但做事常常不太专一。与双子座的人聊天也许会让你觉得很兴奋，因为他们脑子中那些新鲜的、稀奇古怪的东西会让人充满好奇。也许是对新鲜事物的追求和好奇，会让人觉得他们很花心，其实不然，他们仅仅是喜欢新鲜而已。\n关键字：沟通\n象征：孪生子\n"; pictureBox5.Image = imageList1.Images[4]; this.label6.Text = "5月21日-6月21日"; this.label7.Text = "风向\n"; this.textBox1.Text = "一人计短二人计长\n"; }; break;
                case "巨蟹座": { richTextBox.Text = "巨蟹座(Cancer)\n巨蟹座的人往往充满了爱心，他们将母性的本质发挥到了极限。对他们来说，最重要的东西是家庭。他们往往就像蟹一样，在充满坚硬的外壳下面是柔软的内心。巨蟹座是最执着的星座，他们对朋友、对家人非常忠实，做事也会一直坚持到底。\n关键词：家庭\n象征：蟹\n"; pictureBox5.Image = imageList1.Images[5]; this.label6.Text = "6月22日-7月22日"; this.label7.Text = "水向\n"; this.textBox1.Text = "我妈咪！\n"; }; break;
                case "狮子座": { richTextBox.Text = "狮子座(Leo)\n狮子座的人热情、阳光、大方。这些是他们性格上最大的特色。与他们性格上的优点不同，他们爱面子、自信得有点儿自大，常常会很在乎别人对自己的看法，也常常会因此而使自己不快乐。\n关键词：乐趣\n象征：狮子\n"; pictureBox5.Image = imageList1.Images[6]; this.label6.Text = "7月23日-8月22日"; this.label7.Text = "火向\n"; this.textBox1.Text = "我最大\n"; }; break;
                case "处女座": { richTextBox.Text = "处女座(Virgo)\n处女座追求完美，吹毛求疵是他们的特性。多数的处女座都很谦虚，但也因此给自己造成很大的压力。处女座的人不喜欢闲着，对别人常常乐于服务。缺乏自信的处女座有时候组织能力较差，需要家人与朋友们的鼓励去推动他们。\n关键词：完美\n象征：处女\n"; pictureBox5.Image = imageList1.Images[7]; this.label6.Text = "8月23日-9月22日"; this.label7.Text = "土向\n"; this.textBox1.Text = "Perfect！\n"; }; break;
                case "天秤座": { richTextBox.Text = "天秤座(Libra)\n天秤座常常追求和平和谐的感觉，他们善于交谈，沟通能力极强是他们最大的优点。但他们最大的缺点，往往是犹豫不决。天秤座的人容易将自己的想法加诸到别人身上，天秤座的人要小心这点。天秤座女生常常希望他们的伴侣会时刻陪伴着她。\n关键词：合伙\n象征：天秤\n"; pictureBox5.Image = imageList1.Images[8]; this.label6.Text = "9月23日-10月23日"; this.label7.Text = "风向\n"; this.textBox1.Text = "情人眼里出西施\n"; }; break;
                case "天蝎座": { richTextBox.Text = "天蝎座(Scorpio)\n天蝎座的人精力旺盛、热情、善妒，占有欲极强。他们想要每天过得非常充实，如果失去了目标，他们很难认真地投入精力。天蝎是记仇的，会不顾一切地打击仇人。他们的一个成功优点，就是他们一旦定了目标，就会不达目的誓不罢休。\n关键词：性\n象征：蝎子\n"; pictureBox5.Image = imageList1.Images[9]; this.label6.Text = "10月24日-11月22日"; this.label7.Text = "水向\n"; this.textBox1.Text = "Come in…babay！\n"; }; break;
                case "射手座": { richTextBox.Text = "射手座(Sagittarius)\n射手座的人就像那只在弦上的箭一样，他们主动出击。为人乐观、诚实、热情、喜欢挑战。射手是十二星座中的冒险家，热爱旅行、喜欢赌博。意志力薄弱是射手座天生的弱点，如果沉迷赌博与游戏，后果不堪设想。\n关键词：哲学\n象征：人马\n"; pictureBox5.Image = imageList1.Images[10]; this.label6.Text = "11月23日-12月21日"; this.label7.Text = "火向\n"; this.textBox1.Text = "不要排斥我\n"; }; break;
                case "摩羯座": { richTextBox.Text = "摩羯座(Capricorn)\n摩羯座是十二星座中最有耐心，行事最小心、也是最善良的星座他们做事脚踏实地，也比较固执，不达目的是不会放手的。他们的忍耐力也是出奇的强大，同时也非常勤奋。他们心中总是背负着很多的责任感，但往往又很没有安全感，不会完全地相信别人\n关键词：社会地位\n象征：山羊\n"; pictureBox5.Image = imageList1.Images[11]; this.label6.Text = "12月22日-1月19日"; this.label7.Text = "土向\n"; textBox1.Text = "有最多名利大赢家\n"; }; break;
                default: { richTextBox.Text = "小可爱，你属于什么星座?\n你的星座性格特征是什么?\n快来输入框输入你的星座名吧……"; pictureBox5.Image = imageList1.Images[12]; this.label6.Text = "今天是个好日子 ：）"; this.label7.Text = "哈哈，我有点迷信"; this.textBox1.Text = "短发的冉燕可以性感的可爱"; this.BackColor = Color.FromArgb(122, 13, 14); textBox1.BackColor = Color.FromArgb(12,12,12); }; break;

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textoutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_2(object sender, EventArgs e)
        {
          
        }

        private void richTextBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
