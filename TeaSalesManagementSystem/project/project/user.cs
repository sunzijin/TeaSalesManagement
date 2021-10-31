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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //返回登陆界面
            this.Visible = false;
            Form1 fr = new Form1();
            fr.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void user_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“myteadatabaseDataSet.Object_table”中。您可以根据需要移动或删除它。
            this.object_tableTableAdapter.Fill(this.myteadatabaseDataSet.Object_table);
            // TODO: 这行代码将数据加载到表“myteadatabaseDataSet.Object_table”中。您可以根据需要移动或删除它。
            this.object_tableTableAdapter.Fill(this.myteadatabaseDataSet.Object_table);
            // TODO: 这行代码将数据加载到表“myteadatabaseDataSet.Object_table”中。您可以根据需要移动或删除它。
            this.object_tableTableAdapter.Fill(this.myteadatabaseDataSet.Object_table);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            //信息框（对话框）
            DialogResult dr = MessageBox.Show("是否确定购买此商品?", "标题", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string NA = comboBox1.Text;
                string co = comboBox2.Text;
                int CO = Convert.ToInt32(co);//要买的奶茶数
                string sql = "select * from Object_table where name='" + NA + "'";
                DBA dba = new DBA();
                SqlDataReader sdr = dba.selectOneRow(sql);
                if (sdr.Read())
                {
                     int c = sdr.GetInt32(sdr.GetOrdinal("count"));  //获得数据库中奶茶的数量
                     string sql2 = "update Object_table set count=count-'" + CO + "' where name='" + NA + "'";
                     if (CO > c || c <= 0)
                     {
                         MessageBox.Show("库存不足，无法购买！");
                     }
                     else
                     {
                         DBA da = new DBA();
                         da.nonSelect(sql2);
                         da.close();
                         this.Visible = false;
                         buy bu = new buy();
                         bu.Visible = true;
                     }
                }
                dba.close();//关闭连接

            }     
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
