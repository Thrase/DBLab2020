using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();

            string[] sex =
            new[] {"男", "女" };

            string[] yesno = new[] {"是","否" };
            string[] yesno2 = new[] { "是", "否" };

            comboBox1.DataSource = sex;
            comboBox_login.DataSource = yesno;
            comboBox_seat.DataSource = yesno2;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cardno = text_cardno.Text.Trim();
            string name = text_name.Text.Trim();
            string depa = text_depa.Text.Trim();
            string tel = text_tel.Text.Trim();
            string voc = text_voc.Text.Trim();
            string avi = text_avi.Text.Trim();
            string sex = comboBox1.Text.Trim();
            string account = text_acc.Text.Trim();
            string pwd = text_pwd.Text.Trim();
            string canlogin = comboBox_login.Text.Trim();
            string canseat = comboBox_seat.Text.Trim();

            string sql;
            if (canlogin=="是")
            {
                sql = "insert into userLogin values('" + account + "','" + pwd + "',0,0)";
            }
            else
            {
                sql = "insert into userLogin values('" + account + "','" + pwd + "',0,1)";
            }
            ExecuteSql.Executesql(sql);

            sql = "insert into userinfo values('"+cardno+"','" + name + "','" +sex+ "','" + voc + "'," + avi + ",0,'" + depa + "','" + tel + "','" + canseat + "','','"+account+"')";
            if (ExecuteSql.Executesql(sql)>0)
            {
                MessageBox.Show("添加成功");
                this.Close();
            }
        }
    }
}
