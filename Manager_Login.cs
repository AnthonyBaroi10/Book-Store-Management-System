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
    public partial class Manager_Login : Form
    {
        public Manager_Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            User_Form user_Form = new User_Form();
            user_Form.Show();
            this.Hide();
        }
        private void logincheck()
        {
            try
            {
                Connection CN = new Connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandText = "SELECT * FROM login WHERE UserName='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'";
                OracleDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
                    Main_Menu main_Menu = new Main_Menu();
                    main_Menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("username or password incorrect");
                }
                //this.Close();
                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logincheck();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            logincheck();
        }
    }
}
