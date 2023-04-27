namespace TinyLibraryBook_Store
{
    partial class Manager_Create_Delete
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(740, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 650);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create Manager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1078, 650);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delete Manager";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 35);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName,
            this.Password});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(339, 116);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1035, 466);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.Manager_Create_Delete_Load);
            // 
            // UserName
            // 
            this.UserName.Text = "Manager Name";
            this.UserName.Width = 200;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 200;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(339, 693);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 253);
            this.panel1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(235, 35);
            this.textBox2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "User Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(910, 693);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 253);
            this.panel2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(206, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(235, 35);
            this.textBox3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Manager Name";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(663, 966);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 47);
            this.button3.TabIndex = 10;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(910, 967);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 46);
            this.button4.TabIndex = 11;
            this.button4.Text = "Main Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Manager_Create_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1669, 1042);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Manager_Create_Delete";
            this.Text = "Manager_Create_Delete";
            this.Load += new System.EventHandler(this.Manager_Create_Delete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader Password;
    }
}