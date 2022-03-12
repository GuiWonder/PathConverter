namespace PathConverter
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1md = new System.Windows.Forms.Button();
            this.button1ms = new System.Windows.Forms.Button();
            this.button1mf = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1X = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1M = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1Q = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2M = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2X = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2Q = new System.Windows.Forms.TextBox();
            this.button1qs = new System.Windows.Forms.Button();
            this.button1qf = new System.Windows.Forms.Button();
            this.button1x = new System.Windows.Forms.Button();
            this.button1qd = new System.Windows.Forms.Button();
            this.button2ms = new System.Windows.Forms.Button();
            this.button2md = new System.Windows.Forms.Button();
            this.button2mf = new System.Windows.Forms.Button();
            this.button2q = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button1md
            // 
            this.button1md.AutoSize = true;
            this.button1md.Location = new System.Drawing.Point(475, 6);
            this.button1md.Name = "button1md";
            this.button1md.Size = new System.Drawing.Size(39, 23);
            this.button1md.TabIndex = 4;
            this.button1md.Text = "目录";
            this.button1md.UseVisualStyleBackColor = true;
            this.button1md.Click += new System.EventHandler(this.Buttond_Click);
            // 
            // button1ms
            // 
            this.button1ms.AutoSize = true;
            this.button1ms.Location = new System.Drawing.Point(385, 6);
            this.button1ms.Name = "button1ms";
            this.button1ms.Size = new System.Drawing.Size(39, 23);
            this.button1ms.TabIndex = 3;
            this.button1ms.Text = "简化";
            this.button1ms.UseVisualStyleBackColor = true;
            this.button1ms.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button1mf
            // 
            this.button1mf.AutoSize = true;
            this.button1mf.Location = new System.Drawing.Point(430, 6);
            this.button1mf.Name = "button1mf";
            this.button1mf.Size = new System.Drawing.Size(39, 23);
            this.button1mf.TabIndex = 3;
            this.button1mf.Text = "文件";
            this.button1mf.UseVisualStyleBackColor = true;
            this.button1mf.Click += new System.EventHandler(this.Buttonf_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 180);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "使用/";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // textBox1X
            // 
            this.textBox1X.Location = new System.Drawing.Point(12, 137);
            this.textBox1X.Name = "textBox1X";
            this.textBox1X.Size = new System.Drawing.Size(502, 21);
            this.textBox1X.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "相对路径";
            // 
            // textBox1M
            // 
            this.textBox1M.Location = new System.Drawing.Point(13, 32);
            this.textBox1M.Name = "textBox1M";
            this.textBox1M.Size = new System.Drawing.Size(501, 21);
            this.textBox1M.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "相对于";
            // 
            // textBox1Q
            // 
            this.textBox1Q.Location = new System.Drawing.Point(13, 84);
            this.textBox1Q.Name = "textBox1Q";
            this.textBox1Q.Size = new System.Drawing.Size(502, 21);
            this.textBox1Q.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "绝对路径";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "相对于";
            // 
            // textBox2M
            // 
            this.textBox2M.Location = new System.Drawing.Point(14, 234);
            this.textBox2M.Name = "textBox2M";
            this.textBox2M.Size = new System.Drawing.Size(500, 21);
            this.textBox2M.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "相对路径";
            // 
            // textBox2X
            // 
            this.textBox2X.Location = new System.Drawing.Point(13, 286);
            this.textBox2X.Name = "textBox2X";
            this.textBox2X.Size = new System.Drawing.Size(501, 21);
            this.textBox2X.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "绝对路径";
            // 
            // textBox2Q
            // 
            this.textBox2Q.Location = new System.Drawing.Point(14, 339);
            this.textBox2Q.Name = "textBox2Q";
            this.textBox2Q.Size = new System.Drawing.Size(501, 21);
            this.textBox2Q.TabIndex = 1;
            // 
            // button1qs
            // 
            this.button1qs.AutoSize = true;
            this.button1qs.Location = new System.Drawing.Point(385, 59);
            this.button1qs.Name = "button1qs";
            this.button1qs.Size = new System.Drawing.Size(39, 23);
            this.button1qs.TabIndex = 3;
            this.button1qs.Text = "简化";
            this.button1qs.UseVisualStyleBackColor = true;
            this.button1qs.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button1qf
            // 
            this.button1qf.AutoSize = true;
            this.button1qf.Location = new System.Drawing.Point(430, 59);
            this.button1qf.Name = "button1qf";
            this.button1qf.Size = new System.Drawing.Size(39, 23);
            this.button1qf.TabIndex = 3;
            this.button1qf.Text = "文件";
            this.button1qf.UseVisualStyleBackColor = true;
            this.button1qf.Click += new System.EventHandler(this.Buttonf_Click);
            // 
            // button1x
            // 
            this.button1x.AutoSize = true;
            this.button1x.Location = new System.Drawing.Point(475, 111);
            this.button1x.Name = "button1x";
            this.button1x.Size = new System.Drawing.Size(39, 23);
            this.button1x.TabIndex = 4;
            this.button1x.Text = "生成";
            this.button1x.UseVisualStyleBackColor = true;
            this.button1x.Click += new System.EventHandler(this.Button1x_Click);
            // 
            // button1qd
            // 
            this.button1qd.AutoSize = true;
            this.button1qd.Location = new System.Drawing.Point(475, 59);
            this.button1qd.Name = "button1qd";
            this.button1qd.Size = new System.Drawing.Size(39, 23);
            this.button1qd.TabIndex = 4;
            this.button1qd.Text = "目录";
            this.button1qd.UseVisualStyleBackColor = true;
            this.button1qd.Click += new System.EventHandler(this.Buttond_Click);
            // 
            // button2ms
            // 
            this.button2ms.AutoSize = true;
            this.button2ms.Location = new System.Drawing.Point(385, 207);
            this.button2ms.Name = "button2ms";
            this.button2ms.Size = new System.Drawing.Size(39, 23);
            this.button2ms.TabIndex = 3;
            this.button2ms.Text = "简化";
            this.button2ms.UseVisualStyleBackColor = true;
            this.button2ms.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button2md
            // 
            this.button2md.AutoSize = true;
            this.button2md.Location = new System.Drawing.Point(475, 207);
            this.button2md.Name = "button2md";
            this.button2md.Size = new System.Drawing.Size(39, 23);
            this.button2md.TabIndex = 4;
            this.button2md.Text = "目录";
            this.button2md.UseVisualStyleBackColor = true;
            this.button2md.Click += new System.EventHandler(this.Buttond_Click);
            // 
            // button2mf
            // 
            this.button2mf.AutoSize = true;
            this.button2mf.Location = new System.Drawing.Point(430, 207);
            this.button2mf.Name = "button2mf";
            this.button2mf.Size = new System.Drawing.Size(39, 23);
            this.button2mf.TabIndex = 3;
            this.button2mf.Text = "文件";
            this.button2mf.UseVisualStyleBackColor = true;
            this.button2mf.Click += new System.EventHandler(this.Buttonf_Click);
            // 
            // button2q
            // 
            this.button2q.AutoSize = true;
            this.button2q.Location = new System.Drawing.Point(475, 313);
            this.button2q.Name = "button2q";
            this.button2q.Size = new System.Drawing.Size(39, 23);
            this.button2q.TabIndex = 4;
            this.button2q.Text = "生成";
            this.button2q.UseVisualStyleBackColor = true;
            this.button2q.Click += new System.EventHandler(this.Button2q_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 380);
            this.Controls.Add(this.button2q);
            this.Controls.Add(this.button1x);
            this.Controls.Add(this.button2mf);
            this.Controls.Add(this.button2md);
            this.Controls.Add(this.button1qf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1qd);
            this.Controls.Add(this.button2ms);
            this.Controls.Add(this.button1md);
            this.Controls.Add(this.textBox1Q);
            this.Controls.Add(this.button1qs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1ms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2M);
            this.Controls.Add(this.button1mf);
            this.Controls.Add(this.textBox1M);
            this.Controls.Add(this.textBox2Q);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2X);
            this.Controls.Add(this.textBox1X);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = " 路径转换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1md;
        private System.Windows.Forms.Button button1ms;
        private System.Windows.Forms.Button button1mf;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1M;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1Q;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2M;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2X;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2Q;
        private System.Windows.Forms.Button button1qs;
        private System.Windows.Forms.Button button1qf;
        private System.Windows.Forms.Button button1x;
        private System.Windows.Forms.Button button1qd;
        private System.Windows.Forms.Button button2ms;
        private System.Windows.Forms.Button button2md;
        private System.Windows.Forms.Button button2mf;
        private System.Windows.Forms.Button button2q;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

