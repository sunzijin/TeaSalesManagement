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
    public partial class house : Form
    {
        public house()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            superuser su = new superuser();
            su.Visible = true;
        }

        private void house_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“myteadatabaseDataSet.Object_table”中。您可以根据需要移动或删除它。
            this.object_tableTableAdapter.Fill(this.myteadatabaseDataSet.Object_table);

        }

        public void refresh()
        {
            this.Visible = false;
            house ho = new house();
            ho.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string count1 = textBox2.Text;
            int count = Convert.ToInt32(count1);
            string price1 = textBox3.Text;
            double price = Convert.ToDouble(price1);
            if (radioButton1.Checked)//上架功能实现
            {
                string sql = "insert into Object_table values('" + name + "','" + count + "','" + price + "')";
                DBA dba = new DBA();
                dba.nonSelect(sql);
                MessageBox.Show("上架成功！");
                dba.close();
                refresh();//列表刷新
            }
            else if (radioButton2.Checked)//下架功能实现
            {
                string sql = "select * from Object_table where name='" + name + "'";
                DBA dba = new DBA();
                SqlDataReader sdr = dba.selectOneRow(sql);
                if (sdr.Read())
                {
                    DBA dda = new DBA();
                    string sql2 = "delete Object_table where name='" + name + "'";
                    dda.nonSelect(sql2);
                    MessageBox.Show("下架成功！");
                    dda.close();
                    refresh();//列表刷新
                }
                else
                {
                    MessageBox.Show("下架失败！该饮品不存在！");
                }
                dba.close();
            }
            else
            {
                MessageBox.Show("请选择‘上架’或‘下架’选项！");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string NA = comboBox2.Text;
            string name = textBox4.Text;
            string count = textBox5.Text;
            string price = textBox6.Text;
            //bug调整
            if (name == "" || count == "" || price == "")
            {
                MessageBox.Show("亲，数据不能为空哦！");
            }
            else
            {
                string sql = "update Object_table set name='" + name + "' ,count='" + count + "' ,price='" + price + "' where name='" + NA + "'";
                DBA ed = new DBA();
                ed.nonSelect(sql);
                MessageBox.Show("修改成功！");
                ed.close();
                refresh();//列表刷新
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
