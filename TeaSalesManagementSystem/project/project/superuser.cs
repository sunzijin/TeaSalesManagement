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
    public partial class superuser : Form
    {
        public superuser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 fr = new Form1();
            fr.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            house ho = new house();
            ho.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pwd = textBox2.Text;
            string pwd2 = textBox3.Text;
            //bug调整
            if (name == "" || pwd == ""|| pwd2 == "")
            {
                MessageBox.Show("亲，数据不能为空哦！");
            }
            DBA dba = new DBA();
            string sql = "select * from User_table where name='" + name + "' and password='" + pwd + "'";
            SqlDataReader sdr = dba.selectOneRow(sql);
            if (sdr.Read())
            {
                if (!pwd.Equals(pwd2))
                {
                    MessageBox.Show("重复输入密码有误，请重试。");
                }
                else 
                {
                    string t = sdr.GetString(sdr.GetOrdinal("type"));//获得数据库中的登录类型
                    if (t != "root")
                    {
                        DBA dda = new DBA();
                        string sql2 = "delete User_table where name='" + name + "'";
                        dda.nonSelect(sql2);
                        MessageBox.Show("注销成功！");
                        dda.close();
                    }
                    else
                    {
                        MessageBox.Show("对不起，无法注销管理员！");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("注销失败！用户名或密码有误！");
            }
            dba.close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox4.Text;
            string pwd = textBox5.Text;
            string typ = comboBox1.Text;
            //bug调整
            if (name == "" || pwd == ""||typ=="")
            {
                MessageBox.Show("亲，数据不能为空哦！");
            }
            DBA dba = new DBA();
            string sql = "select * from User_table where name='" + name + "' and password='" + pwd + "'";
            SqlDataReader sdr = dba.selectOneRow(sql);
            if (sdr.Read())
            {
                string p = sdr.GetString(sdr.GetOrdinal("password"));//获得数据库中的登录密码
                DBA d = new DBA();
                string sql2 = "update User_table set type='" + typ + "'where password='" + p + "'";
                d.nonSelect(sql2);
                MessageBox.Show("用户权限修改成功！");
                d.close();
            }
            else
            {
                MessageBox.Show("用户名或密码输入有误，请重新核实！");
            }
            dba.close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
