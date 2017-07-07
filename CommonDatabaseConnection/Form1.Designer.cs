namespace CommonDatabaseConnection
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.rb_oracle = new System.Windows.Forms.RadioButton();
            this.rb_mysql = new System.Windows.Forms.RadioButton();
            this.rb_sqlserver = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.conn_info = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.url);
            this.groupBox1.Controls.Add(this.rb_oracle);
            this.groupBox1.Controls.Add(this.rb_mysql);
            this.groupBox1.Controls.Add(this.rb_sqlserver);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(261, 28);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(73, 21);
            this.port.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "端口：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 20);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "选择数据库：";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(208, 109);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 21);
            this.password.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "密码：";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(56, 112);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 21);
            this.username.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "用户名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(8, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 52);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(125, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "sqlServer身份验证";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "widows身份验证";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "服务器地址：";
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(87, 28);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(127, 21);
            this.url.TabIndex = 4;
            // 
            // rb_oracle
            // 
            this.rb_oracle.AutoSize = true;
            this.rb_oracle.Location = new System.Drawing.Point(208, 0);
            this.rb_oracle.Name = "rb_oracle";
            this.rb_oracle.Size = new System.Drawing.Size(59, 16);
            this.rb_oracle.TabIndex = 3;
            this.rb_oracle.Text = "Oracle";
            this.rb_oracle.UseVisualStyleBackColor = true;
            this.rb_oracle.CheckedChanged += new System.EventHandler(this.rb_oracle_CheckedChanged);
            // 
            // rb_mysql
            // 
            this.rb_mysql.AutoSize = true;
            this.rb_mysql.Location = new System.Drawing.Point(107, 0);
            this.rb_mysql.Name = "rb_mysql";
            this.rb_mysql.Size = new System.Drawing.Size(53, 16);
            this.rb_mysql.TabIndex = 2;
            this.rb_mysql.Text = "MySql";
            this.rb_mysql.UseVisualStyleBackColor = true;
            this.rb_mysql.CheckedChanged += new System.EventHandler(this.rb_mysql_CheckedChanged);
            // 
            // rb_sqlserver
            // 
            this.rb_sqlserver.AutoSize = true;
            this.rb_sqlserver.Checked = true;
            this.rb_sqlserver.Location = new System.Drawing.Point(6, 0);
            this.rb_sqlserver.Name = "rb_sqlserver";
            this.rb_sqlserver.Size = new System.Drawing.Size(77, 16);
            this.rb_sqlserver.TabIndex = 1;
            this.rb_sqlserver.TabStop = true;
            this.rb_sqlserver.Text = "sqlServer";
            this.rb_sqlserver.UseVisualStyleBackColor = true;
            this.rb_sqlserver.CheckedChanged += new System.EventHandler(this.rb_sqlserver_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "连接";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // conn_info
            // 
            this.conn_info.Location = new System.Drawing.Point(12, 324);
            this.conn_info.Name = "conn_info";
            this.conn_info.Size = new System.Drawing.Size(388, 96);
            this.conn_info.TabIndex = 2;
            this.conn_info.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 432);
            this.Controls.Add(this.conn_info);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "通用数据库连接";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_oracle;
        private System.Windows.Forms.RadioButton rb_mysql;
        private System.Windows.Forms.RadioButton rb_sqlserver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox conn_info;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label5;
    }
}

