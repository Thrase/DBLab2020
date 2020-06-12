namespace MyLibrary
{
    partial class FormLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.text_account = new System.Windows.Forms.TextBox();
            this.text_pwd = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_account
            // 
            this.text_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_account.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.text_account.Location = new System.Drawing.Point(173, 153);
            this.text_account.Name = "text_account";
            this.text_account.Size = new System.Drawing.Size(183, 16);
            this.text_account.TabIndex = 0;
            // 
            // text_pwd
            // 
            this.text_pwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_pwd.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.text_pwd.Location = new System.Drawing.Point(173, 193);
            this.text_pwd.Name = "text_pwd";
            this.text_pwd.PasswordChar = '*';
            this.text_pwd.Size = new System.Drawing.Size(183, 16);
            this.text_pwd.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_login.Location = new System.Drawing.Point(131, 235);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(91, 26);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_exit.Location = new System.Drawing.Point(265, 235);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 26);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 460);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.text_pwd);
            this.Controls.Add(this.text_account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLogin";
            this.Text = "图书管理系统登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_account;
        private System.Windows.Forms.TextBox text_pwd;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
    }
}

