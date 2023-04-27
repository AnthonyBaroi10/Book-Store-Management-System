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
    public partial class Manager_Create_Delete : Form
    {
        public Manager_Create_Delete()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Manager_Create_Delete_Load(object sender, EventArgs e)
        {
            Connection CN = new Connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = CN.thisConnection.CreateCommand();

            thisCommand.CommandText =
                "SELECT * FROM login order by UserName";

            OracleDataReader thisReader = thisCommand.ExecuteReader();


            while (thisReader.Read())
            {
                ListViewItem lsvItem = new ListViewItem();
                lsvItem.Text = thisReader["UserName"].ToString();
                //lsvItem.SubItems.Add(thisReader["UserName"].ToString());
                lsvItem.SubItems.Add(thisReader["Password"].ToString());

                listView1.Items.Add(lsvItem);
            }


            CN.thisConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Connection CN = new Connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandText = "SELECT * FROM login WHERE UserName='" + textBox3.Text + "'";
                OracleDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
                    deleteManager();
                    Manager_Create_Delete_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Manager not exist!");
                }
                //this.Close();
                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection CN = new Connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandText = "SELECT * FROM login WHERE UserName='" + textBox1.Text + "'";
                OracleDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
                    MessageBox.Show("User name already exist!");
                }
                else
                {
                    addManager();
                    Manager_Create_Delete_Load(sender, e);
                }
                //this.Close();
                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void addManager()
        {
            Connection sv = new Connection();
            sv.thisConnection.Open();

            OracleDataAdapter thisAdapter = new OracleDataAdapter("SELECT * FROM login", sv.thisConnection);

            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);

            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "login");

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            DataRow thisRow = thisDataSet.Tables["login"].NewRow();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            try
            {
                thisRow["UserName"] = textBox1.Text;
                thisRow["Password"] = textBox2.Text;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                thisDataSet.Tables["login"].Rows.Add(thisRow);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                thisAdapter.Update(thisDataSet, "login");
                MessageBox.Show("Submitted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sv.thisConnection.Close();
            this.Refresh();
            textBox1.Clear();
            textBox2.Clear();
            listView1.Items.Clear();          
        }

        private void deleteManager()
        {
            try
            {
                Connection con = new Connection();
                con.thisConnection.Open();

                OracleCommand thisCommand1 = con.thisConnection.CreateCommand();

                thisCommand1.CommandText =
                    "delete login where UserName = '" + textBox3.Text + "'";

                thisCommand1.Connection = con.thisConnection;
                thisCommand1.CommandType = CommandType.Text;
                //For Insert Data Into Oracle//

                thisCommand1.ExecuteNonQuery();
                MessageBox.Show("delete successfully");
                this.Refresh();
                textBox3.Clear();
                listView1.Items.Clear();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            User_Form user_Form = new User_Form();
            user_Form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Hide();
        }

    }
}
