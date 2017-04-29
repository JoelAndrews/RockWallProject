using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ManageManagers : Form
    {
        public string CurrentUserName;
        public string CurrentPassword;
        public ManageManagers(string currUser, string pWord, int lvl)
        {
            InitializeComponent();
            CurrentUserName = currUser;
            CurrentPassword = pWord;

            if(lvl != 3)
            {
                groupBox1.Enabled = false;
            }

           

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(txtloginnewname.Text == "" || txtloginnewpass.Text == "" || txtverifypass.Text == "")
            {
                return;
            }

            if(txtloginnewpass.Text != txtverifypass.Text)
            {
                String message = "Passwords entered do not match!";
                MessageBox.Show(message);
                return;
            }

            //need to make sure there isn't a duplicate login name 
            MySqlConnection sql = new MySqlConnection(connectionstring.CS);

            //sql.Open();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("Select Count(*) From Login Where UserName = '" + txtloginnewname.Text + "'", sql);


            DataTable table = new DataTable();
            mySqlDataAdapter.Fill(table);
            DataRowCollection rowColl = table.Rows;
            

            if (table.Rows[0][0].ToString() != "0")
            {
                String message = "UserName already in use!";
                MessageBox.Show(message);
                sql.Close();
                return;
            }


          //  sql = new MySqlConnection(connectionstring.CS);


            MySqlDataAdapter sqlDA = new MySqlDataAdapter("INSERT INTO Login(UserName, Password, Level) VALUES ('" + txtloginnewname.Text + "', '" + txtloginnewpass.Text + "','2')", sql);

            table = new DataTable();
            sqlDA.Fill(table);
            rowColl = table.Rows;

            String message1 = "Successfully created user " + txtloginnewname.Text + "!";
            MessageBox.Show(message1);
            sql.Close();
        }

        private void ManageManagers_Load(object sender, EventArgs e)
        {

        }
    }
}
