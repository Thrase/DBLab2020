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
    public partial class FormAddbook : Form
    {
        public FormAddbook()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string isbn = text_isbn.Text.Trim();
            string press = text_press.Text.Trim();
            string name = text_bookname.Text.Trim();
            string author = text_author.Text.Trim();
            string number = text_number.Text.Trim();
            string anumber =text_anumber.Text.Trim();

            string sql;
            if (anumber != "0")
            {
                sql = "insert into bookinfo values('" + isbn + "', '" + name + "', '" + press + "', '" + author + "', " + number + ", " + anumber+ ", 1)";
            }
            else
            {
                sql = "insert into bookinfo values('" + isbn + "', '" + name + "', '" + press + "', '" + author + "', " + number + ", 0, 0)";
            }

            if (ExecuteSql.Executesql(sql)>0)
            {
                MessageBox.Show("添加成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
