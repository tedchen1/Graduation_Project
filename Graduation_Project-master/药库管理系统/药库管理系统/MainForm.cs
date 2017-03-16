using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 药库管理系统
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //button1.BackColor = System.Drawing.Color.Blue;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            // ResetButton();  //reset button
        }
        //public int i = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            ResetButton();  //reset button
            //i += 1;
            //if (i % 2 == 1)
            //{
                panel1.Dock = DockStyle.None;
                panel1.Dock = DockStyle.Bottom;
                button6.Dock = DockStyle.Bottom;
                button10.Dock = DockStyle.Bottom;
            button7.Dock = DockStyle.Bottom;
                button8.Dock = DockStyle.Bottom;
                button9.Dock = DockStyle.Bottom;
                
                btn_5();
               // panel1.BringToFront();
                //button11.BringToFront();
                //button11.Location = new Point(48, 35);
                //button12.BringToFront();
                // button13.BringToFront();
                //button14.BringToFront();
                //button15.BringToFront();
                // button16.BringToFront();
                //button11.Image = Image.FromFile(@"Images\t5.gif");
                //listView1.Dock = DockStyle.None;
                //listView1.BringToFront();
                //listView1.Dock = DockStyle.Bottom;
                //listView1.Clear();
                // panel1.Visible = false;
            //}
        }
      private  void btn_5()
        {//   1    将button11的图片、text值、所发生的事件改变，不同的大板块button11所触发的事件不一样

            button11.Image = Image.FromFile(@"Images\t5.gif");
            button11.Text = "药品入库";
            button11.Click += new System.EventHandler(this.btns5_Click);
            //return;
        }
        private void btns5_Click(object sender, System.EventArgs e)
        {//   2   该事件主要是：当点击button11的时候触发跳转到窗口“pass” 
            if (button11.Text.Equals("药品入库"))//    2-1    判断button11是属于哪个大板块（button5、button6、button7、button8、button9、button10）的button11
            {
                pass pa = new pass();
                pa.ShowDialog();
                //MessageBox.Show(((Button)sender).Text + " was clicked !"); //通过sender判断激发事件的控件
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ResetButton();  //reset button
            //i = i + 1;
            //if (i % 2 == 1)
            //{
            panel1.Dock = DockStyle.None;
            panel1.Dock = DockStyle.Bottom;
            button7.Dock = DockStyle.Bottom;
            button8.Dock = DockStyle.Bottom;
            button9.Dock = DockStyle.Bottom;
            button10.Dock = DockStyle.Bottom;
            btn_6();
            //button11.Image = Image.FromFile(@"Images\p2.gif");
            //button11.Text = "药品出库";
            //button11.Click += new System.EventHandler(this.btns2_Click); 
            //listView1.Dock = DockStyle.None;
            //listView1.BringToFront();
            // listView1.Dock = DockStyle.Bottom;
            //button11.Image = Image.FromFile(@"Images\p2.gif");
            //listView1.Clear();
            //}
        }
        private void btn_6()
        {//同上1
            button11.Image = Image.FromFile(@"Images\p2.gif");
            button11.Text = "药品出库";
            button11.Click += new System.EventHandler(this.btns6_Click);
            //return;
        }
        private void btns6_Click(object sender, System.EventArgs e)
        {//同上2
            if (button11.Text.Equals("药品出库"))
            {//同上2-1
                pass pa = new pass();
                pa.ShowDialog();
               // MessageBox.Show(((Button)sender).Text + " lk !"); //通过sender判断激发事件的控件
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            ResetButton();  //reset button
            //i += 1;
            //if (i % 2 == 1)
            //{
            panel1.Dock = DockStyle.None;
            panel1.Dock = DockStyle.Bottom;
            button8.Dock = DockStyle.Bottom;
            button9.Dock = DockStyle.Bottom;
            button10.Dock = DockStyle.Bottom;
            btn_7();
            // listView1.Dock = DockStyle.None;
            //listView1.BringToFront();
            //listView1.Dock = DockStyle.Bottom;
            //listView1.Clear();
            //}
            //else
            //{
            //    listView1.Clear();
            //    //panel1.Visible = false;
            //}
        }
        private void btn_7()
        {//同上1
            button11.Image = Image.FromFile(@"Images\p2.gif");
            button11.Text = "药品盘点";
            button11.Click += new System.EventHandler(this.btns7_Click);
            //return;
        }
        private void btns7_Click(object sender, System.EventArgs e)
        {//同上2
            if (button11.Text.Equals("药品盘点"))
            {//同上2-1
                PharmacyManage.INMedicine pmi = new PharmacyManage.INMedicine();
                pmi.ShowDialog();
                //MessageBox.Show(((Button)sender).Text + "lvk !"); //通过sender判断激发事件的控件
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            ResetButton();  //reset button
            //i += 1;
            //if (i % 2 == 1)
            //{
                panel1.Dock = DockStyle.None;
                panel1.Dock = DockStyle.Bottom;
                button9.Dock = DockStyle.Bottom;
                button10.Dock = DockStyle.Bottom;
                btn_8();
               // listView1.Dock = DockStyle.None; 
               //listView1.BringToFront();
               // listView1.Dock = DockStyle.Bottom;
                //listView1.Clear();
            //}
        }
        private void btn_8()
        {//同上1
            button11.Image = Image.FromFile(@"Images\p2.gif");
            button11.Text = "其他功能";
            button11.Click+=new System. EventHandler(this.btns8_Click);
        }
        private void btns8_Click(object sender, System.EventArgs e)
        {//同上2
            if (button11.Text.Equals("其他功能"))
            {//同上2-1
                pass pa = new pass();
                pa.ShowDialog();
                //MessageBox.Show(((Button)sender).Text + "lvkun !"); //通过sender判断激发事件的控件
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            ResetButton();  //reset button
            //i += 1;
            //if (i % 2 == 1)
            //{
            panel1.Dock = DockStyle.None;
            panel1.Dock = DockStyle.Bottom;
           // listView1.Dock = DockStyle.None;
            button10.Dock = DockStyle.Bottom;
            btn_9();
           // listView1.BringToFront();
           // listView1.Dock = DockStyle.Bottom;
           // listView1.Clear();
            //}
            //else
            //{
            //listView1.BringToFront();
            //listView1.Dock = DockStyle.Bottom;
            //    listView1.Clear();
            //}
        }
        private void btn_9()
        {//同上1
            button11.Image = Image.FromFile(@"Images\p2.gif");
            button11.Text = "Other-Function-one";
            button11.Click += new System.EventHandler(this.btns9_Click);
        }
        private void btns9_Click(object sender, System.EventArgs e)
        {//同上2
            if (button11.Text.Equals("Other-Function-one"))
            {//同上2-1

               PharmacyManage.INMedicine pmi = new PharmacyManage.INMedicine();
               pmi.ShowDialog();
                //MessageBox.Show(((Button)sender).Text + "你好，lvkun !"); //通过sender判断激发事件的控件
            }
        }
       private void button10_Click(object sender, EventArgs e)
        {
            ResetButton();  //reset button
            
            //i += 1;
            //if (i % 2 == 1)
            //{
                //listView1.Visible = true;
                //panel1.Dock = DockStyle.None;
                //panel1.Dock = DockStyle.Bottom;
                btn_10();
                //panel1.Visible = false;
            //}
            //else
            //{
            //   // listView1.Visible = false;
            //    panel1.Visible = true;
            //    btn_10();
            //}
        }
       private void btn_10()
       {//同上1
           button11.Image = Image.FromFile(@"Images\p2.gif");
           button11.Text = "退出系统";
           button11.Click += new System.EventHandler(this.btns10_Click);
       }
       private void btns10_Click(object sender, System.EventArgs e)
       {//同上2
           if (button11.Text.Equals("退出系统"))
           {//同上2-1
               PharmacyManage.INMedicine pmi = new PharmacyManage.INMedicine();
               pmi.ShowDialog();
               //MessageBox.Show(((Button)sender).Text + "你好，helloworld!"); //通过sender判断激发事件的控件
           }
       }
        public void ResetButton()          //初始化时的设置，初始化各button、panel的值
        {
            button5.Dock = DockStyle.Bottom;
            button6.Dock = DockStyle.Bottom;
            button7.Dock = DockStyle.Bottom;
            button8.Dock = DockStyle.Bottom;
            button9.Dock = DockStyle.Bottom;
            button10.Dock = DockStyle.Bottom;
            panel1.Dock = DockStyle.Bottom;
            //panel1.Dock = DockStyle.None;
            //listView1.Dock = DockStyle.Bottom;
           // listView1.Dock = DockStyle.None;
            button5.Dock = DockStyle.None;
            button6.Dock = DockStyle.None;
            button7.Dock = DockStyle.None;
            button8.Dock = DockStyle.None;
            button9.Dock = DockStyle.None;
            button10.Dock = DockStyle.None;
        }


        #region 修改按钮控件鼠标经过的效果以及效果通用函数
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonMove(button1);
            //button1.BackColor = Color.FromArgb(243,248,193);
            //button1.FlatStyle = FlatStyle.Popup;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

            ButtonLeave(button1);
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            ButtonLeave(button4);
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonMove(button4);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonMove(button2);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            ButtonLeave(button2);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ButtonLeave(button3);
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonMove(button3);
        }

        private void button11_MouseMove(object sender, MouseEventArgs e)
        {
            button11.FlatStyle = FlatStyle.Popup;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.FlatStyle = FlatStyle.Flat;
        }

        private void button12_MouseMove(object sender, MouseEventArgs e)
        {
            button12.FlatStyle = FlatStyle.Popup;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.FlatStyle = FlatStyle.Flat;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.FlatStyle = FlatStyle.Flat;
        }

        private void button13_MouseMove(object sender, MouseEventArgs e)
        {
            button13.FlatStyle = FlatStyle.Popup;
        }

        private void button14_MouseMove(object sender, MouseEventArgs e)
        {
            button14.FlatStyle = FlatStyle.Popup;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.FlatStyle = FlatStyle.Flat;
        }

        private void button15_MouseMove(object sender, MouseEventArgs e)
        {
            button15.FlatStyle = FlatStyle.Popup;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.FlatStyle = FlatStyle.Flat;
        }

        private void button16_MouseMove(object sender, MouseEventArgs e)
        {
            button16.FlatStyle = FlatStyle.Popup;
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.FlatStyle = FlatStyle.Flat;
        }
        
        //鼠标经过控件时触发效果
        private void ButtonMove(Button buttonName)
        {
            buttonName.BackColor = Color.FromArgb(243, 248, 193);
            buttonName.FlatStyle = FlatStyle.Popup;
        }

        //鼠标离开控件时恢复原状
        private void ButtonLeave(Button buttonName)
        {
            buttonName.BackColor = System.Drawing.Color.Transparent;
            buttonName.FlatStyle = FlatStyle.Flat;
        }
        #endregion
    }
}
