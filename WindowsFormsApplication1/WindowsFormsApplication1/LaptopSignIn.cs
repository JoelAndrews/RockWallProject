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

namespace WindowsFormsApplication1
{
    public partial class LaptopSignIn : Form
    {
        public LaptopSignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           // SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\joela\Desktop\database\TestData.mdf; Integrated Security = True; Connect Timeout = 30;");
                                                  //  Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\joela\Documents\test.mdf; Integrated Security = True; Connect Timeout = 30
            SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\joela\Documents\test.mdf; Integrated Security = True; Connect Timeout = 30;");

            //sql.Open();

            SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter("Select Count(*) From NotTable where UserName = '" + userNameText.Text + "' and Password = '" + Password.Text + "'", sql);

          
            DataTable myDataTable = new DataTable();
            mySqlDataAdapter.Fill(myDataTable);

            if (myDataTable.Rows[0][0].ToString() == "1")
            {

                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM NotTable", sql);

                DataTable table = new DataTable();
                sqlDA.Fill(table);
                DataRowCollection rowColl = table.Rows;

                for(int i = 0; i < rowColl.Count; i++)
                {
                    DataRow row1 = rowColl[i];

                    var one = row1.ItemArray[0];
                    var two = row1.ItemArray[1];

                    if(one.ToString() == userNameText.Text && two.ToString() == Password.Text)
                    {
                        var three = row1.ItemArray[2];

                  


                        if(three.ToString() == "3")
                        {
                            RockWallManager wallM = new RockWallManager(3, one.ToString(), two.ToString());
                            wallM.Show();

                        }
                        else if (three.ToString() == "2")
                        {
                            RockWallManager wallM = new RockWallManager(2, one.ToString(),two.ToString());
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
    }
}
