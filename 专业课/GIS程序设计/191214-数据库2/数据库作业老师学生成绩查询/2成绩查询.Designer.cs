namespace 数据库作业老师学生成绩查询
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblChinese = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblMath = new System.Windows.Forms.Label();
            this.查询 = new System.Windows.Forms.Button();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblChinese);
            this.groupBox1.Controls.Add(this.lblEnglish);
            this.groupBox1.Controls.Add(this.lblMath);
            this.groupBox1.Controls.Add(this.查询);
            this.groupBox1.Controls.Add(this.txtChinese);
            this.groupBox1.Controls.Add(this.txtEnglish);
            this.groupBox1.Controls.Add(this.txtMath);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(36, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "姓名";
            this.lblName.Visible = false;
            this.lblName.TextChanged += new System.EventHandler(this.txtName_TextChanged_1);
            // 
            // lblChinese
            // 
            this.lblChinese.AutoSize = true;
            this.lblChinese.Location = new System.Drawing.Point(6, 290);
            this.lblChinese.Name = "lblChinese";
            this.lblChinese.Size = new System.Drawing.Size(37, 15);
            this.lblChinese.TabIndex = 2;
            this.lblChinese.Text = "语文";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(6, 228);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(37, 15);
            this.lblEnglish.TabIndex = 2;
            this.lblEnglish.Text = "英语";
            // 
            // lblMath
            // 
            this.lblMath.AutoSize = true;
            this.lblMath.Location = new System.Drawing.Point(6, 168);
            this.lblMath.Name = "lblMath";
            this.lblMath.Size = new System.Drawing.Size(37, 15);
            this.lblMath.TabIndex = 2;
            this.lblMath.Text = "数学";
            // 
            // 查询
            // 
            this.查询.Location = new System.Drawing.Point(214, 156);
            this.查询.Name = "查询";
            this.查询.Size = new System.Drawing.Size(86, 39);
            this.查询.TabIndex = 1;
            this.查询.Text = "查询";
            this.查询.UseVisualStyleBackColor = true;
            this.查询.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(75, 287);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(100, 25);
            this.txtChinese.TabIndex = 0;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(75, 225);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 25);
            this.txtEnglish.TabIndex = 0;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(75, 165);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 25);
            this.txtMath.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 25);
            this.txtName.TabIndex = 0;
            this.txtName.Visible = false;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩查询页面";
            this.VisibleChanged += new System.EventHandler(this.Form2_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblChinese;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblMath;
        private System.Windows.Forms.Button 查询;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}