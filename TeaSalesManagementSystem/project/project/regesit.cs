using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//引用命名空间
using System.Data.Sql;
using System.Data.SqlClient;
namespace project
{
    public partial class regesit : Form
    {
        public regesit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBA dba = new DBA();
            string Na = txtlgname.Text;
            string PWD = txtlgpasswd.Text;
            string PWD1 = txtlgpasswd1.Text;
            string sql = "insert into User_table values('" + Na + "','" + PWD + "','user')";
            //bug调整
            if (Na == "" || PWD == "" || PWD1 == "")
            {
                MessageBox.Show("亲，数据不能为空哦！");
            }
            else if (!PWD.Equals(PWD1))
            {
                MessageBox.Show("两次密码不一致，请检查并重新输入！");
                return;
            }
            else
            {
                dba.nonSelect(sql);
                MessageBox.Show("注册成功！");
                dba.close();
            }
            
            //跳转至登录页面
            this.Visible = false;
            Form1 fr = new Form1();
            fr.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtlgname.Text = null;
            txtlgpasswd.Text = null;
            txtlgpasswd1.Text = null;
        }
    }
}
