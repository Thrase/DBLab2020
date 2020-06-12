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
    public partial class FormUserData : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        int myauth;

        public FormUserData(int auth)
        {
            InitializeComponent();
            myauth = auth;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cardno = text_cardno.Text.Trim();
            string depa = text_depa.Text.Trim();
            string name = text_name.Text.Trim();
            string tel = text_tel.Text.Trim();

            string srct = "userinfo";          
            this.dataGridView1.DataSource = ExecuteQuery.Query("select user_cardno '借书证号', user_username '姓名', user_sex '性别', user_vocation '职称', user_availnumber '可借数量', user_lendnumber '已借数量', user_department '工作部门', user_tel '联系电话', login_account '账户名', user_canseat '是否允许选座' from userinfo where user_cardno like '%" + cardno + "%' and user_username like '%" + name + "%' and user_department like '%" + depa + "%' and user_tel like '%" + tel + "%'", srct).Tables["userinfo"];
            


        }

        private void btn_searchlend_Click(object sender, EventArgs e)
        {
            
            try
            {
                int a = dataGridView1.CurrentRow.Index;
                SqlConnection conn = new SqlConnection(connectionString);
                string sql = "sp_findlendinfobycardno";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter[] paras = new SqlParameter[]
                {
                new SqlParameter("@cn",dataGridView1.Rows[a].Cells[0].Value.ToString()),
                // 输出参数
                new SqlParameter("@msg",SqlDbType.Char,300)
                };

                paras[1].Direction = ParameterDirection.Output;
                cmd.Parameters.AddRange(paras);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                object obj = paras[1].Value;
                MessageBox.Show(obj.ToString(),"该用户借阅情况如下：");

                conn.Close();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("请先选择用户");
            }
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser();
            formAddUser.Owner = this;
            formAddUser.Show();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            string cardno = dataGridView1.Rows[a].Cells[0].Value.ToString();
            string lendnum = dataGridView1.Rows[a].Cells[5].Value.ToString();
            string acc = dataGridView1.Rows[a].Cells[8].Value.ToString();
            if (lendnum!="0")
            {
                MessageBox.Show("有书未还，不可删除");
            }
            else
            {
                string sql = "delete from userinfo where user_cardno='" + cardno+"'";
                if (ExecuteSql.Executesql(sql)>0)
                {
                    MessageBox.Show("删除成功");
                }
                sql = "delete from userLogin where login_account='"+acc+"'";
                ExecuteSql.Executesql(sql);
            }
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
           
            string[] s = new string[11];
            int a = dataGridView1.CurrentRow.Index;
            for (int i=0;i<=9;i++)
            {
                s[i] = dataGridView1.Rows[a].Cells[i].Value.ToString();
            }
            // MessageBox.Show(s[8]);
            string sql = "select login_Auth from userLogin where login_account='" + s[8] + "'";
            string rtauth = UserDataBLL.SimpleQuery2(sql);

            if ((rtauth=="2" || rtauth=="1") && myauth==1 )
            {
                MessageBox.Show("您无权修改该数据！");
            }
            else
            {
                sql = "select login_canlogin from userLogin where login_account='" + s[8] + "'";
                s[10] = UserDataBLL.SimpleQuery(sql);

                FormEditUser formEditUser = new FormEditUser(s);
                formEditUser.Owner = this;
                formEditUser.Show();
            }

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
