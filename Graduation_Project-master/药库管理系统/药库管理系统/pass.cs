using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace 药库管理系统
{
    public partial class pass : Form
    {
        public static string psw;
        public pass()
        {
            InitializeComponent();
        }

        private void pass_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            byte[] result = Encoding.Default.GetBytes(this.Psw.Text.Trim());    //Psw为输入密码的文本框
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            this.textBox3.Text = BitConverter.ToString(output).Replace("lk618", "");  //textbox3为输出加密文本的文本框,lv618是加密算法，随便自己定义，不同的定义，所得到的加密码不一样
            psw = textBox3.Text;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Psw.Text = "";
            textBox3.Text = "";
        }
    }
}
