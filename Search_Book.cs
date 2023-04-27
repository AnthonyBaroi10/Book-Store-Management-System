using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace TinyLibraryBook_Store
{
    public partial class Search_Book : Form
    {
        public Search_Book()
        {
            InitializeComponent();
        }

        public void Search_Book_Load(object sender, EventArgs e)
        {
            Connection CN = new Connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = CN.thisConnection.CreateCommand();

            thisCommand.CommandText =
                "SELECT * FROM ManagerBookEntry order by BookName";

            OracleDataReader thisReader = thisCommand.ExecuteReader();


            while (thisReader.Read())
            {
                ListViewItem lsvItem = new ListViewItem();
                lsvItem.Text = thisReader["BookName"].ToString();
                lsvItem.SubItems.Add(thisReader["WriterName"].ToString());
                lsvItem.SubItems.Add(thisReader["BookPublishYear"].ToString());
                lsvItem.SubItems.Add(thisReader["QuantityOFBook"].ToString());
                lsvItem.SubItems.Add(thisReader["CatagoryName"].ToString());
                lsvItem.SubItems.Add(thisReader["EntryDate"].ToString());

                listView1.Items.Add(lsvItem);
            }


            CN.thisConnection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                Connection CN = new Connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;


                if (comboBox1.Text == "Book Name")
                {
                    thisCommand.CommandText = "SELECT * FROM ManagerBookEntry WHERE BookName='" + textBox1.Text + "'";
                }
                else if (comboBox1.Text == "Writer Name")
                {
                    thisCommand.CommandText = "SELECT * FROM ManagerBookEntry WHERE WriterName='" + textBox1.Text + "'";
                }
                else if (comboBox1.Text == "Publish Year")
                {
                    thisCommand.CommandText = "SELECT * FROM ManagerBookEntry WHERE BookPublishYear='" + textBox1.Text + "'";
                }
                else if (comboBox1.Text == "Catagory")
                {
                    thisCommand.CommandText = "SELECT * FROM ManagerBookEntry WHERE CatagoryName='" + textBox1.Text + "'";
                }


                OracleDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
                    listView1.Items.Clear();
                    search();
                }
                else
                {
                    MessageBox.Show("Book not exist!");
                }
                //this.Close();
                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void search()
        {
          
                Connection con = new Connection();
                con.thisConnection.Open();

                OracleCommand thisCommand1 = con.thisConnection.CreateCommand();

                if (comboBox1.Text == "Book Name")
                {
                    thisCommand1.CommandText = "SELECT * FROM ManagerBookEntry WHERE BookName='" + textBox1.Text + "'";
                }
                else if (comboBox1.Text == "Writer Name")
                {
                    thisCommand1.CommandText = "SELECT * FROM ManagerBookEntry WHERE WriterName='" + textBox1.Text + "'";
                }
                else if (comboBox1.Text == "Publish Year")
                {
                    thisCommand1.CommandText = "SELECT * FROM ManagerBookEntry WHERE BookPublishYear='" + textBox1.Text + "'";
                }
                else if (comboBox1.Text == "Catagory")
                {
                    thisCommand1.CommandText = "SELECT * FROM ManagerBookEntry WHERE CatagoryName='" + textBox1.Text + "'";
                }


                OracleDataReader thisReader = thisCommand1.ExecuteReader();


                while (thisReader.Read())
                {
                    ListViewItem lsvItem = new ListViewItem();
                    lsvItem.Text = thisReader["BookName"].ToString();
                    lsvItem.SubItems.Add(thisReader["WriterName"].ToString());
                    lsvItem.SubItems.Add(thisReader["BookPublishYear"].ToString());
                    lsvItem.SubItems.Add(thisReader["QuantityOFBook"].ToString());
                    lsvItem.SubItems.Add(thisReader["CatagoryName"].ToString());
                    lsvItem.SubItems.Add(thisReader["EntryDate"].ToString());

                    listView1.Items.Add(lsvItem);
                }


                con.thisConnection.Close();

            }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Search_Book_Load(sender, e);
        }
    }
}
