namespace project
{
    partial class regesit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regesit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlgname = new System.Windows.Forms.TextBox();
            this.txtlgpasswd = new System.Windows.Forms.TextBox();
            this.txtlgpasswd1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::project.Properties.Resources.img1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 538);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(166, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(59, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "注册登录名：";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(59, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "注册密码：";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(59, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码：";
            // 
            // txtlgname
            // 
            this.txtlgname.Location = new System.Drawing.Point(226, 152);
            this.txtlgname.Name = "txtlgname";
            this.txtlgname.Size = new System.Drawing.Size(322, 25);
            this.txtlgname.TabIndex = 5;
            // 
            // txtlgpasswd
            // 
            this.txtlgpasswd.Location = new System.Drawing.Point(225, 225);
            this.txtlgpasswd.Name = "txtlgpasswd";
            this.txtlgpasswd.Size = new System.Drawing.Size(322, 25);
            this.txtlgpasswd.TabIndex = 6;
            // 
            // txtlgpasswd1
            // 
            this.txtlgpasswd1.Location = new System.Drawing.Point(227, 299);
            this.txtlgpasswd1.Name = "txtlgpasswd1";
            this.txtlgpasswd1.Size = new System.Drawing.Size(319, 25);
            this.txtlgpasswd1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(383, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(197, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "请输入用户注册信息";
            // 
            // regesit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 538);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtlgpasswd1);
            this.Controls.Add(this.txtlgpasswd);
            this.Controls.Add(this.txtlgname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "regesit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlgname;
        private System.Windows.Forms.TextBox txtlgpasswd;
        private System.Windows.Forms.TextBox txtlgpasswd1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}