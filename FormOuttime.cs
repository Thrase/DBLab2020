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
    public partial class FormOuttime : Form
    {
        public FormOuttime()
        {
            InitializeComponent();
            string srct = "outtime";
            this.dataGridView1.DataSource = ExecuteQuery.Query("select user_cardno '借书证号', book_isbn 'ISBN书号', lendout '借出时间', timelimit '期限时间' from outtime", srct).Tables["outtime"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
