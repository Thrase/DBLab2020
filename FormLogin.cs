using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MyLibrary
{
    public partial class FormLogin : Form
    {
        static string rtacc;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string acc = text_account.Text.Trim();
            string pwd = text_pwd.Text.Trim();
            string sql = "select * from userLogin where login_account='" + acc + "' and login_pwd='" + pwd + "'";
            int[] rtauth = LoginBLL.SimpleQuery(sql);
            if (rtauth[0]==-1)
            {
                MessageBox.Show("用户名或密码错误");
            }
            else
            {
                rtacc = LoginBLL.SimpleQuery2(sql);
                if (rtauth[1]==0)
                {
                    if (rtauth[0] == 0)
                    {
                        FormUser formUser = new FormUser(rtacc);
                        formUser.Owner = this;
                        formUser.Show();
                        this.Hide();
                    }
                    else
                    {
                        FormAdmin formAdmin = new FormAdmin(rtacc, rtauth[0]);
                        formAdmin.Owner = this;
                        formAdmin.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("本用户已被管理员禁止登录。");
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}