namespace 贪吃蛇_12_25
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblCondition = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.btnQuick = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(32, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 485);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnBegin
            // 
            this.btnBegin.CausesValidation = false;
            this.btnBegin.Location = new System.Drawing.Point(803, 341);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(98, 49);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "开始";
            this.btnBegin.UseCompatibleTextRendering = true;
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnUp
            // 
            this.btnUp.CausesValidation = false;
            this.btnUp.Location = new System.Drawing.Point(802, 275);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(95, 45);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "上";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.CausesValidation = false;
            this.btnLeft.Location = new System.Drawing.Point(698, 343);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(95, 45);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "左";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.CausesValidation = false;
            this.btnRight.Location = new System.Drawing.Point(907, 343);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(95, 45);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "右";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.CausesValidation = false;
            this.btnDown.Location = new System.Drawing.Point(802, 421);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(95, 45);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "下";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.食物呈现时间_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 12000;
            this.timer2.Tick += new System.EventHandler(this.第一次出现与第二次间隔时间_Tick);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.CausesValidation = false;
            this.lblCondition.Location = new System.Drawing.Point(645, 140);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(37, 15);
            this.lblCondition.TabIndex = 0;
            this.lblCondition.Text = "状态";
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.CausesValidation = false;
            this.lblScore.Location = new System.Drawing.Point(784, 140);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(37, 15);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "分数";
            // 
            // btnQuick
            // 
            this.btnQuick.CausesValidation = false;
            this.btnQuick.Location = new System.Drawing.Point(870, 46);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(87, 34);
            this.btnQuick.TabIndex = 7;
            this.btnQuick.Text = "分数快些";
            this.btnQuick.UseVisualStyleBackColor = true;
            this.btnQuick.Click += new System.EventHandler(this.btnQuick_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.AllowDrop = true;
            this.btnSlow.CausesValidation = false;
            this.btnSlow.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSlow.Location = new System.Drawing.Point(734, 46);
            this.btnSlow.Margin = new System.Windows.Forms.Padding(30);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(100, 34);
            this.btnSlow.TabIndex = 7;
            this.btnSlow.TabStop = false;
            this.btnSlow.Text = "分数慢些";
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.CausesValidation = false;
            this.lblSpeed.Location = new System.Drawing.Point(989, 56);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(37, 15);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.Text = "速度";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.CausesValidation = false;
            this.button1.Location = new System.Drawing.Point(594, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 33);
            this.button1.TabIndex = 9;
            this.button1.TabStop = false;
            this.button1.Text = "暂停-继续";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.btnSlow);
            this.Controls.Add(this.btnQuick);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "贪吃蛇小游戏";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeDong);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Button button1;
    }
}

