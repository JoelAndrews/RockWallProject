using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class LaptopSignIn : Form
    {
        public LaptopSignIn()
        {

            // EXPERIMENTAL
            // it would be nice to check if the database exists and create one if it doesn't - however this may not be feasable 
            // with how the tablet communicates wit the laptop
            // disregard for now

            //MySqlConnectionStringBuilder conn_strings = new MySqlConnectionStringBuilder();
            //conn_strings.Server = "localhost";
            //conn_strings.UserID = "root";
            //conn_strings.Password = "rockwall";
            //conn_strings.Database = "rockwall";


            //string connStr = @"Data Source=localhost;Initial Catalog=Test;Integrated Security=True";
            //string cmdStr = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = 'rockwalls' AND table_name = 'login'";

            //using (MySqlConnection conn = new MySqlConnection(conn_strings.ToString()))
            //{
            //    MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
            //    conn.Open();
            //    MySqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        int count = reader.GetInt32(0);
            //        if (count == 0)
            //        {
            //            MessageBox.Show("No such data table exists!");
            //        }
            //        else if (count == 1)
            //        {
            //            MessageBox.Show("Such data table exists!");
            //        }
            //    }
            //}





            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.UserID = "root";
            conn_string.Password = "";
           // conn_string.Password = "rockwall";
            conn_string.Database = "rockwall";
            

            connectionstring.CS = conn_string.ToString();




            //var x = ConfigurationSettings.AppSettings;


         //   connectionstring.CS = x[1];

            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try { 

            MySqlConnection conn = new MySqlConnection(connectionstring.CS);
            //    MySqlDataReader rdr = null;
            MySqlDataAdapter adapter;
            
            conn.Open();
            string stm = "Select count(*) From Login where UserName = '" + userNameText.Text + "' and Password = '" + Password.Text + "'";
            MySqlCommand cmd = new MySqlCommand(stm, conn);

            DataTable dataset = new DataTable();

            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataset);


         string x =  dataset.Rows[0][0].ToString();
          

            if (dataset.Rows[0][0].ToString() == "1")
            {

                    stm = "SELECT * FROM Login";

                    cmd = new MySqlCommand(stm, conn);
                
                DataTable table = new DataTable();
                    adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
                DataRowCollection rowColl = table.Rows;
                    conn.Close();

                for (int i = 0; i < rowColl.Count; i++)
                {
                    DataRow row1 = rowColl[i];

                    var one = row1.ItemArray[0];
                    var two = row1.ItemArray[1];

                    if (one.ToString().ToUpper() == userNameText.Text.ToUpper() && two.ToString() == Password.Text)
                    {
                        var three = row1.ItemArray[2];




                        if (three.ToString() == "3")
                        {
                            RockWallManager wallM = new RockWallManager(3, one.ToString(), two.ToString());
                            wallM.Show();

                        }
                        else if (three.ToString() == "2")
                        {
                            RockWallManager wallM = new RockWallManager(2, one.ToString(), two.ToString());
                            wallM.Show();

                        }
                        else if (three.ToString() == "1")
                        {
                            RockWallManager wallM = new RockWallManager(1, one.ToString(), two.ToString());
                            wallM.Show();

                        }
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect UserName or Password");
            }
        }
                catch
                {
                    MessageBox.Show("Problems connecting with database - check database connection info in the configuration XML");

                }
}
        }
 }

            