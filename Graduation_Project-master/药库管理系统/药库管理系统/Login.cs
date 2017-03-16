using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace 药库管理系统
{
    public partial class Login : Form
    {
        public static string psw;
        SqlConnection conn;
        SqlCommand cm;
        SqlDataReader dr;
        SqlDataAdapter da;
        public Login()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipIcon = ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "用户名通行证！";
            this.toolTip1.SetToolTip(this.userName,"请您输入用户名！");
            this.toolTip1.ToolTipTitle = "用户名通行证！";
            this.toolTip1.SetToolTip(this.Psw,"请您输入通行证！");
            
            conn = new SqlConnection(SQL.conStr);
            DataSet ds = new DataSet();
            da = new SqlDataAdapter("select sele from login", conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            da.Fill(ds, "login");
            conn.Close();
            sel.DataSource = ds.Tables["login"];
            sel.DisplayMember = "sele";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] result = Encoding.Default.GetBytes(this.Psw.Text.Trim());    //Psw为输入密码的文本框
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            //this.textBox3.Text = BitConverter.ToString(output).Replace("-", "");  //textbox3为输出加密文本的文本框
          string   p = BitConverter.ToString(output).Replace("-", "");  //textbox3为输出加密文本的文本框
            conn = new SqlConnection(SQL.conStr);
            //string sql = "select * from login where userID='"+userName.Text.Trim()+"'and pw='"+textBox3.Text.Trim()+"'and sele='"+sel.Text.Trim()+"'";
          string sql = "select * from login where userID='"+userName.Text.Trim()+"'and pw='"+p+"' and sele='"+sel.Text.Trim()+"'";
            cm = new SqlCommand(sql,conn);
            conn.Open();
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                this.Visible = false;//当前窗口不可见      
                new MainForm().Show();//form2显示new Form2().Show();
            }
            else
            {
                MessageBox.Show("用户名或者密码错误","提示");
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
