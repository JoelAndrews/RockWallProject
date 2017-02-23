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
    public partial class ManageAdmins : Form
    {
        public string CurrentUserName;
        public string CurrentPassword;
        public ManageAdmins(string currUser, string pWord)
        {
            InitializeComponent();
            CurrentUserName = currUser;
            CurrentPassword = pWord;

            this.label4.Text = CurrentUserName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currPass.Text != this.CurrentPassword)
            {
                String message = "Password entered for current password is incorrect.";
               // message += this.CurrentPassword;
                MessageBox.Show(message);
                return;
            }


            SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\joela\Documents\test.mdf; Integrated Security = True; Connect Timeout = 30;");

            //sql.Open();

            SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter("Select * From STUDENT", sql);


            //DataTable myDataTable = new DataTable();
            //mySqlDataAdapter.Fill(myDataTable);

            //if (myDataTable.Rows[0][0].ToString() == "1")
            //{

            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM NotTable", sql);

            DataTable table = new DataTable();
            sqlDA.Fill(table);
            DataRowCollection rowColl = table.Rows;


            for (int i = 0; i < rowColl.Count; i++)
            {
                DataRow row1 = rowColl[i];

                var three = row1.ItemArray[1];
                var one = row1.ItemArray[0];
                //  var two = row1.ItemArray[1];

                if (three.ToString() == this.CurrentPassword && one.ToString() == this.CurrentUserName)
                {



                    SqlCommandBuilder cb;



                    table.Rows[i].BeginEdit();
                    //row1.ItemArray[3] = belayBox.Checked;
                    table.Rows[i][1] = newPass.Text;

                    //belayBox.Checked = (bool)four;
                    table.Rows[i].EndEdit();

                    cb = new SqlCommandBuilder(sqlDA);
                    sqlDA.DeleteCommand = cb.GetDeleteCommand(true);
                    sqlDA.UpdateCommand = cb.GetUpdateCommand(true);
                    sqlDA.InsertCommand = cb.GetInsertCommand(true);


                    sqlDA.Update(table);

                    String message = "Password successfully changed!";
                    MessageBox.Show(message);

                    this.Hide();
                    break;

                    //}
                    //}
                }


            }
        }
    }
}
