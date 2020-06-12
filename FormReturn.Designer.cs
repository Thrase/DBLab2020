namespace MyLibrary
{
    partial class FormReturn
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
            this.btn_return = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.White;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_return.Location = new System.Drawing.Point(287, 342);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(84, 27);
            this.btn_return.TabIndex = 2;
            this.btn_return.Text = "确认";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(627, 223);
            this.dataGridView1.TabIndex = 4;
            // 
            // FormReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibrary.Properties.Resources.bookreturn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormReturn";
            this.Text = "归还图书";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}