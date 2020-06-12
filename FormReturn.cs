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
    public partial class FormReturn : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

       

        


        string acc;
        static string cardno;
        public FormReturn(string account)
        {
            InitializeComponent();
            acc = account;
            string sql = "select user_cardno from userinfo where login_account='" + acc + "'";
            cardno = ReturnBookBLL.SimpleQuery2(sql);
            
            this.dataGridView1.DataSource = ReturnBookBLL.Query("select lendinfo.book_isbn 'ISBN书号', book_bookname '书名', lendout '借阅时间', timelimit '期限日期' from lendinfo,bookinfo where lendinfo.user_cardno='" + cardno + "' and returnin is null and lendinfo.book_isbn=bookinfo.book_isbn").Tables["lendinfo"];

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            string isbn = dataGridView1.Rows[a].Cells[0].Value.ToString().Trim();
            string sttm = dataGridView1.Rows[a].Cells[2].Value.ToString().Trim();
            string tmlm = dataGridView1.Rows[a].Cells[3].Value.ToString().Trim();

            DateTime dt1 = DateTime.Parse(tmlm);
            DateTime dt2 = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));

            TimeSpan ts = dt2.Subtract(dt1);
            int diff = (int)ts.TotalDays;
            int fine = (int)(diff*0.5);
            if (fine<0)
            {
                fine = 0;
            }
            if (diff>0)
            {
                if (MessageBox.Show("本书需要缴纳滞纳金"+ fine.ToString() +"元。是否缴纳？", "提醒" ,MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    fine = 0;
                }
            }

            string sql = "update lendinfo set returnin='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where user_cardno='" + cardno + "' and book_isbn='" + isbn + "' and lendout='" + sttm + "'";
            if (ExecuteSql.Executesql(sql)==0)
            {
                MessageBox.Show("还书失败");
            }
            else
            {
                MessageBox.Show("还书成功");
                this.Close();
            }

            sql = "update lendinfo set fine='" + fine.ToString() + "' where user_cardno='" + cardno + "' and book_isbn='" + isbn + "' and lendout='" + sttm + "'";
            if (ExecuteSql.Executesql(sql) == 0)
            {
                MessageBox.Show("罚款更新失败");
            }


        }
    }
}
