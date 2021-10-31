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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBA dba = new DBA();
            string loginname = txtlogin.Text;
            string passwd = txtpasswd.Text;
            string sql = "select * from User_table where name='" +loginname+ "' and password='" +passwd+ "'";

            SqlDataReader sdr = dba.selectOneRow(sql);
            if (sdr.Read())
            {
                MessageBox.Show("登录成功！欢迎-" + sdr["name"] + "-登录");
                string n= sdr.GetString(sdr.GetOrdinal("type"));//获得数据库中的登录类型
                if (n == "root")//进入管理员界面
                {
                    this.Visible = false;
                    superuser su = new superuser();
                    su.Visible = true;
                }
                else//进入普通用户界面
                {
                    this.Visible = false;
                    user us = new user();
                    us.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("登录失败！用户名或密码有误！");
            }
            dba.close();//关闭连接
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            regesit re = new regesit();
            re.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
