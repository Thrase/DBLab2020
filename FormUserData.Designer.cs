namespace MyLibrary
{
    partial class FormUserData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_depa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_cardno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_searchlend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_del
            // 
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_del.ForeColor = System.Drawing.Color.Red;
            this.btn_del.Location = new System.Drawing.Point(607, 483);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(88, 37);
            this.btn_del.TabIndex = 27;
            this.btn_del.Text = "删除该用户";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_edit.Location = new System.Drawing.Point(526, 483);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 37);
            this.btn_edit.TabIndex = 26;
            this.btn_edit.Text = "修改信息";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_add.Location = new System.Drawing.Point(445, 483);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 37);
            this.btn_add.TabIndex = 25;
            this.btn_add.Text = "添加用户";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(655, 217);
            this.dataGridView1.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.text_tel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.text_depa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.text_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.text_cardno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Location = new System.Drawing.Point(39, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 76);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // text_tel
            // 
            this.text_tel.Location = new System.Drawing.Point(350, 46);
            this.text_tel.Name = "text_tel";
            this.text_tel.Size = new System.Drawing.Size(140, 21);
            this.text_tel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "联系电话";
            // 
            // text_depa
            // 
            this.text_depa.Location = new System.Drawing.Point(350, 16);
            this.text_depa.Name = "text_depa";
            this.text_depa.Size = new System.Drawing.Size(140, 21);
            this.text_depa.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "工作部门";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(106, 45);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(140, 21);
            this.text_name.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "姓名";
            // 
            // text_cardno
            // 
            this.text_cardno.Location = new System.Drawing.Point(106, 16);
            this.text_cardno.Name = "text_cardno";
            this.text_cardno.Size = new System.Drawing.Size(140, 21);
            this.text_cardno.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "借书证号";
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.btn_search.Location = new System.Drawing.Point(532, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(84, 51);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_searchlend
            // 
            this.btn_searchlend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchlend.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_searchlend.Location = new System.Drawing.Point(39, 483);
            this.btn_searchlend.Name = "btn_searchlend";
            this.btn_searchlend.Size = new System.Drawing.Size(146, 37);
            this.btn_searchlend.TabIndex = 30;
            this.btn_searchlend.Text = "查看该用户借阅情况";
            this.btn_searchlend.UseVisualStyleBackColor = true;
            this.btn_searchlend.Click += new System.EventHandler(this.btn_searchlend_Click);
            // 
            // FormUserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MyLibrary.Properties.Resources.useradmin1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 555);
            this.Controls.Add(this.btn_searchlend);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormUserData";
            this.Text = "用户管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_depa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_cardno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_searchlend;
    }
}