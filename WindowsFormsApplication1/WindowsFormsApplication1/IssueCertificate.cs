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
            SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\joela\Documents\test.mdf; Integrated Security = True; Connect Timeout = 30;");

            //sql.Open();

            SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter("Select Count(*) From STUDENT where ID = '" + id_box.Text + "'", sql);
           

            DataTable myDataTable = new DataTable();
            mySqlDataAdapter.Fill(myDataTable);
            
            

            if (myDataTable.Rows[0][0].ToString() == "1")
            {

                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM STUDENT", sql);

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

                        var four = row1.ItemArray[3];
                        var five = row1.ItemArray[4];

                        belayBox.Checked = (bool)four;
                        freeclimbbox.Checked = (bool)five;

                        belayCertButton.Enabled = true;
                        freeClimbButton.Enabled = true;

                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect UserName or Password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\joela\Documents\test.mdf; Integrated Security = True; Connect Timeout = 30;");

            //sql.Open();

            SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter("Select Count(*) From STUDENT where ID = '" + id_box.Text + "'", sql);


            DataTable myDataTable = new DataTable();
            mySqlDataAdapter.Fill(myDataTable);

            if (myDataTable.Rows[0][0].ToString() == "1")
            {

                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM STUDENT", sql);

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
                       
                        
                         
                        SqlCommandBuilder cb;



                        table.Rows[i].BeginEdit();
                        //row1.ItemArray[3] = belayBox.Checked;
                        table.Rows[i][3] = !belayBox.Checked;

                        belayBox.Checked = !belayBox.Checked;
                        //belayBox.Checked = (bool)four;
                        table.Rows[i].EndEdit();

                        cb = new SqlCommandBuilder(sqlDA);
                        sqlDA.DeleteCommand = cb.GetDeleteCommand(true);
                        sqlDA.UpdateCommand = cb.GetUpdateCommand(true);
                        sqlDA.InsertCommand = cb.GetInsertCommand(true);


                        sqlDA.Update(table);


                        

                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect UserName or Password");
            }


        }

        private void freeClimbButton_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\joela\Documents\test.mdf; Integrated Security = True; Connect Timeout = 30;");

            //sql.Open();

            SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter("Select Count(*) From STUDENT where ID = '" + id_box.Text + "'", sql);


            DataTable myDataTable = new DataTable();
            mySqlDataAdapter.Fill(myDataTable);

            if (myDataTable.Rows[0][0].ToString() == "1")
            {

                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM STUDENT", sql);

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



                        SqlCommandBuilder cb;



                        table.Rows[i].BeginEdit();
                        //row1.ItemArray[3] = belayBox.Checked;
                        table.Rows[i][4] = !freeclimbbox.Checked;

                        freeclimbbox.Checked = !freeclimbbox.Checked;
                        //belayBox.Checked = (bool)four;
                        table.Rows[i].EndEdit();

                        cb = new SqlCommandBuilder(sqlDA);
                        sqlDA.DeleteCommand = cb.GetDeleteCommand(true);
                        sqlDA.UpdateCommand = cb.GetUpdateCommand(true);
                        sqlDA.InsertCommand = cb.GetInsertCommand(true);


                        sqlDA.Update(table);




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


