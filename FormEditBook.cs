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
    public partial class FormEditBook : Form
    {
        string[] bs = new string[6];
        string ISBNrecord;

        public FormEditBook(string[] s)
        {
            InitializeComponent();
            // isbn, bookname,author, press, totalamount, availamount
            text_isbn.Text = s[0];
            text_bookname.Text = s[1];
            text_author.Text = s[2];
            text_press.Text = s[3];
            text_number.Text = s[4];
            text_anumber.Text = s[5];

            ISBNrecord = s[0];

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
        
            string isbn = text_isbn.Text.Trim();
            string press = text_press.Text.Trim();
            string name = text_bookname.Text.Trim();
            string author = text_author.Text.Trim();
            string number = text_number.Text.Trim();
            string anumber = text_anumber.Text.Trim();

            string sql;
            if (anumber != "0")
            {
                sql = "update bookinfo set book_isbn='" + isbn + "', book_bookname='" + name + "', book_press='" + press + "', book_author='" + author + "', book_totalamount=" + number + ", book_availamount=" + anumber + ", book_ifavail=1 where book_isbn='" + ISBNrecord+"'";
            }
            else
            {
                sql = "update bookinfo set book_isbn='" + isbn + "', book_bookname='" + name + "', book_press='" + press + "', book_author='" + author + "', book_totalamount=" + number + ", book_availamount=0, book_ifavail=0 where book_isbn='" + ISBNrecord + "'";
            }

            if (ExecuteSql.Executesql(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            string isbn = text_isbn.Text.Trim();
            string press = text_press.Text.Trim();
            string name = text_bookname.Text.Trim();
            string author = text_author.Text.Trim();
            string number = text_number.Text.Trim();
            string anumber = text_anumber.Text.Trim();

            string sql;
            if (anumber != "0")
            {
                sql = "update bookinfo set book_isbn='" + isbn + "', book_bookname='" + name + "', book_press='" + press + "', book_author='" + author + "', book_totalamount=" + number + ", book_availamount=" + anumber + ", book_ifavail=1 where book_isbn='" + ISBNrecord + "'";
            }
            else
            {
                sql = "update bookinfo set book_isbn='" + isbn + "', book_bookname='" + name + "', book_press='" + press + "', book_author='" + author + "', book_totalamount=" + number + ", book_availamount=0, book_ifavail=0 where book_isbn='" + ISBNrecord + "'";
            }

            if (ExecuteSql.Executesql(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
