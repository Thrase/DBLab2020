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
    public partial class FormUser : Form
    {

        string rtseats;
        string cardno;

        private object v;
        string acc;

        DateTime currentDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));

        public FormUser(string account)
        {
            InitializeComponent();
            acc = account;
            string sql = "select user_seated from userinfo where login_account='" + acc + "'";
            rtseats = UserBLL.SimpleQuery3(sql);
            sql = "select user_cardno from userinfo where login_account='" + acc + "'";
            cardno = UserBLL.SimpleQuery2(sql);

            if (rtseats[0] != '-')
            {
                label_ifs.Text = rtseats;
                btn_chooseseats.Visible = false;
                btn_zl.Visible = true;
                btn_sf.Visible = true;
            }
            else
            {
                label_ifs.Text = "未选座";
                btn_chooseseats.Visible = true;
                btn_zl.Visible = false;
                btn_sf.Visible = false;
            }
        }

        public FormUser(object v)
        {
            this.v = v;
        }             

        private void btn_lend_Click_1(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            string isbn = dataGridView1.Rows[a].Cells[0].Value.ToString().Trim();
            string avail = dataGridView1.Rows[a].Cells[5].Value.ToString().Trim();
            if (avail == "0")
            {
                MessageBox.Show("已经借完，无法借阅！");
            }
            else
            {
                string sql = "select user_availnumber,user_lendnumber from userinfo where login_account='" + acc + "'";
                int canl = UserBLL.SimpleQuery(sql);
                if (canl == -1)
                {
                    MessageBox.Show("无法查询到用户信息");
                }
                else if (canl == 0)
                {
                    MessageBox.Show("您已借满，请先还书！");
                }
                else
                {
                    if (cardno == "")
                    {
                        MessageBox.Show("无法查到借书证号");
                    }
                    else
                    {
                        sql = "insert into lendinfo(user_cardno, book_isbn, lendout, timelimit) values('" + cardno + "', '" + isbn + "', '" + currentDate.ToString("yyyy-MM-dd") + "', '" + currentDate.AddDays(30).ToString("yyyy-MM-dd") + "')";
                        int oprows = ExecuteSql.Executesql(sql);
                        if (oprows > 0)
                        {
                            MessageBox.Show("借书成功，借期30天，请在" + currentDate.AddDays(30).ToString("yyyy-MM-dd") + "前归还！");
                        }
                        else
                        {
                            MessageBox.Show("借书失败");
                        }
                    }
                }
            }
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            string isbn = text_isbn.Text.Trim();
            string press = text_press.Text.Trim();
            string name = text_bookname.Text.Trim();
            string author = text_author.Text.Trim();

            string srct = "bookinfo";
            this.dataGridView1.DataSource = ExecuteQuery.Query("select book_isbn 'ISBN书号', book_bookname '书名', book_author '作者', book_press '出版社', book_totalamount '馆藏数量', book_availamount '可借数量' from bookinfo where book_isbn like '%" + isbn + "%' and book_press like '%" + press + "%' and book_bookname like '%" + name + "%' and book_author like '%" + author + "%'", srct).Tables["bookinfo"];

        }

        private void btn_return_Click_1(object sender, EventArgs e)
        {
            FormReturn formReturn = new FormReturn(acc);
            formReturn.Owner = this;
            formReturn.Show();
        }

        private void btn_pwd_Click_1(object sender, EventArgs e)
        {
            FormEditPwd formEditPwd = new FormEditPwd(acc);
            formEditPwd.Show();
            this.Close();
        }

        private void btn_searchseats_Click(object sender, EventArgs e)
        {
            string seats = text_seats.Text.Trim();
            string srct = "seats";
            this.dataGridView2.DataSource = ExecuteQuery.Query("select seatno '座位号', seatstatus '当前状态' from seats where seatno like '%" + seats + "%'", srct).Tables["seats"];

        }

        private void btn_chooseseats_Click(object sender, EventArgs e)
        {
            int a = dataGridView2.CurrentRow.Index;
            rtseats = dataGridView2.Rows[a].Cells[0].Value.ToString().Trim();

            string cdt = DateTime.Now.ToString();
            string sql = "insert into userseats(seatno, user_cardno, starttime, operation) values('" + rtseats + "', '" + cardno + "', '" + cdt + "', 1)";
            if (ExecuteSql.Executesql(sql) > 0)
            {
                MessageBox.Show("选座成功");

                sql = "select seated from userinfo where login_account='" + acc + "'";
                rtseats = UserBLL.SimpleQuery3(sql);
                label_ifs.Text = rtseats;
                btn_chooseseats.Visible = false;
                btn_zl.Visible = true;
                btn_sf.Visible = true;
            }
            else
            {
                MessageBox.Show("选座失败");
            }
        }

        private void btn_zl_Click_1(object sender, EventArgs e)
        {
            string cdt = DateTime.Now.ToString();
            string sql = "insert into userseats(seatno, user_cardno, starttime, operation) values('" + rtseats + "', '" + cardno + "', '" + cdt + "', 2)";
            if (ExecuteSql.Executesql(sql) > 0)
            {
                MessageBox.Show("设置暂离成功");
            }
            else
            {
                MessageBox.Show("设置暂离失败");
            }
        }

        private void btn_sf_Click(object sender, EventArgs e)
        {
            string cdt = DateTime.Now.ToString();
            string sql = "insert into userseats(seatno, user_cardno, starttime, operation) values('" + rtseats + "', '" + cardno + "', '" + cdt + "', 0)";
            if (ExecuteSql.Executesql(sql) > 0)
            {
                MessageBox.Show("释放座位成功！感谢您的使用");

                label_ifs.Text = "未选座";
                btn_chooseseats.Visible = true;
                btn_zl.Visible = false;
                btn_sf.Visible = false;
            }
            else
            {
                MessageBox.Show("释放座位失败");
            }
        }
    }
}
