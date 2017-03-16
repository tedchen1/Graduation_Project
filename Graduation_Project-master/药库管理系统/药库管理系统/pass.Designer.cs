namespace 药库管理系统
{
    partial class pass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.Psw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(253, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(369, 21);
            this.textBox3.TabIndex = 15;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(576, 39);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(46, 23);
            this.reset.TabIndex = 14;
            this.reset.Text = "退出";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(201, 111);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(46, 23);
            this.submit.TabIndex = 13;
            this.submit.Text = "加密";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Psw
            // 
            this.Psw.Location = new System.Drawing.Point(72, 113);
            this.Psw.Name = "Psw";
            this.Psw.PasswordChar = '●';
            this.Psw.Size = new System.Drawing.Size(121, 21);
            this.Psw.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "通行证";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "清空";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Psw);
            this.Controls.Add(this.label2);
            this.Name = "pass";
            this.Text = "pass";
            this.Load += new System.EventHandler(this.pass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox Psw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}