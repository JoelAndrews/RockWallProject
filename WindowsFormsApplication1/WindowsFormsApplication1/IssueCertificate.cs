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
    public partial class IssueCertificate : Form
    {
        DataSet studentTable;

        public string Five
        {
            get
            {
                return "five";
            }
            private set
            {
                if(value.ToUpper() == "FALSE")
                {
                    belayBox.Checked = false;
                    lblBelay.Text = "No";
                }
                else
                {
                    belayBox.Checked = true;
                    lblBelay.Text = "Yes";
                }
            }
        }
        public string Six
        {
            get
            {
                return "six";
            }
            private set
            {
                if (value.ToUpper() == "FALSE")
                {
                    freeclimbbox.Checked = false;
                    lblFreeClimb.Text = "No";
                }
                else
                {
                    freeclimbbox.Checked = true;
                    lblFreeClimb.Text = "Yes";
                }
            }
        }
        public IssueCertificate()
        {
            InitializeComponent();


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  SqlConnection con = new SqlConnection();

           // con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\joela\Documents\test.mdf; Integrated Security = True; Connect Timeout = 30;";
            studentTable = new DataSet();
            MySqlConnection sql = new MySqlConnection(connectionstring.CS);

            //sql.Open();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("Select Count(*) From STUDENT where ID = '" + id_box.Text + "'", sql);
           

            DataTable myDataTable = new DataTable();
            mySqlDataAdapter.Fill(myDataTable);
            
            

            if (myDataTable.Rows[0][0].ToString() == "1")
            {

                MySqlDataAdapter sqlDA = new MySqlDataAdapter("SELECT * FROM STUDENT", sql);

                DataTable table = new DataTable();
                sqlDA.Fill(table);
                DataRowCollection rowColl = table.Rows;

                for (int i = 0; i < rowColl.Count; i++)
                {
                    DataRow row1 = rowColl[i];

                    var three = row1.ItemArray[2];
                    //  var two = row1.ItemArray[1];

                    if (three.ToString() == id_box.Text)
                    {
                        var one = row1.ItemArray[0];
                        var two = row1.ItemArray[1];

                        lNameBox.Text = two.ToString();
                        fNameBox.Text = one.ToString();

                        Five = CheckBoolValue(row1.ItemArray[3].ToString());
                        Six = CheckBoolValue(row1.ItemArray[4].ToString());


                        belayCertButton.Enabled = true;
                        freeClimbButton.Enabled = true;

                    }
                }
            }
            else
            {
                MessageBox.Show("ID not found.");
            }
            sql.Close();
        }

        private string CheckBoolValue(string boolValue)
        {
            if (boolValue == "1")
                return "True";
            else
                return "False";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection sql = new MySqlConnection(connectionstring.CS);

            //sql.Open();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("Select Count(*) From STUDENT where ID = '" + id_box.Text + "'", sql);


            DataTable myDataTable = new DataTable();
            mySqlDataAdapter.Fill(myDataTable);

            if (myDataTable.Rows[0][0].ToString() == "1")
            {

                MySqlDataAdapter sqlDA = new MySqlDataAdapter("SELECT * FROM STUDENT", sql);

                DataTable table = new DataTable();
                sqlDA.Fill(table);
                DataRowCollection rowColl = table.Rows;
                
                
                for (int i = 0; i < rowColl.Count; i++)
                {
                    DataRow row1 = rowColl[i];

                    var three = row1.ItemArray[2];
                    //  var two = row1.ItemArray[1];

                    if (three.ToString() == id_box.Text)
                    {
                       
                        
                         
                        MySqlCommandBuilder cb;



                        table.Rows[i].BeginEdit();
                        //row1.ItemArray[3] = belayBox.Checked;
                        table.Rows[i][3] = !belayBox.Checked;

                        belayBox.Checked = !belayBox.Checked;
                        if (belayBox.Checked)
                            lblBelay.Text = "Yes";
                        else
                            lblBelay.Text = "No";

                        //belayBox.Checked = (bool)four;
                        table.Rows[i].EndEdit();

                        cb = new MySqlCommandBuilder(sqlDA);

                        sqlDA.UpdateCommand = cb.GetUpdateCommand();


                        sqlDA.Update(table);


                        

                    }
                }
            }
            else
            {
                MessageBox.Show("Id not found");
            }
            sql.Close();


        }

        private void freeClimbButton_Click(object sender, EventArgs e)
        {
            MySqlConnection sql = new MySqlConnection(connectionstring.CS);

            //sql.Open();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("Select Count(*) From STUDENT where ID = '" + id_box.Text + "'", sql);


            DataTable myDataTable = new DataTable();
            mySqlDataAdapter.Fill(myDataTable);

            if (myDataTable.Rows[0][0].ToString() == "1")
            {

                MySqlDataAdapter sqlDA = new MySqlDataAdapter("SELECT * FROM STUDENT", sql);

                DataTable table = new DataTable();
                sqlDA.Fill(table);
                DataRowCollection rowColl = table.Rows;


                for (int i = 0; i < rowColl.Count; i++)
                {
                    DataRow row1 = rowColl[i];

                    var three = row1.ItemArray[2];
                    //  var two = row1.ItemArray[1];

                    if (three.ToString() == id_box.Text)
                    {



                        MySqlCommandBuilder cb;



                        table.Rows[i].BeginEdit();
                        //row1.ItemArray[3] = belayBox.Checked;
                        table.Rows[i][4] = !freeclimbbox.Checked;

                        freeclimbbox.Checked = !freeclimbbox.Checked;

                        if (freeclimbbox.Checked)
                            lblFreeClimb.Text = "Yes";
                        else
                            lblFreeClimb.Text = "No";

                               

                        

                        //belayBox.Checked = (bool)four;
                        table.Rows[i].EndEdit();

                        cb = new MySqlCommandBuilder(sqlDA);
                        sqlDA.UpdateCommand = cb.GetUpdateCommand();



                        sqlDA.Update(table);




                    }
                }
            }
            else
            {
                MessageBox.Show("Id not found");
            }
            sql.Close();

        }
    }
}


