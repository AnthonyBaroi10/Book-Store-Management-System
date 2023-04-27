namespace TinyLibraryBook_Store
{
    partial class Delete_Book
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WriterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublishYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityOfBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CatagoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.EntryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(772, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(722, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Book Name",
            "Writer Name",
            "Publish Year",
            "Catagory"});
            this.comboBox1.Location = new System.Drawing.Point(227, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(431, 37);
            this.comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(863, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 35);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(862, 822);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1370, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 56);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookName,
            this.WriterName,
            this.PublishYear,
            this.QuantityOfBook,
            this.CatagoryName,
            this.EntryDate});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(242, 248);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1490, 537);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // BookName
            // 
            this.BookName.Text = "Book Name";
            this.BookName.Width = 100;
            // 
            // WriterName
            // 
            this.WriterName.Text = "Writer Name";
            this.WriterName.Width = 100;
            // 
            // PublishYear
            // 
            this.PublishYear.Text = "Publish Year";
            this.PublishYear.Width = 100;
            // 
            // QuantityOfBook
            // 
            this.QuantityOfBook.Text = "Quantity";
            this.QuantityOfBook.Width = 100;
            // 
            // CatagoryName
            // 
            this.CatagoryName.Text = "Catagory";
            this.CatagoryName.Width = 100;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1590, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 56);
            this.button3.TabIndex = 10;
            this.button3.Text = "View List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EntryDate
            // 
            this.EntryDate.Text = "Entry Date";
            this.EntryDate.Width = 100;
            // 
            // Delete_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1804, 914);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Delete_Book";
            this.Text = "Delete_Book";
            this.Load += new System.EventHandler(this.Delete_Book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader BookName;
        private System.Windows.Forms.ColumnHeader WriterName;
        private System.Windows.Forms.ColumnHeader PublishYear;
        private System.Windows.Forms.ColumnHeader QuantityOfBook;
        private System.Windows.Forms.ColumnHeader CatagoryName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader EntryDate;
    }
}