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
    public partial class New_Book_Entry : Form
    {
        public New_Book_Entry()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Book already exist!");
                }
                else
                {
                    addBook();
                }
                //this.Close();
                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addBook()
        {
            Connection sv = new Connection();
            sv.thisConnection.Open();

            OracleDataAdapter thisAdapter = new OracleDataAdapter("SELECT * FROM ManagerBookEntry", sv.thisConnection);

            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);

            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "ManagerBookEntry");

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            DataRow thisRow = thisDataSet.Tables["ManagerBookEntry"].NewRow();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            try
            {
                thisRow["BookName"] = textBox1.Text;
                thisRow["BookPublishYear"] = textBox2.Text;
                thisRow["WriterName"] = textBox3.Text;
                thisRow["CatagoryName"] = textBox4.Text;
                thisRow["QuantityOfBook"] = textBox5.Text;
                thisRow["EntryDate"] = dateTimePicker1.Text;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                thisDataSet.Tables["ManagerBookEntry"].Rows.Add(thisRow);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                thisAdapter.Update(thisDataSet, "ManagerBookEntry");
                MessageBox.Show("Book Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sv.thisConnection.Close();

            Main_Menu ob = new Main_Menu();
            ob.Show();
            this.Hide();
        }
    }
}
