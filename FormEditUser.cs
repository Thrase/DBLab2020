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
    public partial class FormEditUser : Form
    {
        string oldcardno;
        string acc;
        public FormEditUser(string[] s)
        {
            // cardno '借书证号', username '姓名', sex '性别', vocation '职称', availnumber '可借数量', lendnumber '已借数量', department '工作部门', tel '联系电话', account '账户名', canseat '是否允许选座' 
            InitializeComponent();

            string[] sex =
            new[] { "男", "女" };

            string[] yesno = new[] { "是", "否" };
            string[] yesno2 = new[] { "是", "否" };

            comboBox1.DataSource = sex;
            comboBox_login.DataSource = yesno;
            comboBox_seat.DataSource = yesno2;


            text_cardno.Text = s[0];
            oldcardno = s[0];
            text_name.Text = s[1];
            comboBox1.Text = s[2].Trim();
            text_voc.Text = s[3];
            text_avi.Text = s[4];
            text_depa.Text = s[6];
            text_tel.Text = s[7];
            acc = s[8];
            comboBox_seat.Text = s[9].Trim();
            if (s[10] == "0")
            {
                comboBox_login.Text = "是";
            }
            else
            {
                comboBox_login.Text = "否";
            }


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
            string canlogin = comboBox_login.Text.Trim();
            string canseat = comboBox_seat.Text.Trim();

            string sql;
            if (canlogin=="是")
            {
                sql = "update userLogin set login_canlogin=0 where login_account='" + acc + "'";
            }
            else
            {
                sql = "update userLogin set login_canlogin=1 where login_account='" + acc + "'";
            }
            
            ExecuteSql.Executesql(sql);

            sql = "update userinfo set user_cardno='"+cardno+ "',user_username='" + name+ "',user_department='" + depa+ "',user_tel='" + tel+ "',user_vocation='" + voc+ "',user_availnumber=" + avi+ ",user_sex='" + sex+ "',user_canseat='" + canseat+ "' where user_cardno='" + oldcardno+"'";

            if (ExecuteSql.Executesql(sql) > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
        }
    }
}
