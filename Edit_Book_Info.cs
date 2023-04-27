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
    public partial class Edit_Book_Info : Form
    {
        public Edit_Book_Info()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Book_Info_Load(object sender, EventArgs e)
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

                thisCommand.CommandText = "SELECT * FROM ManagerBookEntry WHERE BookName='" + textBox1.Text + "'";
            

                OracleDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
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

            thisCommand1.CommandText = "SELECT BookName, BookPublishYear, WriterName, CatagoryName, EntryDate, QuantityOfBook FROM ManagerBookEntry WHERE BookName='" + textBox1.Text + "'";

            OracleDataReader thisReader = thisCommand1.ExecuteReader();

            while (thisReader.Read())
            {
                textBox2.Text = thisReader.GetValue(0).ToString();
                textBox3.Text = thisReader.GetValue(1).ToString();
                textBox4.Text = thisReader.GetValue(2).ToString();
                textBox5.Text = thisReader.GetValue(3).ToString();
                dateTimePicker1.Text = thisReader.GetValue(4).ToString();
                textBox6.Text = thisReader.GetValue(5).ToString();
            }

            con.thisConnection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.thisConnection.Open();

            OracleCommand thisCommand1 = con.thisConnection.CreateCommand();

            thisCommand1.CommandText = "UPDATE ManagerBookEntry SET BookName=:BookName, BookPublishYear=:BookPublishYear, WriterName=:WriterName, CatagoryName=:CatagoryName, QuantityOfBook=:QuantityOfBook WHERE BookName='"+textBox1.Text+"'";

            thisCommand1.Parameters.AddWithValue(":BookName", textBox2.Text);
            thisCommand1.Parameters.AddWithValue(":BookPublishYear", int.Parse(textBox3.Text));
            thisCommand1.Parameters.AddWithValue(":WriterName", textBox4.Text);
            thisCommand1.Parameters.AddWithValue(":CatagoryName", textBox5.Text);
            thisCommand1.Parameters.AddWithValue(":QuantityOfBook", int.Parse(textBox6.Text));
            //thisCommand1.Parameters.AddWithValue(":EntryDate", dateTimePicker1.Text);

            thisCommand1.ExecuteNonQuery();

            con.thisConnection.Close();

            MessageBox.Show("Updated");
           /* textBox1.Text = textBox2.Text;
            search();*/
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
