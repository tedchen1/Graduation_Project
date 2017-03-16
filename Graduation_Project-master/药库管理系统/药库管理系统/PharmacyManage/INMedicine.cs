using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 药库管理系统.PharmacyManage
{
    public partial class INMedicine : Form
    {
        public INMedicine()
        {
            InitializeComponent();
        }
        OperateCB operatedb = new OperateCB();//这是我自己写的一个类，到时候在每个窗口都可以直接调用了，不再需要在应用"using System.Data.SqlClient"
        DataSet ds2;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {//textBox1的文本事件，当在textBox1文本框中输入任何东西时触发的事件；
            string sqlstring = "";
            if (textBox1.Text == "")
            {
                sqlstring = "select * from test1";
            }
            else
            {
                sqlstring = "select *from test1 where 快捷码 like '%" + textBox1.Text.Trim() + "%'";//快捷码查询
            }
            DataSet ds = operatedb.GetDataSet(sqlstring, "test1");
            int n = ds.Tables["test1"].Rows.Count;
            dataGridView1.DataSource = ds.Tables["test1"];
            dataGridView1.Location = new Point(190, 120);//dataGridView1位置的移动
            if (textBox1.Text == "")
            {
                dataGridView1.Location = new Point(1024, 120);//dataGridView1位置的移动
            }
            if (n == 0)
            {
                MessageBox.Show("没有此快捷码！", "信息提示");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {//在textBox1输完内容时，点击“enter”键会触发事件，在本阶段暂时不需要用此功能，但是在以后需要用到，现在先保留
            if (e.KeyChar == 13)//按huichejian
            {
                string kj = textBox1.Text;
                string sqlstring1 = "select * from test1 where 快捷码='" + kj + "'";
                DataSet ds1 = operatedb.GetDataSet(sqlstring1, "test1");
                if (ds1.Tables["test1"].Rows.Count == 0)
                {
                    MessageBox.Show("没有此快捷码！", "信息提示");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else
                {
                    string sqlstring2 = "select *from test1 where 快捷码='" + textBox1.Text + "'";
                    ds2 = operatedb.GetDataSet(sqlstring2, "test1");
                    dataGridView1.DataSource = ds2.Tables["test1"];
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//本事件主要功能是：获取dataGridView1中行的值，并把获取到的该行的值赋给textBox显示出来。
            textBox2.Text = Convert.ToString(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value).Trim();
            textBox3.Text = Convert.ToString(dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value).Trim();
            textBox4.Text = Convert.ToString(dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value).Trim();
        }
    }
}
