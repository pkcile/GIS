namespace 学习成绩计算器
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
            this.btnInset = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnAverageStandard = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblPrint = new System.Windows.Forms.Label();
            this.lblPrin = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblJudge = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInset
            // 
            this.btnInset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInset.Location = new System.Drawing.Point(38, 567);
            this.btnInset.Margin = new System.Windows.Forms.Padding(4);
            this.btnInset.Name = "btnInset";
            this.btnInset.Size = new System.Drawing.Size(110, 34);
            this.btnInset.TabIndex = 0;
            this.btnInset.Text = "打印";
            this.btnInset.UseVisualStyleBackColor = false;
            this.btnInset.Click += new System.EventHandler(this.btnInset_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMaxMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMaxMin.Location = new System.Drawing.Point(255, 569);
            this.btnMaxMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(159, 34);
            this.btnMaxMin.TabIndex = 1;
            this.btnMaxMin.Text = "最大、最小名字";
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnAverageStandard
            // 
            this.btnAverageStandard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAverageStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAverageStandard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAverageStandard.Location = new System.Drawing.Point(498, 569);
            this.btnAverageStandard.Margin = new System.Windows.Forms.Padding(4);
            this.btnAverageStandard.Name = "btnAverageStandard";
            this.btnAverageStandard.Size = new System.Drawing.Size(133, 32);
            this.btnAverageStandard.TabIndex = 2;
            this.btnAverageStandard.Text = "平均分和方差";
            this.btnAverageStandard.UseVisualStyleBackColor = false;
            this.btnAverageStandard.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSort.Location = new System.Drawing.Point(763, 569);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(98, 32);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "排序";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Location = new System.Drawing.Point(79, 66);
            this.lblPrint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(0, 24);
            this.lblPrint.TabIndex = 4;
            // 
            // lblPrin
            // 
            this.lblPrin.AutoSize = true;
            this.lblPrin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblPrin.Location = new System.Drawing.Point(79, 84);
            this.lblPrin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrin.Name = "lblPrin";
            this.lblPrin.Size = new System.Drawing.Size(116, 24);
            this.lblPrin.TabIndex = 5;
            this.lblPrin.Text = "名字   成绩   ";
            this.lblPrin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblM.Location = new System.Drawing.Point(264, 84);
            this.lblM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(139, 24);
            this.lblM.TabIndex = 6;
            this.lblM.Text = "最大者   最小者";
            this.lblM.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblA.Location = new System.Drawing.Point(499, 84);
            this.lblA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(134, 24);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "平均分  标准差";
            this.lblA.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblJudge
            // 
            this.lblJudge.AutoSize = true;
            this.lblJudge.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblJudge.Location = new System.Drawing.Point(783, 84);
            this.lblJudge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJudge.Name = "lblJudge";
            this.lblJudge.Size = new System.Drawing.Size(167, 24);
            this.lblJudge.TabIndex = 8;
            this.lblJudge.Text = "成绩由高到低排序 ";
            this.lblJudge.Click += new System.EventHandler(this.lblR_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(933, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "清除";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1024, 636);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblJudge);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblPrin);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnAverageStandard);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.btnInset);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInset;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnAverageStandard;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.Label lblPrin;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblJudge;
        private System.Windows.Forms.Button button2;
    }
}

