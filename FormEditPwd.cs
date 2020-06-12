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
    public partial class FormEditPwd : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        string acc;

        public FormEditPwd(string account)
        {
            InitializeComponent();
            acc = account;
            label4.Text = acc;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string acc = textBox1.Text.Trim();
            string pwd = textBox2.Text.Trim();
            string newp = textBox3.Text.Trim();

            string sql = "select * from userLogin where login_account='" + acc + "' and login_pwd='" + pwd + "'";
            if (EditPwdBLL.SimpleQuery(sql)==1)
            {
                sql = "update userLogin set login_pwd='"+newp+"' where login_account='"+acc+"'";
                if (ExecuteSql.Executesql(sql)==1)
                {
                    MessageBox.Show("修改成功！请重新登录");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败：密码不得少于六位，且不可使用纯数字。");
                }
            }
            else
            {
                MessageBox.Show("原用户名或密码错误！");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
