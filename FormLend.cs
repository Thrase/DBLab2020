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
    public partial class FormLend : Form
    {
        public FormLend()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = textBox1.Text.Trim();
            string srct = "lendinfo";
            this.dataGridView1.DataSource = ExecuteQuery.Query("select user_cardno '借书证号', book_isbn 'ISBN书号', lendout '借出时间', timelimit '期限时间' from lendinfo where returnin is null and book_isbn like '%"+isbn+"%'", srct).Tables["lendinfo"];
        }
    }
}
