using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyLibraryBook_Store
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            New_Book_Entry new_Book_Entry = new New_Book_Entry();
            new_Book_Entry.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search_Book search_Book = new Search_Book();
            search_Book.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit_Book_Info edit_Book_Info = new Edit_Book_Info();
            edit_Book_Info.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete_Book delete_Book = new Delete_Book();
            delete_Book.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            User_Form user_Form = new User_Form();  
            user_Form.Show();
            this.Hide();
        }
    }
}
