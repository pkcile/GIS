namespace 俄罗斯方块12_14
{
    partial class kuang
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
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.timerSpeed = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCondition2 = new System.Windows.Forms.Label();
            this.btnSmaller = new System.Windows.Forms.Button();
            this.btnLonger = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblConditon1 = new System.Windows.Forms.Label();
            this.btnSlower = new System.Windows.Forms.Button();
            this.btnQuicker = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(905, 422);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(93, 50);
            this.btnRight.TabIndex = 0;
            this.btnRight.Text = "右";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(776, 508);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(93, 50);
            this.btnDown.TabIndex = 0;
            this.btnDown.Text = "下";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 551);
            this.panel1.TabIndex = 1;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(776, 422);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(104, 48);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "开始";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(776, 328);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(93, 50);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "变换";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(660, 422);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(93, 50);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "左";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft1_Click);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(660, 250);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(37, 15);
            this.lblCondition.TabIndex = 3;
            this.lblCondition.Text = "状态";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(747, 250);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(37, 15);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "分数";
            // 
            // timerSpeed
            // 
            this.timerSpeed.Enabled = true;
            this.timerSpeed.Interval = 400;
            this.timerSpeed.Tick += new System.EventHandler(this.timerSpeed_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSize);
            this.groupBox2.Controls.Add(this.lblCondition2);
            this.groupBox2.Controls.Add(this.btnSmaller);
            this.groupBox2.Controls.Add(this.btnLonger);
            this.groupBox2.Location = new System.Drawing.Point(843, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 152);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "每单位像素";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(20, 105);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(37, 15);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "减小";
            // 
            // lblCondition2
            // 
            this.lblCondition2.AutoSize = true;
            this.lblCondition2.Location = new System.Drawing.Point(20, 42);
            this.lblCondition2.Name = "lblCondition2";
            this.lblCondition2.Size = new System.Drawing.Size(37, 15);
            this.lblCondition2.TabIndex = 1;
            this.lblCondition2.Text = "增大";
            // 
            // btnSmaller
            // 
            this.btnSmaller.Location = new System.Drawing.Point(93, 99);
            this.btnSmaller.Name = "btnSmaller";
            this.btnSmaller.Size = new System.Drawing.Size(75, 23);
            this.btnSmaller.TabIndex = 0;
            this.btnSmaller.Text = "↓";
            this.btnSmaller.UseVisualStyleBackColor = true;
            this.btnSmaller.Click += new System.EventHandler(this.btnSmaller_Click);
            // 
            // btnLonger
            // 
            this.btnLonger.Location = new System.Drawing.Point(93, 36);
            this.btnLonger.Name = "btnLonger";
            this.btnLonger.Size = new System.Drawing.Size(75, 23);
            this.btnLonger.TabIndex = 0;
            this.btnLonger.Text = "↑";
            this.btnLonger.UseVisualStyleBackColor = true;
            this.btnLonger.Click += new System.EventHandler(this.btnLonger_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSpeed);
            this.groupBox1.Controls.Add(this.lblConditon1);
            this.groupBox1.Controls.Add(this.btnSlower);
            this.groupBox1.Controls.Add(this.btnQuicker);
            this.groupBox1.Location = new System.Drawing.Point(631, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 152);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "下落速度";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(20, 105);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(37, 15);
            this.lblSpeed.TabIndex = 1;
            this.lblSpeed.Text = "减小";
            // 
            // lblConditon1
            // 
            this.lblConditon1.AutoSize = true;
            this.lblConditon1.Location = new System.Drawing.Point(20, 42);
            this.lblConditon1.Name = "lblConditon1";
            this.lblConditon1.Size = new System.Drawing.Size(37, 15);
            this.lblConditon1.TabIndex = 1;
            this.lblConditon1.Text = "增大";
            // 
            // btnSlower
            // 
            this.btnSlower.Location = new System.Drawing.Point(93, 99);
            this.btnSlower.Name = "btnSlower";
            this.btnSlower.Size = new System.Drawing.Size(75, 23);
            this.btnSlower.TabIndex = 0;
            this.btnSlower.Text = "↓";
            this.btnSlower.UseVisualStyleBackColor = true;
            this.btnSlower.Click += new System.EventHandler(this.btnSlower_Click);
            // 
            // btnQuicker
            // 
            this.btnQuicker.Location = new System.Drawing.Point(93, 36);
            this.btnQuicker.Name = "btnQuicker";
            this.btnQuicker.Size = new System.Drawing.Size(75, 23);
            this.btnQuicker.TabIndex = 0;
            this.btnQuicker.Text = "↑";
            this.btnQuicker.UseVisualStyleBackColor = true;
            this.btnQuicker.Click += new System.EventHandler(this.btnQuicker_Click);
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(936, 250);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(110, 40);
            this.btnControl.TabIndex = 7;
            this.btnControl.Text = "继续-暂停";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // kuang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnUp);
            this.Name = "kuang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "方块小游戏";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timerSpeed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblCondition2;
        private System.Windows.Forms.Button btnSmaller;
        private System.Windows.Forms.Button btnLonger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblConditon1;
        private System.Windows.Forms.Button btnSlower;
        private System.Windows.Forms.Button btnQuicker;
        private System.Windows.Forms.Button btnControl;
    }
}

