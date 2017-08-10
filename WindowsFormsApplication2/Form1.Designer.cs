namespace WindowsFormsApplication2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_clear1 = new System.Windows.Forms.Button();
            this.bt_copy1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bt_viewer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bt_clear2 = new System.Windows.Forms.Button();
            this.bt_copy2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.bt_modify = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_paste = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 623);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(524, 21);
            this.textBox4.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 21);
            this.textBox1.TabIndex = 6;
            // 
            // bt_clear1
            // 
            this.bt_clear1.Location = new System.Drawing.Point(503, 12);
            this.bt_clear1.Name = "bt_clear1";
            this.bt_clear1.Size = new System.Drawing.Size(75, 34);
            this.bt_clear1.TabIndex = 7;
            this.bt_clear1.Text = "清空";
            this.bt_clear1.UseVisualStyleBackColor = true;
            this.bt_clear1.Click += new System.EventHandler(this.bt_clear1_Click);
            // 
            // bt_copy1
            // 
            this.bt_copy1.Location = new System.Drawing.Point(584, 12);
            this.bt_copy1.Name = "bt_copy1";
            this.bt_copy1.Size = new System.Drawing.Size(75, 35);
            this.bt_copy1.TabIndex = 8;
            this.bt_copy1.Text = "复制";
            this.bt_copy1.UseVisualStyleBackColor = true;
            this.bt_copy1.Click += new System.EventHandler(this.bt_copy1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 54);
            this.textBox2.MaxLength = 327670;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(640, 185);
            this.textBox2.TabIndex = 9;
            // 
            // bt_viewer
            // 
            this.bt_viewer.Location = new System.Drawing.Point(11, 13);
            this.bt_viewer.Name = "bt_viewer";
            this.bt_viewer.Size = new System.Drawing.Size(112, 35);
            this.bt_viewer.TabIndex = 10;
            this.bt_viewer.Text = "看看字符串↓";
            this.bt_viewer.UseVisualStyleBackColor = true;
            this.bt_viewer.Click += new System.EventHandler(this.bt_viewer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "修改后重新编码→";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 351);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(350, 21);
            this.textBox3.TabIndex = 12;
            // 
            // bt_clear2
            // 
            this.bt_clear2.Location = new System.Drawing.Point(495, 346);
            this.bt_clear2.Name = "bt_clear2";
            this.bt_clear2.Size = new System.Drawing.Size(75, 35);
            this.bt_clear2.TabIndex = 7;
            this.bt_clear2.Text = "清空";
            this.bt_clear2.UseVisualStyleBackColor = true;
            this.bt_clear2.Click += new System.EventHandler(this.bt_clear2_Click);
            // 
            // bt_copy2
            // 
            this.bt_copy2.Location = new System.Drawing.Point(576, 346);
            this.bt_copy2.Name = "bt_copy2";
            this.bt_copy2.Size = new System.Drawing.Size(75, 35);
            this.bt_copy2.TabIndex = 8;
            this.bt_copy2.Text = "复制";
            this.bt_copy2.UseVisualStyleBackColor = true;
            this.bt_copy2.Click += new System.EventHandler(this.bt_copy2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "修改XXX的值:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(108, 314);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(287, 21);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "3,5,2,1,67,8";
            // 
            // bt_modify
            // 
            this.bt_modify.Location = new System.Drawing.Point(576, 306);
            this.bt_modify.Name = "bt_modify";
            this.bt_modify.Size = new System.Drawing.Size(75, 34);
            this.bt_modify.TabIndex = 16;
            this.bt_modify.Text = "确定修改";
            this.bt_modify.UseVisualStyleBackColor = true;
            this.bt_modify.Click += new System.EventHandler(this.bt_modify_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(23, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "修改示例:   3,4,5,6,20,432,5,3,643   填写数字然后用逗号分割         也可以直接在上面里边修改";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_paste
            // 
            this.bt_paste.Location = new System.Drawing.Point(420, 13);
            this.bt_paste.Name = "bt_paste";
            this.bt_paste.Size = new System.Drawing.Size(75, 34);
            this.bt_paste.TabIndex = 18;
            this.bt_paste.Text = "<- 粘贴";
            this.bt_paste.UseVisualStyleBackColor = true;
            this.bt_paste.Click += new System.EventHandler(this.bt_paste_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "修改为:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(108, 281);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(106, 21);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "例如:count";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 22;
            this.button2.Text = "<-粘贴";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(495, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 23;
            this.button3.Text = "清空\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(13, 396);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(382, 21);
            this.textBox7.TabIndex = 24;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(13, 436);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(382, 21);
            this.textBox8.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(414, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "粘贴";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(495, 396);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "清空";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(577, 396);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 26;
            this.button8.Text = "确定修改";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(577, 434);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 27;
            this.button9.Text = "复制";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(496, 434);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "清空";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "示例:1s1s#2d34g5h";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "piano",
            "bass",
            "square",
            "saw",
            "lead",
            "celesta",
            "vibraphone",
            "plucked",
            "steel-drum"});
            this.comboBox1.Location = new System.Drawing.Point(420, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.Text = "piano";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 471);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_paste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_modify);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_viewer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bt_copy2);
            this.Controls.Add(this.bt_copy1);
            this.Controls.Add(this.bt_clear2);
            this.Controls.Add(this.bt_clear1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "异星工厂-0.15蓝图字符串查看";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_clear1;
        private System.Windows.Forms.Button bt_copy1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bt_viewer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button bt_clear2;
        private System.Windows.Forms.Button bt_copy2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button bt_modify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_paste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

