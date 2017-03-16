namespace 药库管理系统
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.Psw = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sel = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(389, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(389, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "通行证";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(464, 121);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(121, 21);
            this.userName.TabIndex = 2;
            // 
            // Psw
            // 
            this.Psw.Location = new System.Drawing.Point(464, 153);
            this.Psw.Name = "Psw";
            this.Psw.PasswordChar = '●';
            this.Psw.Size = new System.Drawing.Size(121, 21);
            this.Psw.TabIndex = 3;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(473, 230);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(46, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "登录";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(529, 230);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(46, 23);
            this.reset.TabIndex = 5;
            this.reset.Text = "退出";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(389, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "权  限";
            // 
            // sel
            // 
            this.sel.FormattingEnabled = true;
            this.sel.Location = new System.Drawing.Point(464, 190);
            this.sel.Name = "sel";
            this.sel.Size = new System.Drawing.Size(121, 20);
            this.sel.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::药库管理系统.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(634, 362);
            this.Controls.Add(this.sel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Psw);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox Psw;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}