using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;

namespace 药库管理系统
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cm;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isUserExist = false;
            //if (userName.Text == "" || psw.Text == "" || sel.Text == "")
            //{

                if (userName.Text == "")
                {
                    label5.Text = "用户名不能为空！";
                    return;
                }
                if (psw.Text == "")
                {
                    label6.Text = "密码不能为空！";
                    return;
                }
                if (sel.Text == "")
                {
                    label7.Text = "用户不能为空！";
                    return;
                }
            //}
            else
            {
               // string inputstring = Md5hash_String(psw.Text);
                conn = new SqlConnection(SQL.conStr);
                conn.Open();
                string sql = "select userID from login where userID='" + userName.Text + "' and password='" + psw.Text + "'and sele='" + sel.Text + "'";
                // string sql = "select userID from login where userID='" + userName.Text + "'and password='" + psw.Text + "'";
                cm = new SqlCommand(sql, conn);
                da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() == userName.Text)
                    {
                        isUserExist = true;
                        break;
                    }
                }
                if (isUserExist == false)
                {
                    label5.Text = "该用户不存在！";
                    label6.Text = "";
                    label7.Text = "";
                    return;
                }
                else
                {
                   cm = new SqlCommand("select password from login where userID='" + userName.Text + "'", conn); 
                   string correctPwd = cm.ExecuteScalar().ToString();
                   string inputstring = Md5hash_String(correctPwd);
                        if (psw.Text !=inputstring)
                        {
                            label5.Text = "";
                            label6.Text = "密码输入错误!";
                            label7.Text = "";
                            MessageBox.Show("密码错误，请确认输入或联系管理员！", "提示");
                        }
                
                    else
                    {
                        cm = new SqlCommand("select sele from login where userID='" + userName.Text + "'", conn);
                        //da = new SqlDataAdapter(cm);
                        string zc = cm.ExecuteScalar().ToString();
                        if (zc == "admin")
                        {
                            this.Visible = false;//当前窗口不可见      
                            new MainForm().Show();//form2显示new Form2().Show();
                        }
                    }
                     
                    conn.Close();
                }
            }
                }
        public static string Md5hash_String(string input)
        {
            byte[] result = System.Text.Encoding.Default.GetBytes(input);    //tbPass为输入密码的文本框
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            //this.textBox3.Text = BitConverter.ToString(output).Replace("-", "");  //tbMd5pass为输出加密文本的文本框
            //MD5 md5 = new MD5CryptoServiceProvider();
            //byte[] data = System.Text.Encoding.Default.GetBytes(input);
            //byte[] md5data = md5.ComputeHash(data);
            md5.Clear();
            string str = "";
            for (int i = 0; i < output.Length - 1; i++)
            {
                str = BitConverter.ToString(output).Replace("-", "");
            }
            return str;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(SQL.conStr);
            DataSet ds = new DataSet();
            da = new SqlDataAdapter("select sele from login",conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            da.Fill(ds,"login");
            conn.Close();
            sel.DataSource=ds.Tables["login"];
            sel.DisplayMember = "sele";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
